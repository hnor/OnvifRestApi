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
            if (xmlDoc.InnerText.Contains("s:Fault"))
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
            if (xmlDoc.InnerText.Contains("s:Fault"))
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
            if (xmlDoc.InnerText.Contains("s:Fault"))
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
            if (xmlDoc.InnerText.Contains("s:Fault"))
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


    }
}
