using System;
using System.IO;
using System.Xml;

namespace SgiOnvifRestApiGW.SgiOnvif
{
    public class SgiOnvifPTZ
    {
        private OnvifAddressing _rootAddr;
        public SgiOnvifPTZ()
        {
            this._rootAddr = OnvifAddressing.ptz_service;
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
            var res = NetFuncs.PostXmlRequest(CameraIP, continue_xml, Username, Password, "ContinuousMove",_rootAddr);
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
        public void SetHomePosition(String CameraIP, String Username, String Password, String ProfileToken) 
        {
            string sthm_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                "<SetHomePosition xmlns=\"http://www.onvif.org/ver20/ptz/wsdl\">" +
                                    "<ProfileToken>" + ProfileToken + "</ProfileToken>" +
                                "</SetHomePosition>" +
                              "</s:Body>";//MediaProfile000
            var res = NetFuncs.PostXmlRequest(CameraIP, sthm_xml, Username, Password, "SetHomePosition");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
        }
        public void GotoHomePosition(String CameraIP, String Username, String Password, String ProfileToken) 
        {
            string gthm_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                "<GotoHomePosition xmlns=\"http://www.onvif.org/ver20/ptz/wsdl\">" +
                                    "<ProfileToken>"+ProfileToken+"</ProfileToken>" +
                                "</GotoHomePosition>" +
                              "</s:Body>";//MediaProfile000
            var res = NetFuncs.PostXmlRequest(CameraIP, gthm_xml, Username, Password, "GotoHomePosition");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
        }
        public OnvifObjects.GetPresetsResponse.GetPresetsResponse GetPresets(String CameraIP, String Username, String Password, String ProfileToken)
        {
            string gtprst_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetPresets xmlns=\"http://www.onvif.org/ver20/ptz/wsdl\">" +
                                        "<ProfileToken>"+ProfileToken+"</ProfileToken>" +
                                    "</GetPresets>" +
                                "</s:Body>"; //MediaProfile000
             var res = NetFuncs.PostXmlRequest(CameraIP, gtprst_xml, Username, Password, "GetPresets", _rootAddr);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetPresetsResponse.GetPresetsResponse));
            rnod.Normalize();
            OnvifObjects.GetPresetsResponse.GetPresetsResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetPresetsResponse.GetPresetsResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.OnvifPtzGetConfigurationsResponse.GetConfigurationsResponse GetConfigurations(String CameraIP, String Username, String Password)
        {
            string getcfg_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                     "<GetConfigurations xmlns=\"http://www.onvif.org/ver20/ptz/wsdl\"/>" +
                                 "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getcfg_xml, Username, Password, "GetConfigurations",_rootAddr);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (xmlDoc.InnerText.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.OnvifPtzGetConfigurationsResponse.GetConfigurationsResponse));
            rnod.Normalize();
            OnvifObjects.OnvifPtzGetConfigurationsResponse.GetConfigurationsResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.OnvifPtzGetConfigurationsResponse.GetConfigurationsResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }


    }
}
