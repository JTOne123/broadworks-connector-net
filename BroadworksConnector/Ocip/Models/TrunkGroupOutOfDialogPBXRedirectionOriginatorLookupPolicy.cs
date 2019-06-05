using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupOutOfDialogPBXRedirectionOriginatorLookupPolicy{
    [XmlEnum(Name = "Asserted")]
    Asserted,
    [XmlEnum(Name = "Presentation")]
    Presentation,
    [XmlEnum(Name = "Asserted Or Presentation")]
    AssertedOrPresentation,
 }
}
