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
    /// The type User Experience Analytics Model Scores.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserExperienceAnalyticsModelScores>))]
    public partial class UserExperienceAnalyticsModelScores : Entity
    {
    
        /// <summary>
        /// Gets or sets app reliability score.
        /// The user experience analytics model app reliability score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("appReliabilityScore")]
        public double? AppReliabilityScore { get; set; }
    
        /// <summary>
        /// Gets or sets battery health score.
        /// The user experience analytics model battery health score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("batteryHealthScore")]
        public double? BatteryHealthScore { get; set; }
    
        /// <summary>
        /// Gets or sets endpoint analytics score.
        /// The user experience analytics model score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("endpointAnalyticsScore")]
        public double? EndpointAnalyticsScore { get; set; }
    
        /// <summary>
        /// Gets or sets health status.
        /// The health state of the user experience analytics model. Possible values are: unknown, insufficientData, needsAttention, meetingGoals, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("healthStatus")]
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
    
        /// <summary>
        /// Gets or sets manufacturer.
        /// A unique identifier of the user experience analytics model scores: device manufacturer.
        /// </summary>
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// A unique identifier of the user experience analytics model scores: device model.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
        /// <summary>
        /// Gets or sets model device count.
        /// The user experience analytics model device count. Valid values -9.22337203685478E+18 to 9.22337203685478E+18
        /// </summary>
        [JsonPropertyName("modelDeviceCount")]
        public Int64? ModelDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets startup performance score.
        /// The user experience analytics model startup performance score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("startupPerformanceScore")]
        public double? StartupPerformanceScore { get; set; }
    
        /// <summary>
        /// Gets or sets work from anywhere score.
        /// The user experience analytics model work from anywhere score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("workFromAnywhereScore")]
        public double? WorkFromAnywhereScore { get; set; }
    
    }
}

