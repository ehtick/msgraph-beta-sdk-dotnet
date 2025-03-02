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
    /// The type Windows Phone81Vpn Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsPhone81VpnConfiguration>))]
    public partial class WindowsPhone81VpnConfiguration : Windows81VpnConfiguration
    {
    
        ///<summary>
        /// The WindowsPhone81VpnConfiguration constructor
        ///</summary>
        public WindowsPhone81VpnConfiguration()
        {
            this.ODataType = "microsoft.graph.windowsPhone81VpnConfiguration";
        }

        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication method. Possible values are: certificate, usernameAndPassword, sharedSecret, derivedCredential, azureAD.
        /// </summary>
        [JsonPropertyName("authenticationMethod")]
        public VpnAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets bypass vpn on company wifi.
        /// Bypass VPN on company Wi-Fi.
        /// </summary>
        [JsonPropertyName("bypassVpnOnCompanyWifi")]
        public bool? BypassVpnOnCompanyWifi { get; set; }
    
        /// <summary>
        /// Gets or sets bypass vpn on home wifi.
        /// Bypass VPN on home Wi-Fi.
        /// </summary>
        [JsonPropertyName("bypassVpnOnHomeWifi")]
        public bool? BypassVpnOnHomeWifi { get; set; }
    
        /// <summary>
        /// Gets or sets dns suffix search list.
        /// DNS suffix search list.
        /// </summary>
        [JsonPropertyName("dnsSuffixSearchList")]
        public IEnumerable<string> DnsSuffixSearchList { get; set; }
    
        /// <summary>
        /// Gets or sets remember user credentials.
        /// Remember user credentials.
        /// </summary>
        [JsonPropertyName("rememberUserCredentials")]
        public bool? RememberUserCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// Identity certificate for client authentication when authentication method is certificate.
        /// </summary>
        [JsonPropertyName("identityCertificate")]
        public WindowsPhone81CertificateProfileBase IdentityCertificate { get; set; }
    
    }
}

