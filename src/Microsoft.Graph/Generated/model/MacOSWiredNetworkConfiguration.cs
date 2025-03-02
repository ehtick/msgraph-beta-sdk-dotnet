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
    /// The type Mac OSWired Network Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MacOSWiredNetworkConfiguration>))]
    public partial class MacOSWiredNetworkConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The MacOSWiredNetworkConfiguration constructor
        ///</summary>
        public MacOSWiredNetworkConfiguration()
        {
            this.ODataType = "microsoft.graph.macOSWiredNetworkConfiguration";
        }

        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication Method when EAP Type is configured to PEAP or EAP-TTLS. Possible values are: certificate, usernameAndPassword, derivedCredential.
        /// </summary>
        [JsonPropertyName("authenticationMethod")]
        public WiFiAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets eap fast configuration.
        /// EAP-FAST Configuration Option when EAP-FAST is the selected EAP Type. Possible values are: noProtectedAccessCredential, useProtectedAccessCredential, useProtectedAccessCredentialAndProvision, useProtectedAccessCredentialAndProvisionAnonymously.
        /// </summary>
        [JsonPropertyName("eapFastConfiguration")]
        public EapFastConfiguration? EapFastConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets eap type.
        /// Extensible Authentication Protocol (EAP). Indicates the type of EAP protocol set on the wired network. Possible values are: eapTls, leap, eapSim, eapTtls, peap, eapFast, teap.
        /// </summary>
        [JsonPropertyName("eapType")]
        public EapType? EapType { get; set; }
    
        /// <summary>
        /// Gets or sets enable outer identity privacy.
        /// Enable identity privacy (Outer Identity) when EAP Type is configured to EAP-TTLS, EAP-FAST or PEAP. This property masks usernames with the text you enter. For example, if you use 'anonymous', each user that authenticates with this wired network using their real username is displayed as 'anonymous'.
        /// </summary>
        [JsonPropertyName("enableOuterIdentityPrivacy")]
        public string EnableOuterIdentityPrivacy { get; set; }
    
        /// <summary>
        /// Gets or sets network interface.
        /// Network interface. Possible values are: anyEthernet, firstActiveEthernet, secondActiveEthernet, thirdActiveEthernet, firstEthernet, secondEthernet, thirdEthernet.
        /// </summary>
        [JsonPropertyName("networkInterface")]
        public WiredNetworkInterface? NetworkInterface { get; set; }
    
        /// <summary>
        /// Gets or sets network name.
        /// Network Name
        /// </summary>
        [JsonPropertyName("networkName")]
        public string NetworkName { get; set; }
    
        /// <summary>
        /// Gets or sets non eap authentication method for eap ttls.
        /// Non-EAP Method for Authentication (Inner Identity) when EAP Type is EAP-TTLS and Authenticationmethod is Username and Password. Possible values are: unencryptedPassword, challengeHandshakeAuthenticationProtocol, microsoftChap, microsoftChapVersionTwo.
        /// </summary>
        [JsonPropertyName("nonEapAuthenticationMethodForEapTtls")]
        public NonEapAuthenticationMethodForEapTtlsType? NonEapAuthenticationMethodForEapTtls { get; set; }
    
        /// <summary>
        /// Gets or sets trusted server certificate names.
        /// Trusted server certificate names when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP. This is the common name used in the certificates issued by your trusted certificate authority (CA). If you provide this information, you can bypass the dynamic trust dialog that is displayed on end users devices when they connect to this wired network.
        /// </summary>
        [JsonPropertyName("trustedServerCertificateNames")]
        public IEnumerable<string> TrustedServerCertificateNames { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate for client authentication.
        /// Identity Certificate for client authentication when EAP Type is configured to EAP-TLS, EAP-TTLS (with Certificate Authentication), or PEAP (with Certificate Authentication).
        /// </summary>
        [JsonPropertyName("identityCertificateForClientAuthentication")]
        public MacOSCertificateProfileBase IdentityCertificateForClientAuthentication { get; set; }
    
        /// <summary>
        /// Gets or sets root certificate for server validation.
        /// Trusted Root Certificate for Server Validation when EAP Type is configured to EAP-TLS/TTLS/FAST or PEAP.
        /// </summary>
        [JsonPropertyName("rootCertificateForServerValidation")]
        public MacOSTrustedRootCertificate RootCertificateForServerValidation { get; set; }
    
    }
}

