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
    /// The type DeliveryOptimizationMaxCacheSizePercentage.
    /// </summary>
    public partial class DeliveryOptimizationMaxCacheSizePercentage : DeliveryOptimizationMaxCacheSize
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryOptimizationMaxCacheSizePercentage"/> class.
        /// </summary>
        public DeliveryOptimizationMaxCacheSizePercentage()
        {
            this.ODataType = "microsoft.graph.deliveryOptimizationMaxCacheSizePercentage";
        }

        /// <summary>
        /// Gets or sets maximumCacheSizePercentage.
        /// Specifies the maximum cache size that Delivery Optimization can utilize, as a percentage of disk size (1-100). Valid values 1 to 100
        /// </summary>
        [JsonPropertyName("maximumCacheSizePercentage")]
        public Int32? MaximumCacheSizePercentage { get; set; }
    
    }
}
