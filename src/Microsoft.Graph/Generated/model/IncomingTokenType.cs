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
    /// The enum IncomingTokenType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
	[System.Flags]
    public enum IncomingTokenType
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Primary Refresh Token
        /// </summary>
        PrimaryRefreshToken = 1,
	
        /// <summary>
        /// Saml11
        /// </summary>
        Saml11 = 2,
	
        /// <summary>
        /// Saml20
        /// </summary>
        Saml20 = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 8,
	
        /// <summary>
        /// Remote Desktop Token
        /// </summary>
        RemoteDesktopToken = 16,
	
    }
}
