using System;
using System.IO;
using System.Xml;

namespace SgiOnvifRestApiGW.SgiOnvif
{
    public class SgiOnvifPTZ
    {
        public SgiOnvifPTZ()
        {

        }
        public void ContinuousMove(String CameraIP, String Username, String Password, String ProfileToken, float PanTiltX, float PanTiltY)
        {
            string continue_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<ContinuousMove xmlns=\"http://www.onvif.org/ver20/ptz/wsdl\">" +
                                        "<ProfileToken>" + ProfileToken + "</ProfileToken>" +
                                        "<Velocity>" +
                                            "<PanTilt x=\"" + PanTiltX + "\" y=\"" + PanTiltY + "\" xmlns=\"http://www.onvif.org/ver10/schema\"/>" +
                                        "</Velocity>" +
                                    "</ContinuousMove>" +
                                  "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, continue_xml, Username, Password, "ContinuousMove");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
        }
        public void AbsoluteMove(string CameraIP, string Username, string Password,String ProfileToken,float PantiltX,float PanTiltY,float Zoom)
        {
            string abslutmv_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<AbsoluteMove xmlns=\"http://www.onvif.org/ver20/ptz/wsdl\">" +
                                        "<ProfileToken>" + ProfileToken + "</ProfileToken>" +
                                        "<Position>" +
                                            "<PanTilt x=\"" + PantiltX + "\" y=\"" + PanTiltY + "\" xmlns=\"http://www.onvif.org/ver10/schema\"/>" +
                                            "<Zoom x=\"" + Zoom + "\" xmlns=\"http://www.onvif.org/ver10/schema\"/>" +
                                        "</Position>" +
                                     "</AbsoluteMove>" +
                                   "</s:Body>";
            string res = NetFuncs.PostXmlRequest(CameraIP, abslutmv_xml, Username, Password, "AbsoluteMove");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
        }
        public void RelativeMove(string CameraIP, string Username, string Password,String ProfileToken,float PantiltX,float PanTiltY)
        {
            string abslutmv_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<RelativeMove xmlns=\"http://www.onvif.org/ver20/ptz/wsdl\">" +
                                        "<ProfileToken>" + ProfileToken + "</ProfileToken>" +
                                        "<Translation>" +
                                            "<PanTilt x=\"" + PantiltX + "\" y=\"" + PanTiltY + "\" xmlns=\"http://www.onvif.org/ver10/schema\"/>" +
                                        "</Translation>" +
                                    "</RelativeMove>" +
                                  "</s:Body>";
            string res = NetFuncs.PostXmlRequest(CameraIP, abslutmv_xml, Username, Password, "RelativeMove");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
        }




        public void Stop(String CameraIP, String Username, String Password, String ProfileToken) 
        {
            string stop_xml = "< s:Body xmlns:xsi =\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                "<Stop xmlns=\"http://www.onvif.org/ver20/ptz/wsdl\">" +
                                    "<ProfileToken>" + ProfileToken + "</ProfileToken>" +
                                    "<PanTilt>true</PanTilt>" +
                                    "<Zoom>false</Zoom>" +
                                "</Stop>" +
                              "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, stop_xml, Username, Password, "Stop");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
        }
    }
}
