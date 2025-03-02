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
    /// The type Planner Plan Details.
    /// </summary>
    public partial class PlannerPlanDetails : PlannerDelta
    {
    
        ///<summary>
        /// The PlannerPlanDetails constructor
        ///</summary>
        public PlannerPlanDetails()
        {
            this.ODataType = "microsoft.graph.plannerPlanDetails";
        }

        /// <summary>
        /// Gets or sets category descriptions.
        /// An object that specifies the descriptions of the 25 categories that can be associated with tasks in the plan.
        /// </summary>
        [JsonPropertyName("categoryDescriptions")]
        public PlannerCategoryDescriptions CategoryDescriptions { get; set; }
    
        /// <summary>
        /// Gets or sets context details.
        /// A collection of additional information associated with plannerPlanContext entries that are defined for the plannerPlan container. Read-only.
        /// </summary>
        [JsonPropertyName("contextDetails")]
        public PlannerPlanContextDetailsCollection ContextDetails { get; set; }
    
        /// <summary>
        /// Gets or sets shared with.
        /// The set of user IDs that this plan is shared with. If you are using Microsoft 365 groups, use the groups API to manage group membership to share the group's plan. You can also add existing members of the group to this collection, although it is not required in order for them to access the plan owned by the group.
        /// </summary>
        [JsonPropertyName("sharedWith")]
        public PlannerUserIds SharedWith { get; set; }
    
    }
}

