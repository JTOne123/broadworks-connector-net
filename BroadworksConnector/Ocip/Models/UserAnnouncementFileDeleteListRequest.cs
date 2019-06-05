using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileDeleteListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.AnnouncementFileKey> _announcementFileKey;

    [XmlElement(ElementName = "announcementFileKey", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.AnnouncementFileKey> AnnouncementFileKey {
        get => _announcementFileKey;
        set {
            AnnouncementFileKeySpecified = true;
            _announcementFileKey = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementFileKeySpecified { get; set; }
}
}
