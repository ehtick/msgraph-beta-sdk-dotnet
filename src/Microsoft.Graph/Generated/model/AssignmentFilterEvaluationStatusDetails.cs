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
    /// The type Assignment Filter Evaluation Status Details.
    /// </summary>
    public partial class AssignmentFilterEvaluationStatusDetails : Entity
    {
    
        /// <summary>
        /// Gets or sets payload id.
        /// PayloadId on which filter has been applied.
        /// </summary>
        [JsonPropertyName("payloadId")]
        public string PayloadId { get; set; }
    
    }
}

