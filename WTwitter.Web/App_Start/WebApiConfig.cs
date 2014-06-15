using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace WTwitter.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "UserApi",
                routeTemplate: "api/v1/Users/{id}",
                defaults: new { controller = "apiUser", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "LoginApi",
                routeTemplate: "api/v1/Login/{id}",
                defaults: new { controller = "apiLogin", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "TweetsApi",
                routeTemplate: "api/v1/Tweets/{id}",
                defaults: new { controller = "apiTweet", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "FollowApi",
                routeTemplate: "api/v1/Follow/{id}",
                defaults: new { controller = "apiFollow", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
