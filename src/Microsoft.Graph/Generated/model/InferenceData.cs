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
    /// The type InferenceData.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<InferenceData>))]
    public partial class InferenceData
    {

        /// <summary>
        /// Gets or sets confidenceScore.
        /// Confidence score reflecting the accuracy of the data inferred about the user.
        /// </summary>
        [JsonPropertyName("confidenceScore")]
        public double? ConfidenceScore { get; set; }
    
        /// <summary>
        /// Gets or sets userHasVerifiedAccuracy.
        /// Records if the user has confirmed this inference as being True or False.
        /// </summary>
        [JsonPropertyName("userHasVerifiedAccuracy")]
        public bool? UserHasVerifiedAccuracy { get; set; }
    
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
