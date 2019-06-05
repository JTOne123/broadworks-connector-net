using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSimultaneousRingPersonalGetPhoneNumberResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _answerConfirmationRequired;

    [XmlElement(ElementName = "answerConfirmationRequired", IsNullable = false, Namespace = "")]
    public bool AnswerConfirmationRequired {
        get => _answerConfirmationRequired;
        set {
            AnswerConfirmationRequiredSpecified = true;
            _answerConfirmationRequired = value;
        }
    }

    [XmlIgnore]
    public bool AnswerConfirmationRequiredSpecified { get; set; }
}
}
