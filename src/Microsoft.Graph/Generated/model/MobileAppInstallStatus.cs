// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Mobile App Install Status.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MobileAppInstallStatus>))]
    public partial class MobileAppInstallStatus : Entity
    {
    
        /// <summary>
        /// Gets or sets device id.
        /// Device ID
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Device name
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets display version.
        /// Human readable version of the application
        /// </summary>
        [JsonPropertyName("displayVersion")]
        public string DisplayVersion { get; set; }
    
        /// <summary>
        /// Gets or sets error code.
        /// The error code for install or uninstall failures.
        /// </summary>
        [JsonPropertyName("errorCode")]
        public Int32? ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets install state.
        /// The install state of the app. Possible values are: installed, failed, notInstalled, uninstallFailed, pendingInstall, unknown, notApplicable.
        /// </summary>
        [JsonPropertyName("installState")]
        public ResultantAppState? InstallState { get; set; }
    
        /// <summary>
        /// Gets or sets install state detail.
        /// The install state detail of the app. Possible values are: noAdditionalDetails, dependencyFailedToInstall, dependencyWithRequirementsNotMet, dependencyPendingReboot, dependencyWithAutoInstallDisabled, supersededAppUninstallFailed, supersededAppUninstallPendingReboot, removingSupersededApps, iosAppStoreUpdateFailedToInstall, vppAppHasUpdateAvailable, userRejectedUpdate, uninstallPendingReboot, supersedingAppsDetected, supersededAppsDetected, seeInstallErrorCode, autoInstallDisabled, managedAppNoLongerPresent, userRejectedInstall, userIsNotLoggedIntoAppStore, untargetedSupersedingAppsDetected, appRemovedBySupersedence, seeUninstallErrorCode, pendingReboot, installingDependencies, contentDownloaded, supersedingAppsNotApplicable, powerShellScriptRequirementNotMet, registryRequirementNotMet, fileSystemRequirementNotMet, platformNotApplicable, minimumCpuSpeedNotMet, minimumLogicalProcessorCountNotMet, minimumPhysicalMemoryNotMet, minimumOsVersionNotMet, minimumDiskSpaceNotMet, processorArchitectureNotApplicable.
        /// </summary>
        [JsonPropertyName("installStateDetail")]
        public ResultantAppStateDetail? InstallStateDetail { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// Last sync date time
        /// </summary>
        [JsonPropertyName("lastSyncDateTime")]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets mobile app install status value.
        /// The install state of the app. Possible values are: installed, failed, notInstalled, uninstallFailed, pendingInstall, unknown, notApplicable.
        /// </summary>
        [JsonPropertyName("mobileAppInstallStatusValue")]
        public ResultantAppState? MobileAppInstallStatusValue { get; set; }
    
        /// <summary>
        /// Gets or sets os description.
        /// OS Description
        /// </summary>
        [JsonPropertyName("osDescription")]
        public string OsDescription { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// OS Version
        /// </summary>
        [JsonPropertyName("osVersion")]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// Device User Name
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User Principal Name
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets app.
        /// The navigation link to the mobile app.
        /// </summary>
        [JsonPropertyName("app")]
        public MobileApp App { get; set; }
    
    }
}

