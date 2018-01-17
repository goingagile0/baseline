using Microsoft.AspNetCore.Mvc;

namespace ACME.Web.Greetings
{
    [Produces("application/json")]
    [Route("api/Greeting")]
    public class GreetingController : Controller
    {
        public string Get()
        {
            return "hello, world!";
        }
    }
}