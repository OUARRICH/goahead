using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my <b>Default</b> action...";
        }

        public string Welcome(string name, int age)
        {
            return "Welocome to "+name+ " page. He is "+age+ " years old";
        }
    }
}
