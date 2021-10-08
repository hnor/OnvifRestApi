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


        [SwaggerOperation(Summary = "دستگاه NTP دریافت تنظیمات")]
        [HttpGet("GetNTP")]
        public OnvifObjects.OnvifGetNTPResponse.GetNTPResponse GetNTP(string CameraIp, string UserName, string Password)
        {
            SgiOnvif.SgiOnvifDevice sod1 = new SgiOnvif.SgiOnvifDevice();
            return sod1.GetNTP(CameraIp, UserName, Password);
        }


        [SwaggerOperation(Summary = "دریافت تنظیمات پیکربندی صفر")]
        [HttpGet("GetZeroConfiguration")]
        public OnvifObjects.GetZeroConfigurationResponse.GetZeroConfigurationResponse GetZeroConfiguration(string CameraIp, string UserName, string Password)
        {
            SgiOnvif.SgiOnvifDevice sod1 = new SgiOnvif.SgiOnvifDevice();
            return sod1.GetZeroConfiguration(CameraIp, UserName, Password);
        }


        [SwaggerOperation(Summary = "دریافت نام دستگاه")]
        [HttpGet("GetHostname")]
        public OnvifObjects.OnvifGetHostnameResponse.GetHostnameResponse GetHostname(string CameraIp, string UserName, string Password)
        {
            SgiOnvif.SgiOnvifDevice sod1 = new SgiOnvif.SgiOnvifDevice();
            return sod1.GetHostname(CameraIp, UserName, Password);
        }


        [SwaggerOperation(Summary = "دریافت اطلاعات گیت وی")]
        [HttpGet("GetNetworkDefaultGateway")]
        public OnvifObjects.GetNetworkDefaultGatewayResponse.GetNetworkDefaultGatewayResponse GetNetworkDefaultGateway(string CameraIp, string UserName, string Password)
        {
            SgiOnvif.SgiOnvifDevice sod1 = new SgiOnvif.SgiOnvifDevice();
            return sod1.GetNetworkDefaultGateway(CameraIp, UserName, Password);
        }


        [SwaggerOperation(Summary = "دریافت اطلاعات سرور نام دستگاه")]
        [HttpGet("GetDNS")]
        public OnvifObjects.GetDNSResponse.GetDNSResponse GetDNS(string CameraIp, string UserName, string Password)
        {
            SgiOnvif.SgiOnvifDevice sod1 = new SgiOnvif.SgiOnvifDevice();
            return sod1.GetDNS(CameraIp, UserName, Password);
        }


        [SwaggerOperation(Summary = "دریافت اطلاعات پروتکل های شبکه دستگاه")]
        [HttpGet("GetNetworkProtocols")]
        public OnvifObjects.GetNetworkProtocolsResponse.GetNetworkProtocolsResponse GetNetworkProtocols(string CameraIp, string UserName, string Password)
        {
            SgiOnvif.SgiOnvifDevice sod1 = new SgiOnvif.SgiOnvifDevice();
            return sod1.GetNetworkProtocols(CameraIp, UserName, Password);
        }


        [SwaggerOperation(Summary = "دریافت اطلاعات دیسکاوری دستگاه")]
        [HttpGet("GetDiscoveryMode")]
        public OnvifObjects.GetDiscoveryModeResponse.GetDiscoveryModeResponse GetDiscoveryMode(string CameraIp, string UserName, string Password)
        {
            SgiOnvif.SgiOnvifDevice sod1 = new SgiOnvif.SgiOnvifDevice();
            return sod1.GetDiscoveryMode(CameraIp, UserName, Password);
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
