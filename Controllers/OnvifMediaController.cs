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

namespace OnvifRestApiGW.Controllers
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
        public OnvifObjects.GetProfilesResponse.GetProfilesResponse GetProfiles(string CameraIp, string UserName, string Password)
        {
            Onvif.OnvifMedia som1 = new Onvif.OnvifMedia();
            return som1.GetProfiles(CameraIp,UserName,Password);
            //return JsonSerializer.Serialize(res);
        }

        [SwaggerOperation(Summary = "دریافت اطلاعات یک پروفایل دستگاه")]
        [HttpGet("GetProfile")]
        public OnvifObjects.GetProfileResponse.GetProfileResponse GetProfile(string CameraIp, string UserName, string Password,string ProfileToken)
        {
            Onvif.OnvifMedia som1 = new Onvif.OnvifMedia();
            return som1.GetProfile(CameraIp,UserName,Password,ProfileToken);
            //return JsonSerializer.Serialize(res);
        }


        [SwaggerOperation(Summary = "دریافت آدرس تصویر")]
        [HttpGet("GetStreamUri")]
        public OnvifObjects.OnvifGetStreamUriResponce.GetStreamUriResponse GetStreamUri(string CameraIp, string UserName, string Password,string ProfileToken)
        {
            Onvif.OnvifMedia som1 = new Onvif.OnvifMedia();
            return som1.GetStreamUri(CameraIp,UserName,Password, ProfileToken);
        }


        [SwaggerOperation(Summary = "دریافت آدرس عکس برداری")]
        [HttpGet("GetSnapshotUri")]
        public OnvifObjects.GetSnapshotUriResponse.GetSnapshotUriResponse GetSnapshotUri(string CameraIp, string UserName, string Password,string ProfileToken)
        {
            Onvif.OnvifMedia som1 = new Onvif.OnvifMedia();
            return som1.GetSnapshotUri(CameraIp,UserName,Password, ProfileToken);
        }


        [SwaggerOperation(Summary = "دریافت تنظیمات ویدئو")]
        [HttpGet("GetVideoSourceConfiguration")]
        public OnvifObjects.GetVideoSourceConfigurationResponse.GetVideoSourceConfigurationResponse GetVideoSourceConfiguration(string CameraIp, string UserName, string Password,string ConfigurationToken)
        {
            Onvif.OnvifMedia som1 = new Onvif.OnvifMedia();
            return som1.GetVideoSourceConfiguration(CameraIp,UserName,Password, ConfigurationToken);
        }


        [SwaggerOperation(Summary = "دریافت تنظیمات صدا")]
        [HttpGet("GetAudioSourceConfigurations")]
        public OnvifObjects.GetAudioSourceConfigurationsResponse.GetAudioSourceConfigurationsResponse GetAudioSourceConfigurations(string CameraIp, string UserName, string Password,string ConfigurationToken)
        {
            Onvif.OnvifMedia som1 = new Onvif.OnvifMedia();
            return som1.GetAudioSourceConfigurations(CameraIp,UserName,Password, ConfigurationToken);
        }


        [SwaggerOperation(Summary = "دریافت تنظیمات کدینگ ویدئو")]
        [HttpGet("GetVideoEncoderConfigurationOptions")]
        public OnvifObjects.GetVideoEncoderConfigurationOptionsResponse.GetVideoEncoderConfigurationOptionsResponse GetVideoEncoderConfigurationOptions(string CameraIp, string UserName, string Password, string ProfileToken, string ConfigurationToken)
        {
            Onvif.OnvifMedia som1 = new Onvif.OnvifMedia();
            return som1.GetVideoEncoderConfigurationOptions(CameraIp, UserName, Password, ProfileToken, ConfigurationToken);
        }


        [SwaggerOperation(Summary = "دریافت تنظیمات ")]
        [HttpGet("GetMetadataConfigurationOptions")]
        public OnvifObjects.GetMetadataConfigurationOptionsResponse.GetMetadataConfigurationOptionsResponse GetMetadataConfigurationOptions(string CameraIp, string UserName, string Password, string ProfileToken, string ConfigurationToken)
        {
            Onvif.OnvifMedia som1 = new Onvif.OnvifMedia();
            return som1.GetMetadataConfigurationOptions(CameraIp, UserName, Password, ProfileToken, ConfigurationToken);
        }


        [SwaggerOperation(Summary = "حذف یک پروفایل")]
        [HttpPut("DeleteProfile")]
        public bool DeleteProfile(string CameraIp, string UserName, string Password, string ProfileToken)
        {
            Onvif.OnvifMedia som1 = new Onvif.OnvifMedia();
            return som1.DeleteProfile(CameraIp, UserName, Password, ProfileToken);
        }



    }
}
