using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21GreetingOnlyForwardingDestinationMenuKeys 
{
    private string _greetingOnlyForwardingDestination;

    [XmlElement(ElementName = "greetingOnlyForwardingDestination", IsNullable = false, Namespace = "")]
    public string GreetingOnlyForwardingDestination {
        get => _greetingOnlyForwardingDestination;
        set {
            GreetingOnlyForwardingDestinationSpecified = true;
            _greetingOnlyForwardingDestination = value;
        }
    }

    [XmlIgnore]
    public bool GreetingOnlyForwardingDestinationSpecified { get; set; }
}
}
