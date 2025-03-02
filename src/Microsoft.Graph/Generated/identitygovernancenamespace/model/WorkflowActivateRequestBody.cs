// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkflowActivateRequestBody.
    /// </summary>
    public partial class WorkflowActivateRequestBody
    {
    
        /// <summary>
        /// Gets or sets Subjects.
        /// </summary>
        [JsonPropertyName("subjects")]
        public IEnumerable<Microsoft.Graph.User> Subjects { get; set; }
    
    }
}
