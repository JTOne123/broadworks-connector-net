using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the DTMF transmission settings.
    /// The response is either SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8598""}]")]
    public class SystemDTMFTransmissionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.DTMFTransmissionMethod _transmissionMethod;

        [XmlElement(ElementName = "transmissionMethod", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8598")]
        public BroadWorksConnector.Ocip.Models.DTMFTransmissionMethod TransmissionMethod
        {
            get => _transmissionMethod;
            set
            {
                TransmissionMethodSpecified = true;
                _transmissionMethod = value;
            }
        }

        [XmlIgnore]
        protected bool TransmissionMethodSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DtmfTransmissionSignalingContentType _signalingContentType;

        [XmlElement(ElementName = "signalingContentType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8598")]
        public BroadWorksConnector.Ocip.Models.DtmfTransmissionSignalingContentType SignalingContentType
        {
            get => _signalingContentType;
            set
            {
                SignalingContentTypeSpecified = true;
                _signalingContentType = value;
            }
        }

        [XmlIgnore]
        protected bool SignalingContentTypeSpecified { get; set; }

    }
}
