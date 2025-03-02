// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.SecurityNamespace
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum DefaultRecordBehavior.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DefaultRecordBehavior
    {
    
        /// <summary>
        /// Start Locked
        /// </summary>
        StartLocked = 0,
	
        /// <summary>
        /// Start Unlocked
        /// </summary>
        StartUnlocked = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}
