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
    /// The type MetricTimeSeriesDataPoint.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MetricTimeSeriesDataPoint>))]
    public partial class MetricTimeSeriesDataPoint
    {

        /// <summary>
        /// Gets or sets dateTime.
        /// Time of the metric time series data point
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTimeOffset? DateTime { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// Value of the metric time series data point
        /// </summary>
        [JsonPropertyName("value")]
        public Int64? Value { get; set; }
    
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
