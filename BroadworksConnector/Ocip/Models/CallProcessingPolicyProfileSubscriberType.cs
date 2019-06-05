using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallProcessingPolicyProfileSubscriberType
    {
        [XmlEnum(Name = "User")]
        User,
        [XmlEnum(Name = "Trunk Group Pilot User")]
        TrunkGroupPilotUser,
        [XmlEnum(Name = "Auto Attendant")]
        AutoAttendant,
        [XmlEnum(Name = "BroadWorks Anywhere")]
        BroadWorksAnywhere,
        [XmlEnum(Name = "Call Center")]
        CallCenter,
        [XmlEnum(Name = "Find-me/Follow-me")]
        FindmeFollowme,
        [XmlEnum(Name = "Group Paging")]
        GroupPaging,
        [XmlEnum(Name = "Hunt Group")]
        HuntGroup,
        [XmlEnum(Name = "Instant Group Call")]
        InstantGroupCall,
        [XmlEnum(Name = "Meet-Me Conferencing")]
        MeetMeConferencing,
        [XmlEnum(Name = "Route Point")]
        RoutePoint,
        [XmlEnum(Name = "Voice Portal")]
        VoicePortal,
        [XmlEnum(Name = "VoiceXML")]
        VoiceXML,
    }
}
