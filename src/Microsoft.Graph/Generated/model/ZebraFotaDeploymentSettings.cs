// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ZebraFotaDeploymentSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ZebraFotaDeploymentSettings>))]
    public partial class ZebraFotaDeploymentSettings
    {

        /// <summary>
        /// Gets or sets batteryRuleMinimumBatteryLevelPercentage.
        /// Minimum battery level (%) required for both download and installation. Default: -1 (System defaults). Maximum is 100.
        /// </summary>
        [JsonPropertyName("batteryRuleMinimumBatteryLevelPercentage")]
        public Int32? BatteryRuleMinimumBatteryLevelPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets batteryRuleRequireCharger.
        /// Flag indicating if charger is required. When set to false, the client can install updates whether the device is in or out of the charger. Applied only for installation. Defaults to false.
        /// </summary>
        [JsonPropertyName("batteryRuleRequireCharger")]
        public bool? BatteryRuleRequireCharger { get; set; }
    
        /// <summary>
        /// Gets or sets deviceModel.
        /// Deploy update for devices with this model only.
        /// </summary>
        [JsonPropertyName("deviceModel")]
        public string DeviceModel { get; set; }
    
        /// <summary>
        /// Gets or sets downloadRuleNetworkType.
        /// Download network type as described in 'zebraFotaNetworkType'. Default: any. Possible values are: any, wifi, cellular, wifiAndCellular, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("downloadRuleNetworkType")]
        public ZebraFotaNetworkType? DownloadRuleNetworkType { get; set; }
    
        /// <summary>
        /// Gets or sets downloadRuleStartDateTime.
        /// Date and time in the device time zone when the download will start (e.g., 2018-07-25T10:20:32). The default value is UTC now and the maximum is 10 days from deployment creation.
        /// </summary>
        [JsonPropertyName("downloadRuleStartDateTime")]
        public DateTimeOffset? DownloadRuleStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets firmwareTargetArtifactDescription.
        /// A description provided by Zebra for the the firmware artifact to update the device to (e.g.: LifeGuard Update 120 (released 29-June-2022).
        /// </summary>
        [JsonPropertyName("firmwareTargetArtifactDescription")]
        public string FirmwareTargetArtifactDescription { get; set; }
    
        /// <summary>
        /// Gets or sets firmwareTargetBoardSupportPackageVersion.
        /// Deployment's Board Support Package (BSP. E.g.: '01.18.02.00'). Required only for custom update type.
        /// </summary>
        [JsonPropertyName("firmwareTargetBoardSupportPackageVersion")]
        public string FirmwareTargetBoardSupportPackageVersion { get; set; }
    
        /// <summary>
        /// Gets or sets firmwareTargetOsVersion.
        /// Target OS Version (e.g.: '8.1.0'). Required only for custom update type.
        /// </summary>
        [JsonPropertyName("firmwareTargetOsVersion")]
        public string FirmwareTargetOsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets firmwareTargetPatch.
        /// Target patch name (e.g.: 'U06'). Required only for custom update type.
        /// </summary>
        [JsonPropertyName("firmwareTargetPatch")]
        public string FirmwareTargetPatch { get; set; }
    
        /// <summary>
        /// Gets or sets installRuleStartDateTime.
        /// Date and time in device time zone when the install will start. Default - download startDate if configured, otherwise defaults to NOW. Ignored when deployment update type was set to auto.
        /// </summary>
        [JsonPropertyName("installRuleStartDateTime")]
        public DateTimeOffset? InstallRuleStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets installRuleWindowEndTime.
        /// Time of day after which the install cannot start. Possible range is 00:30:00 to 23:59:59. Should be greater than 'installRuleWindowStartTime' by 30 mins. The time is expressed in a 24-hour format, as hh:mm, and is in the device time zone. Default - 23:59:59. Respected for all values of update type, including AUTO.
        /// </summary>
        [JsonPropertyName("installRuleWindowEndTime")]
        public TimeOfDay InstallRuleWindowEndTime { get; set; }
    
        /// <summary>
        /// Gets or sets installRuleWindowStartTime.
        /// Time of day (00:00:00 - 23:30:00) when installation should begin. The time is expressed in a 24-hour format, as hh:mm, and is in the device time zone. Default - 00:00:00. Respected for all values of update type, including AUTO.
        /// </summary>
        [JsonPropertyName("installRuleWindowStartTime")]
        public TimeOfDay InstallRuleWindowStartTime { get; set; }
    
        /// <summary>
        /// Gets or sets scheduleDurationInDays.
        /// Maximum 28 days. Default is 28 days. Sequence of dates are: 1) Download start date. 2) Install start date. 3) Schedule end date. If any of the values are not provided, the date provided in the preceding step of the sequence is used. If no values are provided, the string value of the current UTC is used.
        /// </summary>
        [JsonPropertyName("scheduleDurationInDays")]
        public Int32? ScheduleDurationInDays { get; set; }
    
        /// <summary>
        /// Gets or sets scheduleMode.
        /// Deployment installation schedule mode. Default is installNow. All scheduled deployments date and time are in the device’s timezone. For Install Now, the date and time are in UTC (same date and time anywhere in the world). Possible values are: installNow, scheduled, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("scheduleMode")]
        public ZebraFotaScheduleMode? ScheduleMode { get; set; }
    
        /// <summary>
        /// Gets or sets timeZoneOffsetInMinutes.
        /// This attribute indicates the deployment time offset (e.g.180 represents an offset of +03:00, and -270 represents an offset of -04:30). The time offset is the time timezone where the devices are located. The deployment start and end data uses this timezone
        /// </summary>
        [JsonPropertyName("timeZoneOffsetInMinutes")]
        public Int32? TimeZoneOffsetInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets updateType.
        /// The deployment's update type. Possible values are custom, latest, and auto. When custom mode is set, the request must provide artifact values. When latest type is set, the latest released update becomes the target OS. If latest is specified, the firmware target values are not required. Note: latest may update the device to a new Android version. When the value is set to auto, the device always looks for the latest package available and tries to update whenever a new package is available. This continues until the admin cancels the auto update. While other modes return an ID starting with FOTA-x, auto mode returns an ID starting with AUTO-x. Possible values are: custom, latest, auto, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("updateType")]
        public ZebraFotaUpdateType? UpdateType { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
