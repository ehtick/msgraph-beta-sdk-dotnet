// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Trust Framework.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TrustFramework>))]
    public partial class TrustFramework
    {
    
        /// <summary>
        /// Gets or sets key sets.
        /// </summary>
        [JsonPropertyName("keySets")]
        public ITrustFrameworkKeySetsCollectionPage KeySets { get; set; }

        /// <summary>
        /// Gets or sets keySetsNextLink.
        /// </summary>
        [JsonPropertyName("keySets@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string KeySetsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets policies.
        /// </summary>
        [JsonPropertyName("policies")]
        public ITrustFrameworkPoliciesCollectionPage Policies { get; set; }

        /// <summary>
        /// Gets or sets policiesNextLink.
        /// </summary>
        [JsonPropertyName("policies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

