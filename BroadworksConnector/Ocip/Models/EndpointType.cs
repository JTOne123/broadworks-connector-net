using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Types of Endpoints in Broadworks.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EndpointType
    {
        [XmlEnum(Name = "Primary")]
        Primary,
        [XmlEnum(Name = "Shared Call Appearance")]
        SharedCallAppearance,
        [XmlEnum(Name = "Video Add On")]
        VideoAddOn,
        [XmlEnum(Name = "Public Service Identity")]
        PublicServiceIdentity,
        [XmlEnum(Name = "Music On Hold Internal")]
        MusicOnHoldInternal,
        [XmlEnum(Name = "Flexible Seating Guest")]
        FlexibleSeatingGuest,
    }
}
