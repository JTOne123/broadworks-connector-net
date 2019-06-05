using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFindMeFollowMeGetAlertingGroupRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private string _alertingGroupName;

    [XmlElement(ElementName = "alertingGroupName", IsNullable = false, Namespace = "")]
    public string AlertingGroupName {
        get => _alertingGroupName;
        set {
            AlertingGroupNameSpecified = true;
            _alertingGroupName = value;
        }
    }

    [XmlIgnore]
    public bool AlertingGroupNameSpecified { get; set; }
}
}
