using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceManagementFileCustomization
    {
        [XmlEnum(Name = "Disallow")]
        Disallow,
        [XmlEnum(Name = "Administrator")]
        Administrator,
        [XmlEnum(Name = "Administrator and User")]
        AdministratorandUser,
    }
}
