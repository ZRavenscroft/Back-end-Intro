using Microsoft.AspNetCore.Mvc;

namespace Homework_1_.Controllers
{
    public class HomeController:Controller
    {
        public ContentResult Index()
        {
            ContentResult result = new ContentResult();
            result.Content = "<h1>P132</h1>";
            return result;
        }
        public JsonResult Student()
        {
            var obj = new { Name = "Zackary", Surname = "Ravenscroft", Age = 20 };
            JsonResult js = new JsonResult(obj);
            return js;
        }
        public ViewResult About()
        {
            ViewResult viewResult = new ViewResult();
            viewResult.ViewName = "about";
            return viewResult;
        }
        public ViewResult Contact()
        {
            return View();
        }
    }
}
