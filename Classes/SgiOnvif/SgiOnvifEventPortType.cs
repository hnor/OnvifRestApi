using System;
using System.Net;
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


        public OnvifObjects.SubscribeResponse.SubscribeResponse DoSubscribe()
        {
            string xm = "<s:Envelope xmlns:s=\"http://www.w3.org/2003/05/soap-envelope\" xmlns:a=\"http://www.w3.org/2005/08/addressing\">" +
                            "<s:Header>" +
                                "<a:Action s:mustUnderstand=\"1\">http://docs.oasis-open.org/wsn/bw-2/NotificationProducer/SubscribeRequest</a:Action>" +
                                    "<a:MessageID>urn:uuid:a551b100-c4b6-44ba-af84-c38208fa2bd7</a:MessageID>" +
                                    "<a:ReplyTo>" +
                                        "<a:Address>http://www.w3.org/2005/08/addressing/anonymous</a:Address>" +
                                    "</a:ReplyTo>" +
                                    "<Security s:mustUnderstand=\"1\" xmlns=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd\">" +
                                        "<UsernameToken>" +
                                            "<Username>admin</Username>" +
                                            "<Password Type=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-username-token-profile-1.0#PasswordDigest\">5THMqzD9lC3ZvzsiKEGRg7MP5Xo=</Password>" +
                                            "<Nonce EncodingType=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#Base64Binary\">XOln1lCPw0eCPkOU4sNTwjg4AAAAAA==</Nonce>" +
                                            "<Created xmlns=\"http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd\">2021-10-08T10:01:09.127Z</Created>" +
                                        "</UsernameToken>" +
                                    "</Security>" +
                                    "<a:To s:mustUnderstand=\"1\">http://172.16.11.217/onvif/event_service</a:To>" +
                                "</s:Header>" +
                                "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<Subscribe xmlns=\"http://docs.oasis-open.org/wsn/b-2\">" +
                                        "<ConsumerReference>" +
                                            "<a:Address>http://172.16.12.11:8080/subscription-22</a:Address>" +
                                        "</ConsumerReference>" +
                                        "<InitialTerminationTime>PT60S</InitialTerminationTime>" +
                                    "</Subscribe>" +
                                "</s:Body>" +
                            "</s:Envelope>";
            string responseStr1 = "";
            HttpWebRequest request1 = (HttpWebRequest)WebRequest.Create("http://172.16.11.217/onvif/event_service");
            byte[] bytes;
            bytes = System.Text.Encoding.ASCII.GetBytes(xm);
            request1.ContentType = "application/soap+xml; charset=utf-8; ";
            request1.ContentLength = bytes.Length;
            request1.Method = "POST";
            System.IO.Stream requestStream1 = request1.GetRequestStream();
            requestStream1.Write(bytes, 0, bytes.Length);
            requestStream1.Close();
            HttpWebResponse response1;
            response1 = (HttpWebResponse)request1.GetResponse();
            if (response1.StatusCode == HttpStatusCode.OK)
            {
                System.IO.Stream responseStream = response1.GetResponseStream();
                responseStr1 = new System.IO.StreamReader(responseStream).ReadToEnd();
            }
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(responseStr1);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.SubscribeResponse.SubscribeResponse), new System.Xml.Serialization.XmlAttributeOverrides());
            rnod.Normalize();
            OnvifObjects.SubscribeResponse.SubscribeResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.SubscribeResponse.SubscribeResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

    }
}
