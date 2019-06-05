using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointGetAnnouncementResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead17 _mediaOnHoldSource;

    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead17 MediaOnHoldSource {
        get => _mediaOnHoldSource;
        set {
            MediaOnHoldSourceSpecified = true;
            _mediaOnHoldSource = value;
        }
    }

    [XmlIgnore]
    public bool MediaOnHoldSourceSpecified { get; set; }
}
}
