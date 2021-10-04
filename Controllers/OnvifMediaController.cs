using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SgiOnvifRestApiGW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OnvifMediaController : ControllerBase
    {
        private readonly ILogger<OnvifMediaController> _logger;

        public OnvifMediaController(ILogger<OnvifMediaController> logger)
        {
            _logger = logger;

        }
        [SwaggerOperation(Summary = "دریافت پروفایل های موجود در دستگاه")]
        [HttpGet("GetProfiles")]
        /// <summary>
        /// Get list of camera profiles
        /// </summary>
        /// <param name="CameraIp">cameraip[:port]</param>
        /// <param name="UserName">camera username</param>
        /// <param name="Password">camera password</param>
        /// <returns>list of profiles as json string</returns>
        public string GetProfiles(string CameraIp, string UserName, string Password)
        {
            SgiOnvif.SgiOnvifMedia som1 = new SgiOnvif.SgiOnvifMedia();
            var res = som1.GetProfiles(CameraIp,UserName,Password);
            return JsonSerializer.Serialize(res);
        }


        [SwaggerOperation(Summary = "دریافت آدرس تصویر")]
        [HttpGet("GetStreamUri")]
        public OnvifObjects.OnvifGetStreamUriResponce.GetStreamUriResponse GetStreamUri(string CameraIp, string UserName, string Password,string ProfileToken)
        {
            SgiOnvif.SgiOnvifMedia som1 = new SgiOnvif.SgiOnvifMedia();
            return som1.GetStreamUri(CameraIp,UserName,Password, ProfileToken);
        }



    }
}
