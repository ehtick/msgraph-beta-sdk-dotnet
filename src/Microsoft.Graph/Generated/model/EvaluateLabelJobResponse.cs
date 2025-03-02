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
    /// The type Evaluate Label Job Response.
    /// </summary>
    public partial class EvaluateLabelJobResponse : JobResponseBase
    {
    
        ///<summary>
        /// The EvaluateLabelJobResponse constructor
        ///</summary>
        public EvaluateLabelJobResponse()
        {
            this.ODataType = "microsoft.graph.evaluateLabelJobResponse";
        }

        /// <summary>
        /// Gets or sets result.
        /// </summary>
        [JsonPropertyName("result")]
        public EvaluateLabelJobResultGroup Result { get; set; }
    
    }
}

