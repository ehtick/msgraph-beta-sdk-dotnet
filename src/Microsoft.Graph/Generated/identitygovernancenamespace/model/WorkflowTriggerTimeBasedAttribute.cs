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
    /// The enum WorkflowTriggerTimeBasedAttribute.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkflowTriggerTimeBasedAttribute
    {
    
        /// <summary>
        /// Employee Hire Date
        /// </summary>
        EmployeeHireDate = 0,
	
        /// <summary>
        /// Employee Leave Date Time
        /// </summary>
        EmployeeLeaveDateTime = 1,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 2,
	
    }
}
