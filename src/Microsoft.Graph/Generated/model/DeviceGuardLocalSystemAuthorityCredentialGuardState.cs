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
    /// The enum DeviceGuardLocalSystemAuthorityCredentialGuardState.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeviceGuardLocalSystemAuthorityCredentialGuardState
    {
    
        /// <summary>
        /// Running
        /// </summary>
        Running = 0,
	
        /// <summary>
        /// Reboot Required
        /// </summary>
        RebootRequired = 1,
	
        /// <summary>
        /// Not Licensed
        /// </summary>
        NotLicensed = 2,
	
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 3,
	
        /// <summary>
        /// Virtualization Based Security Not Running
        /// </summary>
        VirtualizationBasedSecurityNotRunning = 4,
	
    }
}
