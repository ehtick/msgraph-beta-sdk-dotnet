// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Tenant Customized Information.
    /// </summary>
    public partial class TenantCustomizedInformation : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets contacts.
        /// The collection of contacts for the managed tenant. Optional.
        /// </summary>
        [JsonPropertyName("contacts")]
        public IEnumerable<TenantContactInformation> Contacts { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the managed tenant. Required. Read-only.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets website.
        /// The website for the managed tenant. Required.
        /// </summary>
        [JsonPropertyName("website")]
        public string Website { get; set; }
    
    }
}

