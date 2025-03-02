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
    /// The type User Experience Analytics Battery Health Device Runtime History.
    /// </summary>
    public partial class UserExperienceAnalyticsBatteryHealthDeviceRuntimeHistory : Entity
    {
    
        /// <summary>
        /// Gets or sets device id.
        /// The unique identifier of the device, Intune DeviceID or SCCM device id.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets estimated runtime in minutes.
        /// The estimated runtime of the device when the battery is fully charged. Unit in minutes. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("estimatedRuntimeInMinutes")]
        public Int32? EstimatedRuntimeInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets runtime date time.
        /// The datetime for the instance of runtime history.
        /// </summary>
        [JsonPropertyName("runtimeDateTime")]
        public string RuntimeDateTime { get; set; }
    
    }
}

