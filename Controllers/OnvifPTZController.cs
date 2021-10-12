using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SgiOnvifRestApiGW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OnvifPTZController : Controller
    {
        private readonly ILogger<OnvifPTZController> _logger;

        public OnvifPTZController(ILogger<OnvifPTZController> logger)
        {
            _logger = logger;

        }


        [SwaggerOperation(Summary = "دستگاه PTZ دریافت تنظیمات")]
        [HttpGet("GetConfigurations")]
        public OnvifObjects.OnvifPtzGetConfigurationsResponse.GetConfigurationsResponse GetConfigurations(String CameraIP, String Username, String Password)
        {
            SgiOnvif.SgiOnvifPTZ sop1 = new SgiOnvif.SgiOnvifPTZ();
            return sop1.GetConfigurations(CameraIP, Username, Password);
        }


        [SwaggerOperation(Summary = "حرکت دوربین به صورت مطلق")]
        [HttpPut("AbsuloteMove")]
        public void AbsuloteMove(String CameraIP, String Username, String Password, String ProfileToken, float PanTiltX, float PanTiltY,float Zoom)
        {
            SgiOnvif.SgiOnvifPTZ sop1 = new SgiOnvif.SgiOnvifPTZ();
            sop1.AbsoluteMove(CameraIP, Username, Password, ProfileToken, PanTiltX, PanTiltY, Zoom);
        }


        [SwaggerOperation(Summary = "حرکت دوربین به صورت نسبی")]
        [HttpPut("RelativeMove")]
        public void RelativeMove(String CameraIP, String Username, String Password, String ProfileToken, float PanTiltX, float PanTiltY)
        {
            SgiOnvif.SgiOnvifPTZ sop1 = new SgiOnvif.SgiOnvifPTZ();
            sop1.RelativeMove(CameraIP, Username, Password, ProfileToken, PanTiltX, PanTiltY);
        }


        [SwaggerOperation(Summary = "حرکت دوربین به صورت ادامه دار")]
        [HttpPut("ContinuousMove")]
        public void ContinuousMove(String CameraIP, String Username, String Password,String ProfileToken,float PanTiltX, float PanTiltY)
        {
            SgiOnvif.SgiOnvifPTZ sop1 = new SgiOnvif.SgiOnvifPTZ();
            sop1.ContinuousMove(CameraIP, Username, Password, ProfileToken, PanTiltX, PanTiltY);
        }


        [SwaggerOperation(Summary = "توقف حرکت دوربین")]
        [HttpPut("Stop")]
        public void Stop(String CameraIP, String Username, String Password,String ProfileToken)
        {
            SgiOnvif.SgiOnvifPTZ sop1 = new SgiOnvif.SgiOnvifPTZ();
            sop1.Stop(CameraIP, Username, Password, ProfileToken);
        }
    }
}
