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
    /// The enum VpnOnDemandRuleConnectionAction.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VpnOnDemandRuleConnectionAction
    {
    
        /// <summary>
        /// Connect
        /// </summary>
        Connect = 0,
	
        /// <summary>
        /// Evaluate Connection
        /// </summary>
        EvaluateConnection = 1,
	
        /// <summary>
        /// Ignore
        /// </summary>
        Ignore = 2,
	
        /// <summary>
        /// Disconnect
        /// </summary>
        Disconnect = 3,
	
    }
}
