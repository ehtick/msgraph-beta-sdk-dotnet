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
    /// The enum AttributeType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AttributeType
    {
    
        /// <summary>
        /// String
        /// </summary>
        @String = 0,
	
        /// <summary>
        /// Integer
        /// </summary>
        Integer = 1,
	
        /// <summary>
        /// Reference
        /// </summary>
        Reference = 2,
	
        /// <summary>
        /// Binary
        /// </summary>
        Binary = 3,
	
        /// <summary>
        /// Boolean
        /// </summary>
        Boolean = 4,
	
        /// <summary>
        /// Date Time
        /// </summary>
        DateTime = 5,
	
    }
}
