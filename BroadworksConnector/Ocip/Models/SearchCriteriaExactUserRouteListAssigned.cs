using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactUserRouteListAssigned : BroadworksConnector.Ocip.Models.SearchCriteria
{
    private bool _routeListAssigned;

    [XmlElement(ElementName = "routeListAssigned", IsNullable = false, Namespace = "")]
    public bool RouteListAssigned {
        get => _routeListAssigned;
        set {
            RouteListAssignedSpecified = true;
            _routeListAssigned = value;
        }
    }

    [XmlIgnore]
    public bool RouteListAssignedSpecified { get; set; }
}
}
