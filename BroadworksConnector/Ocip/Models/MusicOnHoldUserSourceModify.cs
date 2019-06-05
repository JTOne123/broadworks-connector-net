using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldUserSourceModify 
{
    private BroadworksConnector.Ocip.Models.MusicOnHoldUserMessageSelection _messageSourceSelection;

    [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MusicOnHoldUserMessageSelection MessageSourceSelection {
        get => _messageSourceSelection;
        set {
            MessageSourceSelectionSpecified = true;
            _messageSourceSelection = value;
        }
    }

    [XmlIgnore]
    public bool MessageSourceSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MusicOnHoldUserSourceModifyCustomSource _customSource;

    [XmlElement(ElementName = "customSource", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MusicOnHoldUserSourceModifyCustomSource CustomSource {
        get => _customSource;
        set {
            CustomSourceSpecified = true;
            _customSource = value;
        }
    }

    [XmlIgnore]
    public bool CustomSourceSpecified { get; set; }
}
}
