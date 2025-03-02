// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum IosUpdatesInstallStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum IosUpdatesInstallStatus
    {
    
        /// <summary>
        /// Update Scan Failed
        /// </summary>
        UpdateScanFailed = -2016324062,
	
        /// <summary>
        /// Device Os Higher Than Desired Os Version
        /// </summary>
        DeviceOsHigherThanDesiredOsVersion = -2016330696,
	
        /// <summary>
        /// Update Error
        /// </summary>
        UpdateError = -2016330697,
	
        /// <summary>
        /// Shared Device User Logged In Error
        /// </summary>
        SharedDeviceUserLoggedInError = -2016330699,
	
        /// <summary>
        /// Not Supported Operation
        /// </summary>
        NotSupportedOperation = -2016330701,
	
        /// <summary>
        /// Install Failed
        /// </summary>
        InstallFailed = -2016330702,
	
        /// <summary>
        /// Install Phone Call In Progress
        /// </summary>
        InstallPhoneCallInProgress = -2016330703,
	
        /// <summary>
        /// Install Insufficient Power
        /// </summary>
        InstallInsufficientPower = -2016330704,
	
        /// <summary>
        /// Install Insufficient Space
        /// </summary>
        InstallInsufficientSpace = -2016330705,
	
        /// <summary>
        /// Installing
        /// </summary>
        Installing = -2016330706,
	
        /// <summary>
        /// Download Insufficient Network
        /// </summary>
        DownloadInsufficientNetwork = -2016330707,
	
        /// <summary>
        /// Download Insufficient Power
        /// </summary>
        DownloadInsufficientPower = -2016330708,
	
        /// <summary>
        /// Download Insufficient Space
        /// </summary>
        DownloadInsufficientSpace = -2016330709,
	
        /// <summary>
        /// Download Requires Computer
        /// </summary>
        DownloadRequiresComputer = -2016330710,
	
        /// <summary>
        /// Download Failed
        /// </summary>
        DownloadFailed = -2016330711,
	
        /// <summary>
        /// Downloading
        /// </summary>
        Downloading = -2016330712,
	
        /// <summary>
        /// Timeout
        /// </summary>
        Timeout = -2016333898,
	
        /// <summary>
        /// Mdm Client Crashed
        /// </summary>
        MdmClientCrashed = -2016336109,
	
        /// <summary>
        /// Success
        /// </summary>
        Success = 0,
	
        /// <summary>
        /// Available
        /// </summary>
        Available = 1,
	
        /// <summary>
        /// Idle
        /// </summary>
        Idle = 2,
	
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 3,
	
    }
}
