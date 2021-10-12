using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SgiOnvifRestApiGW.OnvifObjects.OnvifPtzGetConfigurationsResponse
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

        private GetConfigurationsResponse getConfigurationsResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
        public GetConfigurationsResponse GetConfigurationsResponse
        {
            get
            {
                return this.getConfigurationsResponseField;
            }
            set
            {
                this.getConfigurationsResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver20/ptz/wsdl", IsNullable = false)]
    public partial class GetConfigurationsResponse
    {

        private GetConfigurationsResponsePTZConfiguration pTZConfigurationField;

        /// <remarks/>
        public GetConfigurationsResponsePTZConfiguration PTZConfiguration
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver20/ptz/wsdl")]
    public partial class GetConfigurationsResponsePTZConfiguration
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

        private DefaultPTZSpeed defaultPTZSpeedField;

        private string defaultPTZTimeoutField;

        private PanTiltLimits panTiltLimitsField;

        private ZoomLimits zoomLimitsField;

        private byte tokenField;

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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public DefaultPTZSpeed DefaultPTZSpeed
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema", DataType = "duration")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public PanTiltLimits PanTiltLimits
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public ZoomLimits ZoomLimits
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class DefaultPTZSpeed
    {

        private DefaultPTZSpeedPanTilt panTiltField;

        private DefaultPTZSpeedZoom zoomField;

        /// <remarks/>
        public DefaultPTZSpeedPanTilt PanTilt
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
        public DefaultPTZSpeedZoom Zoom
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
    public partial class DefaultPTZSpeedPanTilt
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
    public partial class DefaultPTZSpeedZoom
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class PanTiltLimits
    {

        private PanTiltLimitsRange rangeField;

        /// <remarks/>
        public PanTiltLimitsRange Range
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
    public partial class PanTiltLimitsRange
    {

        private string uRIField;

        private PanTiltLimitsRangeXRange xRangeField;

        private PanTiltLimitsRangeYRange yRangeField;

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
        public PanTiltLimitsRangeXRange XRange
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
        public PanTiltLimitsRangeYRange YRange
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
    public partial class PanTiltLimitsRangeXRange
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
    public partial class PanTiltLimitsRangeYRange
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
    public partial class ZoomLimits
    {

        private ZoomLimitsRange rangeField;

        /// <remarks/>
        public ZoomLimitsRange Range
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
    public partial class ZoomLimitsRange
    {

        private string uRIField;

        private ZoomLimitsRangeXRange xRangeField;

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
        public ZoomLimitsRangeXRange XRange
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
    public partial class ZoomLimitsRangeXRange
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


}
