using System;
using System.IO;
using System.Xml;

namespace OnvifRestApiGW.Onvif
{
    public class OnvifMedia
    {
        private OnvifAddressing _rootAddr;
        public OnvifMedia()
        {
            this._rootAddr = OnvifAddressing.media_service;
        }
        public OnvifObjects.GetVideoEncoderConfigurationOptionsResponse.GetVideoEncoderConfigurationOptionsResponse GetVideoEncoderConfigurationOptions(string CameraIP, string Username,string Password,string ProfileToken,string ConfigurationToken) 
        {
            string getstruri_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetVideoEncoderConfigurationOptions xmlns=\"http://www.onvif.org/ver10/media/wsdl\">" +
                                        "<ConfigurationToken>" + ConfigurationToken + "</ConfigurationToken>" +
                                        "<ProfileToken>" + ProfileToken + "</ProfileToken>" +
                                    "</GetVideoEncoderConfigurationOptions>" +
                                   "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getstruri_xml, Username, Password, "GetVideoEncoderConfigurationOptions",_rootAddr);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetVideoEncoderConfigurationOptionsResponse.GetVideoEncoderConfigurationOptionsResponse));
            rnod.Normalize();
            OnvifObjects.GetVideoEncoderConfigurationOptionsResponse.GetVideoEncoderConfigurationOptionsResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetVideoEncoderConfigurationOptionsResponse.GetVideoEncoderConfigurationOptionsResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetVideoSourceConfigurationResponse.GetVideoSourceConfigurationResponse GetVideoSourceConfiguration(string CameraIP, string Username,string Password,string ConfigurationToken) 
        {
            string getstruri_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                        "<GetVideoSourceConfiguration xmlns=\"http://www.onvif.org/ver10/media/wsdl\">" +
                                            "<ConfigurationToken>" + ConfigurationToken + "</ConfigurationToken>" +
                                        "</GetVideoSourceConfiguration>" +
                                   "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getstruri_xml, Username, Password, "GetVideoSourceConfiguration");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetVideoSourceConfigurationResponse.GetVideoSourceConfigurationResponse));
            rnod.Normalize();
            OnvifObjects.GetVideoSourceConfigurationResponse.GetVideoSourceConfigurationResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetVideoSourceConfigurationResponse.GetVideoSourceConfigurationResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetAudioSourceConfigurationsResponse.GetAudioSourceConfigurationsResponse GetAudioSourceConfigurations(string CameraIP, string Username,string Password,string ConfigurationToken) 
        {
            string getaudc_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetAudioSourceConfigurations xmlns=\"http://www.onvif.org/ver10/media/wsdl\"/>" +
                                 "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getaudc_xml, Username, Password, "wsdlGetAudioSourceConfigurations");
            res=res.Replace("_", "");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            string ooo=rnod.OuterXml.Replace("_", "");
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetAudioSourceConfigurationsResponse.GetAudioSourceConfigurationsResponse));
            rnod.Normalize();
            OnvifObjects.GetAudioSourceConfigurationsResponse.GetAudioSourceConfigurationsResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetAudioSourceConfigurationsResponse.GetAudioSourceConfigurationsResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetSnapshotUriResponse.GetSnapshotUriResponse GetSnapshotUri(string CameraIP, string Username, string Password,string ProfileToken) 
        {
            string getstruri_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetSnapshotUri xmlns=\"http://www.onvif.org/ver10/media/wsdl\">" +
                                        "<ProfileToken>" + ProfileToken + "</ProfileToken>" +
                                    "</GetSnapshotUri>" +
                                   "</s:Body>";
            var res = NetFuncs.PostXmlRequest(CameraIP, getstruri_xml, Username, Password, "GetSnapshotUri");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetSnapshotUriResponse.GetSnapshotUriResponse));
            rnod.Normalize();
            OnvifObjects.GetSnapshotUriResponse.GetSnapshotUriResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetSnapshotUriResponse.GetSnapshotUriResponse)serializer.Deserialize(stringReader);
            }
            return cr;
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
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
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

        public OnvifObjects.GetProfileResponse.GetProfileResponse GetProfile(string CameraIP, string Username, string Password, string ProfileToken)
        {
            string getprofiles_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                        "<GetProfile xmlns=\"http://www.onvif.org/ver10/media/wsdl\">" +
                                            "<ProfileToken>" + ProfileToken + "</ProfileToken>" +
                                        "</GetProfile>" +
                                     "</s:Body>";//MediaProfile000
            OnvifObjects.GetProfileResponse.GetProfileResponse cr = null;
            var res = NetFuncs.PostXmlRequest(CameraIP, getprofiles_xml, Username, Password, "wsdlGetProfile", _rootAddr);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetProfileResponse.GetProfileResponse),new System.Xml.Serialization.XmlAttributeOverrides());
            rnod.Normalize();
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetProfileResponse.GetProfileResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }
    
        public OnvifObjects.GetProfilesResponse.GetProfilesResponse GetProfiles(string CameraIP, string Username, string Password)
        {
            string getprofiles_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">"+
                                        "<GetProfiles xmlns =\"http://www.onvif.org/ver10/media/wsdl\"/>"+
                                     "</s:Body>";
            OnvifObjects.GetProfilesResponse.GetProfilesResponse cr = null;
            var res = NetFuncs.PostXmlRequest(CameraIP, getprofiles_xml, Username, Password, "GetProfiles", _rootAddr);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetProfilesResponse.GetProfilesResponse),new System.Xml.Serialization.XmlAttributeOverrides());
            rnod.Normalize();
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetProfilesResponse.GetProfilesResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }

        public OnvifObjects.GetMetadataConfigurationOptionsResponse.GetMetadataConfigurationOptionsResponse GetMetadataConfigurationOptions(string CameraIP, string Username, string Password, string ProfileToken,string ConfigurationToken)
        {
            string getmd_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                    "<GetMetadataConfigurationOptions xmlns=\"http://www.onvif.org/ver10/media/wsdl\">" +
                                        "<ConfigurationToken>" + ConfigurationToken + "</ConfigurationToken>" +
                                        "<ProfileToken>" + ProfileToken + "</ProfileToken>" +
                                    "</GetMetadataConfigurationOptions>" +
                               "</s:Body>";//MediaProfile000
            var res = NetFuncs.PostXmlRequest(CameraIP, getmd_xml, Username, Password, "GetMetadataConfigurationOptions", _rootAddr);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            var rnod = xmlDoc.ChildNodes[1].FirstChild.NextSibling.FirstChild;
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(OnvifObjects.GetMetadataConfigurationOptionsResponse.GetMetadataConfigurationOptionsResponse), new System.Xml.Serialization.XmlAttributeOverrides());
            rnod.Normalize();
            OnvifObjects.GetMetadataConfigurationOptionsResponse.GetMetadataConfigurationOptionsResponse cr = null;
            using (StringReader stringReader = new StringReader(rnod.OuterXml.Trim()))
            {
                cr = (OnvifObjects.GetMetadataConfigurationOptionsResponse.GetMetadataConfigurationOptionsResponse)serializer.Deserialize(stringReader);
            }
            return cr;
        }





        public bool DeleteProfile(string CameraIP, string Username, string Password, string ProfileToken)
        {
            string delprofiles_xml = "<s:Body xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                                        "<DeleteProfile xmlns=\"http://www.onvif.org/ver10/media/wsdl\">" +
                                            "<ProfileToken>" + ProfileToken + "</ProfileToken>" +
                                        "</DeleteProfile>" +
                                      "</s:Body>";//MediaProfile000
            var res = NetFuncs.PostXmlRequest(CameraIP, delprofiles_xml, Username, Password, "DeleteProfile", _rootAddr);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(res);
            if (res.Contains("s:Fault"))
            {
                throw new Exception(xmlDoc.InnerText);
            }
            if (res.Contains("DeleteProfileResponse")) return true;
            return false;
        }


    }
}
