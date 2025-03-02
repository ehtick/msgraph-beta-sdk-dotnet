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
    /// The enum SiteSecurityLevel.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SiteSecurityLevel
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Low
        /// </summary>
        Low = 1,
	
        /// <summary>
        /// Medium Low
        /// </summary>
        MediumLow = 2,
	
        /// <summary>
        /// Medium
        /// </summary>
        Medium = 3,
	
        /// <summary>
        /// Medium High
        /// </summary>
        MediumHigh = 4,
	
        /// <summary>
        /// High
        /// </summary>
        High = 5,
	
    }
}
