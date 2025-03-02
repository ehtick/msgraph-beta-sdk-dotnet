// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum WorkflowExecutionType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkflowExecutionType
    {
    
        /// <summary>
        /// Scheduled
        /// </summary>
        Scheduled = 0,
	
        /// <summary>
        /// On Demand
        /// </summary>
        OnDemand = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}
