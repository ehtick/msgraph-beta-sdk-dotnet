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
    /// The type Simulation Automation.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SimulationAutomation>))]
    public partial class SimulationAutomation : Entity
    {
    
        /// <summary>
        /// Gets or sets created by.
        /// Identity of the user who created the attack simulation automation.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public EmailIdentity CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time when the attack simulation automation was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the attack simulation automation.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the attack simulation automation. Supports $filter and $orderby.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// Identity of the user who most recently modified the attack simulation automation.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public EmailIdentity LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Date and time when the attack simulation automation was most recently modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last run date time.
        /// Date and time of the latest run of the attack simulation automation.
        /// </summary>
        [JsonPropertyName("lastRunDateTime")]
        public DateTimeOffset? LastRunDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets next run date time.
        /// Date and time of the upcoming run of the attack simulation automation.
        /// </summary>
        [JsonPropertyName("nextRunDateTime")]
        public DateTimeOffset? NextRunDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Status of the attack simulation automation. Supports $filter and $orderby. The possible values are: unknown, draft, notRunning, running, completed, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("status")]
        public SimulationAutomationStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets runs.
        /// A collection of simulation automation runs.
        /// </summary>
        [JsonPropertyName("runs")]
        public ISimulationAutomationRunsCollectionPage Runs { get; set; }

        /// <summary>
        /// Gets or sets runsNextLink.
        /// </summary>
        [JsonPropertyName("runs@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RunsNextLink { get; set; }
    
    }
}

