// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Mac OSVpn Configuration.
    /// </summary>
    public partial class MacOSVpnConfiguration : AppleVpnConfiguration
    {
    
        ///<summary>
        /// The MacOSVpnConfiguration constructor
        ///</summary>
        public MacOSVpnConfiguration()
        {
            this.ODataType = "microsoft.graph.macOSVpnConfiguration";
        }

        /// <summary>
        /// Gets or sets identity certificate.
        /// Identity certificate for client authentication when authentication method is certificate.
        /// </summary>
        [JsonPropertyName("identityCertificate")]
        public MacOSCertificateProfileBase IdentityCertificate { get; set; }
    
    }
}

