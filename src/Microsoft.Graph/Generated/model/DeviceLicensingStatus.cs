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
    /// The enum DeviceLicensingStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeviceLicensingStatus
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = -1,
	
        /// <summary>
        /// License Refresh Started
        /// </summary>
        LicenseRefreshStarted = 0,
	
        /// <summary>
        /// License Refresh Pending
        /// </summary>
        LicenseRefreshPending = 1,
	
        /// <summary>
        /// Device Is Not Azure Active Directory Joined
        /// </summary>
        DeviceIsNotAzureActiveDirectoryJoined = 2,
	
        /// <summary>
        /// Verifying Microsoft Device Identity
        /// </summary>
        VerifyingMicrosoftDeviceIdentity = 3,
	
        /// <summary>
        /// Device Identity Verification Failed
        /// </summary>
        DeviceIdentityVerificationFailed = 4,
	
        /// <summary>
        /// Verifying Mirosoft Account Identity
        /// </summary>
        VerifyingMirosoftAccountIdentity = 5,
	
        /// <summary>
        /// Mirosoft Account Verification Failed
        /// </summary>
        MirosoftAccountVerificationFailed = 6,
	
        /// <summary>
        /// Acquiring Device License
        /// </summary>
        AcquiringDeviceLicense = 7,
	
        /// <summary>
        /// Refreshing Device License
        /// </summary>
        RefreshingDeviceLicense = 8,
	
        /// <summary>
        /// Device License Refresh Succeed
        /// </summary>
        DeviceLicenseRefreshSucceed = 9,
	
        /// <summary>
        /// Device License Refresh Failed
        /// </summary>
        DeviceLicenseRefreshFailed = 10,
	
        /// <summary>
        /// Removing Device License
        /// </summary>
        RemovingDeviceLicense = 11,
	
        /// <summary>
        /// Device License Remove Succeed
        /// </summary>
        DeviceLicenseRemoveSucceed = 12,
	
        /// <summary>
        /// Device License Remove Failed
        /// </summary>
        DeviceLicenseRemoveFailed = 13,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 14,
	
    }
}
