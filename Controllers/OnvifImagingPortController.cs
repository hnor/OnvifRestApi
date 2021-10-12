using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SgiOnvifRestApiGW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OnvifImagingPortController : ControllerBase
    {
        public OnvifImagingPortController()
        {

        }

        [SwaggerOperation(Summary = "")]
        [HttpGet("GetOptions")]
        public OnvifObjects.GetOptionsResponse.GetOptionsResponse GetProfile(string CameraIp, string UserName, string Password, string VideoSourceToken)
        {
            SgiOnvif.SgiOnvifImagingPort soip1 = new SgiOnvif.SgiOnvifImagingPort();
            return soip1.GetOptions(CameraIp, UserName, Password, VideoSourceToken);
        }

        [SwaggerOperation(Summary = "")]
        [HttpGet("GetMoveOptions")]
        public OnvifObjects.GetMoveOptionsResponse.GetMoveOptionsResponse GetMoveOptions(string CameraIp, string UserName, string Password, string VideoSourceToken)
        {
            SgiOnvif.SgiOnvifImagingPort soip1 = new SgiOnvif.SgiOnvifImagingPort();
            return soip1.GetMoveOptions(CameraIp, UserName, Password, VideoSourceToken);
        }

        [SwaggerOperation(Summary = "")]
        [HttpGet("GetImagingSettings")]
        public OnvifObjects.GetImagingSettingsResponse.GetImagingSettingsResponse GetImagingSettings(string CameraIp, string UserName, string Password, string VideoSourceToken)
        {
            SgiOnvif.SgiOnvifImagingPort soip1 = new SgiOnvif.SgiOnvifImagingPort();
            return soip1.GetImagingSettings(CameraIp, UserName, Password, VideoSourceToken);
//          return System.Text.Json.JsonSerializer.Serialize(res);
        }



    }
}
