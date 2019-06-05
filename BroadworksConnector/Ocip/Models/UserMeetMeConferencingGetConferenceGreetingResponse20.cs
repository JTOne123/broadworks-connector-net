using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingGetConferenceGreetingResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _playEntranceGreeting;

    [XmlElement(ElementName = "playEntranceGreeting", IsNullable = false, Namespace = "")]
    public bool PlayEntranceGreeting {
        get => _playEntranceGreeting;
        set {
            PlayEntranceGreetingSpecified = true;
            _playEntranceGreeting = value;
        }
    }

    [XmlIgnore]
    public bool PlayEntranceGreetingSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AnnouncementFileKey _entranceGreetingFile;

    [XmlElement(ElementName = "entranceGreetingFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey EntranceGreetingFile {
        get => _entranceGreetingFile;
        set {
            EntranceGreetingFileSpecified = true;
            _entranceGreetingFile = value;
        }
    }

    [XmlIgnore]
    public bool EntranceGreetingFileSpecified { get; set; }
}
}
