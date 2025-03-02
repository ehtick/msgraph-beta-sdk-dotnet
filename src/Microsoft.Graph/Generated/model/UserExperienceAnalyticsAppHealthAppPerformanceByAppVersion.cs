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
    /// The type User Experience Analytics App Health App Performance By App Version.
    /// </summary>
    public partial class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersion : Entity
    {
    
        /// <summary>
        /// Gets or sets app crash count.
        /// The number of crashes for the app. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("appCrashCount")]
        public Int32? AppCrashCount { get; set; }
    
        /// <summary>
        /// Gets or sets app display name.
        /// The friendly name of the application.
        /// </summary>
        [JsonPropertyName("appDisplayName")]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app name.
        /// The name of the application.
        /// </summary>
        [JsonPropertyName("appName")]
        public string AppName { get; set; }
    
        /// <summary>
        /// Gets or sets app publisher.
        /// The publisher of the application.
        /// </summary>
        [JsonPropertyName("appPublisher")]
        public string AppPublisher { get; set; }
    
        /// <summary>
        /// Gets or sets app usage duration.
        /// The total usage time of the application in minutes. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("appUsageDuration")]
        public Int32? AppUsageDuration { get; set; }
    
        /// <summary>
        /// Gets or sets app version.
        /// The version of the application.
        /// </summary>
        [JsonPropertyName("appVersion")]
        public string AppVersion { get; set; }
    
        /// <summary>
        /// Gets or sets mean time to failure in minutes.
        /// The mean time to failure for the app in minutes. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("meanTimeToFailureInMinutes")]
        public Int32? MeanTimeToFailureInMinutes { get; set; }
    
    }
}

