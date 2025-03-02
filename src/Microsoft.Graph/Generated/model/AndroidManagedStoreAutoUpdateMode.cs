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
    /// The enum AndroidManagedStoreAutoUpdateMode.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AndroidManagedStoreAutoUpdateMode
    {
    
        /// <summary>
        /// Default
        /// </summary>
        Default = 0,
	
        /// <summary>
        /// Postponed
        /// </summary>
        Postponed = 1,
	
        /// <summary>
        /// Priority
        /// </summary>
        Priority = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
    }
}
