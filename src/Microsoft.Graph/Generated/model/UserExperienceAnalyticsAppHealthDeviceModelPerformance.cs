// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type User Experience Analytics App Health Device Model Performance.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class UserExperienceAnalyticsAppHealthDeviceModelPerformance : Entity
    {
    
		///<summary>
		/// The UserExperienceAnalyticsAppHealthDeviceModelPerformance constructor
		///</summary>
        public UserExperienceAnalyticsAppHealthDeviceModelPerformance()
        {
            this.ODataType = "microsoft.graph.userExperienceAnalyticsAppHealthDeviceModelPerformance";
        }
	
        /// <summary>
        /// Gets or sets active device count.
        /// The number of active devices for the model. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ActiveDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets device manufacturer.
        /// The manufacturer name of the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceManufacturer", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceManufacturer { get; set; }
    
        /// <summary>
        /// Gets or sets device model.
        /// The model name of the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceModel", Required = Newtonsoft.Json.Required.Default)]
        public string DeviceModel { get; set; }
    
        /// <summary>
        /// Gets or sets mean time to failure in minutes.
        /// The mean time to failure for the model device in minutes. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meanTimeToFailureInMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MeanTimeToFailureInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets model app health score.
        /// The app health score of the device model. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "modelAppHealthScore", Required = Newtonsoft.Json.Required.Default)]
        public double? ModelAppHealthScore { get; set; }
    
        /// <summary>
        /// Gets or sets model app health status.
        /// The overall app health status of the device model.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "modelAppHealthStatus", Required = Newtonsoft.Json.Required.Default)]
        public string ModelAppHealthStatus { get; set; }
    
    }
}

