using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderGroupPagingTargetsCapacityModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private int _maximumTargetUsers;

    [XmlElement(ElementName = "maximumTargetUsers", IsNullable = false, Namespace = "")]
    public int MaximumTargetUsers {
        get => _maximumTargetUsers;
        set {
            MaximumTargetUsersSpecified = true;
            _maximumTargetUsers = value;
        }
    }

    [XmlIgnore]
    public bool MaximumTargetUsersSpecified { get; set; }
}
}
