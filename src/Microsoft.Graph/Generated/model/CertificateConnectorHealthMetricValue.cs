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
    /// The type CertificateConnectorHealthMetricValue.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CertificateConnectorHealthMetricValue>))]
    public partial class CertificateConnectorHealthMetricValue
    {

        /// <summary>
        /// Gets or sets dateTime.
        /// Timestamp for this metric data-point.
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTimeOffset? DateTime { get; set; }
    
        /// <summary>
        /// Gets or sets failureCount.
        /// Count of failed requests/operations.
        /// </summary>
        [JsonPropertyName("failureCount")]
        public Int64? FailureCount { get; set; }
    
        /// <summary>
        /// Gets or sets successCount.
        /// Count of successful requests/operations.
        /// </summary>
        [JsonPropertyName("successCount")]
        public Int64? SuccessCount { get; set; }
    
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
