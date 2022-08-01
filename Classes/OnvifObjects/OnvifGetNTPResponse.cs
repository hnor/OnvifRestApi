using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnvifRestApiGW.OnvifObjects.OnvifGetNTPResponse
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

        private GetNTPResponse getNTPResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl")]
        public GetNTPResponse GetNTPResponse
        {
            get
            {
                return this.getNTPResponseField;
            }
            set
            {
                this.getNTPResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/device/wsdl", IsNullable = false)]
    public partial class GetNTPResponse
    {

        private GetNTPResponseNTPInformation nTPInformationField;

        /// <remarks/>
        public GetNTPResponseNTPInformation NTPInformation
        {
            get
            {
                return this.nTPInformationField;
            }
            set
            {
                this.nTPInformationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/device/wsdl")]
    public partial class GetNTPResponseNTPInformation
    {

        private bool fromDHCPField;

        private NTPManual[] nTPManualField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/schema")]
        public bool FromDHCP
        {
            get
            {
                return this.fromDHCPField;
            }
            set
            {
                this.fromDHCPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NTPManual", Namespace = "http://www.onvif.org/ver10/schema")]
        public NTPManual[] NTPManual
        {
            get
            {
                return this.nTPManualField;
            }
            set
            {
                this.nTPManualField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/schema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/schema", IsNullable = false)]
    public partial class NTPManual
    {

        private string typeField;

        private string iPv6AddressField;

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
        public string IPv6Address
        {
            get
            {
                return this.iPv6AddressField;
            }
            set
            {
                this.iPv6AddressField = value;
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

}
