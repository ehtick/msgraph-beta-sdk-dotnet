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
    /// The type Governance Role Setting.
    /// </summary>
    public partial class GovernanceRoleSetting : Entity
    {
    
        /// <summary>
        /// Gets or sets admin eligible settings.
        /// The rule settings that are evaluated when an administrator tries to add an eligible role assignment.
        /// </summary>
        [JsonPropertyName("adminEligibleSettings")]
        public IEnumerable<GovernanceRuleSetting> AdminEligibleSettings { get; set; }
    
        /// <summary>
        /// Gets or sets admin member settings.
        /// The rule settings that are evaluated when an administrator tries to add a direct member role assignment.
        /// </summary>
        [JsonPropertyName("adminMemberSettings")]
        public IEnumerable<GovernanceRuleSetting> AdminMemberSettings { get; set; }
    
        /// <summary>
        /// Gets or sets is default.
        /// Read-only. Indicate if the roleSetting is a default roleSetting
        /// </summary>
        [JsonPropertyName("isDefault")]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets last updated by.
        /// Read-only. The display name of the administrator who last updated the roleSetting.
        /// </summary>
        [JsonPropertyName("lastUpdatedBy")]
        public string LastUpdatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last updated date time.
        /// Read-only. The time when the role setting was last updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("lastUpdatedDateTime")]
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// Required. The id of the resource that the role setting is associated with.
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets role definition id.
        /// Required. The id of the role definition that the role setting is associated with.
        /// </summary>
        [JsonPropertyName("roleDefinitionId")]
        public string RoleDefinitionId { get; set; }
    
        /// <summary>
        /// Gets or sets user eligible settings.
        /// The rule settings that are evaluated when a user tries to add an eligible role assignment. The setting is not supported for now.
        /// </summary>
        [JsonPropertyName("userEligibleSettings")]
        public IEnumerable<GovernanceRuleSetting> UserEligibleSettings { get; set; }
    
        /// <summary>
        /// Gets or sets user member settings.
        /// The rule settings that are evaluated when a user tries to activate his role assignment.
        /// </summary>
        [JsonPropertyName("userMemberSettings")]
        public IEnumerable<GovernanceRuleSetting> UserMemberSettings { get; set; }
    
        /// <summary>
        /// Gets or sets resource.
        /// Read-only. The associated resource for this role setting.
        /// </summary>
        [JsonPropertyName("resource")]
        public GovernanceResource Resource { get; set; }
    
        /// <summary>
        /// Gets or sets role definition.
        /// Read-only. The role definition that is enforced with this role setting.
        /// </summary>
        [JsonPropertyName("roleDefinition")]
        public GovernanceRoleDefinition RoleDefinition { get; set; }
    
    }
}

