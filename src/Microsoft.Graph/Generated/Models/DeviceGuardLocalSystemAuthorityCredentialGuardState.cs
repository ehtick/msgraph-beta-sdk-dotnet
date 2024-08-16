// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public enum DeviceGuardLocalSystemAuthorityCredentialGuardState
    #pragma warning restore CS1591
    {
        /// <summary>Running</summary>
        [EnumMember(Value = "running")]
        Running,
        /// <summary>Reboot required</summary>
        [EnumMember(Value = "rebootRequired")]
        RebootRequired,
        /// <summary>Not licensed for Credential Guard</summary>
        [EnumMember(Value = "notLicensed")]
        NotLicensed,
        /// <summary>Not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Virtualization Based security is not running</summary>
        [EnumMember(Value = "virtualizationBasedSecurityNotRunning")]
        VirtualizationBasedSecurityNotRunning,
    }
}
