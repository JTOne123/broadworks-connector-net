using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Communication Barring Incoming Rules that replaces a
    /// previously configured list. By convention, an element of this type
    /// may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3232""}]")]
    public class ReplacementCommunicationBarringIncomingRuleList19sp1
    {

        private List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1> _rule = new List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1>();

        [XmlElement(ElementName = "rule", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3232")]
        public List<BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingRule19sp1> Rule
        {
            get => _rule;
            set
            {
                RuleSpecified = true;
                _rule = value;
            }
        }

        [XmlIgnore]
        protected bool RuleSpecified { get; set; }

    }
}
