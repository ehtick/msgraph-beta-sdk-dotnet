// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public enum WindowsAutopilotProfileAssignmentStatus
    #pragma warning restore CS1591
    {
        /// <summary>Unknown assignment status</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Assigned successfully in Intune and in sync with Windows auto pilot program</summary>
        [EnumMember(Value = "assignedInSync")]
        AssignedInSync,
        /// <summary>Assigned successfully in Intune and not in sync with Windows auto pilot program</summary>
        [EnumMember(Value = "assignedOutOfSync")]
        AssignedOutOfSync,
        /// <summary>Assigned successfully in Intune and either in-sync or out of sync with Windows auto pilot program</summary>
        [EnumMember(Value = "assignedUnkownSyncState")]
        AssignedUnkownSyncState,
        /// <summary>Not assigned</summary>
        [EnumMember(Value = "notAssigned")]
        NotAssigned,
        /// <summary>Pending assignment</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary> Assignment failed</summary>
        [EnumMember(Value = "failed")]
        Failed,
    }
}
