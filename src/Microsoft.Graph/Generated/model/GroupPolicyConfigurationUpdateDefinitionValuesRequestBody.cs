// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type GroupPolicyConfigurationUpdateDefinitionValuesRequestBody.
    /// </summary>
    public partial class GroupPolicyConfigurationUpdateDefinitionValuesRequestBody
    {
    
        /// <summary>
        /// Gets or sets Added.
        /// </summary>
        [JsonPropertyName("added")]
        public IEnumerable<GroupPolicyDefinitionValue> Added { get; set; }
    
        /// <summary>
        /// Gets or sets Updated.
        /// </summary>
        [JsonPropertyName("updated")]
        public IEnumerable<GroupPolicyDefinitionValue> Updated { get; set; }
    
        /// <summary>
        /// Gets or sets DeletedIds.
        /// </summary>
        [JsonPropertyName("deletedIds")]
        public IEnumerable<string> DeletedIds { get; set; }
    
    }
}
