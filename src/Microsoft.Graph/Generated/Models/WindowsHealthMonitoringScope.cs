// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Device health monitoring scope</summary>
    [Flags]
    public enum WindowsHealthMonitoringScope
    {
        /// <summary>Undefined</summary>
        [EnumMember(Value = "undefined")]
        Undefined = 1,
        /// <summary>Basic events for windows device health monitoring</summary>
        [EnumMember(Value = "healthMonitoring")]
        HealthMonitoring = 2,
        /// <summary>Boot performance events</summary>
        [EnumMember(Value = "bootPerformance")]
        BootPerformance = 4,
        /// <summary>Windows updates events</summary>
        [EnumMember(Value = "windowsUpdates")]
        WindowsUpdates = 8,
        /// <summary>PrivilegeManagement</summary>
        [EnumMember(Value = "privilegeManagement")]
        PrivilegeManagement = 16,
    }
}
