using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAnswerConfirmationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.AnswerConfirmationAnnouncementSelection _announcementMessageSelection;

    [XmlElement(ElementName = "announcementMessageSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnswerConfirmationAnnouncementSelection AnnouncementMessageSelection {
        get => _announcementMessageSelection;
        set {
            AnnouncementMessageSelectionSpecified = true;
            _announcementMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementMessageSelectionSpecified { get; set; }
    private string _confirmationMessageAudioFileDescription;

    [XmlElement(ElementName = "confirmationMessageAudioFileDescription", IsNullable = false, Namespace = "")]
    public string ConfirmationMessageAudioFileDescription {
        get => _confirmationMessageAudioFileDescription;
        set {
            ConfirmationMessageAudioFileDescriptionSpecified = true;
            _confirmationMessageAudioFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool ConfirmationMessageAudioFileDescriptionSpecified { get; set; }
    private int _confirmationTimoutSeconds;

    [XmlElement(ElementName = "confirmationTimoutSeconds", IsNullable = false, Namespace = "")]
    public int ConfirmationTimoutSeconds {
        get => _confirmationTimoutSeconds;
        set {
            ConfirmationTimoutSecondsSpecified = true;
            _confirmationTimoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool ConfirmationTimoutSecondsSpecified { get; set; }
}
}
