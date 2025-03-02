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
    /// The type User Experience Analytics App Health Device Performance Details.
    /// </summary>
    public partial class UserExperienceAnalyticsAppHealthDevicePerformanceDetails : Entity
    {
    
        /// <summary>
        /// Gets or sets app display name.
        /// The friendly name of the application for which the event occurred.
        /// </summary>
        [JsonPropertyName("appDisplayName")]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app publisher.
        /// The publisher of the application.
        /// </summary>
        [JsonPropertyName("appPublisher")]
        public string AppPublisher { get; set; }
    
        /// <summary>
        /// Gets or sets app version.
        /// The version of the application.
        /// </summary>
        [JsonPropertyName("appVersion")]
        public string AppVersion { get; set; }
    
        /// <summary>
        /// Gets or sets device display name.
        /// The name of the device.
        /// </summary>
        [JsonPropertyName("deviceDisplayName")]
        public string DeviceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets device id.
        /// The id of the device.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets event date time.
        /// The time the event occurred.
        /// </summary>
        [JsonPropertyName("eventDateTime")]
        public DateTimeOffset? EventDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets event type.
        /// The type of the event.
        /// </summary>
        [JsonPropertyName("eventType")]
        public string EventType { get; set; }
    
    }
}

