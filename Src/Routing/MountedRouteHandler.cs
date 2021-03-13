using System.Web;
using System.Web.Routing;

namespace Nina
{
    internal class MountedRouteHandler : IRouteHandler
	{
        private IHttpHandler _httpHandler;

        public MountedRouteHandler(string mountedUrl)
		{
            _httpHandler = new Nina.NinaHandler(mountedUrl);
		}

		public IHttpHandler GetHttpHandler(RequestContext requestContext)
		{
		    return _httpHandler;
		}
	}
}
