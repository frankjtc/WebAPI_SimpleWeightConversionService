using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_WeightConversion.Controllers
{
    public class WeightConversionController : ApiController
    {
        const double factor = 2.2046226218;
        //Pound-Kilo Conversion
        [HttpGet]
        public IHttpActionResult ConvertLbToKilo(double pounds)
        {
            var kilos = pounds /factor;
            return Ok(kilos);
        }

        //Kilo-Pound Conversion
        [HttpGet]
        public IHttpActionResult ConvertKiloToLb(double kilos)
        {
            var pounds = kilos * factor;
            return Ok(pounds);
        }
    }
}
