using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SgiOnvifRestApiGW.OnvifObjects.GetZeroConfigurationResponse
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

        private GetZeroConfigurationResponse getZeroConfigurationResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public GetZeroConfigurationResponse GetZeroConfigurationResponse
        {
            get
            {
                return this.getZeroConfigurationResponseField;
            }
            set
            {
                this.getZeroConfigurationResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", IsNullable = false)]
    public partial class GetZeroConfigurationResponse
    {

        private GetZeroConfigurationResponseZeroConfiguration zeroConfigurationField;

        /// <remarks/>
        public GetZeroConfigurationResponseZeroConfiguration ZeroConfiguration
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public partial class GetZeroConfigurationResponseZeroConfiguration
    {

        private string interfaceTokenField;

        private bool enabledField;

        private string[] addressesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public string InterfaceToken
        {
            get
            {
                return this.interfaceTokenField;
            }
            set
            {
                this.interfaceTokenField = value;
            }
        }

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
        [System.Xml.Serialization.XmlElementAttribute("Addresses", Namespace = "http://www.onvif.org/ver10/schema")]
        public string[] Addresses
        {
            get
            {
                return this.addressesField;
            }
            set
            {
                this.addressesField = value;
            }
        }
    }

}
