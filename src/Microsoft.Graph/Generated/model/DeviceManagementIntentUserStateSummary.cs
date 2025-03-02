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
    /// The type Device Management Intent User State Summary.
    /// </summary>
    public partial class DeviceManagementIntentUserStateSummary : Entity
    {
    
        /// <summary>
        /// Gets or sets conflict count.
        /// Number of users in conflict
        /// </summary>
        [JsonPropertyName("conflictCount")]
        public Int32? ConflictCount { get; set; }
    
        /// <summary>
        /// Gets or sets error count.
        /// Number of error users
        /// </summary>
        [JsonPropertyName("errorCount")]
        public Int32? ErrorCount { get; set; }
    
        /// <summary>
        /// Gets or sets failed count.
        /// Number of failed users
        /// </summary>
        [JsonPropertyName("failedCount")]
        public Int32? FailedCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable count.
        /// Number of not applicable users
        /// </summary>
        [JsonPropertyName("notApplicableCount")]
        public Int32? NotApplicableCount { get; set; }
    
        /// <summary>
        /// Gets or sets success count.
        /// Number of succeeded users
        /// </summary>
        [JsonPropertyName("successCount")]
        public Int32? SuccessCount { get; set; }
    
    }
}

