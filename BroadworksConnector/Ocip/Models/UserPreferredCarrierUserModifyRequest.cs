using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPreferredCarrierUserModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.UserPreferredCarrierNameModify _intraLataCarrier;

    [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UserPreferredCarrierNameModify IntraLataCarrier {
        get => _intraLataCarrier;
        set {
            IntraLataCarrierSpecified = true;
            _intraLataCarrier = value;
        }
    }

    [XmlIgnore]
    public bool IntraLataCarrierSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.UserPreferredCarrierNameModify _interLataCarrier;

    [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UserPreferredCarrierNameModify InterLataCarrier {
        get => _interLataCarrier;
        set {
            InterLataCarrierSpecified = true;
            _interLataCarrier = value;
        }
    }

    [XmlIgnore]
    public bool InterLataCarrierSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.UserPreferredCarrierNameModify _internationalCarrier;

    [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UserPreferredCarrierNameModify InternationalCarrier {
        get => _internationalCarrier;
        set {
            InternationalCarrierSpecified = true;
            _internationalCarrier = value;
        }
    }

    [XmlIgnore]
    public bool InternationalCarrierSpecified { get; set; }
}
}
