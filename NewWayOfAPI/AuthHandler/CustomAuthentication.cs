using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.NewWayOfAPI.AuthHandler
{
    public static class CustomAuthentication
    {
        public static void HandleAuthenticationFromMultipleProviders(this IServiceCollection svcCollection)
        {
            /*
             * This simple statement inject the JWT Authentication with a "Bearer" scheme
             * that extarcts JWT token from the Authorization request Header
             *********** services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
             * 
             ************ Below lines does same thing with "Test" scheme
             * services.AddAuthentication("Test").AddJwtBearer("Test", options =>
             {
                 
             });
             */
            //svcCollection.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
            //    jwtBearerOption => { 
            //        jwtBearerOption.
            //    }
            //    );
        }
    }
}
