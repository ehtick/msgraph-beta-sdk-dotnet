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
    /// The type Governance Subject.
    /// </summary>
    public partial class GovernanceSubject : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the subject.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets email.
        /// The email address of the user subject. If the subject is in other types, it is empty.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets principal name.
        /// The principal name of the user subject. If the subject is in other types, it is empty.
        /// </summary>
        [JsonPropertyName("principalName")]
        public string PrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The type of the subject. The value can be User, Group, and ServicePrincipal.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    
    }
}

