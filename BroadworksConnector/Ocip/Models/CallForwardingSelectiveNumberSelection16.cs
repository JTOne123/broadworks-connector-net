using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Forward to Number Selection.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallForwardingSelectiveNumberSelection16
    {
        [XmlEnum(Name = "Forward To Default Number")]
        ForwardToDefaultNumber,
        [XmlEnum(Name = "Forward To Specified Number")]
        ForwardToSpecifiedNumber,
        [XmlEnum(Name = "Do not forward")]
        Donotforward,
    }
}
