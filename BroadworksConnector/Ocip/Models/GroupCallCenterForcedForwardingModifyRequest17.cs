using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterForcedForwardingModifyRequest17 : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        private string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = true, Namespace = "")]
        public string ForwardToPhoneNumber
        {
            get => _forwardToPhoneNumber;
            set
            {
                ForwardToPhoneNumberSpecified = true;
                _forwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool ForwardToPhoneNumberSpecified { get; set; }
        private bool _allowEnableViaFAC;

        [XmlElement(ElementName = "allowEnableViaFAC", IsNullable = false, Namespace = "")]
        public bool AllowEnableViaFAC
        {
            get => _allowEnableViaFAC;
            set
            {
                AllowEnableViaFACSpecified = true;
                _allowEnableViaFAC = value;
            }
        }

        [XmlIgnore]
        public bool AllowEnableViaFACSpecified { get; set; }
        private bool _playAnnouncementBeforeForwarding;

        [XmlElement(ElementName = "playAnnouncementBeforeForwarding", IsNullable = false, Namespace = "")]
        public bool PlayAnnouncementBeforeForwarding
        {
            get => _playAnnouncementBeforeForwarding;
            set
            {
                PlayAnnouncementBeforeForwardingSpecified = true;
                _playAnnouncementBeforeForwarding = value;
            }
        }

        [XmlIgnore]
        public bool PlayAnnouncementBeforeForwardingSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

        [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection
        {
            get => _audioMessageSelection;
            set
            {
                AudioMessageSelectionSpecified = true;
                _audioMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool AudioMessageSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _audioUrlList;

        [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify AudioUrlList
        {
            get => _audioUrlList;
            set
            {
                AudioUrlListSpecified = true;
                _audioUrlList = value;
            }
        }

        [XmlIgnore]
        public bool AudioUrlListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _audioFileList;

        [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify AudioFileList
        {
            get => _audioFileList;
            set
            {
                AudioFileListSpecified = true;
                _audioFileList = value;
            }
        }

        [XmlIgnore]
        public bool AudioFileListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

        [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection
        {
            get => _videoMessageSelection;
            set
            {
                VideoMessageSelectionSpecified = true;
                _videoMessageSelection = value;
            }
        }

        [XmlIgnore]
        public bool VideoMessageSelectionSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _videoUrlList;

        [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify VideoUrlList
        {
            get => _videoUrlList;
            set
            {
                VideoUrlListSpecified = true;
                _videoUrlList = value;
            }
        }

        [XmlIgnore]
        public bool VideoUrlListSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify _videoFileList;

        [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify VideoFileList
        {
            get => _videoFileList;
            set
            {
                VideoFileListSpecified = true;
                _videoFileList = value;
            }
        }

        [XmlIgnore]
        public bool VideoFileListSpecified { get; set; }
    }
}
