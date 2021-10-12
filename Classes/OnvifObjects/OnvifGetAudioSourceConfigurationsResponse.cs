using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SgiOnvifRestApiGW.OnvifObjects.GetAudioSourceConfigurationsResponse
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

        private GetAudioSourceConfigurationsResponse getAudioSourceConfigurationsResponseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl")]
        public GetAudioSourceConfigurationsResponse GetAudioSourceConfigurationsResponse
        {
            get
            {
                return this.getAudioSourceConfigurationsResponseField;
            }
            set
            {
                this.getAudioSourceConfigurationsResponseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.onvif.org/ver10/media/wsdl", IsNullable = false)]
    public partial class GetAudioSourceConfigurationsResponse
    {

        private GetAudioSourceConfigurationsResponseConfigurations configurationsField;

        /// <remarks/>
        public GetAudioSourceConfigurationsResponseConfigurations Configurations
        {
            get
            {
                return this.configurationsField;
            }
            set
            {
                this.configurationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.onvif.org/ver10/media/wsdl")]
    public partial class GetAudioSourceConfigurationsResponseConfigurations
    {

        private string nameField;

        private byte useCountField;

        private byte sourceTokenField;

        private string tokenField;

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


}
