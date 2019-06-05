using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMeetMeConferencingGetResponse17sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _conferenceIdLength;

    [XmlElement(ElementName = "conferenceIdLength", IsNullable = false, Namespace = "")]
    public int ConferenceIdLength {
        get => _conferenceIdLength;
        set {
            ConferenceIdLengthSpecified = true;
            _conferenceIdLength = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceIdLengthSpecified { get; set; }
    private int _moderatorPinLength;

    [XmlElement(ElementName = "moderatorPinLength", IsNullable = false, Namespace = "")]
    public int ModeratorPinLength {
        get => _moderatorPinLength;
        set {
            ModeratorPinLengthSpecified = true;
            _moderatorPinLength = value;
        }
    }

    [XmlIgnore]
    public bool ModeratorPinLengthSpecified { get; set; }
    private bool _enableConferenceEndDateRestriction;

    [XmlElement(ElementName = "enableConferenceEndDateRestriction", IsNullable = false, Namespace = "")]
    public bool EnableConferenceEndDateRestriction {
        get => _enableConferenceEndDateRestriction;
        set {
            EnableConferenceEndDateRestrictionSpecified = true;
            _enableConferenceEndDateRestriction = value;
        }
    }

    [XmlIgnore]
    public bool EnableConferenceEndDateRestrictionSpecified { get; set; }
    private int _conferenceEndDateRestrictionMonths;

    [XmlElement(ElementName = "conferenceEndDateRestrictionMonths", IsNullable = false, Namespace = "")]
    public int ConferenceEndDateRestrictionMonths {
        get => _conferenceEndDateRestrictionMonths;
        set {
            ConferenceEndDateRestrictionMonthsSpecified = true;
            _conferenceEndDateRestrictionMonths = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceEndDateRestrictionMonthsSpecified { get; set; }
    private bool _deleteExpiredConferencesAfterHoldPeriod;

    [XmlElement(ElementName = "deleteExpiredConferencesAfterHoldPeriod", IsNullable = false, Namespace = "")]
    public bool DeleteExpiredConferencesAfterHoldPeriod {
        get => _deleteExpiredConferencesAfterHoldPeriod;
        set {
            DeleteExpiredConferencesAfterHoldPeriodSpecified = true;
            _deleteExpiredConferencesAfterHoldPeriod = value;
        }
    }

    [XmlIgnore]
    public bool DeleteExpiredConferencesAfterHoldPeriodSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MeetMeConferencingExpiredConferenceHoldPeriodDays _expiredConferenceHoldPeriodDays;

    [XmlElement(ElementName = "expiredConferenceHoldPeriodDays", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingExpiredConferenceHoldPeriodDays ExpiredConferenceHoldPeriodDays {
        get => _expiredConferenceHoldPeriodDays;
        set {
            ExpiredConferenceHoldPeriodDaysSpecified = true;
            _expiredConferenceHoldPeriodDays = value;
        }
    }

    [XmlIgnore]
    public bool ExpiredConferenceHoldPeriodDaysSpecified { get; set; }
    private string _recordingWebAppURL;

    [XmlElement(ElementName = "recordingWebAppURL", IsNullable = false, Namespace = "")]
    public string RecordingWebAppURL {
        get => _recordingWebAppURL;
        set {
            RecordingWebAppURLSpecified = true;
            _recordingWebAppURL = value;
        }
    }

    [XmlIgnore]
    public bool RecordingWebAppURLSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MeetMeConferencingRecordingFileFormat _recordingFileFormat;

    [XmlElement(ElementName = "recordingFileFormat", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingRecordingFileFormat RecordingFileFormat {
        get => _recordingFileFormat;
        set {
            RecordingFileFormatSpecified = true;
            _recordingFileFormat = value;
        }
    }

    [XmlIgnore]
    public bool RecordingFileFormatSpecified { get; set; }
}
}
