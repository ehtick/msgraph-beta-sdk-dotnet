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
    /// The type CloudPcHealthCheckItem.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CloudPcHealthCheckItem>))]
    public partial class CloudPcHealthCheckItem
    {

        /// <summary>
        /// Gets or sets additionalDetails.
        /// Additional message for this health check.
        /// </summary>
        [JsonPropertyName("additionalDetails")]
        public string AdditionalDetails { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The connectivity health check item name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets lastHealthCheckDateTime.
        /// Timestamp when the last check occurs. The timestamp is shown in ISO 8601 format and Coordinated Universal Time (UTC). For example, midnight UTC on Jan 1, 2014 appears as 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("lastHealthCheckDateTime")]
        public DateTimeOffset? LastHealthCheckDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets result.
        /// The result of this health check item. Possible values are: unknown, success, failure.
        /// </summary>
        [JsonPropertyName("result")]
        public CloudPcConnectivityEventResult? Result { get; set; }
    
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
