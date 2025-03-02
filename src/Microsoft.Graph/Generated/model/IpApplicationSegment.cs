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
    /// The type Ip Application Segment.
    /// </summary>
    public partial class IpApplicationSegment : ApplicationSegment
    {
    
        ///<summary>
        /// The IpApplicationSegment constructor
        ///</summary>
        public IpApplicationSegment()
        {
            this.ODataType = "microsoft.graph.ipApplicationSegment";
        }

        /// <summary>
        /// Gets or sets destination host.
        /// </summary>
        [JsonPropertyName("destinationHost")]
        public string DestinationHost { get; set; }
    
        /// <summary>
        /// Gets or sets port.
        /// </summary>
        [JsonPropertyName("port")]
        public Int32? Port { get; set; }
    
    }
}

