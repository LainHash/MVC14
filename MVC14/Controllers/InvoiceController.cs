using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC14.Data;

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
            var invoices = await _context.Invoices.ToListAsync();
            return View(invoices);
        }
    }
}
