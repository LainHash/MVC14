using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC14.Data;
using MVC14.Helpers.Constants.Sessions;
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

        public async Task<IActionResult> BuyOne(int id)
        {
            var userId = HttpContext.Session.GetInt32(SessionConstants.userId) ?? null;
            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var customer = await _context.Customers
                .SingleOrDefaultAsync(c => c.UserId == userId);
            //if (customer == null)
            //{
            //    return NotFound("Khách hàng không tồn tại!");
            //}

            var product = await _context.VwProducts
                .FirstOrDefaultAsync(c => c.ProductId == id);
            if(product == null)
            {
                return NotFound("Sản phẩm này không tồn tại!");
            }

            var vm = new InvoiceVM()
            {
                CustomerCode = customer.CustomerCode,
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice,
                Quantity = 1,
                DiscountPercent = 0,
                LineTotal = product.UnitPrice,
                Subtotal = product.UnitPrice,
                TaxAmount = 0.12f,
                TotalAmount = (int)(Math.Round(product.UnitPrice * 0.12m / 1000, 0) * 1000),
                Note = ""
            };

            ViewBag.Discounts = new SelectList(_context.Discounts.ToList(), "DiscountPercent", "DiscountCode");

            return View(vm);
        }
    }
}
