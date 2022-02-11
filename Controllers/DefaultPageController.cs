using epi12.Models.Pages;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace epi12.Controllers
{
    public class DefaultPageController : PageController<BasePage>
    {
        public ViewResult Index(BasePage currentPage)
        {
            return View("~/Views/DefaultPage/Index.cshtml", currentPage);
        }
    }
}