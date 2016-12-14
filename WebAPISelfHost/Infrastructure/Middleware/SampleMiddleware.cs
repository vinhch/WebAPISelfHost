using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFunc = System.Func<System.Collections.Generic.IDictionary<string, object>, System.Threading.Tasks.Task>;

namespace WebAPISelfHost
{
    class SampleMiddleware
    {
        AppFunc _next;

        public SampleMiddleware(AppFunc next)
        {
            _next = next;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            IOwinContext context = new OwinContext(environment);
            //await context.Response.WriteAsync("<h1>Hello from My First Middleware</h1>");

            // Invoke and await the next middleware component:
            await _next.Invoke(environment);

            Console.WriteLine("URI: {0} Status Code: {1}",
                context.Request.Uri, context.Response.StatusCode);
        }
    }
}
