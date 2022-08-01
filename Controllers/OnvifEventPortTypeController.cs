using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Text;
using System.Diagnostics;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace OnvifRestApiGW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OnvifEventPortTypeController : ControllerBase
    {
        public OnvifEventPortTypeController()
        {

        }

        [SwaggerOperation(Summary = "دریافت مشخصات رویدادهای دستگاه")]
        [HttpGet("GetEventProperties")]
        public OnvifObjects.GetEventPropertiesResponse.GetEventPropertiesResponse GetEventProperties(string CameraIP, string Username, string Password)
        {
            Onvif.OnvifEventPortType soept = new Onvif.OnvifEventPortType();
            return soept.GetEventProperties(CameraIP, Username, Password);
        }

        [SwaggerOperation(Summary = "")]
        [HttpGet("Subscribe")]
        public OnvifObjects.SubscribeResponse.SubscribeResponse Subscribe()
        {
            Onvif.OnvifEventPortType soept = new Onvif.OnvifEventPortType();
            return soept.DoSubscribe();
        }


    }

}
