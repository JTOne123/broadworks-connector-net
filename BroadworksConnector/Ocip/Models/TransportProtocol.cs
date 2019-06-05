using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TransportProtocol{
    [XmlEnum(Name = "UDP")]
    UDP,
    [XmlEnum(Name = "TCP")]
    TCP,
    [XmlEnum(Name = "Unspecified")]
    Unspecified,
 }
}
