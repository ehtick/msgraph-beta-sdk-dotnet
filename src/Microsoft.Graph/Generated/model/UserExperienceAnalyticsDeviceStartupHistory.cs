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
    /// The type User Experience Analytics Device Startup History.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserExperienceAnalyticsDeviceStartupHistory>))]
    public partial class UserExperienceAnalyticsDeviceStartupHistory : Entity
    {
    
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
        /// Gets or sets device id.
        /// The user experience analytics device id.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets feature update boot time in ms.
        /// The user experience analytics device feature update time in milliseconds.
        /// </summary>
        [JsonPropertyName("featureUpdateBootTimeInMs")]
        public Int32? FeatureUpdateBootTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets group policy boot time in ms.
        /// The User experience analytics Device group policy boot time in milliseconds.
        /// </summary>
        [JsonPropertyName("groupPolicyBootTimeInMs")]
        public Int32? GroupPolicyBootTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets group policy login time in ms.
        /// The User experience analytics Device group policy login time in milliseconds.
        /// </summary>
        [JsonPropertyName("groupPolicyLoginTimeInMs")]
        public Int32? GroupPolicyLoginTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets is feature update.
        /// The user experience analytics device boot record is a feature update.
        /// </summary>
        [JsonPropertyName("isFeatureUpdate")]
        public bool? IsFeatureUpdate { get; set; }
    
        /// <summary>
        /// Gets or sets is first login.
        /// The user experience analytics device first login.
        /// </summary>
        [JsonPropertyName("isFirstLogin")]
        public bool? IsFirstLogin { get; set; }
    
        /// <summary>
        /// Gets or sets operating system version.
        /// The user experience analytics device boot record's operating system version.
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
        /// Gets or sets restart category.
        /// OS restart category. Possible values are: unknown, restartWithUpdate, restartWithoutUpdate, blueScreen, shutdownWithUpdate, shutdownWithoutUpdate, longPowerButtonPress, bootError, update.
        /// </summary>
        [JsonPropertyName("restartCategory")]
        public UserExperienceAnalyticsOperatingSystemRestartCategory? RestartCategory { get; set; }
    
        /// <summary>
        /// Gets or sets restart fault bucket.
        /// OS restart fault bucket. The fault bucket is used to find additional information about a system crash.
        /// </summary>
        [JsonPropertyName("restartFaultBucket")]
        public string RestartFaultBucket { get; set; }
    
        /// <summary>
        /// Gets or sets restart stop code.
        /// OS restart stop code. This shows the bug check code which can be used to look up the blue screen reason.
        /// </summary>
        [JsonPropertyName("restartStopCode")]
        public string RestartStopCode { get; set; }
    
        /// <summary>
        /// Gets or sets start time.
        /// The user experience analytics device boot start time.
        /// </summary>
        [JsonPropertyName("startTime")]
        public DateTimeOffset? StartTime { get; set; }
    
        /// <summary>
        /// Gets or sets total boot time in ms.
        /// The user experience analytics device total boot time in milliseconds.
        /// </summary>
        [JsonPropertyName("totalBootTimeInMs")]
        public Int32? TotalBootTimeInMs { get; set; }
    
        /// <summary>
        /// Gets or sets total login time in ms.
        /// The user experience analytics device total login time in milliseconds.
        /// </summary>
        [JsonPropertyName("totalLoginTimeInMs")]
        public Int32? TotalLoginTimeInMs { get; set; }
    
    }
}

