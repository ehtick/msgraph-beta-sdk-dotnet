// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum RoutingMode.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RoutingMode
    {
    
        /// <summary>
        /// One To One
        /// </summary>
        OneToOne = 0,
	
        /// <summary>
        /// Multicast
        /// </summary>
        Multicast = 1,
	
    }
}
