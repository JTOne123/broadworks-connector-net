using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the conference delegates for this conference.
    /// The response is either UserMeetMeConferencingGetConferenceDelegateListResponse or ErrorResponse.
    /// <see cref="UserMeetMeConferencingGetConferenceDelegateListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:718""}]")]
    public class UserMeetMeConferencingGetConferenceDelegateListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:718")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceKey _conferenceKey;

        [XmlElement(ElementName = "conferenceKey", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:718")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceKey ConferenceKey
        {
            get => _conferenceKey;
            set
            {
                ConferenceKeySpecified = true;
                _conferenceKey = value;
            }
        }

        [XmlIgnore]
        protected bool ConferenceKeySpecified { get; set; }

    }
}
