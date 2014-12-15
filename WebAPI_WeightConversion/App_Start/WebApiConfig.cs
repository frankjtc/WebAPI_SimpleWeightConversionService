using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;

namespace WebAPI_WeightConversion
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //route to convert from Lb to Kg
            config.Routes.MapHttpRoute(
              name: "ConvertToKiloApi",
              routeTemplate: "api/conversion/poundtokilo/{pounds}",
              defaults: new { controller = "WeightConversion", action = "ConvertLbToKilo" }
          );

            //route to convert from Kg to Lb
            config.Routes.MapHttpRoute(
              name: "ConvertToPoundApi",
              routeTemplate: "api/conversion/kilotopound/{kilos}",
              defaults: new { controller = "WeightConversion", action = "ConvertKiloToLb" }
          );

            //To get the response as Json
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
