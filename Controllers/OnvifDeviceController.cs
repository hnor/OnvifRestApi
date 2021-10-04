﻿using Microsoft.AspNetCore.Mvc;
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
    public class OnvifDeviceController : ControllerBase
    {
        private readonly ILogger<OnvifMediaController> _logger;

        public OnvifDeviceController(ILogger<OnvifMediaController> logger)
        {
            _logger = logger;

        }
        [SwaggerOperation(Summary = "دریافت مشخصات زمانی دستگاه")]
        [HttpGet("GetSystemDateAndTime")]
        public OnvifObjects.GetSystemDateAndTimeResponse.GetSystemDateAndTimeResponse GetSystemDateAndTime(string CameraIp, string UserName, string Password)
        {
            SgiOnvif.SgiOnvifDevice sod1 = new SgiOnvif.SgiOnvifDevice();
            return sod1.GetDeviceDateTime(CameraIp, UserName, Password);
        }


        [SwaggerOperation(Summary = "دریافت لیست قابلیتهای دستگاه")]
        [HttpGet("GetCapabilities")]
        public OnvifObjects.GetCapabilitiesResponse.GetCapabilitiesResponse GetCapabilities(string CameraIp, string UserName, string Password)
        {
            SgiOnvif.SgiOnvifDevice sod1 = new SgiOnvif.SgiOnvifDevice();
            return sod1.GetCapabilities(CameraIp, UserName, Password);
        }


        [SwaggerOperation(Summary = "دریافت مشخصات اینترفیس شبکه دستگاه")]
        [HttpGet("GetNetworkInterfaces")]
        public OnvifObjects.OnvifGetNetworkInterfacesResponse.GetNetworkInterfacesResponse GetNetworkInterfaces(string CameraIp, string UserName, string Password)
        {
            SgiOnvif.SgiOnvifDevice sod1 = new SgiOnvif.SgiOnvifDevice();
            return sod1.GetNetworkInterfaces(CameraIp, UserName, Password);
        }









        [HttpGet("GetScopes")]
        public OnvifObjects.GetScopesResponse.GetScopesResponse GetScopes(string CameraIp, string UserName, string Password, int _RtspPort = 554, int _Timout = 45)
        {
            return GetScopes(CameraIp, UserName, Password, _RtspPort, _Timout);
        }
        private OnvifObjects.GetScopesResponse.GetScopesResponse get_GetScopes(string CameraIp, string UserName, string Password, int _RtspPort = 554, int _Timout = 45)
        {
            SgiOnvif.SgiOnvifDevice sod1 = new SgiOnvif.SgiOnvifDevice();
            return sod1.GetScopes(CameraIp, UserName, Password);
        }
    }
}
