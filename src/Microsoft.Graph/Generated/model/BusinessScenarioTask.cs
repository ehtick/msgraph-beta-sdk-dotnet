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
    /// The type Business Scenario Task.
    /// </summary>
    public partial class BusinessScenarioTask : PlannerTask
    {
    
        ///<summary>
        /// The BusinessScenarioTask constructor
        ///</summary>
        public BusinessScenarioTask()
        {
            this.ODataType = "microsoft.graph.businessScenarioTask";
        }

        /// <summary>
        /// Gets or sets business scenario properties.
        /// Scenario-specific properties of the task. externalObjectId and externalBucketId properties must be specified when creating a task.
        /// </summary>
        [JsonPropertyName("businessScenarioProperties")]
        public BusinessScenarioProperties BusinessScenarioProperties { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// Target of the task that specifies where the task should be placed. Must be specified when creating a task.
        /// </summary>
        [JsonPropertyName("target")]
        public BusinessScenarioTaskTargetBase Target { get; set; }
    
    }
}

