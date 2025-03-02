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
    /// The enum PermissionType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PermissionType
    {
    
        /// <summary>
        /// Application
        /// </summary>
        Application = 1,
	
        /// <summary>
        /// Delegated
        /// </summary>
        Delegated = 2,
	
        /// <summary>
        /// Delegated User Consentable
        /// </summary>
        DelegatedUserConsentable = 3,
	
    }
}
