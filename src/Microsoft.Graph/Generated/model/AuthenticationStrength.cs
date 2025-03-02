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
    /// The type AuthenticationStrength.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AuthenticationStrength>))]
    public partial class AuthenticationStrength
    {

        /// <summary>
        /// Gets or sets authenticationStrengthId.
        /// Identifier of the authentication strength.
        /// </summary>
        [JsonPropertyName("authenticationStrengthId")]
        public string AuthenticationStrengthId { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The name of the authentication strength.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
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
