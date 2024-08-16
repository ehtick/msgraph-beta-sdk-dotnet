// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Contains properties for Windows architecture.</summary>
    [Flags]
    public enum WindowsArchitecture
    {
        /// <summary>No flags set.</summary>
        [EnumMember(Value = "none")]
        None = 1,
        /// <summary>Whether or not the X86 Windows architecture type is supported.</summary>
        [EnumMember(Value = "x86")]
        X86 = 2,
        /// <summary>Whether or not the X64 Windows architecture type is supported.</summary>
        [EnumMember(Value = "x64")]
        X64 = 4,
        /// <summary>Whether or not the Arm Windows architecture type is supported.</summary>
        [EnumMember(Value = "arm")]
        Arm = 8,
        /// <summary>Whether or not the Neutral Windows architecture type is supported.</summary>
        [EnumMember(Value = "neutral")]
        Neutral = 16,
        /// <summary>Whether or not the Arm64 Windows architecture type is supported.</summary>
        [EnumMember(Value = "arm64")]
        Arm64 = 32,
    }
}
