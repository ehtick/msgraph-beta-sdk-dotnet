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
    /// The enum CertificateRevocationStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CertificateRevocationStatus
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Pending
        /// </summary>
        Pending = 1,
	
        /// <summary>
        /// Issued
        /// </summary>
        Issued = 2,
	
        /// <summary>
        /// Failed
        /// </summary>
        Failed = 3,
	
        /// <summary>
        /// Revoked
        /// </summary>
        Revoked = 4,
	
    }
}
