using System;
using System.IO;
using System.Xml;

namespace SgiOnvifRestApiGW.SgiOnvif
{
    public class SgiOnvifImagingPort
    {
        public SgiOnvifImagingPort()
        {

        }

        public OnvifObjects.GetOptionsResponse.GetOptionsResponse GetOptions(string CameraIP, string Username, string Password, string VideoSourceToken)
        {
            string getstruri_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetOptions xmlns=\"http://www.onvif.org/ver20/imaging/wsdl\">" +
                                        "<VideoSourceToken>" + VideoSourceToken + "</VideoSourceToken>" +
                                    "</GetOptions>" +
                                   "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getstruri_xml, Username, Password, "GetOptions");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetOptionsResponse.GetOptionsResponse));
            rnod.Normalize();
            OnvifObjects.GetOptionsResponse.GetOptionsResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetOptionsResponse.GetOptionsResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetMoveOptionsResponse.GetMoveOptionsResponse GetMoveOptions(string CameraIP, string Username, string Password, string VideoSourceToken)
        {
            string getstruri_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                       "<GetMoveOptions xmlns=\"http://www.onvif.org/ver20/imaging/wsdl\">" +
                                        "<VideoSourceToken>" + VideoSourceToken + "</VideoSourceToken>" +
                                       "</GetMoveOptions>" +
                                   "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getstruri_xml, Username, Password, "GetMoveOptions");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetMoveOptionsResponse.GetMoveOptionsResponse));
            rnod.Normalize();
            OnvifObjects.GetMoveOptionsResponse.GetMoveOptionsResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetMoveOptionsResponse.GetMoveOptionsResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }


    }
}
