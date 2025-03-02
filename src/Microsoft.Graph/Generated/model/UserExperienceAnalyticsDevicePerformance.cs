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
    /// The type User Experience Analytics Device Performance.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserExperienceAnalyticsDevicePerformance>))]
    public partial class UserExperienceAnalyticsDevicePerformance : Entity
    {
    
        /// <summary>
        /// Gets or sets average blue screens.
        /// Average (mean) number of Blue Screens per device in the last 30 days. Valid values 0 to 9999999
        /// </summary>
        [JsonPropertyName("averageBlueScreens")]
        public double? AverageBlueScreens { get; set; }
    
        /// <summary>
        /// Gets or sets average restarts.
        /// Average (mean) number of Restarts per device in the last 30 days. Valid values 0 to 9999999
        /// </summary>
        [JsonPropertyName("averageRestarts")]
        public double? AverageRestarts { get; set; }
    
        /// <summary>
        /// Gets or sets blue screen count.
        /// Number of Blue Screens in the last 30 days. Valid values 0 to 9999999
        /// </summary>
        [JsonPropertyName("blueScreenCount")]
        public Int32? BlueScreenCount { get; set; }
    
        /// <summary>
        /// Gets or sets boot score.
        /// The user experience analytics device boot score.
        /// </summary>
        [JsonPropertyName("bootScore")]
        public Int32? BootScore { get; set; }
    
        /// <summary>
        /// Gets or sets core boot time in ms.
        /// The user experience analytics device core boot time in milliseconds.
        /// </summary>
        [JsonPropertyName("coreBootTimeInMs")]
        public Int32? CoreBootTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets core login time in ms.
        /// The user experience analytics device core login time in milliseconds.
        /// </summary>
        [JsonPropertyName("coreLoginTimeInMs")]
        public Int32? CoreLoginTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets device count.
        /// User experience analytics summarized device count.
        /// </summary>
        [JsonPropertyName("deviceCount")]
        public Int64? DeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// The user experience analytics device name.
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets disk type.
        /// The user experience analytics device disk type. Possible values are: unknown, hdd, ssd, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("diskType")]
        public DiskType? DiskType { get; set; }
    
        /// <summary>
        /// Gets or sets group policy boot time in ms.
        /// The user experience analytics device group policy boot time in milliseconds.
        /// </summary>
        [JsonPropertyName("groupPolicyBootTimeInMs")]
        public Int32? GroupPolicyBootTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets group policy login time in ms.
        /// The user experience analytics device group policy login time in milliseconds.
        /// </summary>
        [JsonPropertyName("groupPolicyLoginTimeInMs")]
        public Int32? GroupPolicyLoginTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets health status.
        /// The health state of the user experience analytics device. Possible values are: unknown, insufficientData, needsAttention, meetingGoals, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("healthStatus")]
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
    
        /// <summary>
        /// Gets or sets login score.
        /// The user experience analytics device login score.
        /// </summary>
        [JsonPropertyName("loginScore")]
        public Int32? LoginScore { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// The user experience analytics device manufacturer.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// The user experience analytics device model.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets model startup performance score.
        /// The user experience analytics model level startup performance score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("modelStartupPerformanceScore")]
        public double? ModelStartupPerformanceScore { get; set; }
    
        /// <summary>
        /// Gets or sets operating system version.
        /// The user experience analytics device Operating System version.
        /// </summary>
        [JsonPropertyName("operatingSystemVersion")]
        public string OperatingSystemVersion { get; set; }
    
        /// <summary>
        /// Gets or sets responsive desktop time in ms.
        /// The user experience analytics responsive desktop time in milliseconds.
        /// </summary>
        [JsonPropertyName("responsiveDesktopTimeInMs")]
        public Int32? ResponsiveDesktopTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets restart count.
        /// Number of Restarts in the last 30 days. Valid values 0 to 9999999
        /// </summary>
        [JsonPropertyName("restartCount")]
        public Int32? RestartCount { get; set; }
    
        /// <summary>
        /// Gets or sets startup performance score.
        /// The user experience analytics device startup performance score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("startupPerformanceScore")]
        public double? StartupPerformanceScore { get; set; }
    
    }
}

