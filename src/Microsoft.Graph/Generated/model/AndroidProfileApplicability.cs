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
    /// The enum AndroidProfileApplicability.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AndroidProfileApplicability
    {
    
        /// <summary>
        /// Default
        /// </summary>
        Default = 0,
	
        /// <summary>
        /// Android Work Profile
        /// </summary>
        AndroidWorkProfile = 1,
	
        /// <summary>
        /// Android Device Owner
        /// </summary>
        AndroidDeviceOwner = 2,
	
    }
}
