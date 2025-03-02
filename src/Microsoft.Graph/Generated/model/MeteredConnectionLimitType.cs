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
    /// The enum MeteredConnectionLimitType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MeteredConnectionLimitType
    {
    
        /// <summary>
        /// Unrestricted
        /// </summary>
        Unrestricted = 0,
	
        /// <summary>
        /// Fixed
        /// </summary>
        Fixed = 1,
	
        /// <summary>
        /// Variable
        /// </summary>
        Variable = 2,
	
    }
}
