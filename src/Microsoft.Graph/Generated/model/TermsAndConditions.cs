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
    /// The type Terms And Conditions.
    /// </summary>
    public partial class TermsAndConditions : Entity
    {
    
        /// <summary>
        /// Gets or sets acceptance statement.
        /// Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&amp;C policy. This is shown to the user on prompts to accept the T&amp;C policy.
        /// </summary>
        [JsonPropertyName("acceptanceStatement")]
        public string AcceptanceStatement { get; set; }
    
        /// <summary>
        /// Gets or sets body text.
        /// Administrator-supplied body text of the terms and conditions, typically the terms themselves. This is shown to the user on prompts to accept the T&amp;C policy.
        /// </summary>
        [JsonPropertyName("bodyText")]
        public string BodyText { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// DateTime the object was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Administrator-supplied description of the T&amp;C policy.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Administrator-supplied name for the T&amp;C policy.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets modified date time.
        /// DateTime the object was last modified.
        /// </summary>
        [JsonPropertyName("modifiedDateTime")]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// Administrator-supplied title of the terms and conditions. This is shown to the user on prompts to accept the T&amp;C policy.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// Integer indicating the current version of the terms. Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&amp;C policy.
        /// </summary>
        [JsonPropertyName("version")]
        public Int32? Version { get; set; }
    
        /// <summary>
        /// Gets or sets acceptance statuses.
        /// The list of acceptance statuses for this T&amp;C policy.
        /// </summary>
        [JsonPropertyName("acceptanceStatuses")]
        public ITermsAndConditionsAcceptanceStatusesCollectionPage AcceptanceStatuses { get; set; }

        /// <summary>
        /// Gets or sets acceptanceStatusesNextLink.
        /// </summary>
        [JsonPropertyName("acceptanceStatuses@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AcceptanceStatusesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of assignments for this T&amp;C policy.
        /// </summary>
        [JsonPropertyName("assignments")]
        public ITermsAndConditionsAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets group assignments.
        /// The list of group assignments for this T&amp;C policy.
        /// </summary>
        [JsonPropertyName("groupAssignments")]
        public ITermsAndConditionsGroupAssignmentsCollectionPage GroupAssignments { get; set; }

        /// <summary>
        /// Gets or sets groupAssignmentsNextLink.
        /// </summary>
        [JsonPropertyName("groupAssignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string GroupAssignmentsNextLink { get; set; }
    
    }
}

