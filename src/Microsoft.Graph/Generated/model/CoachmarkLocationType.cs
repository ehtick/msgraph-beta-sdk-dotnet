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
    /// The enum CoachmarkLocationType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CoachmarkLocationType
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// From Email
        /// </summary>
        FromEmail = 1,
	
        /// <summary>
        /// Subject
        /// </summary>
        Subject = 2,
	
        /// <summary>
        /// External Tag
        /// </summary>
        ExternalTag = 3,
	
        /// <summary>
        /// Display Name
        /// </summary>
        DisplayName = 4,
	
        /// <summary>
        /// Message Body
        /// </summary>
        MessageBody = 5,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 6,
	
    }
}
