using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum IncomingCallToUserAliasMode{
    [XmlEnum(Name = "Enabled")]
    Enabled,
    [XmlEnum(Name = "ExplicitAlias")]
    ExplicitAlias,
    [XmlEnum(Name = "Disabled")]
    Disabled,
 }
}
