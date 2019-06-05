using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierGetGroupListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _carrier;

    [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
    public string Carrier {
        get => _carrier;
        set {
            CarrierSpecified = true;
            _carrier = value;
        }
    }

    [XmlIgnore]
    public bool CarrierSpecified { get; set; }
    private int _responseSizeLimit;

    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
    public int ResponseSizeLimit {
        get => _responseSizeLimit;
        set {
            ResponseSizeLimitSpecified = true;
            _responseSizeLimit = value;
        }
    }

    [XmlIgnore]
    public bool ResponseSizeLimitSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId;

    [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId {
        get => _searchCriteriaGroupId;
        set {
            SearchCriteriaGroupIdSpecified = true;
            _searchCriteriaGroupId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupIdSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupName> _searchCriteriaGroupName;

    [XmlElement(ElementName = "searchCriteriaGroupName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupName> SearchCriteriaGroupName {
        get => _searchCriteriaGroupName;
        set {
            SearchCriteriaGroupNameSpecified = true;
            _searchCriteriaGroupName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaExactServiceProvider> _searchCriteriaExactServiceProvider;

    [XmlElement(ElementName = "searchCriteriaExactServiceProvider", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExactServiceProvider> SearchCriteriaExactServiceProvider {
        get => _searchCriteriaExactServiceProvider;
        set {
            SearchCriteriaExactServiceProviderSpecified = true;
            _searchCriteriaExactServiceProvider = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactServiceProviderSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId;

    [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId {
        get => _searchCriteriaServiceProviderId;
        set {
            SearchCriteriaServiceProviderIdSpecified = true;
            _searchCriteriaServiceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaServiceProviderIdSpecified { get; set; }
}
}
