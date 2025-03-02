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
    /// The enum MacOSContentCachingClientPolicy.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MacOSContentCachingClientPolicy
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Clients In Local Network
        /// </summary>
        ClientsInLocalNetwork = 1,
	
        /// <summary>
        /// Clients With Same Public Ip Address
        /// </summary>
        ClientsWithSamePublicIpAddress = 2,
	
        /// <summary>
        /// Clients In Custom Local Networks
        /// </summary>
        ClientsInCustomLocalNetworks = 3,
	
        /// <summary>
        /// Clients In Custom Local Networks With Fallback
        /// </summary>
        ClientsInCustomLocalNetworksWithFallback = 4,
	
    }
}
