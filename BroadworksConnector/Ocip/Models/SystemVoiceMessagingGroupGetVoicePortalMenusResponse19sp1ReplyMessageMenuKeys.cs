using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:32308""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ReplyMessageMenuKeys
    {

        private string _sendReplyToCaller;

        [XmlElement(ElementName = "sendReplyToCaller", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32308")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SendReplyToCaller
        {
            get => _sendReplyToCaller;
            set
            {
                SendReplyToCallerSpecified = true;
                _sendReplyToCaller = value;
            }
        }

        [XmlIgnore]
        protected bool SendReplyToCallerSpecified { get; set; }

        private string _changeCurrentReply;

        [XmlElement(ElementName = "changeCurrentReply", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32308")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ChangeCurrentReply
        {
            get => _changeCurrentReply;
            set
            {
                ChangeCurrentReplySpecified = true;
                _changeCurrentReply = value;
            }
        }

        [XmlIgnore]
        protected bool ChangeCurrentReplySpecified { get; set; }

        private string _listenToCurrentReply;

        [XmlElement(ElementName = "listenToCurrentReply", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32308")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ListenToCurrentReply
        {
            get => _listenToCurrentReply;
            set
            {
                ListenToCurrentReplySpecified = true;
                _listenToCurrentReply = value;
            }
        }

        [XmlIgnore]
        protected bool ListenToCurrentReplySpecified { get; set; }

        private string _setOrClearUrgentIndicator;

        [XmlElement(ElementName = "setOrClearUrgentIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32308")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetOrClearUrgentIndicator
        {
            get => _setOrClearUrgentIndicator;
            set
            {
                SetOrClearUrgentIndicatorSpecified = true;
                _setOrClearUrgentIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool SetOrClearUrgentIndicatorSpecified { get; set; }

        private string _setOrClearConfidentialIndicator;

        [XmlElement(ElementName = "setOrClearConfidentialIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32308")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string SetOrClearConfidentialIndicator
        {
            get => _setOrClearConfidentialIndicator;
            set
            {
                SetOrClearConfidentialIndicatorSpecified = true;
                _setOrClearConfidentialIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool SetOrClearConfidentialIndicatorSpecified { get; set; }

        private string _returnToPreviousMenu;

        [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32308")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ReturnToPreviousMenu
        {
            get => _returnToPreviousMenu;
            set
            {
                ReturnToPreviousMenuSpecified = true;
                _returnToPreviousMenu = value;
            }
        }

        [XmlIgnore]
        protected bool ReturnToPreviousMenuSpecified { get; set; }

        private string _repeatMenu;

        [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32308")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string RepeatMenu
        {
            get => _repeatMenu;
            set
            {
                RepeatMenuSpecified = true;
                _repeatMenu = value;
            }
        }

        [XmlIgnore]
        protected bool RepeatMenuSpecified { get; set; }

    }
}
