using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SgiOnvifRestApiGW.OnvifObjects.GetImagingSettingsResponse
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

        private GetImagingSettingsResponse getImagingSettingsResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
        public GetImagingSettingsResponse GetImagingSettingsResponse
        {
            get
            {
                return this.getImagingSettingsResponseField;
            }
            set
            {
                this.getImagingSettingsResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver20/imaging/wsdl", IsNullable = false)]
    public partial class GetImagingSettingsResponse
    {

        private GetImagingSettingsResponseImagingSettings imagingSettingsField;

        /// <remarks/>
        public GetImagingSettingsResponseImagingSettings ImagingSettings
        {
            get
            {
                return this.imagingSettingsField;
            }
            set
            {
                this.imagingSettingsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver20/imaging/wsdl")]
    public partial class GetImagingSettingsResponseImagingSettings
    {

        private byte brightnessField;

        private byte colorSaturationField;

        private byte contrastField;

        private GetOptionsResponse.Exposure exposureField;

        private GetOptionsResponse.Focus focusField;

        private byte sharpnessField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public byte Brightness
        {
            get
            {
                return this.brightnessField;
            }
            set
            {
                this.brightnessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public byte ColorSaturation
        {
            get
            {
                return this.colorSaturationField;
            }
            set
            {
                this.colorSaturationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public byte Contrast
        {
            get
            {
                return this.contrastField;
            }
            set
            {
                this.contrastField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public GetOptionsResponse.Exposure Exposure
        {
            get
            {
                return this.exposureField;
            }
            set
            {
                this.exposureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public GetOptionsResponse.Focus Focus
        {
            get
            {
                return this.focusField;
            }
            set
            {
                this.focusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public byte Sharpness
        {
            get
            {
                return this.sharpnessField;
            }
            set
            {
                this.sharpnessField = value;
            }
        }
    }


}
