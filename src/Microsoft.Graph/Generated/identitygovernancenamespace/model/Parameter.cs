// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Parameter.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<Parameter>))]
    public partial class Parameter
    {

        /// <summary>
        /// Gets or sets name.
        /// The name of the parameter.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// The values of the parameter.
        /// </summary>
        [JsonPropertyName("values")]
        public IEnumerable<string> Values { get; set; }
    
        /// <summary>
        /// Gets or sets valueType.
        /// The value type of the parameter. The possible values are: enum, string, int, bool, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("valueType")]
        public ValueType? ValueType { get; set; }
    
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
