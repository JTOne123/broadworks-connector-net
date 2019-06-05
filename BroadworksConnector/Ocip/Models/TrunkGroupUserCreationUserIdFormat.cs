using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupUserCreationUserIdFormat{
    [XmlEnum(Name = "Extension")]
    Extension,
    [XmlEnum(Name = "National DN")]
    NationalDN,
    [XmlEnum(Name = "E164 Format No Plus")]
    E164FormatNoPlus,
 }
}
