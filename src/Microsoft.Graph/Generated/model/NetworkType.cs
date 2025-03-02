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
    /// The enum NetworkType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NetworkType
    {
    
        /// <summary>
        /// Intranet
        /// </summary>
        Intranet = 0,
	
        /// <summary>
        /// Extranet
        /// </summary>
        Extranet = 1,
	
        /// <summary>
        /// Named Network
        /// </summary>
        NamedNetwork = 2,
	
        /// <summary>
        /// Trusted
        /// </summary>
        Trusted = 3,
	
        /// <summary>
        /// Trusted Named Location
        /// </summary>
        TrustedNamedLocation = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
