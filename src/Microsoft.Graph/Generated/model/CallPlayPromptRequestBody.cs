// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type CallPlayPromptRequestBody.
    /// </summary>
    public partial class CallPlayPromptRequestBody
    {
    
        /// <summary>
        /// Gets or sets Prompts.
        /// </summary>
        [JsonPropertyName("prompts")]
        public IEnumerable<Prompt> Prompts { get; set; }
    
        /// <summary>
        /// Gets or sets Loop.
        /// </summary>
        [JsonPropertyName("loop")]
        public bool? Loop { get; set; }
    
        /// <summary>
        /// Gets or sets ClientContext.
        /// </summary>
        [JsonPropertyName("clientContext")]
        public string ClientContext { get; set; }
    
    }
}
