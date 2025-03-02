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
    /// The type WorkbookFunctionsLookupRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsLookupRequestBody
    {
    
        /// <summary>
        /// Gets or sets LookupValue.
        /// </summary>
        [JsonPropertyName("lookupValue")]
        public System.Text.Json.JsonDocument LookupValue { get; set; }
    
        /// <summary>
        /// Gets or sets LookupVector.
        /// </summary>
        [JsonPropertyName("lookupVector")]
        public System.Text.Json.JsonDocument LookupVector { get; set; }
    
        /// <summary>
        /// Gets or sets ResultVector.
        /// </summary>
        [JsonPropertyName("resultVector")]
        public System.Text.Json.JsonDocument ResultVector { get; set; }
    
    }
}
