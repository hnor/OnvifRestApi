using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnvifRestApiGW.OnvifObjects.OnvifGetNetworkInterfacesResponse
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

        private GetNetworkInterfacesResponse getNetworkInterfacesResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public GetNetworkInterfacesResponse GetNetworkInterfacesResponse
        {
            get
            {
                return this.getNetworkInterfacesResponseField;
            }
            set
            {
                this.getNetworkInterfacesResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", IsNullable = false)]
    public partial class GetNetworkInterfacesResponse
    {

        private GetNetworkInterfacesResponseNetworkInterfaces networkInterfacesField;

        /// <remarks/>
        public GetNetworkInterfacesResponseNetworkInterfaces NetworkInterfaces
        {
            get
            {
                return this.networkInterfacesField;
            }
            set
            {
                this.networkInterfacesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public partial class GetNetworkInterfacesResponseNetworkInterfaces
    {

        private bool enabledField;

        private Info infoField;

        private Link linkField;

        private IPv4 iPv4Field;

        private IPv6 iPv6Field;

        private string tokenField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public Info Info
        {
            get
            {
                return this.infoField;
            }
            set
            {
                this.infoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public Link Link
        {
            get
            {
                return this.linkField;
            }
            set
            {
                this.linkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public IPv4 IPv4
        {
            get
            {
                return this.iPv4Field;
            }
            set
            {
                this.iPv4Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public IPv6 IPv6
        {
            get
            {
                return this.iPv6Field;
            }
            set
            {
                this.iPv6Field = value;
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class Info
    {

        private string nameField;

        private string hwAddressField;

        private ushort mTUField;

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
        public string HwAddress
        {
            get
            {
                return this.hwAddressField;
            }
            set
            {
                this.hwAddressField = value;
            }
        }

        /// <remarks/>
        public ushort MTU
        {
            get
            {
                return this.mTUField;
            }
            set
            {
                this.mTUField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class Link
    {

        private LinkAdminSettings adminSettingsField;

        private LinkOperSettings operSettingsField;

        private byte interfaceTypeField;

        /// <remarks/>
        public LinkAdminSettings AdminSettings
        {
            get
            {
                return this.adminSettingsField;
            }
            set
            {
                this.adminSettingsField = value;
            }
        }

        /// <remarks/>
        public LinkOperSettings OperSettings
        {
            get
            {
                return this.operSettingsField;
            }
            set
            {
                this.operSettingsField = value;
            }
        }

        /// <remarks/>
        public byte InterfaceType
        {
            get
            {
                return this.interfaceTypeField;
            }
            set
            {
                this.interfaceTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class LinkAdminSettings
    {

        private bool autoNegotiationField;

        private byte speedField;

        private string duplexField;

        /// <remarks/>
        public bool AutoNegotiation
        {
            get
            {
                return this.autoNegotiationField;
            }
            set
            {
                this.autoNegotiationField = value;
            }
        }

        /// <remarks/>
        public byte Speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }

        /// <remarks/>
        public string Duplex
        {
            get
            {
                return this.duplexField;
            }
            set
            {
                this.duplexField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class LinkOperSettings
    {

        private bool autoNegotiationField;

        private byte speedField;

        private string duplexField;

        /// <remarks/>
        public bool AutoNegotiation
        {
            get
            {
                return this.autoNegotiationField;
            }
            set
            {
                this.autoNegotiationField = value;
            }
        }

        /// <remarks/>
        public byte Speed
        {
            get
            {
                return this.speedField;
            }
            set
            {
                this.speedField = value;
            }
        }

        /// <remarks/>
        public string Duplex
        {
            get
            {
                return this.duplexField;
            }
            set
            {
                this.duplexField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class IPv4
    {

        private bool enabledField;

        private IPv4Config configField;

        /// <remarks/>
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }

        /// <remarks/>
        public IPv4Config Config
        {
            get
            {
                return this.configField;
            }
            set
            {
                this.configField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class IPv4Config
    {

        private IPv4ConfigManual manualField;

        private bool dHCPField;

        /// <remarks/>
        public IPv4ConfigManual Manual
        {
            get
            {
                return this.manualField;
            }
            set
            {
                this.manualField = value;
            }
        }

        /// <remarks/>
        public bool DHCP
        {
            get
            {
                return this.dHCPField;
            }
            set
            {
                this.dHCPField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class IPv4ConfigManual
    {

        private string addressField;

        private byte prefixLengthField;

        /// <remarks/>
        public string Address
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
        public byte PrefixLength
        {
            get
            {
                return this.prefixLengthField;
            }
            set
            {
                this.prefixLengthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class IPv6
    {

        private bool enabledField;

        private IPv6Config configField;

        /// <remarks/>
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }

        /// <remarks/>
        public IPv6Config Config
        {
            get
            {
                return this.configField;
            }
            set
            {
                this.configField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class IPv6Config
    {

        private bool acceptRouterAdvertField;

        private string dHCPField;

        private IPv6ConfigManual manualField;

        private IPv6ConfigLinkLocal linkLocalField;

        private IPv6ConfigFromRA fromRAField;

        /// <remarks/>
        public bool AcceptRouterAdvert
        {
            get
            {
                return this.acceptRouterAdvertField;
            }
            set
            {
                this.acceptRouterAdvertField = value;
            }
        }

        /// <remarks/>
        public string DHCP
        {
            get
            {
                return this.dHCPField;
            }
            set
            {
                this.dHCPField = value;
            }
        }

        /// <remarks/>
        public IPv6ConfigManual Manual
        {
            get
            {
                return this.manualField;
            }
            set
            {
                this.manualField = value;
            }
        }

        /// <remarks/>
        public IPv6ConfigLinkLocal LinkLocal
        {
            get
            {
                return this.linkLocalField;
            }
            set
            {
                this.linkLocalField = value;
            }
        }

        /// <remarks/>
        public IPv6ConfigFromRA FromRA
        {
            get
            {
                return this.fromRAField;
            }
            set
            {
                this.fromRAField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class IPv6ConfigManual
    {

        private object addressField;

        private byte prefixLengthField;

        /// <remarks/>
        public object Address
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
        public byte PrefixLength
        {
            get
            {
                return this.prefixLengthField;
            }
            set
            {
                this.prefixLengthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class IPv6ConfigLinkLocal
    {

        private string addressField;

        private byte prefixLengthField;

        /// <remarks/>
        public string Address
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
        public byte PrefixLength
        {
            get
            {
                return this.prefixLengthField;
            }
            set
            {
                this.prefixLengthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    public partial class IPv6ConfigFromRA
    {

        private string addressField;

        private byte prefixLengthField;

        /// <remarks/>
        public string Address
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
        public byte PrefixLength
        {
            get
            {
                return this.prefixLengthField;
            }
            set
            {
                this.prefixLengthField = value;
            }
        }
    }


}
