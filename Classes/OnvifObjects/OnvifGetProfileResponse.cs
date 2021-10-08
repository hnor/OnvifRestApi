using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SgiOnvifRestApiGW.OnvifObjects.GetProfileResponse
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

        private GetProfileResponse getProfileResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public GetProfileResponse GetProfileResponse
        {
            get
            {
                return this.getProfileResponseField;
            }
            set
            {
                this.getProfileResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", IsNullable = false)]
    public partial class GetProfileResponse
    {

        private GetProfileResponseProfile profileField;

        /// <remarks/>
        public GetProfileResponseProfile Profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public partial class GetProfileResponseProfile
    {

        private string nameField;

        private VideoSourceConfiguration videoSourceConfigurationField;

        private AudioSourceConfiguration audioSourceConfigurationField;

        private VideoEncoderConfiguration videoEncoderConfigurationField;

        private AudioEncoderConfiguration audioEncoderConfigurationField;

        private VideoAnalyticsConfiguration videoAnalyticsConfigurationField;

        private PTZConfiguration pTZConfigurationField;

        private MetadataConfiguration metadataConfigurationField;

        private Extension extensionField;

        private string tokenField;

        private bool fixedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoSourceConfiguration VideoSourceConfiguration
        {
            get
            {
                return this.videoSourceConfigurationField;
            }
            set
            {
                this.videoSourceConfigurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public AudioSourceConfiguration AudioSourceConfiguration
        {
            get
            {
                return this.audioSourceConfigurationField;
            }
            set
            {
                this.audioSourceConfigurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoEncoderConfiguration VideoEncoderConfiguration
        {
            get
            {
                return this.videoEncoderConfigurationField;
            }
            set
            {
                this.videoEncoderConfigurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public AudioEncoderConfiguration AudioEncoderConfiguration
        {
            get
            {
                return this.audioEncoderConfigurationField;
            }
            set
            {
                this.audioEncoderConfigurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public VideoAnalyticsConfiguration VideoAnalyticsConfiguration
        {
            get
            {
                return this.videoAnalyticsConfigurationField;
            }
            set
            {
                this.videoAnalyticsConfigurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZConfiguration PTZConfiguration
        {
            get
            {
                return this.pTZConfigurationField;
            }
            set
            {
                this.pTZConfigurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public MetadataConfiguration MetadataConfiguration
        {
            get
            {
                return this.metadataConfigurationField;
            }
            set
            {
                this.metadataConfigurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public Extension Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool @fixed
        {
            get
            {
                return this.fixedField;
            }
            set
            {
                this.fixedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class VideoSourceConfiguration
    {

        private string nameField;

        private byte useCountField;

        private byte sourceTokenField;

        private VideoSourceConfigurationBounds boundsField;

        private byte tokenField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte UseCount
        {
            get
            {
                return this.useCountField;
            }
            set
            {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        public byte SourceToken
        {
            get
            {
                return this.sourceTokenField;
            }
            set
            {
                this.sourceTokenField = value;
            }
        }

        /// <remarks/>
        public VideoSourceConfigurationBounds Bounds
        {
            get
            {
                return this.boundsField;
            }
            set
            {
                this.boundsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoSourceConfigurationBounds
    {

        private byte xField;

        private byte yField;

        private ushort widthField;

        private ushort heightField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort width
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort height
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class AudioSourceConfiguration
    {

        private string nameField;

        private byte useCountField;

        private byte sourceTokenField;

        private byte tokenField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte UseCount
        {
            get
            {
                return this.useCountField;
            }
            set
            {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        public byte SourceToken
        {
            get
            {
                return this.sourceTokenField;
            }
            set
            {
                this.sourceTokenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class VideoEncoderConfiguration
    {

        private string nameField;

        private byte useCountField;

        private string encodingField;

        private VideoEncoderConfigurationResolution resolutionField;

        private decimal qualityField;

        private VideoEncoderConfigurationRateControl rateControlField;

        private VideoEncoderConfigurationH264 h264Field;

        private VideoEncoderConfigurationMulticast multicastField;

        private string sessionTimeoutField;

        private byte tokenField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte UseCount
        {
            get
            {
                return this.useCountField;
            }
            set
            {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }

        /// <remarks/>
        public VideoEncoderConfigurationResolution Resolution
        {
            get
            {
                return this.resolutionField;
            }
            set
            {
                this.resolutionField = value;
            }
        }

        /// <remarks/>
        public decimal Quality
        {
            get
            {
                return this.qualityField;
            }
            set
            {
                this.qualityField = value;
            }
        }

        /// <remarks/>
        public VideoEncoderConfigurationRateControl RateControl
        {
            get
            {
                return this.rateControlField;
            }
            set
            {
                this.rateControlField = value;
            }
        }

        /// <remarks/>
        public VideoEncoderConfigurationH264 H264
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

        /// <remarks/>
        public VideoEncoderConfigurationMulticast Multicast
        {
            get
            {
                return this.multicastField;
            }
            set
            {
                this.multicastField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string SessionTimeout
        {
            get
            {
                return this.sessionTimeoutField;
            }
            set
            {
                this.sessionTimeoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoEncoderConfigurationResolution
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
    public partial class VideoEncoderConfigurationRateControl
    {

        private byte frameRateLimitField;

        private byte encodingIntervalField;

        private ushort bitrateLimitField;

        /// <remarks/>
        public byte FrameRateLimit
        {
            get
            {
                return this.frameRateLimitField;
            }
            set
            {
                this.frameRateLimitField = value;
            }
        }

        /// <remarks/>
        public byte EncodingInterval
        {
            get
            {
                return this.encodingIntervalField;
            }
            set
            {
                this.encodingIntervalField = value;
            }
        }

        /// <remarks/>
        public ushort BitrateLimit
        {
            get
            {
                return this.bitrateLimitField;
            }
            set
            {
                this.bitrateLimitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoEncoderConfigurationH264
    {

        private byte govLengthField;

        private string h264ProfileField;

        /// <remarks/>
        public byte GovLength
        {
            get
            {
                return this.govLengthField;
            }
            set
            {
                this.govLengthField = value;
            }
        }

        /// <remarks/>
        public string H264Profile
        {
            get
            {
                return this.h264ProfileField;
            }
            set
            {
                this.h264ProfileField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoEncoderConfigurationMulticast
    {

        private VideoEncoderConfigurationMulticastAddress addressField;

        private ushort portField;

        private byte tTLField;

        private bool autoStartField;

        /// <remarks/>
        public VideoEncoderConfigurationMulticastAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public ushort Port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }

        /// <remarks/>
        public byte TTL
        {
            get
            {
                return this.tTLField;
            }
            set
            {
                this.tTLField = value;
            }
        }

        /// <remarks/>
        public bool AutoStart
        {
            get
            {
                return this.autoStartField;
            }
            set
            {
                this.autoStartField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoEncoderConfigurationMulticastAddress
    {

        private string typeField;

        private string iPv4AddressField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string IPv4Address
        {
            get
            {
                return this.iPv4AddressField;
            }
            set
            {
                this.iPv4AddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class AudioEncoderConfiguration
    {

        private string nameField;

        private byte useCountField;

        private string encodingField;

        private byte bitrateField;

        private byte sampleRateField;

        private AudioEncoderConfigurationMulticast multicastField;

        private string sessionTimeoutField;

        private byte tokenField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte UseCount
        {
            get
            {
                return this.useCountField;
            }
            set
            {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }

        /// <remarks/>
        public byte Bitrate
        {
            get
            {
                return this.bitrateField;
            }
            set
            {
                this.bitrateField = value;
            }
        }

        /// <remarks/>
        public byte SampleRate
        {
            get
            {
                return this.sampleRateField;
            }
            set
            {
                this.sampleRateField = value;
            }
        }

        /// <remarks/>
        public AudioEncoderConfigurationMulticast Multicast
        {
            get
            {
                return this.multicastField;
            }
            set
            {
                this.multicastField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string SessionTimeout
        {
            get
            {
                return this.sessionTimeoutField;
            }
            set
            {
                this.sessionTimeoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class AudioEncoderConfigurationMulticast
    {

        private AudioEncoderConfigurationMulticastAddress addressField;

        private ushort portField;

        private byte tTLField;

        private bool autoStartField;

        /// <remarks/>
        public AudioEncoderConfigurationMulticastAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public ushort Port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }

        /// <remarks/>
        public byte TTL
        {
            get
            {
                return this.tTLField;
            }
            set
            {
                this.tTLField = value;
            }
        }

        /// <remarks/>
        public bool AutoStart
        {
            get
            {
                return this.autoStartField;
            }
            set
            {
                this.autoStartField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class AudioEncoderConfigurationMulticastAddress
    {

        private string typeField;

        private string iPv4AddressField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string IPv4Address
        {
            get
            {
                return this.iPv4AddressField;
            }
            set
            {
                this.iPv4AddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class VideoAnalyticsConfiguration
    {

        private string nameField;

        private byte useCountField;

        private VideoAnalyticsConfigurationAnalyticsModule[] analyticsEngineConfigurationField;

        private VideoAnalyticsConfigurationRule[] ruleEngineConfigurationField;

        private byte tokenField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte UseCount
        {
            get
            {
                return this.useCountField;
            }
            set
            {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AnalyticsModule", IsNullable = false)]
        public VideoAnalyticsConfigurationAnalyticsModule[] AnalyticsEngineConfiguration
        {
            get
            {
                return this.analyticsEngineConfigurationField;
            }
            set
            {
                this.analyticsEngineConfigurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Rule", IsNullable = false)]
        public VideoAnalyticsConfigurationRule[] RuleEngineConfiguration
        {
            get
            {
                return this.ruleEngineConfigurationField;
            }
            set
            {
                this.ruleEngineConfigurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModule
    {

        private VideoAnalyticsConfigurationAnalyticsModuleParameters parametersField;

        private string nameField;

        private string typeField;

        /// <remarks/>
        public VideoAnalyticsConfigurationAnalyticsModuleParameters Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParameters
    {

        private VideoAnalyticsConfigurationAnalyticsModuleParametersSimpleItem simpleItemField;

        private VideoAnalyticsConfigurationAnalyticsModuleParametersElementItem[] elementItemField;

        /// <remarks/>
        public VideoAnalyticsConfigurationAnalyticsModuleParametersSimpleItem SimpleItem
        {
            get
            {
                return this.simpleItemField;
            }
            set
            {
                this.simpleItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElementItem")]
        public VideoAnalyticsConfigurationAnalyticsModuleParametersElementItem[] ElementItem
        {
            get
            {
                return this.elementItemField;
            }
            set
            {
                this.elementItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParametersSimpleItem
    {

        private string nameField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParametersElementItem
    {

        private VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemTransformation transformationField;

        private VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemPolygonConfiguration polygonConfigurationField;

        private VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayout cellLayoutField;

        private string nameField;

        /// <remarks/>
        public VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemTransformation Transformation
        {
            get
            {
                return this.transformationField;
            }
            set
            {
                this.transformationField = value;
            }
        }

        /// <remarks/>
        public VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemPolygonConfiguration PolygonConfiguration
        {
            get
            {
                return this.polygonConfigurationField;
            }
            set
            {
                this.polygonConfigurationField = value;
            }
        }

        /// <remarks/>
        public VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayout CellLayout
        {
            get
            {
                return this.cellLayoutField;
            }
            set
            {
                this.cellLayoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemTransformation
    {

        private VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemTransformationTranslate translateField;

        private VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemTransformationScale scaleField;

        /// <remarks/>
        public VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemTransformationTranslate Translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        public VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemTransformationScale Scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemTransformationTranslate
    {

        private decimal xField;

        private decimal yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemTransformationScale
    {

        private decimal xField;

        private decimal yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemPolygonConfiguration
    {

        private VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemPolygonConfigurationPoint[] polygonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Point", IsNullable = false)]
        public VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemPolygonConfigurationPoint[] Polygon
        {
            get
            {
                return this.polygonField;
            }
            set
            {
                this.polygonField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemPolygonConfigurationPoint
    {

        private ushort xField;

        private byte yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayout
    {

        private VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayoutTransformation transformationField;

        private byte columnsField;

        private byte rowsField;

        /// <remarks/>
        public VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayoutTransformation Transformation
        {
            get
            {
                return this.transformationField;
            }
            set
            {
                this.transformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Columns
        {
            get
            {
                return this.columnsField;
            }
            set
            {
                this.columnsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Rows
        {
            get
            {
                return this.rowsField;
            }
            set
            {
                this.rowsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayoutTransformation
    {

        private VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayoutTransformationTranslate translateField;

        private VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayoutTransformationScale scaleField;

        /// <remarks/>
        public VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayoutTransformationTranslate Translate
        {
            get
            {
                return this.translateField;
            }
            set
            {
                this.translateField = value;
            }
        }

        /// <remarks/>
        public VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayoutTransformationScale Scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayoutTransformationTranslate
    {

        private decimal xField;

        private decimal yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationAnalyticsModuleParametersElementItemCellLayoutTransformationScale
    {

        private decimal xField;

        private decimal yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationRule
    {

        private VideoAnalyticsConfigurationRuleParameters parametersField;

        private string nameField;

        private string typeField;

        /// <remarks/>
        public VideoAnalyticsConfigurationRuleParameters Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationRuleParameters
    {

        private VideoAnalyticsConfigurationRuleParametersElementItem elementItemField;

        private VideoAnalyticsConfigurationRuleParametersSimpleItem[] simpleItemField;

        /// <remarks/>
        public VideoAnalyticsConfigurationRuleParametersElementItem ElementItem
        {
            get
            {
                return this.elementItemField;
            }
            set
            {
                this.elementItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SimpleItem")]
        public VideoAnalyticsConfigurationRuleParametersSimpleItem[] SimpleItem
        {
            get
            {
                return this.simpleItemField;
            }
            set
            {
                this.simpleItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationRuleParametersElementItem
    {

        private VideoAnalyticsConfigurationRuleParametersElementItemPolygonConfiguration polygonConfigurationField;

        private string nameField;

        /// <remarks/>
        public VideoAnalyticsConfigurationRuleParametersElementItemPolygonConfiguration PolygonConfiguration
        {
            get
            {
                return this.polygonConfigurationField;
            }
            set
            {
                this.polygonConfigurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationRuleParametersElementItemPolygonConfiguration
    {

        private VideoAnalyticsConfigurationRuleParametersElementItemPolygonConfigurationPoint[] polygonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Point", IsNullable = false)]
        public VideoAnalyticsConfigurationRuleParametersElementItemPolygonConfigurationPoint[] Polygon
        {
            get
            {
                return this.polygonField;
            }
            set
            {
                this.polygonField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationRuleParametersElementItemPolygonConfigurationPoint
    {

        private ushort xField;

        private byte yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class VideoAnalyticsConfigurationRuleParametersSimpleItem
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class PTZConfiguration
    {

        private string nameField;

        private byte useCountField;

        private byte nodeTokenField;

        private string defaultAbsolutePantTiltPositionSpaceField;

        private string defaultAbsoluteZoomPositionSpaceField;

        private string defaultRelativePanTiltTranslationSpaceField;

        private string defaultRelativeZoomTranslationSpaceField;

        private string defaultContinuousPanTiltVelocitySpaceField;

        private string defaultContinuousZoomVelocitySpaceField;

        private PTZConfigurationDefaultPTZSpeed defaultPTZSpeedField;

        private string defaultPTZTimeoutField;

        private PTZConfigurationPanTiltLimits panTiltLimitsField;

        private PTZConfigurationZoomLimits zoomLimitsField;

        private byte tokenField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte UseCount
        {
            get
            {
                return this.useCountField;
            }
            set
            {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        public byte NodeToken
        {
            get
            {
                return this.nodeTokenField;
            }
            set
            {
                this.nodeTokenField = value;
            }
        }

        /// <remarks/>
        public string DefaultAbsolutePantTiltPositionSpace
        {
            get
            {
                return this.defaultAbsolutePantTiltPositionSpaceField;
            }
            set
            {
                this.defaultAbsolutePantTiltPositionSpaceField = value;
            }
        }

        /// <remarks/>
        public string DefaultAbsoluteZoomPositionSpace
        {
            get
            {
                return this.defaultAbsoluteZoomPositionSpaceField;
            }
            set
            {
                this.defaultAbsoluteZoomPositionSpaceField = value;
            }
        }

        /// <remarks/>
        public string DefaultRelativePanTiltTranslationSpace
        {
            get
            {
                return this.defaultRelativePanTiltTranslationSpaceField;
            }
            set
            {
                this.defaultRelativePanTiltTranslationSpaceField = value;
            }
        }

        /// <remarks/>
        public string DefaultRelativeZoomTranslationSpace
        {
            get
            {
                return this.defaultRelativeZoomTranslationSpaceField;
            }
            set
            {
                this.defaultRelativeZoomTranslationSpaceField = value;
            }
        }

        /// <remarks/>
        public string DefaultContinuousPanTiltVelocitySpace
        {
            get
            {
                return this.defaultContinuousPanTiltVelocitySpaceField;
            }
            set
            {
                this.defaultContinuousPanTiltVelocitySpaceField = value;
            }
        }

        /// <remarks/>
        public string DefaultContinuousZoomVelocitySpace
        {
            get
            {
                return this.defaultContinuousZoomVelocitySpaceField;
            }
            set
            {
                this.defaultContinuousZoomVelocitySpaceField = value;
            }
        }

        /// <remarks/>
        public PTZConfigurationDefaultPTZSpeed DefaultPTZSpeed
        {
            get
            {
                return this.defaultPTZSpeedField;
            }
            set
            {
                this.defaultPTZSpeedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string DefaultPTZTimeout
        {
            get
            {
                return this.defaultPTZTimeoutField;
            }
            set
            {
                this.defaultPTZTimeoutField = value;
            }
        }

        /// <remarks/>
        public PTZConfigurationPanTiltLimits PanTiltLimits
        {
            get
            {
                return this.panTiltLimitsField;
            }
            set
            {
                this.panTiltLimitsField = value;
            }
        }

        /// <remarks/>
        public PTZConfigurationZoomLimits ZoomLimits
        {
            get
            {
                return this.zoomLimitsField;
            }
            set
            {
                this.zoomLimitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class PTZConfigurationDefaultPTZSpeed
    {

        private PTZConfigurationDefaultPTZSpeedPanTilt panTiltField;

        private PTZConfigurationDefaultPTZSpeedZoom zoomField;

        /// <remarks/>
        public PTZConfigurationDefaultPTZSpeedPanTilt PanTilt
        {
            get
            {
                return this.panTiltField;
            }
            set
            {
                this.panTiltField = value;
            }
        }

        /// <remarks/>
        public PTZConfigurationDefaultPTZSpeedZoom Zoom
        {
            get
            {
                return this.zoomField;
            }
            set
            {
                this.zoomField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class PTZConfigurationDefaultPTZSpeedPanTilt
    {

        private string spaceField;

        private decimal xField;

        private decimal yField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class PTZConfigurationDefaultPTZSpeedZoom
    {

        private string spaceField;

        private decimal xField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string space
        {
            get
            {
                return this.spaceField;
            }
            set
            {
                this.spaceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class PTZConfigurationPanTiltLimits
    {

        private PTZConfigurationPanTiltLimitsRange rangeField;

        /// <remarks/>
        public PTZConfigurationPanTiltLimitsRange Range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class PTZConfigurationPanTiltLimitsRange
    {

        private string uRIField;

        private PTZConfigurationPanTiltLimitsRangeXRange xRangeField;

        private PTZConfigurationPanTiltLimitsRangeYRange yRangeField;

        /// <remarks/>
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        public PTZConfigurationPanTiltLimitsRangeXRange XRange
        {
            get
            {
                return this.xRangeField;
            }
            set
            {
                this.xRangeField = value;
            }
        }

        /// <remarks/>
        public PTZConfigurationPanTiltLimitsRangeYRange YRange
        {
            get
            {
                return this.yRangeField;
            }
            set
            {
                this.yRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class PTZConfigurationPanTiltLimitsRangeXRange
    {

        private decimal minField;

        private decimal maxField;

        /// <remarks/>
        public decimal Min
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
        public decimal Max
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
    public partial class PTZConfigurationPanTiltLimitsRangeYRange
    {

        private decimal minField;

        private decimal maxField;

        /// <remarks/>
        public decimal Min
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
        public decimal Max
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
    public partial class PTZConfigurationZoomLimits
    {

        private PTZConfigurationZoomLimitsRange rangeField;

        /// <remarks/>
        public PTZConfigurationZoomLimitsRange Range
        {
            get
            {
                return this.rangeField;
            }
            set
            {
                this.rangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class PTZConfigurationZoomLimitsRange
    {

        private string uRIField;

        private PTZConfigurationZoomLimitsRangeXRange xRangeField;

        /// <remarks/>
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        public PTZConfigurationZoomLimitsRangeXRange XRange
        {
            get
            {
                return this.xRangeField;
            }
            set
            {
                this.xRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class PTZConfigurationZoomLimitsRangeXRange
    {

        private decimal minField;

        private decimal maxField;

        /// <remarks/>
        public decimal Min
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
        public decimal Max
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
    public partial class MetadataConfiguration
    {

        private string nameField;

        private byte useCountField;

        private MetadataConfigurationPTZStatus pTZStatusField;

        private MetadataConfigurationEvents eventsField;

        private bool analyticsField;

        private MetadataConfigurationMulticast multicastField;

        private string sessionTimeoutField;

        private byte tokenField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte UseCount
        {
            get
            {
                return this.useCountField;
            }
            set
            {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        public MetadataConfigurationPTZStatus PTZStatus
        {
            get
            {
                return this.pTZStatusField;
            }
            set
            {
                this.pTZStatusField = value;
            }
        }

        /// <remarks/>
        public MetadataConfigurationEvents Events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
            }
        }

        /// <remarks/>
        public bool Analytics
        {
            get
            {
                return this.analyticsField;
            }
            set
            {
                this.analyticsField = value;
            }
        }

        /// <remarks/>
        public MetadataConfigurationMulticast Multicast
        {
            get
            {
                return this.multicastField;
            }
            set
            {
                this.multicastField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "duration")]
        public string SessionTimeout
        {
            get
            {
                return this.sessionTimeoutField;
            }
            set
            {
                this.sessionTimeoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class MetadataConfigurationPTZStatus
    {

        private bool statusField;

        private bool positionField;

        /// <remarks/>
        public bool Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public bool Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class MetadataConfigurationEvents
    {

        private MetadataConfigurationEventsFilter filterField;

        /// <remarks/>
        public MetadataConfigurationEventsFilter Filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class MetadataConfigurationEventsFilter
    {

        private TopicExpression topicExpressionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public TopicExpression TopicExpression
        {
            get
            {
                return this.topicExpressionField;
            }
            set
            {
                this.topicExpressionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/wsn/b-2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://docs.oasis-open.org/wsn/b-2", IsNullable = false)]
    public partial class TopicExpression
    {

        private string dialectField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Dialect
        {
            get
            {
                return this.dialectField;
            }
            set
            {
                this.dialectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class MetadataConfigurationMulticast
    {

        private MetadataConfigurationMulticastAddress addressField;

        private ushort portField;

        private byte tTLField;

        private bool autoStartField;

        /// <remarks/>
        public MetadataConfigurationMulticastAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public ushort Port
        {
            get
            {
                return this.portField;
            }
            set
            {
                this.portField = value;
            }
        }

        /// <remarks/>
        public byte TTL
        {
            get
            {
                return this.tTLField;
            }
            set
            {
                this.tTLField = value;
            }
        }

        /// <remarks/>
        public bool AutoStart
        {
            get
            {
                return this.autoStartField;
            }
            set
            {
                this.autoStartField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class MetadataConfigurationMulticastAddress
    {

        private string typeField;

        private string iPv4AddressField;

        /// <remarks/>
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string IPv4Address
        {
            get
            {
                return this.iPv4AddressField;
            }
            set
            {
                this.iPv4AddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class Extension
    {

        private ExtensionAudioOutputConfiguration audioOutputConfigurationField;

        private ExtensionAudioDecoderConfiguration audioDecoderConfigurationField;

        /// <remarks/>
        public ExtensionAudioOutputConfiguration AudioOutputConfiguration
        {
            get
            {
                return this.audioOutputConfigurationField;
            }
            set
            {
                this.audioOutputConfigurationField = value;
            }
        }

        /// <remarks/>
        public ExtensionAudioDecoderConfiguration AudioDecoderConfiguration
        {
            get
            {
                return this.audioDecoderConfigurationField;
            }
            set
            {
                this.audioDecoderConfigurationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class ExtensionAudioOutputConfiguration
    {

        private string nameField;

        private byte useCountField;

        private byte outputTokenField;

        private string sendPrimacyField;

        private byte outputLevelField;

        private byte tokenField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte UseCount
        {
            get
            {
                return this.useCountField;
            }
            set
            {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        public byte OutputToken
        {
            get
            {
                return this.outputTokenField;
            }
            set
            {
                this.outputTokenField = value;
            }
        }

        /// <remarks/>
        public string SendPrimacy
        {
            get
            {
                return this.sendPrimacyField;
            }
            set
            {
                this.sendPrimacyField = value;
            }
        }

        /// <remarks/>
        public byte OutputLevel
        {
            get
            {
                return this.outputLevelField;
            }
            set
            {
                this.outputLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class ExtensionAudioDecoderConfiguration
    {

        private string nameField;

        private byte useCountField;

        private byte tokenField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public byte UseCount
        {
            get
            {
                return this.useCountField;
            }
            set
            {
                this.useCountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }


}
