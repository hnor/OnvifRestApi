using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnvifRestApiGW.Controllers
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
            Onvif.OnvifPTZ sop1 = new Onvif.OnvifPTZ();
            return sop1.GetConfigurations(CameraIP, Username, Password);
        }


        [SwaggerOperation(Summary = "حرکت دوربین به صورت مطلق")]
        [HttpPut("AbsuloteMove")]
        public void AbsuloteMove(String CameraIP, String Username, String Password, String ProfileToken, float PanTiltX, float PanTiltY,float Zoom, float PantiltXSpeed = (float)0.1, float PanTiltYSpeed = (float)0.1, float ZoomSpeed = (float)0.1)
        {
            Onvif.OnvifPTZ sop1 = new Onvif.OnvifPTZ();
            sop1.AbsoluteMove(CameraIP, Username, Password, ProfileToken, PanTiltX, PanTiltY, Zoom, PantiltXSpeed, PanTiltYSpeed, ZoomSpeed);
        }


        [SwaggerOperation(Summary = "حرکت دوربین به صورت نسبی")]
        [HttpPut("RelativeMove")]
        public void RelativeMove(String CameraIP, String Username, String Password, String ProfileToken, float PanTiltX, float PanTiltY, float SpeedX, float SpeedY)
        {
            Onvif.OnvifPTZ sop1 = new Onvif.OnvifPTZ();
            sop1.RelativeMove(CameraIP, Username, Password, ProfileToken, PanTiltX, PanTiltY, SpeedX, SpeedY);
        }


        [SwaggerOperation(Summary = "حرکت دوربین به صورت ادامه دار")]
        [HttpPut("ContinuousMove")]
        public void ContinuousMove(String CameraIP, String Username, String Password,String ProfileToken,float PanTiltX, float PanTiltY,float Zoom)
        {
            Onvif.OnvifPTZ sop1 = new Onvif.OnvifPTZ();
            sop1.ContinuousMove(CameraIP, Username, Password, ProfileToken, PanTiltX, PanTiltY, Zoom);
        }


        [SwaggerOperation(Summary = "توقف حرکت دوربین")]
        [HttpPut("Stop")]
        public void Stop(String CameraIP, String Username, String Password,String ProfileToken)
        {
            Onvif.OnvifPTZ sop1 = new Onvif.OnvifPTZ();
            sop1.Stop(CameraIP, Username, Password, ProfileToken);
        }


        [SwaggerOperation(Summary = "تنظیم موقعیت خانه")]
        [HttpPut("SetHomePosition")]
        public void SetHomePosition(String CameraIP, String Username, String Password,String ProfileToken)
        {
            Onvif.OnvifPTZ sop1 = new Onvif.OnvifPTZ();
            sop1.SetHomePosition(CameraIP, Username, Password, ProfileToken);
        }


        [SwaggerOperation(Summary = "رفتن به موقعیت خانه")]
        [HttpPut("GotoHomePosition")]
        public void GotoHomePosition(String CameraIP, String Username, String Password,String ProfileToken)
        {
            Onvif.OnvifPTZ sop1 = new Onvif.OnvifPTZ();
            sop1.GotoHomePosition(CameraIP, Username, Password, ProfileToken);
        }


        [SwaggerOperation(Summary = "رفتن به موقعیت ذخیره شده")]
        [HttpPut("GotoPreset")]
        public void GotoPreset(String CameraIP, String Username, String Password,String ProfileToken,int PresetToken)
        {
            Onvif.OnvifPTZ sop1 = new Onvif.OnvifPTZ();
            sop1.GotoPreset(CameraIP, Username, Password, ProfileToken, PresetToken);
        }


        [SwaggerOperation(Summary = "حذف موقعیت ذخیره شده")]
        [HttpPut("RemovePreset")]
        public void RemovePreset(String CameraIP, String Username, String Password,String ProfileToken,int PresetToken)
        {
            Onvif.OnvifPTZ sop1 = new Onvif.OnvifPTZ();
            sop1.RemovePreset(CameraIP, Username, Password, ProfileToken, PresetToken);
        }


        [SwaggerOperation(Summary = "لیست موقعیت های ذخیره شده")]
        [HttpGet("GetPresets")]
        public OnvifObjects.GetPresetsResponse.GetPresetsResponse GetPresets(String CameraIP, String Username, String Password,String ProfileToken)
        {
            Onvif.OnvifPTZ sop1 = new Onvif.OnvifPTZ();
            return sop1.GetPresets(CameraIP, Username, Password, ProfileToken);
        }


        [SwaggerOperation(Summary = "ذخیره یک موقعیت دوربین")]
        [HttpPut("SetPreset")]
        public OnvifObjects.SetPresetResponse.SetPresetResponse SetPreset(String CameraIP, String Username, String Password,String ProfileToken,string PresetName)
        {
            Onvif.OnvifPTZ sop1 = new Onvif.OnvifPTZ();
            return sop1.SetPreset(CameraIP, Username, Password, ProfileToken, PresetName);
        }


    }
}
