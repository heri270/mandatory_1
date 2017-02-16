using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace ConsoleApplication {
    public class Startup {
        public void Configure(IApplicationBuilder app) {
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }
    }
}
