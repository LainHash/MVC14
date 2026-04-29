using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC14.Data;
using MVC14.Helpers.Constants.Sessions;
using MVC14.Models;
using MVC14.ViewModels;

namespace MVC14.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly Dbmvc05Context _context;
        private readonly IMapper _mapper;

        public InvoiceController(Dbmvc05Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var invoices = await _context.VwInvoices
                .OrderByDescending(iv => iv.OrderDate)
                .ToListAsync();
            return View(invoices);
        }
        public async Task<IActionResult> Details(int id)
        {
            var invoice = await _context.VwInvoices
                .FirstOrDefaultAsync(iv => iv.InvoiceId == id);
            if (invoice == null)
            {
                return NotFound();
            }

            ViewBag.InvoiceDetails = await _context.VwInvoiceDetails
                .Where(ivd => ivd.InvoiceId == id)
                .ToListAsync();

            return View(invoice);
        }

        [HttpGet]
        public async Task<IActionResult> BuyOne(int id)
        {
            var userId = HttpContext.Session.GetInt32(SessionConstants.userId);

            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var customer = await _context.Customers
                .SingleOrDefaultAsync(c => c.UserId == userId);

            if (customer == null)
            {
                return NotFound("Khách hàng không tồn tại!");
            }

            var product = await _context.VwProducts
                .FirstOrDefaultAsync(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound("Sản phẩm này không tồn tại!");
            }

            var vm = new InvoiceVM
            {
                CustomerCode = customer.CustomerCode,
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                OrderDate = DateOnly.FromDateTime(DateTime.Now),
                UnitPrice = product.UnitPrice,
                Quantity = 1,
                DiscountPercent = 0,
                LineTotal = product.UnitPrice,
                Subtotal = product.UnitPrice,
                TaxAmount = 0.12f,
                TotalAmount = product.UnitPrice,
                Note = null
            };

            ViewBag.Discounts = new SelectList(
                await _context.Discounts.ToListAsync(),
                "DiscountPercent",
                "DiscountCode"
            );
            return View(vm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BuyOne(InvoiceVM vm)
        {
            var userId = HttpContext.Session.GetInt32(SessionConstants.userId);

            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var customer = await _context.Customers
                .Include(x => x.User)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            if (customer == null)
            {
                return NotFound("Khách hàng không tồn tại!");
            }

            var product = await _context.VwProducts
                .FirstOrDefaultAsync(p => p.ProductId == vm.ProductId);

            if (product == null)
            {
                return NotFound("Sản phẩm không tồn tại!");
            }

            // Validate quantity
            if (vm.Quantity <= 0)
            {
                ModelState.AddModelError("Quantity", "Số lượng phải lớn hơn 0");
            }

            // Validate stock
            if (product.UnitsInStock < vm.Quantity)
            {
                ModelState.AddModelError("Quantity", "Số lượng tồn kho không đủ");
            }

            if(customer.User.Balance < vm.TotalAmount)
            {
                ModelState.AddModelError("Balance", "Số dư không đủ");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Discounts = new SelectList(
                    await _context.Discounts.ToListAsync(),
                    "DiscountPercent",
                    "DiscountCode",
                    vm.DiscountPercent
                );

                // tính lại để render
                vm.LineTotal = (int)(vm.UnitPrice * vm.Quantity * (1 - vm.DiscountPercent / 100f));
                vm.Subtotal = vm.LineTotal;
                vm.TaxAmount = 0;
                vm.TotalAmount = vm.Subtotal;

                return View(vm);
            }

            // ===== Tính tiền =====
            var lineTotal = (int)(vm.UnitPrice * vm.Quantity * (1 - vm.DiscountPercent ));
            var subtotal = lineTotal;
            var taxAmount = 0.12f;
            var shippingFee = 0;
            var totalAmount = (int)(subtotal * (1 + taxAmount) + shippingFee);

            // ===== Tạo Invoice =====
            var invoice = new Invoice
            {
                InvoiceUuid = Guid.NewGuid(),
                CustomerId = customer.CustomerId,
                EmployeeId = null,
                OrderDate = DateOnly.FromDateTime(DateTime.Now),
                RequiredDate = DateOnly.FromDateTime(DateTime.Now.AddDays(3)),
                ShippedDate = null,
                Status = "Pending",
                Subtotal = subtotal,
                TaxAmount = taxAmount,
                TotalAmount = totalAmount,
                Note = vm.Note,
                ShippingFee = shippingFee,
                ShippingDiscount = 0,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();

            // ===== Tạo Invoice Detail =====
            var invoiceDetail = new InvoiceDetail
            {
                InvoiceId = invoice.InvoiceId,
                ProductId = product.ProductId,
                UnitPrice = vm.UnitPrice,
                Quantity = vm.Quantity,
                DiscountPercent = vm.DiscountPercent,
                LineTotal = lineTotal
            };

            _context.InvoiceDetails.Add(invoiceDetail);

            // ===== Trừ tồn kho =====
            product.UnitsInStock -= vm.Quantity;

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { id = invoice.InvoiceId });
        }
    }
}
