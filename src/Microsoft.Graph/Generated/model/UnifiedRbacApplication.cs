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
    /// The type Unified Rbac Application.
    /// </summary>
    public partial class UnifiedRbacApplication : Entity
    {
    
        /// <summary>
        /// Gets or sets resource namespaces.
        /// </summary>
        [JsonPropertyName("resourceNamespaces")]
        public IUnifiedRbacApplicationResourceNamespacesCollectionPage ResourceNamespaces { get; set; }

        /// <summary>
        /// Gets or sets resourceNamespacesNextLink.
        /// </summary>
        [JsonPropertyName("resourceNamespaces@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ResourceNamespacesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets role assignments.
        /// </summary>
        [JsonPropertyName("roleAssignments")]
        public IUnifiedRbacApplicationRoleAssignmentsCollectionPage RoleAssignments { get; set; }

        /// <summary>
        /// Gets or sets roleAssignmentsNextLink.
        /// </summary>
        [JsonPropertyName("roleAssignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleAssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets role definitions.
        /// </summary>
        [JsonPropertyName("roleDefinitions")]
        public IUnifiedRbacApplicationRoleDefinitionsCollectionPage RoleDefinitions { get; set; }

        /// <summary>
        /// Gets or sets roleDefinitionsNextLink.
        /// </summary>
        [JsonPropertyName("roleDefinitions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RoleDefinitionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets transitive role assignments.
        /// </summary>
        [JsonPropertyName("transitiveRoleAssignments")]
        public IUnifiedRbacApplicationTransitiveRoleAssignmentsCollectionPage TransitiveRoleAssignments { get; set; }

        /// <summary>
        /// Gets or sets transitiveRoleAssignmentsNextLink.
        /// </summary>
        [JsonPropertyName("transitiveRoleAssignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TransitiveRoleAssignmentsNextLink { get; set; }
    
    }
}

