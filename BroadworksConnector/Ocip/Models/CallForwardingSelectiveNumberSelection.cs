using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallForwardingSelectiveNumberSelection
    {
        [XmlEnum(Name = "Forward To Default Number")]
        ForwardToDefaultNumber,
        [XmlEnum(Name = "Forward To Specified Number")]
        ForwardToSpecifiedNumber,
    }
}
