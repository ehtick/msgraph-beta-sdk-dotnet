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
    /// The enum ConnectorHealthState.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ConnectorHealthState
    {
    
        /// <summary>
        /// Healthy
        /// </summary>
        Healthy = 0,
	
        /// <summary>
        /// Warning
        /// </summary>
        Warning = 1,
	
        /// <summary>
        /// Unhealthy
        /// </summary>
        Unhealthy = 2,
	
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 3,
	
    }
}
