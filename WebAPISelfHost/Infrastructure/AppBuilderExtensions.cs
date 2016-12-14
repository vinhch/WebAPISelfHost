using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPISelfHost
{
    internal static class AppBuilderExtensions
    {
        public static IAppBuilder UseSampleMiddleware(this IAppBuilder app)
        {
            app.Use<SampleMiddleware>();
            return app;
        }
    }
}
