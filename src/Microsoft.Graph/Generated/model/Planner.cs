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
    /// The type Planner.
    /// </summary>
    public partial class Planner : Entity
    {
    
        /// <summary>
        /// Gets or sets buckets.
        /// Read-only. Nullable. Returns a collection of the specified buckets
        /// </summary>
        [JsonPropertyName("buckets")]
        public IPlannerBucketsCollectionPage Buckets { get; set; }

        /// <summary>
        /// Gets or sets bucketsNextLink.
        /// </summary>
        [JsonPropertyName("buckets@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string BucketsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets plans.
        /// Read-only. Nullable. Returns a collection of the specified plans
        /// </summary>
        [JsonPropertyName("plans")]
        public IPlannerPlansCollectionPage Plans { get; set; }

        /// <summary>
        /// Gets or sets plansNextLink.
        /// </summary>
        [JsonPropertyName("plans@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PlansNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets rosters.
        /// Read-only. Nullable. Returns a collection of the specified rosters
        /// </summary>
        [JsonPropertyName("rosters")]
        public IPlannerRostersCollectionPage Rosters { get; set; }

        /// <summary>
        /// Gets or sets rostersNextLink.
        /// </summary>
        [JsonPropertyName("rosters@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RostersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// Read-only. Nullable. Returns a collection of the specified tasks
        /// </summary>
        [JsonPropertyName("tasks")]
        public IPlannerTasksCollectionPage Tasks { get; set; }

        /// <summary>
        /// Gets or sets tasksNextLink.
        /// </summary>
        [JsonPropertyName("tasks@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TasksNextLink { get; set; }
    
    }
}

