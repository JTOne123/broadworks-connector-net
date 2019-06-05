using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemZoneNetAddressGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _zoneName;

    [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
    public string ZoneName {
        get => _zoneName;
        set {
            ZoneNameSpecified = true;
            _zoneName = value;
        }
    }

    [XmlIgnore]
    public bool ZoneNameSpecified { get; set; }
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaZoneIPAddress> _searchCriteriaZoneIPAddress;

    [XmlElement(ElementName = "searchCriteriaZoneIPAddress", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaZoneIPAddress> SearchCriteriaZoneIPAddress {
        get => _searchCriteriaZoneIPAddress;
        set {
            SearchCriteriaZoneIPAddressSpecified = true;
            _searchCriteriaZoneIPAddress = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaZoneIPAddressSpecified { get; set; }
}
}
