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
    /// The enum ErrorCode.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ErrorCode
    {
    
        /// <summary>
        /// No Error
        /// </summary>
        NoError = 0,
	
        /// <summary>
        /// Unauthorized
        /// </summary>
        Unauthorized = 1,
	
        /// <summary>
        /// Not Found
        /// </summary>
        NotFound = 2,
	
        /// <summary>
        /// Deleted
        /// </summary>
        Deleted = 3,
	
    }
}
