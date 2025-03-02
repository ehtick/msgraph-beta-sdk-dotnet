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
    /// The type Comms Application.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CommsApplication>))]
    public partial class CommsApplication
    {
    
        /// <summary>
        /// Gets or sets calls.
        /// </summary>
        [JsonPropertyName("calls")]
        public ICommsApplicationCallsCollectionPage Calls { get; set; }

        /// <summary>
        /// Gets or sets callsNextLink.
        /// </summary>
        [JsonPropertyName("calls@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string CallsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets online meetings.
        /// </summary>
        [JsonPropertyName("onlineMeetings")]
        public ICommsApplicationOnlineMeetingsCollectionPage OnlineMeetings { get; set; }

        /// <summary>
        /// Gets or sets onlineMeetingsNextLink.
        /// </summary>
        [JsonPropertyName("onlineMeetings@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OnlineMeetingsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

