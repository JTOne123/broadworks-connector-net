using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRoutingAddRouteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _routeName;

    [XmlElement(ElementName = "routeName", IsNullable = false, Namespace = "")]
    public string RouteName {
        get => _routeName;
        set {
            RouteNameSpecified = true;
            _routeName = value;
        }
    }

    [XmlIgnore]
    public bool RouteNameSpecified { get; set; }
}
}
