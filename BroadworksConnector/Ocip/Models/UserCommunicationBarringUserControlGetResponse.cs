using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCommunicationBarringUserControlGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _lockoutStatus;

    [XmlElement(ElementName = "lockoutStatus", IsNullable = false, Namespace = "")]
    public bool LockoutStatus {
        get => _lockoutStatus;
        set {
            LockoutStatusSpecified = true;
            _lockoutStatus = value;
        }
    }

    [XmlIgnore]
    public bool LockoutStatusSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _profileTable;

    [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ProfileTable {
        get => _profileTable;
        set {
            ProfileTableSpecified = true;
            _profileTable = value;
        }
    }

    [XmlIgnore]
    public bool ProfileTableSpecified { get; set; }
}
}
