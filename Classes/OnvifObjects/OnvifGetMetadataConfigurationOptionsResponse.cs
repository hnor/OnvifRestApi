using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnvifRestApiGW.OnvifObjects.GetMetadataConfigurationOptionsResponse
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2003/05/soap-envelope", IsNullable = false)]
    public partial class Envelope
    {

        private object headerField;

        private EnvelopeBody bodyField;

        /// <remarks/>
        public object Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public partial class EnvelopeBody
    {

        private GetMetadataConfigurationOptionsResponse getMetadataConfigurationOptionsResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public GetMetadataConfigurationOptionsResponse GetMetadataConfigurationOptionsResponse
        {
            get
            {
                return this.getMetadataConfigurationOptionsResponseField;
            }
            set
            {
                this.getMetadataConfigurationOptionsResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", IsNullable = false)]
    public partial class GetMetadataConfigurationOptionsResponse
    {

        private GetMetadataConfigurationOptionsResponseOptions optionsField;

        /// <remarks/>
        public GetMetadataConfigurationOptionsResponseOptions Options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public partial class GetMetadataConfigurationOptionsResponseOptions
    {

        private PTZStatusFilterOptions pTZStatusFilterOptionsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZStatusFilterOptions PTZStatusFilterOptions
        {
            get
            {
                return this.pTZStatusFilterOptionsField;
            }
            set
            {
                this.pTZStatusFilterOptionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class PTZStatusFilterOptions
    {

        private bool panTiltStatusSupportedField;

        private bool zoomStatusSupportedField;

        private bool panTiltPositionSupportedField;

        private bool zoomPositionSupportedField;

        /// <remarks/>
        public bool PanTiltStatusSupported
        {
            get
            {
                return this.panTiltStatusSupportedField;
            }
            set
            {
                this.panTiltStatusSupportedField = value;
            }
        }

        /// <remarks/>
        public bool ZoomStatusSupported
        {
            get
            {
                return this.zoomStatusSupportedField;
            }
            set
            {
                this.zoomStatusSupportedField = value;
            }
        }

        /// <remarks/>
        public bool PanTiltPositionSupported
        {
            get
            {
                return this.panTiltPositionSupportedField;
            }
            set
            {
                this.panTiltPositionSupportedField = value;
            }
        }

        /// <remarks/>
        public bool ZoomPositionSupported
        {
            get
            {
                return this.zoomPositionSupportedField;
            }
            set
            {
                this.zoomPositionSupportedField = value;
            }
        }
    }


}
