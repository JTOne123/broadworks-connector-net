using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _availableMobileSubscriberDirectoryNumber;

    [XmlElement(ElementName = "availableMobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
    public List<string> AvailableMobileSubscriberDirectoryNumber {
        get => _availableMobileSubscriberDirectoryNumber;
        set {
            AvailableMobileSubscriberDirectoryNumberSpecified = true;
            _availableMobileSubscriberDirectoryNumber = value;
        }
    }

    [XmlIgnore]
    public bool AvailableMobileSubscriberDirectoryNumberSpecified { get; set; }
}
}
