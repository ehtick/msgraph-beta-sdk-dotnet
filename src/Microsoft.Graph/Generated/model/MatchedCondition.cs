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
    /// The type MatchedCondition.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MatchedCondition>))]
    public partial class MatchedCondition
    {

        /// <summary>
        /// Gets or sets condition.
        /// </summary>
        [JsonPropertyName("condition")]
        public string Condition { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// </summary>
        [JsonPropertyName("values")]
        public IEnumerable<string> Values { get; set; }
    
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
