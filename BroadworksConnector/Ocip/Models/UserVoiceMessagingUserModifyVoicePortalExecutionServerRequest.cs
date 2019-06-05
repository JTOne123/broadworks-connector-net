using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVoiceMessagingUserModifyVoicePortalExecutionServerRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _usePersonalizedName;

    [XmlElement(ElementName = "usePersonalizedName", IsNullable = false, Namespace = "")]
    public bool UsePersonalizedName {
        get => _usePersonalizedName;
        set {
            UsePersonalizedNameSpecified = true;
            _usePersonalizedName = value;
        }
    }

    [XmlIgnore]
    public bool UsePersonalizedNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledFileNameResource _personalizedNameAudioFile;

    [XmlElement(ElementName = "personalizedNameAudioFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledFileNameResource PersonalizedNameAudioFile {
        get => _personalizedNameAudioFile;
        set {
            PersonalizedNameAudioFileSpecified = true;
            _personalizedNameAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool PersonalizedNameAudioFileSpecified { get; set; }
}
}
