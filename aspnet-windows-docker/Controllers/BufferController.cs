using Microsoft.SqlServer.Types;
using System.Web.Http;

namespace aspnet_windows_docker.Controllers
{
    public class BufferController : ApiController
    {
        public double GetSpatial()
        {
            var point = SqlGeometry.Point(4, 7, 4326);
            var buffer = point.STBuffer(5);
            return buffer.STArea().Value;
        }
    }
}
