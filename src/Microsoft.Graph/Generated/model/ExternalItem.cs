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
    /// The type External Item.
    /// </summary>
    [Obsolete("The OData type annotation for this entity is being deprecated by Aug 2021. Please strip the @odata.type annotations for this specific entity from your request payloads before the deprecation date.")]
    public partial class ExternalItem : Entity
    {
    
        /// <summary>
        /// Gets or sets acl.
        /// </summary>
        [JsonPropertyName("acl")]
        public IEnumerable<Acl> Acl { get; set; }
    
        /// <summary>
        /// Gets or sets content.
        /// </summary>
        [JsonPropertyName("content")]
        public ExternalItemContent Content { get; set; }
    
        /// <summary>
        /// Gets or sets properties.
        /// </summary>
        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }
    
    }
}

