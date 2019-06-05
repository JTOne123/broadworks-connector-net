using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserResourcePriorityModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _useDefaultResourcePriority;

    [XmlElement(ElementName = "useDefaultResourcePriority", IsNullable = false, Namespace = "")]
    public bool UseDefaultResourcePriority {
        get => _useDefaultResourcePriority;
        set {
            UseDefaultResourcePrioritySpecified = true;
            _useDefaultResourcePriority = value;
        }
    }

    [XmlIgnore]
    public bool UseDefaultResourcePrioritySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ResourcePriorityValue _userResourcePriority;

    [XmlElement(ElementName = "userResourcePriority", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ResourcePriorityValue UserResourcePriority {
        get => _userResourcePriority;
        set {
            UserResourcePrioritySpecified = true;
            _userResourcePriority = value;
        }
    }

    [XmlIgnore]
    public bool UserResourcePrioritySpecified { get; set; }
}
}
