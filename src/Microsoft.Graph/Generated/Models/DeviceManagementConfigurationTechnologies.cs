// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Describes which technology this setting can be deployed with</summary>
    [Flags]
    public enum DeviceManagementConfigurationTechnologies {
        /// <summary>Default. Setting cannot be deployed through any channel.</summary>
        [EnumMember(Value = "none")]
        None = 1,
        /// <summary>Setting can be deployed through the MDM channel.</summary>
        [EnumMember(Value = "mdm")]
        Mdm = 2,
        /// <summary>Setting can be deployed through the Windows10XManagement channel</summary>
        [EnumMember(Value = "windows10XManagement")]
        Windows10XManagement = 4,
        /// <summary>Setting can be deployed through the ConfigManager channel.</summary>
        [EnumMember(Value = "configManager")]
        ConfigManager = 8,
        /// <summary>Setting can be deployed through the AppleRemoteManagement channel.</summary>
        [EnumMember(Value = "appleRemoteManagement")]
        AppleRemoteManagement = 16,
        /// <summary>Setting can be deployed through the SENSE agent channel.</summary>
        [EnumMember(Value = "microsoftSense")]
        MicrosoftSense = 32,
        /// <summary>Setting can be deployed through the Exchange Online agent channel.</summary>
        [EnumMember(Value = "exchangeOnline")]
        ExchangeOnline = 64,
        /// <summary>Setting can be deployed through the Mobile Application Management (MAM) channel</summary>
        [EnumMember(Value = "mobileApplicationManagement")]
        MobileApplicationManagement = 128,
        /// <summary>Setting can be deployed through the Linux Mdm channel.</summary>
        [EnumMember(Value = "linuxMdm")]
        LinuxMdm = 256,
        /// <summary>Setting can be deployed through device enrollment.</summary>
        [EnumMember(Value = "enrollment")]
        Enrollment = 512,
        /// <summary>Setting can be deployed using the Endpoint privilege management channel</summary>
        [EnumMember(Value = "endpointPrivilegeManagement")]
        EndpointPrivilegeManagement = 1024,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 2048,
    }
}
