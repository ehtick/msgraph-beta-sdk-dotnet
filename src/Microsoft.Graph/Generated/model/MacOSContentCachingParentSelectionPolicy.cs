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
    /// The enum MacOSContentCachingParentSelectionPolicy.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MacOSContentCachingParentSelectionPolicy
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Round Robin
        /// </summary>
        RoundRobin = 1,
	
        /// <summary>
        /// First Available
        /// </summary>
        FirstAvailable = 2,
	
        /// <summary>
        /// Url Path Hash
        /// </summary>
        UrlPathHash = 3,
	
        /// <summary>
        /// Random
        /// </summary>
        Random = 4,
	
        /// <summary>
        /// Sticky Available
        /// </summary>
        StickyAvailable = 5,
	
    }
}
