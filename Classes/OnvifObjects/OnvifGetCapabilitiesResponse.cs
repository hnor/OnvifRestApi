using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SgiOnvifRestApiGW.OnvifObjects.GetCapabilitiesResponse
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRoot(ElementName = "Envelope")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    //[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2003/05/soap-envelope", IsNullable = false)]
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

        private GetCapabilitiesResponse getCapabilitiesResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public GetCapabilitiesResponse GetCapabilitiesResponse
        {
            get
            {
                return this.getCapabilitiesResponseField;
            }
            set
            {
                this.getCapabilitiesResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", IsNullable = false)]
    public partial class GetCapabilitiesResponse
    {

        private GetCapabilitiesResponseCapabilities capabilitiesField;

        /// <remarks/>
        public GetCapabilitiesResponseCapabilities Capabilities
        {
            get
            {
                return this.capabilitiesField;
            }
            set
            {
                this.capabilitiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public partial class GetCapabilitiesResponseCapabilities
    {

        private Analytics analyticsField;

        private Device deviceField;

        private Events eventsField;

        private Imaging imagingField;

        private Media mediaField;

        private PTZ pTZField;

        private Extension extensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public Analytics Analytics
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public Events Events
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public Imaging Imaging
        {
            get
            {
                return this.imagingField;
            }
            set
            {
                this.imagingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public Media Media
        {
            get
            {
                return this.mediaField;
            }
            set
            {
                this.mediaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public PTZ PTZ
        {
            get
            {
                return this.pTZField;
            }
            set
            {
                this.pTZField = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class Analytics
    {

        private string xAddrField;

        private bool ruleSupportField;

        private bool analyticsModuleSupportField;

        /// <remarks/>
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }

        /// <remarks/>
        public bool RuleSupport
        {
            get
            {
                return this.ruleSupportField;
            }
            set
            {
                this.ruleSupportField = value;
            }
        }

        /// <remarks/>
        public bool AnalyticsModuleSupport
        {
            get
            {
                return this.analyticsModuleSupportField;
            }
            set
            {
                this.analyticsModuleSupportField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class Device
    {

        private string xAddrField;

        private DeviceNetwork networkField;

        private DeviceSystem systemField;

        private DeviceIO ioField;

        private DeviceSecurity securityField;

        /// <remarks/>
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }

        /// <remarks/>
        public DeviceNetwork Network
        {
            get
            {
                return this.networkField;
            }
            set
            {
                this.networkField = value;
            }
        }

        /// <remarks/>
        public DeviceSystem System
        {
            get
            {
                return this.systemField;
            }
            set
            {
                this.systemField = value;
            }
        }

        /// <remarks/>
        public DeviceIO IO
        {
            get
            {
                return this.ioField;
            }
            set
            {
                this.ioField = value;
            }
        }

        /// <remarks/>
        public DeviceSecurity Security
        {
            get
            {
                return this.securityField;
            }
            set
            {
                this.securityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class DeviceNetwork
    {

        private bool iPFilterField;

        private bool zeroConfigurationField;

        private bool iPVersion6Field;

        private bool dynDNSField;

        private DeviceNetworkExtension extensionField;

        /// <remarks/>
        public bool IPFilter
        {
            get
            {
                return this.iPFilterField;
            }
            set
            {
                this.iPFilterField = value;
            }
        }

        /// <remarks/>
        public bool ZeroConfiguration
        {
            get
            {
                return this.zeroConfigurationField;
            }
            set
            {
                this.zeroConfigurationField = value;
            }
        }

        /// <remarks/>
        public bool IPVersion6
        {
            get
            {
                return this.iPVersion6Field;
            }
            set
            {
                this.iPVersion6Field = value;
            }
        }

        /// <remarks/>
        public bool DynDNS
        {
            get
            {
                return this.dynDNSField;
            }
            set
            {
                this.dynDNSField = value;
            }
        }

        /// <remarks/>
        public DeviceNetworkExtension Extension
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class DeviceNetworkExtension
    {

        private bool dot11ConfigurationField;

        /// <remarks/>
        public bool Dot11Configuration
        {
            get
            {
                return this.dot11ConfigurationField;
            }
            set
            {
                this.dot11ConfigurationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class DeviceSystem
    {

        private bool discoveryResolveField;

        private bool discoveryByeField;

        private bool remoteDiscoveryField;

        private bool systemBackupField;

        private bool systemLoggingField;

        private bool firmwareUpgradeField;

        private DeviceSystemSupportedVersions[] supportedVersionsField;

        private DeviceSystemExtension extensionField;

        /// <remarks/>
        public bool DiscoveryResolve
        {
            get
            {
                return this.discoveryResolveField;
            }
            set
            {
                this.discoveryResolveField = value;
            }
        }

        /// <remarks/>
        public bool DiscoveryBye
        {
            get
            {
                return this.discoveryByeField;
            }
            set
            {
                this.discoveryByeField = value;
            }
        }

        /// <remarks/>
        public bool RemoteDiscovery
        {
            get
            {
                return this.remoteDiscoveryField;
            }
            set
            {
                this.remoteDiscoveryField = value;
            }
        }

        /// <remarks/>
        public bool SystemBackup
        {
            get
            {
                return this.systemBackupField;
            }
            set
            {
                this.systemBackupField = value;
            }
        }

        /// <remarks/>
        public bool SystemLogging
        {
            get
            {
                return this.systemLoggingField;
            }
            set
            {
                this.systemLoggingField = value;
            }
        }

        /// <remarks/>
        public bool FirmwareUpgrade
        {
            get
            {
                return this.firmwareUpgradeField;
            }
            set
            {
                this.firmwareUpgradeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupportedVersions")]
        public DeviceSystemSupportedVersions[] SupportedVersions
        {
            get
            {
                return this.supportedVersionsField;
            }
            set
            {
                this.supportedVersionsField = value;
            }
        }

        /// <remarks/>
        public DeviceSystemExtension Extension
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class DeviceSystemSupportedVersions
    {

        private byte majorField;

        private byte minorField;

        /// <remarks/>
        public byte Major
        {
            get
            {
                return this.majorField;
            }
            set
            {
                this.majorField = value;
            }
        }

        /// <remarks/>
        public byte Minor
        {
            get
            {
                return this.minorField;
            }
            set
            {
                this.minorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class DeviceSystemExtension
    {

        private bool httpFirmwareUpgradeField;

        private bool httpSystemBackupField;

        private bool httpSystemLoggingField;

        private bool httpSupportInformationField;

        /// <remarks/>
        public bool HttpFirmwareUpgrade
        {
            get
            {
                return this.httpFirmwareUpgradeField;
            }
            set
            {
                this.httpFirmwareUpgradeField = value;
            }
        }

        /// <remarks/>
        public bool HttpSystemBackup
        {
            get
            {
                return this.httpSystemBackupField;
            }
            set
            {
                this.httpSystemBackupField = value;
            }
        }

        /// <remarks/>
        public bool HttpSystemLogging
        {
            get
            {
                return this.httpSystemLoggingField;
            }
            set
            {
                this.httpSystemLoggingField = value;
            }
        }

        /// <remarks/>
        public bool HttpSupportInformation
        {
            get
            {
                return this.httpSupportInformationField;
            }
            set
            {
                this.httpSupportInformationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class DeviceIO
    {

        private byte inputConnectorsField;

        private byte relayOutputsField;

        private DeviceIOExtension extensionField;

        /// <remarks/>
        public byte InputConnectors
        {
            get
            {
                return this.inputConnectorsField;
            }
            set
            {
                this.inputConnectorsField = value;
            }
        }

        /// <remarks/>
        public byte RelayOutputs
        {
            get
            {
                return this.relayOutputsField;
            }
            set
            {
                this.relayOutputsField = value;
            }
        }

        /// <remarks/>
        public DeviceIOExtension Extension
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class DeviceIOExtension
    {

        private bool auxiliaryField;

        private object extensionField;

        /// <remarks/>
        public bool Auxiliary
        {
            get
            {
                return this.auxiliaryField;
            }
            set
            {
                this.auxiliaryField = value;
            }
        }

        /// <remarks/>
        public object Extension
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class DeviceSecurity
    {

        private bool tLS11Field;

        private bool tLS12Field;

        private bool onboardKeyGenerationField;

        private bool accessPolicyConfigField;

        private bool x509TokenField;

        private bool sAMLTokenField;

        private bool kerberosTokenField;

        private bool rELTokenField;

        private DeviceSecurityExtension extensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TLS1.1")]
        public bool TLS11
        {
            get
            {
                return this.tLS11Field;
            }
            set
            {
                this.tLS11Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TLS1.2")]
        public bool TLS12
        {
            get
            {
                return this.tLS12Field;
            }
            set
            {
                this.tLS12Field = value;
            }
        }

        /// <remarks/>
        public bool OnboardKeyGeneration
        {
            get
            {
                return this.onboardKeyGenerationField;
            }
            set
            {
                this.onboardKeyGenerationField = value;
            }
        }

        /// <remarks/>
        public bool AccessPolicyConfig
        {
            get
            {
                return this.accessPolicyConfigField;
            }
            set
            {
                this.accessPolicyConfigField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("X.509Token")]
        public bool X509Token
        {
            get
            {
                return this.x509TokenField;
            }
            set
            {
                this.x509TokenField = value;
            }
        }

        /// <remarks/>
        public bool SAMLToken
        {
            get
            {
                return this.sAMLTokenField;
            }
            set
            {
                this.sAMLTokenField = value;
            }
        }

        /// <remarks/>
        public bool KerberosToken
        {
            get
            {
                return this.kerberosTokenField;
            }
            set
            {
                this.kerberosTokenField = value;
            }
        }

        /// <remarks/>
        public bool RELToken
        {
            get
            {
                return this.rELTokenField;
            }
            set
            {
                this.rELTokenField = value;
            }
        }

        /// <remarks/>
        public DeviceSecurityExtension Extension
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class DeviceSecurityExtension
    {

        private bool tLS10Field;

        private DeviceSecurityExtensionExtension extensionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TLS1.0")]
        public bool TLS10
        {
            get
            {
                return this.tLS10Field;
            }
            set
            {
                this.tLS10Field = value;
            }
        }

        /// <remarks/>
        public DeviceSecurityExtensionExtension Extension
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class DeviceSecurityExtensionExtension
    {

        private bool dot1XField;

        private byte supportedEAPMethodField;

        private bool remoteUserHandlingField;

        /// <remarks/>
        public bool Dot1X
        {
            get
            {
                return this.dot1XField;
            }
            set
            {
                this.dot1XField = value;
            }
        }

        /// <remarks/>
        public byte SupportedEAPMethod
        {
            get
            {
                return this.supportedEAPMethodField;
            }
            set
            {
                this.supportedEAPMethodField = value;
            }
        }

        /// <remarks/>
        public bool RemoteUserHandling
        {
            get
            {
                return this.remoteUserHandlingField;
            }
            set
            {
                this.remoteUserHandlingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class Events
    {

        private string xAddrField;

        private bool wSSubscriptionPolicySupportField;

        private bool wSPullPointSupportField;

        private bool wSPausableSubscriptionManagerInterfaceSupportField;

        /// <remarks/>
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }

        /// <remarks/>
        public bool WSSubscriptionPolicySupport
        {
            get
            {
                return this.wSSubscriptionPolicySupportField;
            }
            set
            {
                this.wSSubscriptionPolicySupportField = value;
            }
        }

        /// <remarks/>
        public bool WSPullPointSupport
        {
            get
            {
                return this.wSPullPointSupportField;
            }
            set
            {
                this.wSPullPointSupportField = value;
            }
        }

        /// <remarks/>
        public bool WSPausableSubscriptionManagerInterfaceSupport
        {
            get
            {
                return this.wSPausableSubscriptionManagerInterfaceSupportField;
            }
            set
            {
                this.wSPausableSubscriptionManagerInterfaceSupportField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class Imaging
    {

        private string xAddrField;

        /// <remarks/>
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class Media
    {

        private string xAddrField;

        private MediaStreamingCapabilities streamingCapabilitiesField;

        private MediaExtension extensionField;

        /// <remarks/>
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }

        /// <remarks/>
        public MediaStreamingCapabilities StreamingCapabilities
        {
            get
            {
                return this.streamingCapabilitiesField;
            }
            set
            {
                this.streamingCapabilitiesField = value;
            }
        }

        /// <remarks/>
        public MediaExtension Extension
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class MediaStreamingCapabilities
    {

        private bool rTPMulticastField;

        private bool rTP_TCPField;

        private bool rTP_RTSP_TCPField;

        /// <remarks/>
        public bool RTPMulticast
        {
            get
            {
                return this.rTPMulticastField;
            }
            set
            {
                this.rTPMulticastField = value;
            }
        }

        /// <remarks/>
        public bool RTP_TCP
        {
            get
            {
                return this.rTP_TCPField;
            }
            set
            {
                this.rTP_TCPField = value;
            }
        }

        /// <remarks/>
        public bool RTP_RTSP_TCP
        {
            get
            {
                return this.rTP_RTSP_TCPField;
            }
            set
            {
                this.rTP_RTSP_TCPField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class MediaExtension
    {

        private MediaExtensionProfileCapabilities profileCapabilitiesField;

        /// <remarks/>
        public MediaExtensionProfileCapabilities ProfileCapabilities
        {
            get
            {
                return this.profileCapabilitiesField;
            }
            set
            {
                this.profileCapabilitiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class MediaExtensionProfileCapabilities
    {

        private byte maximumNumberOfProfilesField;

        /// <remarks/>
        public byte MaximumNumberOfProfiles
        {
            get
            {
                return this.maximumNumberOfProfilesField;
            }
            set
            {
                this.maximumNumberOfProfilesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class PTZ
    {

        private string xAddrField;

        /// <remarks/>
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
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

        private ExtensionDeviceIO deviceIOField;

        private ExtensionExtensions extensionsField;

        /// <remarks/>
        public ExtensionDeviceIO DeviceIO
        {
            get
            {
                return this.deviceIOField;
            }
            set
            {
                this.deviceIOField = value;
            }
        }

        /// <remarks/>
        public ExtensionExtensions Extensions
        {
            get
            {
                return this.extensionsField;
            }
            set
            {
                this.extensionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class ExtensionDeviceIO
    {

        private string xAddrField;

        private byte videoSourcesField;

        private byte videoOutputsField;

        private byte audioSourcesField;

        private byte audioOutputsField;

        private byte relayOutputsField;

        /// <remarks/>
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }

        /// <remarks/>
        public byte VideoSources
        {
            get
            {
                return this.videoSourcesField;
            }
            set
            {
                this.videoSourcesField = value;
            }
        }

        /// <remarks/>
        public byte VideoOutputs
        {
            get
            {
                return this.videoOutputsField;
            }
            set
            {
                this.videoOutputsField = value;
            }
        }

        /// <remarks/>
        public byte AudioSources
        {
            get
            {
                return this.audioSourcesField;
            }
            set
            {
                this.audioSourcesField = value;
            }
        }

        /// <remarks/>
        public byte AudioOutputs
        {
            get
            {
                return this.audioOutputsField;
            }
            set
            {
                this.audioOutputsField = value;
            }
        }

        /// <remarks/>
        public byte RelayOutputs
        {
            get
            {
                return this.relayOutputsField;
            }
            set
            {
                this.relayOutputsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class ExtensionExtensions
    {

        private ExtensionExtensionsTelexCapabilities telexCapabilitiesField;

        /// <remarks/>
        public ExtensionExtensionsTelexCapabilities TelexCapabilities
        {
            get
            {
                return this.telexCapabilitiesField;
            }
            set
            {
                this.telexCapabilitiesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class ExtensionExtensionsTelexCapabilities
    {

        private string xAddrField;

        private bool timeOSDSupportField;

        private bool titleOSDSupportField;

        private bool pTZ3DZoomSupportField;

        private bool pTZAuxSwitchSupportField;

        private bool motionDetectorSupportField;

        private bool tamperDetectorSupportField;

        /// <remarks/>
        public string XAddr
        {
            get
            {
                return this.xAddrField;
            }
            set
            {
                this.xAddrField = value;
            }
        }

        /// <remarks/>
        public bool TimeOSDSupport
        {
            get
            {
                return this.timeOSDSupportField;
            }
            set
            {
                this.timeOSDSupportField = value;
            }
        }

        /// <remarks/>
        public bool TitleOSDSupport
        {
            get
            {
                return this.titleOSDSupportField;
            }
            set
            {
                this.titleOSDSupportField = value;
            }
        }

        /// <remarks/>
        public bool PTZ3DZoomSupport
        {
            get
            {
                return this.pTZ3DZoomSupportField;
            }
            set
            {
                this.pTZ3DZoomSupportField = value;
            }
        }

        /// <remarks/>
        public bool PTZAuxSwitchSupport
        {
            get
            {
                return this.pTZAuxSwitchSupportField;
            }
            set
            {
                this.pTZAuxSwitchSupportField = value;
            }
        }

        /// <remarks/>
        public bool MotionDetectorSupport
        {
            get
            {
                return this.motionDetectorSupportField;
            }
            set
            {
                this.motionDetectorSupportField = value;
            }
        }

        /// <remarks/>
        public bool TamperDetectorSupport
        {
            get
            {
                return this.tamperDetectorSupportField;
            }
            set
            {
                this.tamperDetectorSupportField = value;
            }
        }
    }


}
