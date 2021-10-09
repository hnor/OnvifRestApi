using System;
using System.IO;
using System.Xml;

namespace SgiOnvifRestApiGW.SgiOnvif
{
    public class SgiOnvifEventPortType
    {
        public SgiOnvifEventPortType()
        {

        }

        public OnvifObjects.GetEventPropertiesResponse.GetEventPropertiesResponse GetEventProperties(string CameraIP, string Username, string Password)
        {
            string getevtp_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                "<GetEventProperties xmlns=\"http://www.onvif.org/ver10/events/wsdl\"/>" +
                               "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getevtp_xml, Username, Password, "GetEventProperties");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetEventPropertiesResponse.GetEventPropertiesResponse), new System.Xml.Serialization.XmlAttributeOverrides());
            rnod.Normalize();
            OnvifObjects.GetEventPropertiesResponse.GetEventPropertiesResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetEventPropertiesResponse.GetEventPropertiesResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }
    }
}
