using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnhancedCallLogsRedirectedCallSelection
    {
        private bool _redirectedCall;

        [XmlElement(ElementName = "redirectedCall", IsNullable = false, Namespace = "")]
        public bool RedirectedCall
        {
            get => _redirectedCall;
            set
            {
                RedirectedCallSpecified = true;
                _redirectedCall = value;
            }
        }

        [XmlIgnore]
        public bool RedirectedCallSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.ServiceInvocationDisposition> _redirectType;

        [XmlElement(ElementName = "redirectType", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.ServiceInvocationDisposition> RedirectType
        {
            get => _redirectType;
            set
            {
                RedirectTypeSpecified = true;
                _redirectType = value;
            }
        }

        [XmlIgnore]
        public bool RedirectTypeSpecified { get; set; }
    }
}
