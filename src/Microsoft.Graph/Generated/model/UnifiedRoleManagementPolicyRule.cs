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
    /// The type Unified Role Management Policy Rule.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UnifiedRoleManagementPolicyRule>))]
    public partial class UnifiedRoleManagementPolicyRule : Entity
    {
    
        ///<summary>
        /// The internal UnifiedRoleManagementPolicyRule constructor
        ///</summary>
        protected internal UnifiedRoleManagementPolicyRule()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets target.
        /// Not implemented. Defines details of scope that's targeted by role management policy rule. The details can include the principal type, the role assignment type, and actions affecting a role. Supports $filter (eq, ne).
        /// </summary>
        [JsonPropertyName("target")]
        public UnifiedRoleManagementPolicyRuleTarget Target { get; set; }
    
    }
}

