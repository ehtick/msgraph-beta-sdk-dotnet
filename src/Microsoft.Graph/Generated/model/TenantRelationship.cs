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
    /// The type Tenant Relationship.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TenantRelationship>))]
    public partial class TenantRelationship
    {
    
        /// <summary>
        /// Gets or sets managed tenants.
        /// The operations available to interact with the multi-tenant management platform.
        /// </summary>
        [JsonPropertyName("managedTenants")]
        public Microsoft.Graph.ManagedTenants.ManagedTenant ManagedTenants { get; set; }
    
        /// <summary>
        /// Gets or sets delegated admin customers.
        /// The customer who has a delegated admin relationship with a Microsoft partner.
        /// </summary>
        [JsonPropertyName("delegatedAdminCustomers")]
        public ITenantRelationshipDelegatedAdminCustomersCollectionPage DelegatedAdminCustomers { get; set; }

        /// <summary>
        /// Gets or sets delegatedAdminCustomersNextLink.
        /// </summary>
        [JsonPropertyName("delegatedAdminCustomers@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DelegatedAdminCustomersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets delegated admin relationships.
        /// The details of the delegated administrative privileges that a Microsoft partner has in a customer tenant.
        /// </summary>
        [JsonPropertyName("delegatedAdminRelationships")]
        public ITenantRelationshipDelegatedAdminRelationshipsCollectionPage DelegatedAdminRelationships { get; set; }

        /// <summary>
        /// Gets or sets delegatedAdminRelationshipsNextLink.
        /// </summary>
        [JsonPropertyName("delegatedAdminRelationships@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DelegatedAdminRelationshipsNextLink { get; set; }
    
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

