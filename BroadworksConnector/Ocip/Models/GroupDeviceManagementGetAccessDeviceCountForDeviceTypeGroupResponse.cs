using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDeviceManagementGetAccessDeviceCountForDeviceTypeGroupResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _accessDeviceCount;

    [XmlElement(ElementName = "accessDeviceCount", IsNullable = false, Namespace = "")]
    public int AccessDeviceCount {
        get => _accessDeviceCount;
        set {
            AccessDeviceCountSpecified = true;
            _accessDeviceCount = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceCountSpecified { get; set; }
}
}
