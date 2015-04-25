using System.Collections.Generic;
using System.Web.Http;

namespace WinAPI.Controllers
{
    public class ChapterController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new []
                   {
                       "Owin",
                       "Katana",
                       "Web Frameworks",
                       "Azure",
                       "Custom Middleware",
                       "Authentication",
                       "Appendixes"
                   };
        }
    }
}