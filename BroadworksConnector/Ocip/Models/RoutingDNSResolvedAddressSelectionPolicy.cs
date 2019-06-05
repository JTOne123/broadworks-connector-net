using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum RoutingDNSResolvedAddressSelectionPolicy{
    [XmlEnum(Name = "Standard")]
    Standard,
    [XmlEnum(Name = "Load Balanced")]
    LoadBalanced,
    [XmlEnum(Name = "Stateful")]
    Stateful,
 }
}
