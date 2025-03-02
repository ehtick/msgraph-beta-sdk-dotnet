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
    /// The enum EmbeddedSIMDeviceStateValue.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EmbeddedSIMDeviceStateValue
    {
    
        /// <summary>
        /// Not Evaluated
        /// </summary>
        NotEvaluated = 0,
	
        /// <summary>
        /// Failed
        /// </summary>
        Failed = 1,
	
        /// <summary>
        /// Installing
        /// </summary>
        Installing = 2,
	
        /// <summary>
        /// Installed
        /// </summary>
        Installed = 3,
	
        /// <summary>
        /// Deleting
        /// </summary>
        Deleting = 4,
	
        /// <summary>
        /// Error
        /// </summary>
        Error = 5,
	
        /// <summary>
        /// Deleted
        /// </summary>
        Deleted = 6,
	
        /// <summary>
        /// Removed By User
        /// </summary>
        RemovedByUser = 7,
	
    }
}
