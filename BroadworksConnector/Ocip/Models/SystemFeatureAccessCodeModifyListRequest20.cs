using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFeatureAccessCodeModifyListRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadworksConnector.Ocip.Models.FeatureAccessCodeEntry> _featureAccessCode;

    [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.FeatureAccessCodeEntry> FeatureAccessCode {
        get => _featureAccessCode;
        set {
            FeatureAccessCodeSpecified = true;
            _featureAccessCode = value;
        }
    }

    [XmlIgnore]
    public bool FeatureAccessCodeSpecified { get; set; }
}
}
