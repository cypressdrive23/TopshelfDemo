using Microsoft.Owin.Hosting;
using System;

namespace JWTTest
{
    public class TopshelfService
    {
        private IDisposable _webApp = null;

        public void Start()
        {
            _webApp = WebApp.Start<Startup>("http://localhost:9989");
        }

        public void Stop()
        {
            _webApp?.Dispose();
        }
    }
}
