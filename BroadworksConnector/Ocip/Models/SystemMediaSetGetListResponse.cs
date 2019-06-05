using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaSetGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _mediaSetName;

    [XmlElement(ElementName = "mediaSetName", IsNullable = false, Namespace = "")]
    public List<string> MediaSetName {
        get => _mediaSetName;
        set {
            MediaSetNameSpecified = true;
            _mediaSetName = value;
        }
    }

    [XmlIgnore]
    public bool MediaSetNameSpecified { get; set; }
}
}
