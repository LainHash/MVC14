using Microsoft.AspNetCore.Mvc;
using MVC14.ViewModels;

namespace MVC14.ViewComponents
{
    public class ProductSpec : ViewComponent
    {
        public IViewComponentResult Invoke(ProductVM vm)
        {
            return View(vm);
        }
    }
}
