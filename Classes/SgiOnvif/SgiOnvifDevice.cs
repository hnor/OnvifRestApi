using System;
using System.IO;
using System.Xml;

namespace SgiOnvifRestApiGW.SgiOnvif
{
    public class SgiOnvifDevice
    {
        public SgiOnvifDevice()
        {

        }
        public OnvifObjects.GetSystemDateAndTimeResponse.GetSystemDateAndTimeResponse GetDeviceDateTime(string CameraIP, string Username, string Password)
        {
            OnvifObjects.GetSystemDateAndTimeResponse.GetSystemDateAndTimeResponse ret = null;
            string getsystemdatetime_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                                "<GetSystemDateAndTime xmlns=\"http://www.onvif.org/ver10/device/wsdl\"/>" +
                                           "</s:Body>";
            string res = NetFuncs.PostXmlRequest(CameraIP, getsystemdatetime_xml, Username, Password,"GetSystemDateAndTime");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetSystemDateAndTimeResponse.GetSystemDateAndTimeResponse));
            using (StringReader stringReader = new StringReader(rnod.OuterXml))
            {
                ret = (OnvifObjects.GetSystemDateAndTimeResponse.GetSystemDateAndTimeResponse)serializer.Deserialize(stringReader);
            }
            return ret;
        }
        public OnvifObjects.GetCapabilitiesResponse.GetCapabilitiesResponse GetCapabilities(string CameraIP, string Username, string Password)
        {
            OnvifObjects.GetCapabilitiesResponse.GetCapabilitiesResponse cr = null;
            string getcpblity_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                        "<GetCapabilities xmlns=\"http://www.onvif.org/ver10/device/wsdl\">" +
                                            "<Category>" +
                                                "All" +
                                            "</Category>" +
                                        "</GetCapabilities>" +
                                     "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getcpblity_xml, Username, Password, "GetCapabilities");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetCapabilitiesResponse.GetCapabilitiesResponse));
            using (StringReader stringReader = new StringReader(rnod.OuterXml))
            {
                cr = (OnvifObjects.GetCapabilitiesResponse.GetCapabilitiesResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }
        public OnvifObjects.GetScopesResponse.GetScopesResponse GetScopes(string CameraIP, string Username, string Password)
        {
            OnvifObjects.GetScopesResponse.GetScopesResponse cr = new OnvifObjects.GetScopesResponse.GetScopesResponse();
            string GetScope_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetScopes xmlns=\"http://www.onvif.org/ver10/device/wsdl\"/>" +
                                  "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, GetScope_xml, Username, Password, "GetScopes");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetScopesResponse.GetScopesResponse));
            using (StringReader stringReader = new StringReader(rnod.OuterXml))
            {
                cr = (OnvifObjects.GetScopesResponse.GetScopesResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.OnvifGetNetworkInterfacesResponse.GetNetworkInterfacesResponse GetNetworkInterfaces(string CameraIP, string Username, string Password) 
        {
            string getinterfce_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                        "<GetNetworkInterfaces xmlns=\"http://www.onvif.org/ver10/device/wsdl\"/>" +
                                     "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getinterfce_xml, Username, Password, "GetNetworkInterfaces");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.OnvifGetNetworkInterfacesResponse.GetNetworkInterfacesResponse));
            rnod.Normalize();
            OnvifObjects.OnvifGetNetworkInterfacesResponse.GetNetworkInterfacesResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.OnvifGetNetworkInterfacesResponse.GetNetworkInterfacesResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }
        public OnvifObjects.OnvifGetNTPResponse.GetNTPResponse GetNTP(string CameraIP, string Username, string Password) 
        {
            string getntp_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">"+
                                    "<GetNTP xmlns =\"http://www.onvif.org/ver10/device/wsdl\"/>"+
                                "</s:Body > ";
            var res = NetFuncs.PostXmlRequest(CameraIP, getntp_xml, Username, Password, "GetNTP");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.OnvifGetNTPResponse.GetNTPResponse));
            rnod.Normalize();
            OnvifObjects.OnvifGetNTPResponse.GetNTPResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.OnvifGetNTPResponse.GetNTPResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.OnvifGetHostnameResponse.GetHostnameResponse GetHostname(string CameraIP, string Username, string Password)
        {
            string gethstname_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                        "<GetHostname xmlns=\"http://www.onvif.org/ver10/device/wsdl\"/>" +
                                    "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, gethstname_xml, Username, Password, "GetHostname");
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.OnvifGetHostnameResponse.GetHostnameResponse));
            rnod.Normalize();
            OnvifObjects.OnvifGetHostnameResponse.GetHostnameResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.OnvifGetHostnameResponse.GetHostnameResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetZeroConfigurationResponse.GetZeroConfigurationResponse GetZeroConfiguration(string CameraIP, string Username, string Password)
        {
            string getzer_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetZeroConfiguration xmlns=\"http://www.onvif.org/ver10/device/wsdl\"/>" +
                                "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getzer_xml, Username, Password, "GetZeroConfiguration");
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetZeroConfigurationResponse.GetZeroConfigurationResponse));
            rnod.Normalize();
            OnvifObjects.GetZeroConfigurationResponse.GetZeroConfigurationResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetZeroConfigurationResponse.GetZeroConfigurationResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetDNSResponse.GetDNSResponse GetDNS(string CameraIP, string Username, string Password)
        {
            string getdns_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetDNS xmlns=\"http://www.onvif.org/ver10/device/wsdl\"/>" +
                                "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getdns_xml, Username, Password, "GetDNS");
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetDNSResponse.GetDNSResponse));
            rnod.Normalize();
            OnvifObjects.GetDNSResponse.GetDNSResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetDNSResponse.GetDNSResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetNetworkProtocolsResponse.GetNetworkProtocolsResponse GetNetworkProtocols(string CameraIP, string Username, string Password)
        {
            string getnp_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetNetworkProtocols xmlns=\"http://www.onvif.org/ver10/device/wsdl\"/>" +
                               "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getnp_xml, Username, Password, "GetNetworkProtocols");
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetNetworkProtocolsResponse.GetNetworkProtocolsResponse));
            rnod.Normalize();
            OnvifObjects.GetNetworkProtocolsResponse.GetNetworkProtocolsResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetNetworkProtocolsResponse.GetNetworkProtocolsResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetDiscoveryModeResponse.GetDiscoveryModeResponse GetDiscoveryMode(string CameraIP, string Username, string Password)
        {
            string getdm_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetDiscoveryMode xmlns=\"http://www.onvif.org/ver10/device/wsdl\"/>" +
                               "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getdm_xml, Username, Password, "GetDiscoveryMode");
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetDiscoveryModeResponse.GetDiscoveryModeResponse));
            rnod.Normalize();
            OnvifObjects.GetDiscoveryModeResponse.GetDiscoveryModeResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetDiscoveryModeResponse.GetDiscoveryModeResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetNetworkDefaultGatewayResponse.GetNetworkDefaultGatewayResponse GetNetworkDefaultGateway(string CameraIP, string Username, string Password)
        {
            string getgw_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetNetworkDefaultGateway xmlns=\"http://www.onvif.org/ver10/device/wsdl\"/>" +
                                "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getgw_xml, Username, Password, "GetNetworkDefaultGateway");
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetNetworkDefaultGatewayResponse.GetNetworkDefaultGatewayResponse));
            rnod.Normalize();
            OnvifObjects.GetNetworkDefaultGatewayResponse.GetNetworkDefaultGatewayResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetNetworkDefaultGatewayResponse.GetNetworkDefaultGatewayResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }
        
        public OnvifObjects.GetSystemLogResponse.GetSystemLogResponse GetSystemLog(string CameraIP, string Username, string Password,string LogType)
        {
            string getsl_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetSystemLog xmlns=\"http://www.onvif.org/ver10/device/wsdl\">" +
                                        "<LogType>" + LogType + "</LogType>" +
                                    "</GetSystemLog>" +
                                "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getsl_xml, Username, Password, "GetSystemLog");
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetSystemLogResponse.GetSystemLogResponse));
            rnod.Normalize();
            OnvifObjects.GetSystemLogResponse.GetSystemLogResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetSystemLogResponse.GetSystemLogResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetRelayOutputsResponse.GetRelayOutputsResponse GetRelayOutputs(string CameraIP, string Username, string Password) 
        {
            string getru_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                "<GetRelayOutputs xmlns=\"http://www.onvif.org/ver10/device/wsdl\"/>" +
                               "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getru_xml, Username, Password, "GetRelayOutputs");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetRelayOutputsResponse.GetRelayOutputsResponse));
            rnod.Normalize();
            OnvifObjects.GetRelayOutputsResponse.GetRelayOutputsResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetRelayOutputsResponse.GetRelayOutputsResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetUsersResponse.GetUsersResponse GetUsers(string CameraIP, string Username, string Password) 
        {
            string getusr_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetUsers xmlns=\"http://www.onvif.org/ver10/device/wsdl\"/>" +
                                "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getusr_xml, Username, Password, "GetUsers");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetUsersResponse.GetUsersResponse));
            rnod.Normalize();
            OnvifObjects.GetUsersResponse.GetUsersResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetUsersResponse.GetUsersResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetServicesResponse.GetServicesResponse GetServices(string CameraIP, string Username, string Password,bool IncludeCapability) 
        {
            string getusr_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetServices xmlns=\"http://www.onvif.org/ver10/device/wsdl\">" +
                                        "<IncludeCapability>" + IncludeCapability + "</IncludeCapability>" +
                                    "</GetServices>" +
                                "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getusr_xml, Username, Password, "GetServices");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetServicesResponse.GetServicesResponse));
            rnod.Normalize();
            OnvifObjects.GetServicesResponse.GetServicesResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetServicesResponse.GetServicesResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }





        public void SetScopes(string CameraIP, string Username, string Password,string DeviceName,string LocationName)
        {
            string setScope_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<SetScopes xmlns=\"http://www.onvif.org/ver10/device/wsdl\">" +
                                        "<Scopes>odm:name:" + DeviceName + "</Scopes>" +
                                        "<Scopes>odm:location:" + LocationName + "</Scopes>" +
                                    "</SetScopes></s:Body>";
            NetFuncs.PostXmlRequest(CameraIP, setScope_xml, Username, Password, "SetScopes");
        }

        public void SetNetworkInterfaces(string CameraIP, string Username, string Password,OnvifObjects.Inputs.OnvifSetNetworkInterfacesInputs NewInterfaceConfig)
        {
            string setSintf_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<SetNetworkInterfaces xmlns=\"http://www.onvif.org/ver10/device/wsdl\">" +
                                        "<InterfaceToken>" + NewInterfaceConfig.InterfaceName + "</InterfaceToken>" +
                                        "<NetworkInterface>" +
                                            "<Enabled xmlns=\"http://www.onvif.org/ver10/schema\">" + NewInterfaceConfig.Enabled + "</Enabled>" +
                                            "<MTU xmlns=\"http://www.onvif.org/ver10/schema\">" + NewInterfaceConfig.MTU + "</MTU>" +
                                            "<IPv4 xmlns=\"http://www.onvif.org/ver10/schema\">" +
                                                "<Enabled>" + NewInterfaceConfig.IPV4Enabled + "</Enabled>" +
                                                "<Manual>" + (NewInterfaceConfig.IPV4Manual ?
                                                            "<Address>" + NewInterfaceConfig.IPV4ManualAddress + "</Address>" +
                                                            "<PrefixLength>" + NewInterfaceConfig.IPV4PrefixLength + "</PrefixLength>" :
                                                            "false") +
                                                "</Manual>" +
                                                "<DHCP>" + NewInterfaceConfig.IPV4DHCP + "</DHCP>" +
                                            "</IPv4>" +
                                        "</NetworkInterface>" +
                                    "</SetNetworkInterfaces>" +
                                 "</s:Body>";
            NetFuncs.PostXmlRequest(CameraIP, setSintf_xml, Username, Password, "SetNetworkInterfaces");
        }

    }
}
