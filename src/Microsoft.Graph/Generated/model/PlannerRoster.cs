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
    /// The type Planner Roster.
    /// </summary>
    public partial class PlannerRoster : Entity
    {
    
        /// <summary>
        /// Gets or sets members.
        /// Retrieves the members of the plannerRoster.
        /// </summary>
        [JsonPropertyName("members")]
        public IPlannerRosterMembersCollectionPage Members { get; set; }

        /// <summary>
        /// Gets or sets membersNextLink.
        /// </summary>
        [JsonPropertyName("members@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MembersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets plans.
        /// Retrieves the plans contained by the plannerRoster.
        /// </summary>
        [JsonPropertyName("plans")]
        public IPlannerRosterPlansCollectionWithReferencesPage Plans { get; set; }

        /// <summary>
        /// Gets or sets plansNextLink.
        /// </summary>
        [JsonPropertyName("plans@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PlansNextLink { get; set; }
    
    }
}

