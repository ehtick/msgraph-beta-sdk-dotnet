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
    /// The enum DeviceManagementAutopilotPolicyComplianceStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeviceManagementAutopilotPolicyComplianceStatus
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Compliant
        /// </summary>
        Compliant = 1,
	
        /// <summary>
        /// Installed
        /// </summary>
        Installed = 2,
	
        /// <summary>
        /// Not Compliant
        /// </summary>
        NotCompliant = 3,
	
        /// <summary>
        /// Not Installed
        /// </summary>
        NotInstalled = 4,
	
        /// <summary>
        /// Error
        /// </summary>
        Error = 5,
	
    }
}
