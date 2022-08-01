using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnvifRestApiGW.OnvifObjects.GetEventPropertiesResponse
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2003/05/soap-envelope", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeHeader headerField;

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeHeader Header
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
    public partial class EnvelopeHeader
    {

        private string actionField;

        private string toField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2005/08/addressing")]
        public string Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2005/08/addressing")]
        public string To
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public partial class EnvelopeBody
    {

        private GetEventPropertiesResponse getEventPropertiesResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/events/wsdl")]
        public GetEventPropertiesResponse GetEventPropertiesResponse
        {
            get
            {
                return this.getEventPropertiesResponseField;
            }
            set
            {
                this.getEventPropertiesResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/events/wsdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/events/wsdl", IsNullable = false)]
    public partial class GetEventPropertiesResponse
    {

        private string topicNamespaceLocationField;

        private bool fixedTopicSetField;

        private TopicSet topicSetField;

        private string[] topicExpressionDialectField;

        private string messageContentFilterDialectField;

        private string messageContentSchemaLocationField;

        /// <remarks/>
        public string TopicNamespaceLocation
        {
            get
            {
                return this.topicNamespaceLocationField;
            }
            set
            {
                this.topicNamespaceLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public bool FixedTopicSet
        {
            get
            {
                return this.fixedTopicSetField;
            }
            set
            {
                this.fixedTopicSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public TopicSet TopicSet
        {
            get
            {
                return this.topicSetField;
            }
            set
            {
                this.topicSetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TopicExpressionDialect", Namespace = "http://docs.oasis-open.org/wsn/b-2")]
        public string[] TopicExpressionDialect
        {
            get
            {
                return this.topicExpressionDialectField;
            }
            set
            {
                this.topicExpressionDialectField = value;
            }
        }

        /// <remarks/>
        public string MessageContentFilterDialect
        {
            get
            {
                return this.messageContentFilterDialectField;
            }
            set
            {
                this.messageContentFilterDialectField = value;
            }
        }

        /// <remarks/>
        public string MessageContentSchemaLocation
        {
            get
            {
                return this.messageContentSchemaLocationField;
            }
            set
            {
                this.messageContentSchemaLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://docs.oasis-open.org/wsn/t-1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://docs.oasis-open.org/wsn/t-1", IsNullable = false)]
    public partial class TopicSet
    {

        private RuleEngine ruleEngineField;

        private VideoSource videoSourceField;

        private Configuration configurationField;

        private Device deviceField;

        private Monitoring monitoringField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/topics")]
        public RuleEngine RuleEngine
        {
            get
            {
                return this.ruleEngineField;
            }
            set
            {
                this.ruleEngineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/topics")]
        public VideoSource VideoSource
        {
            get
            {
                return this.videoSourceField;
            }
            set
            {
                this.videoSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/topics")]
        public Configuration Configuration
        {
            get
            {
                return this.configurationField;
            }
            set
            {
                this.configurationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/topics")]
        public Device Device
        {
            get
            {
                return this.deviceField;
            }
            set
            {
                this.deviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/topics")]
        public Monitoring Monitoring
        {
            get
            {
                return this.monitoringField;
            }
            set
            {
                this.monitoringField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/topics")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/topics", IsNullable = false)]
    public partial class RuleEngine
    {

        private CellMotionDetector cellMotionDetectorField;

        private TamperDetector tamperDetectorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public CellMotionDetector CellMotionDetector
        {
            get
            {
                return this.cellMotionDetectorField;
            }
            set
            {
                this.cellMotionDetectorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public TamperDetector TamperDetector
        {
            get
            {
                return this.tamperDetectorField;
            }
            set
            {
                this.tamperDetectorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CellMotionDetector
    {

        private CellMotionDetectorMotion motionField;

        /// <remarks/>
        public CellMotionDetectorMotion Motion
        {
            get
            {
                return this.motionField;
            }
            set
            {
                this.motionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CellMotionDetectorMotion
    {

        private MessageDescription messageDescriptionField;

        private bool topicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public MessageDescription MessageDescription
        {
            get
            {
                return this.messageDescriptionField;
            }
            set
            {
                this.messageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public bool topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class MessageDescription
    {

        private MessageDescriptionSimpleItemDescription[] sourceField;

        private MessageDescriptionData dataField;

        private bool isPropertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SimpleItemDescription", IsNullable = false)]
        public MessageDescriptionSimpleItemDescription[] Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        public MessageDescriptionData Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsProperty
        {
            get
            {
                return this.isPropertyField;
            }
            set
            {
                this.isPropertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class MessageDescriptionSimpleItemDescription
    {

        private string nameField;

        private string typeField;

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
    public partial class MessageDescriptionData
    {

        private MessageDescriptionDataElementItemDescription elementItemDescriptionField;

        private MessageDescriptionDataSimpleItemDescription simpleItemDescriptionField;

        /// <remarks/>
        public MessageDescriptionDataElementItemDescription ElementItemDescription
        {
            get
            {
                return this.elementItemDescriptionField;
            }
            set
            {
                this.elementItemDescriptionField = value;
            }
        }

        /// <remarks/>
        public MessageDescriptionDataSimpleItemDescription SimpleItemDescription
        {
            get
            {
                return this.simpleItemDescriptionField;
            }
            set
            {
                this.simpleItemDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class MessageDescriptionDataElementItemDescription
    {

        private string nameField;

        private string typeField;

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
    public partial class MessageDescriptionDataSimpleItemDescription
    {

        private string nameField;

        private string typeField;

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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TamperDetector
    {

        private TamperDetectorTamper tamperField;

        /// <remarks/>
        public TamperDetectorTamper Tamper
        {
            get
            {
                return this.tamperField;
            }
            set
            {
                this.tamperField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TamperDetectorTamper
    {

        private MessageDescription messageDescriptionField;

        private bool topicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public MessageDescription MessageDescription
        {
            get
            {
                return this.messageDescriptionField;
            }
            set
            {
                this.messageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public bool topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/topics")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/topics", IsNullable = false)]
    public partial class VideoSource
    {

        private MotionAlarm motionAlarmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public MotionAlarm MotionAlarm
        {
            get
            {
                return this.motionAlarmField;
            }
            set
            {
                this.motionAlarmField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class MotionAlarm
    {

        private MessageDescription messageDescriptionField;

        private bool topicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public MessageDescription MessageDescription
        {
            get
            {
                return this.messageDescriptionField;
            }
            set
            {
                this.messageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public bool topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/topics")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/topics", IsNullable = false)]
    public partial class Configuration
    {

        private VideoEncoderConfiguration videoEncoderConfigurationField;

        private AudioEncoderConfiguration audioEncoderConfigurationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class VideoEncoderConfiguration
    {

        private MessageDescription messageDescriptionField;

        private bool topicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public MessageDescription MessageDescription
        {
            get
            {
                return this.messageDescriptionField;
            }
            set
            {
                this.messageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public bool topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class AudioEncoderConfiguration
    {

        private MessageDescription messageDescriptionField;

        private bool topicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public MessageDescription MessageDescription
        {
            get
            {
                return this.messageDescriptionField;
            }
            set
            {
                this.messageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public bool topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/topics")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/topics", IsNullable = false)]
    public partial class Device
    {

        private Trigger triggerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public Trigger Trigger
        {
            get
            {
                return this.triggerField;
            }
            set
            {
                this.triggerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Trigger
    {

        private TriggerDigitalInput digitalInputField;

        /// <remarks/>
        public TriggerDigitalInput DigitalInput
        {
            get
            {
                return this.digitalInputField;
            }
            set
            {
                this.digitalInputField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TriggerDigitalInput
    {

        private MessageDescription messageDescriptionField;

        private bool topicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public MessageDescription MessageDescription
        {
            get
            {
                return this.messageDescriptionField;
            }
            set
            {
                this.messageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public bool topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/topics")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/topics", IsNullable = false)]
    public partial class Monitoring
    {

        private ProcessorUsage processorUsageField;

        private OperatingTime operatingTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public ProcessorUsage ProcessorUsage
        {
            get
            {
                return this.processorUsageField;
            }
            set
            {
                this.processorUsageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public OperatingTime OperatingTime
        {
            get
            {
                return this.operatingTimeField;
            }
            set
            {
                this.operatingTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ProcessorUsage
    {

        private MessageDescription messageDescriptionField;

        private bool topicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public MessageDescription MessageDescription
        {
            get
            {
                return this.messageDescriptionField;
            }
            set
            {
                this.messageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public bool topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class OperatingTime
    {

        private OperatingTimeLastReboot lastRebootField;

        private OperatingTimeLastReset lastResetField;

        private OperatingTimeLastClockSynchronization lastClockSynchronizationField;

        /// <remarks/>
        public OperatingTimeLastReboot LastReboot
        {
            get
            {
                return this.lastRebootField;
            }
            set
            {
                this.lastRebootField = value;
            }
        }

        /// <remarks/>
        public OperatingTimeLastReset LastReset
        {
            get
            {
                return this.lastResetField;
            }
            set
            {
                this.lastResetField = value;
            }
        }

        /// <remarks/>
        public OperatingTimeLastClockSynchronization LastClockSynchronization
        {
            get
            {
                return this.lastClockSynchronizationField;
            }
            set
            {
                this.lastClockSynchronizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OperatingTimeLastReboot
    {

        private MessageDescription messageDescriptionField;

        private bool topicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public MessageDescription MessageDescription
        {
            get
            {
                return this.messageDescriptionField;
            }
            set
            {
                this.messageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public bool topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OperatingTimeLastReset
    {

        private MessageDescription messageDescriptionField;

        private bool topicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public MessageDescription MessageDescription
        {
            get
            {
                return this.messageDescriptionField;
            }
            set
            {
                this.messageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public bool topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class OperatingTimeLastClockSynchronization
    {

        private MessageDescription messageDescriptionField;

        private bool topicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public MessageDescription MessageDescription
        {
            get
            {
                return this.messageDescriptionField;
            }
            set
            {
                this.messageDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://docs.oasis-open.org/wsn/t-1")]
        public bool topic
        {
            get
            {
                return this.topicField;
            }
            set
            {
                this.topicField = value;
            }
        }
    }


}
