using Microsoft.AspNetCore.Mvc;
using MVC14.DTOs.Products.Update;

namespace MVC14.ViewComponents
{
    public class UpdateProductSpec : ViewComponent
    {
        public IViewComponentResult Invoke(UpdateProductDTO dto, int categoryId)
        {
            ViewBag.CategoryId = categoryId;
            return View(dto);
        }
    }
}
