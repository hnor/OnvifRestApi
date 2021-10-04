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





    }
}
