using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserServiceGetAssignmentListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _servicePacksAssignmentTable;

    [XmlElement(ElementName = "servicePacksAssignmentTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ServicePacksAssignmentTable {
        get => _servicePacksAssignmentTable;
        set {
            ServicePacksAssignmentTableSpecified = true;
            _servicePacksAssignmentTable = value;
        }
    }

    [XmlIgnore]
    public bool ServicePacksAssignmentTableSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _userServicesAssignmentTable;

    [XmlElement(ElementName = "userServicesAssignmentTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable UserServicesAssignmentTable {
        get => _userServicesAssignmentTable;
        set {
            UserServicesAssignmentTableSpecified = true;
            _userServicesAssignmentTable = value;
        }
    }

    [XmlIgnore]
    public bool UserServicesAssignmentTableSpecified { get; set; }
}
}
