using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CommunicationBarringCallMeNowAction
    {
        [XmlEnum(Name = "Allow")]
        Allow,
        [XmlEnum(Name = "Allow Timed")]
        AllowTimed,
        [XmlEnum(Name = "Block")]
        Block,
    }
}
