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
    /// The type AlertImpact.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<AlertImpact>))]
    public partial class AlertImpact
    {

        /// <summary>
        /// Gets or sets aggregationType.
        /// </summary>
        [JsonPropertyName("aggregationType")]
        public AggregationType? AggregationType { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// </summary>
        [JsonPropertyName("value")]
        public Int32? Value { get; set; }
    
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
