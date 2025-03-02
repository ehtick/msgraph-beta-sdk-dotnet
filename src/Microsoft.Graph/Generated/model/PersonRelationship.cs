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
    /// The enum PersonRelationship.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PersonRelationship
    {
    
        /// <summary>
        /// Manager
        /// </summary>
        Manager = 0,
	
        /// <summary>
        /// Colleague
        /// </summary>
        Colleague = 1,
	
        /// <summary>
        /// Direct Report
        /// </summary>
        DirectReport = 2,
	
        /// <summary>
        /// Dot Line Report
        /// </summary>
        DotLineReport = 3,
	
        /// <summary>
        /// Assistant
        /// </summary>
        Assistant = 4,
	
        /// <summary>
        /// Dot Line Manager
        /// </summary>
        DotLineManager = 5,
	
        /// <summary>
        /// Alternate Contact
        /// </summary>
        AlternateContact = 6,
	
        /// <summary>
        /// Friend
        /// </summary>
        Friend = 7,
	
        /// <summary>
        /// Spouse
        /// </summary>
        Spouse = 8,
	
        /// <summary>
        /// Sibling
        /// </summary>
        Sibling = 9,
	
        /// <summary>
        /// Child
        /// </summary>
        Child = 10,
	
        /// <summary>
        /// Parent
        /// </summary>
        Parent = 11,
	
        /// <summary>
        /// Sponsor
        /// </summary>
        Sponsor = 12,
	
        /// <summary>
        /// Emergency Contact
        /// </summary>
        EmergencyContact = 13,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 14,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 15,
	
    }
}
