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
    /// The enum TeamworkSupportedClient.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TeamworkSupportedClient
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Skype Default And Teams
        /// </summary>
        SkypeDefaultAndTeams = 1,
	
        /// <summary>
        /// Teams Default And Skype
        /// </summary>
        TeamsDefaultAndSkype = 2,
	
        /// <summary>
        /// Skype Only
        /// </summary>
        SkypeOnly = 3,
	
        /// <summary>
        /// Teams Only
        /// </summary>
        TeamsOnly = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
