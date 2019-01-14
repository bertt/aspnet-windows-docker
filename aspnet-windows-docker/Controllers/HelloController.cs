using System.Web.Http;

namespace aspnet_windows_docker.Controllers
{
    public class HelloController : ApiController
    {
        public string GetSpatial()
        {
            return "hello";
        }
    }
}
