using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class AutoAttendantKeyConfiguration19
    {
        private BroadworksConnector.Ocip.Models.AutoAttendantMenuKey _key;

        [XmlElement(ElementName = "key", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AutoAttendantMenuKey Key
        {
            get => _key;
            set
            {
                KeySpecified = true;
                _key = value;
            }
        }

        [XmlIgnore]
        public bool KeySpecified { get; set; }
        private BroadworksConnector.Ocip.Models.AutoAttendantKeyConfigurationEntry19 _entry;

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.AutoAttendantKeyConfigurationEntry19 Entry
        {
            get => _entry;
            set
            {
                EntrySpecified = true;
                _entry = value;
            }
        }

        [XmlIgnore]
        public bool EntrySpecified { get; set; }
    }
}
