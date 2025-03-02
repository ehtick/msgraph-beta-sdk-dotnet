// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.DeviceManagementNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type RuleThreshold.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<RuleThreshold>))]
    public partial class RuleThreshold
    {

        /// <summary>
        /// Gets or sets aggregation.
        /// Indicates the built-in aggregation methods. The possible values are: count, percentage, affectedCloudPcCount, affectedCloudPcPercentage, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("aggregation")]
        public AggregationType? Aggregation { get; set; }
    
        /// <summary>
        /// Gets or sets operator.
        /// Indicates the built-in operator. The possible values are: greaterOrEqual, equal, greater, less, lessOrEqual, notEqual, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("operator")]
        public OperatorType? Operator { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// The target threshold value.
        /// </summary>
        [JsonPropertyName("target")]
        public Int32? Target { get; set; }
    
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
