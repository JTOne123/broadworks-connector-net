using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SystemUserCallingLineIdSelection{
    [XmlEnum(Name = "Disable All")]
    DisableAll,
    [XmlEnum(Name = "Enable All")]
    EnableAll,
    [XmlEnum(Name = "Enable All Except Emergency")]
    EnableAllExceptEmergency,
    [XmlEnum(Name = "Enable Emergency Only")]
    EnableEmergencyOnly,
 }
}
