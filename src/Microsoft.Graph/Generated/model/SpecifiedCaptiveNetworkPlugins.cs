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
    /// The type SpecifiedCaptiveNetworkPlugins.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SpecifiedCaptiveNetworkPlugins>))]
    public partial class SpecifiedCaptiveNetworkPlugins
    {

        /// <summary>
        /// Gets or sets allowedBundleIdentifiers.
        /// Address of the IKEv2 server. Must be a FQDN, UserFQDN, network address, or ASN1DN
        /// </summary>
        [JsonPropertyName("allowedBundleIdentifiers")]
        public IEnumerable<string> AllowedBundleIdentifiers { get; set; }
    
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
