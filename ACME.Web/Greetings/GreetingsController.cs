using Microsoft.AspNetCore.Mvc;

namespace ACME.Web.Greetings
{
    [Produces("application/json")]
    [Route("api/Greetings")]
    public class GreetingsController : Controller
    {
        public string Get()
        {
            return "hello, world!";
        }
    }
}