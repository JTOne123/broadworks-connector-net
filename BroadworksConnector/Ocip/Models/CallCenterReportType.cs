using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportType
    {
        [XmlEnum(Name = "Agent")]
        Agent,
        [XmlEnum(Name = "Call Center Dnis")]
        CallCenterDnis,
        [XmlEnum(Name = "Call Center")]
        CallCenter,
    }
}
