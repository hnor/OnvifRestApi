using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnvifRestApiGW.OnvifObjects.GetVideoEncoderConfigurationOptionsResponse
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

        private GetVideoEncoderConfigurationOptionsResponse getVideoEncoderConfigurationOptionsResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public GetVideoEncoderConfigurationOptionsResponse GetVideoEncoderConfigurationOptionsResponse
        {
            get
            {
                return this.getVideoEncoderConfigurationOptionsResponseField;
            }
            set
            {
                this.getVideoEncoderConfigurationOptionsResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", IsNullable = false)]
    public partial class GetVideoEncoderConfigurationOptionsResponse
    {

        private GetVideoEncoderConfigurationOptionsResponseOptions optionsField;

        /// <remarks/>
        public GetVideoEncoderConfigurationOptionsResponseOptions Options
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
    public partial class GetVideoEncoderConfigurationOptionsResponseOptions
    {

        private QualityRange qualityRangeField;

        private JPEG jPEGField;

        private H264 h264Field;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public QualityRange QualityRange
        {
            get
            {
                return this.qualityRangeField;
            }
            set
            {
                this.qualityRangeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public JPEG JPEG
        {
            get
            {
                return this.jPEGField;
            }
            set
            {
                this.jPEGField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public H264 H264
        {
            get
            {
                return this.h264Field;
            }
            set
            {
                this.h264Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class QualityRange
    {

        private byte minField;

        private byte maxField;

        /// <remarks/>
        public byte Min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        public byte Max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class JPEG
    {

        private JPEGResolutionsAvailable[] resolutionsAvailableField;

        private JPEGFrameRateRange frameRateRangeField;

        private JPEGEncodingIntervalRange encodingIntervalRangeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResolutionsAvailable")]
        public JPEGResolutionsAvailable[] ResolutionsAvailable
        {
            get
            {
                return this.resolutionsAvailableField;
            }
            set
            {
                this.resolutionsAvailableField = value;
            }
        }

        /// <remarks/>
        public JPEGFrameRateRange FrameRateRange
        {
            get
            {
                return this.frameRateRangeField;
            }
            set
            {
                this.frameRateRangeField = value;
            }
        }

        /// <remarks/>
        public JPEGEncodingIntervalRange EncodingIntervalRange
        {
            get
            {
                return this.encodingIntervalRangeField;
            }
            set
            {
                this.encodingIntervalRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class JPEGResolutionsAvailable
    {

        private ushort widthField;

        private ushort heightField;

        /// <remarks/>
        public ushort Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public ushort Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class JPEGFrameRateRange
    {

        private byte minField;

        private byte maxField;

        /// <remarks/>
        public byte Min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        public byte Max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class JPEGEncodingIntervalRange
    {

        private byte minField;

        private byte maxField;

        /// <remarks/>
        public byte Min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        public byte Max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class H264
    {

        private H264ResolutionsAvailable[] resolutionsAvailableField;

        private H264GovLengthRange govLengthRangeField;

        private H264FrameRateRange frameRateRangeField;

        private H264EncodingIntervalRange encodingIntervalRangeField;

        private string h264ProfilesSupportedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResolutionsAvailable")]
        public H264ResolutionsAvailable[] ResolutionsAvailable
        {
            get
            {
                return this.resolutionsAvailableField;
            }
            set
            {
                this.resolutionsAvailableField = value;
            }
        }

        /// <remarks/>
        public H264GovLengthRange GovLengthRange
        {
            get
            {
                return this.govLengthRangeField;
            }
            set
            {
                this.govLengthRangeField = value;
            }
        }

        /// <remarks/>
        public H264FrameRateRange FrameRateRange
        {
            get
            {
                return this.frameRateRangeField;
            }
            set
            {
                this.frameRateRangeField = value;
            }
        }

        /// <remarks/>
        public H264EncodingIntervalRange EncodingIntervalRange
        {
            get
            {
                return this.encodingIntervalRangeField;
            }
            set
            {
                this.encodingIntervalRangeField = value;
            }
        }

        /// <remarks/>
        public string H264ProfilesSupported
        {
            get
            {
                return this.h264ProfilesSupportedField;
            }
            set
            {
                this.h264ProfilesSupportedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class H264ResolutionsAvailable
    {

        private ushort widthField;

        private ushort heightField;

        /// <remarks/>
        public ushort Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }

        /// <remarks/>
        public ushort Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class H264GovLengthRange
    {

        private byte minField;

        private byte maxField;

        /// <remarks/>
        public byte Min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        public byte Max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class H264FrameRateRange
    {

        private byte minField;

        private byte maxField;

        /// <remarks/>
        public byte Min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        public byte Max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class H264EncodingIntervalRange
    {

        private byte minField;

        private byte maxField;

        /// <remarks/>
        public byte Min
        {
            get
            {
                return this.minField;
            }
            set
            {
                this.minField = value;
            }
        }

        /// <remarks/>
        public byte Max
        {
            get
            {
                return this.maxField;
            }
            set
            {
                this.maxField = value;
            }
        }
    }


}
