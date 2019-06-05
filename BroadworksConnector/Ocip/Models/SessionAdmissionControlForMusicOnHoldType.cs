using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SessionAdmissionControlForMusicOnHoldType{
    [XmlEnum(Name = "Do Not Play")]
    DoNotPlay,
    [XmlEnum(Name = "Play And Count")]
    PlayAndCount,
 }
}
