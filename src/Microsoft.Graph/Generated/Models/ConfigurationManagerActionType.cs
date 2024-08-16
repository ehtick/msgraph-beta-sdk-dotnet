// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Action type on Configuration Manager client</summary>
    public enum ConfigurationManagerActionType
    {
        /// <summary>Refresh machine policy on Configuration Manager client</summary>
        [EnumMember(Value = "refreshMachinePolicy")]
        RefreshMachinePolicy,
        /// <summary>Refresh user policy on Configuration Manager client</summary>
        [EnumMember(Value = "refreshUserPolicy")]
        RefreshUserPolicy,
        /// <summary>Wake up Configuration Manager client</summary>
        [EnumMember(Value = "wakeUpClient")]
        WakeUpClient,
        /// <summary>Evaluation application policy on Configuration Manager client</summary>
        [EnumMember(Value = "appEvaluation")]
        AppEvaluation,
        /// <summary>Evaluation application policy on Configuration Manager client</summary>
        [EnumMember(Value = "quickScan")]
        QuickScan,
        /// <summary>Evaluation application policy on Configuration Manager client</summary>
        [EnumMember(Value = "fullScan")]
        FullScan,
        /// <summary>Evaluation application policy on Configuration Manager client</summary>
        [EnumMember(Value = "windowsDefenderUpdateSignatures")]
        WindowsDefenderUpdateSignatures,
    }
}
