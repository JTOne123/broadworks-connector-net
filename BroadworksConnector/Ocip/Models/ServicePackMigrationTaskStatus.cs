using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServicePackMigrationTaskStatus{
    [XmlEnum(Name = "Awaiting Edits")]
    AwaitingEdits,
    [XmlEnum(Name = "Pending")]
    Pending,
    [XmlEnum(Name = "Processing")]
    Processing,
    [XmlEnum(Name = "Terminating")]
    Terminating,
    [XmlEnum(Name = "Terminated")]
    Terminated,
    [XmlEnum(Name = "Stopped By System")]
    StoppedBySystem,
    [XmlEnum(Name = "Completed")]
    Completed,
 }
}
