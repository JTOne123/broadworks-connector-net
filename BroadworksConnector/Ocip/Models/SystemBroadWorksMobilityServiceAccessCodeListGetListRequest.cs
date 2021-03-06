using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of Service Access Code lists.
    /// The response is either SystemBroadWorksMobilityServiceAccessCodeListGetListResponse or ErrorResponse.
    /// <see cref="SystemBroadWorksMobilityServiceAccessCodeListGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f7ae3539fd471e995b07dc1bf8836e2d:1137""}]")]
    public class SystemBroadWorksMobilityServiceAccessCodeListGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
