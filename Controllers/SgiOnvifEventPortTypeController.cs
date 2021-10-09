using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace SgiOnvifRestApiGW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SgiOnvifEventPortTypeController : ControllerBase
    {
        public SgiOnvifEventPortTypeController()
        {

        }

        [SwaggerOperation(Summary = "دریافت مشخصات رویدادهای دستگاه")]
        [HttpGet("GetEventProperties")]
        public OnvifObjects.GetEventPropertiesResponse.GetEventPropertiesResponse GetEventProperties(string CameraIP, string Username, string Password) 
        {
            SgiOnvif.SgiOnvifEventPortType soept = new SgiOnvif.SgiOnvifEventPortType();
            return soept.GetEventProperties(CameraIP, Username, Password);
        }
    }
}
