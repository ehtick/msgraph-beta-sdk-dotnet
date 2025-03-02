// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ManagementCertificateWithThumbprint.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ManagementCertificateWithThumbprint>))]
    public partial class ManagementCertificateWithThumbprint
    {

        /// <summary>
        /// Gets or sets certificate.
        /// The Base 64 encoded management certificate
        /// </summary>
        [JsonPropertyName("certificate")]
        public string Certificate { get; set; }
    
        /// <summary>
        /// Gets or sets thumbprint.
        /// The thumbprint of the management certificate
        /// </summary>
        [JsonPropertyName("thumbprint")]
        public string Thumbprint { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
