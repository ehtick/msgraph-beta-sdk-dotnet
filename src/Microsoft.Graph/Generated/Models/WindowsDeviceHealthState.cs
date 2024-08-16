// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Computer endpoint protection state</summary>
    [Flags]
    public enum WindowsDeviceHealthState
    {
        /// <summary>Computer is clean and no action is required</summary>
        [EnumMember(Value = "clean")]
        Clean = 1,
        /// <summary>Computer is in pending full scan state</summary>
        [EnumMember(Value = "fullScanPending")]
        FullScanPending = 2,
        /// <summary>Computer is in pending reboot state</summary>
        [EnumMember(Value = "rebootPending")]
        RebootPending = 4,
        /// <summary>Computer is in pending manual steps state</summary>
        [EnumMember(Value = "manualStepsPending")]
        ManualStepsPending = 8,
        /// <summary>Computer is in pending offline scan state</summary>
        [EnumMember(Value = "offlineScanPending")]
        OfflineScanPending = 16,
        /// <summary>Computer is in critical failure state</summary>
        [EnumMember(Value = "critical")]
        Critical = 32,
    }
}
