// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.TermStore
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum TermGroupScope.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TermGroupScope
    {
    
        /// <summary>
        /// Global
        /// </summary>
        Global = 0,
	
        /// <summary>
        /// System
        /// </summary>
        System = 1,
	
        /// <summary>
        /// Site Collection
        /// </summary>
        SiteCollection = 2,
	
    }
}
