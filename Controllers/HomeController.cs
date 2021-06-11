using Microsoft.AspNetCore.Mvc;
namespace Portfolio1
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [Route("/projects")]
        [HttpGet]
        public ViewResult Projects()
        {
            return View();
        }
        [Route("/contact")]
        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }
    }
}