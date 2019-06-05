using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAlternateUserIdModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _alternateUserId;

    [XmlElement(ElementName = "alternateUserId", IsNullable = false, Namespace = "")]
    public string AlternateUserId {
        get => _alternateUserId;
        set {
            AlternateUserIdSpecified = true;
            _alternateUserId = value;
        }
    }

    [XmlIgnore]
    public bool AlternateUserIdSpecified { get; set; }
    private string _newAlternateUserId;

    [XmlElement(ElementName = "newAlternateUserId", IsNullable = false, Namespace = "")]
    public string NewAlternateUserId {
        get => _newAlternateUserId;
        set {
            NewAlternateUserIdSpecified = true;
            _newAlternateUserId = value;
        }
    }

    [XmlIgnore]
    public bool NewAlternateUserIdSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
}
}
