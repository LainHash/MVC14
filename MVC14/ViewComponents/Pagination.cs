using Microsoft.AspNetCore.Mvc;
using MVC14.ViewModels;

namespace MVC14.ViewComponents
{
    public class Pagination : ViewComponent
    {
        public IViewComponentResult Invoke(int active = 1, int index = 1, int total = 1)
        {
            var paginate = new PaginateVM()
            {
                ActivePage = active,
                IndexPage = index,
                TotalPages = total
            };
            return View(paginate);
        }
    }
}
