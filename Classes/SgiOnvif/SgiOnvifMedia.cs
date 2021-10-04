using System;
using System.IO;
using System.Xml;

namespace SgiOnvifRestApiGW.SgiOnvif
{
    public class SgiOnvifMedia
    {
        public SgiOnvifMedia()
        {

        }
        public OnvifObjects.OnvifGetStreamUriResponce.GetStreamUriResponse GetStreamUri(string CameraIP, string Username, string Password,string ProfileToken) 
        {
            string getstruri_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetStreamUri xmlns=\"http://www.onvif.org/ver10/media/wsdl\">" +
                                        "<StreamSetup>" +
                                            "<Stream xmlns=\"http://www.onvif.org/ver10/schema\">" +
                                                "RTP-Unicast" +
                                            "</Stream>" +
                                            "<Transport xmlns=\"http://www.onvif.org/ver10/schema\">" +
                                                "<Protocol>RTSP</Protocol>" +
                                            "</Transport>" +
                                        "</StreamSetup>" +
                                        "<ProfileToken>"+ProfileToken+"</ProfileToken>" +
                                    "</GetStreamUri>" +
                                   "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getstruri_xml, Username, Password, "GetStreamUri");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.ChildNodes[1].FirstChild.FirstChild.Name== "s:Fault")
            {
                throw new Exception(xmlDoc.ChildNodes[1].FirstChild.FirstChild.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.OnvifGetStreamUriResponce.GetStreamUriResponse));
            rnod.Normalize();
            OnvifObjects.OnvifGetStreamUriResponce.GetStreamUriResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.OnvifGetStreamUriResponce.GetStreamUriResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }
        public OnvifObjects.GetProfilesResponse.GetProfilesResponseProfiles[] GetProfiles(string CameraIP, string Username, string Password)
        {
            string getprofiles_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">"+
                                        "<GetProfiles xmlns =\"http://www.onvif.org/ver10/media/wsdl\"/>"+
                                     "</s:Body > ";
            OnvifObjects.GetProfilesResponse.GetProfilesResponse cr = null;
            var res = NetFuncs.PostXmlRequest(CameraIP, getprofiles_xml, Username, Password, "GetProfiles");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetProfilesResponse.GetProfilesResponse),new System.Xml.Serialization.XmlAttributeOverrides());
            rnod.Normalize();
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetProfilesResponse.GetProfilesResponse)serializer.Deserialize(stringReader);
            }
            return cr.Profiles;
        }
    }
}
