using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets the system level attributes of the Cr Interface.
    /// The response is either a SystemCrInterfaceGetResponse or an ErrorResponse.
    /// <see cref="SystemCrInterfaceGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6896""}]")]
    public class SystemCrInterfaceGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
