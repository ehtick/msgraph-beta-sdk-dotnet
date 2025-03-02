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
    /// The type OnPremisesPublishingSingleSignOn.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OnPremisesPublishingSingleSignOn>))]
    public partial class OnPremisesPublishingSingleSignOn
    {

        /// <summary>
        /// Gets or sets kerberosSignOnSettings.
        /// The Kerberos Constrained Delegation settings for applications that use Integrated Window Authentication.
        /// </summary>
        [JsonPropertyName("kerberosSignOnSettings")]
        public KerberosSignOnSettings KerberosSignOnSettings { get; set; }
    
        /// <summary>
        /// Gets or sets singleSignOnMode.
        /// The preferred single-sign on mode for the application. Possible values are: none, onPremisesKerberos, aadHeaderBased,pingHeaderBased, oAuthToken.
        /// </summary>
        [JsonPropertyName("singleSignOnMode")]
        public SingleSignOnMode? SingleSignOnMode { get; set; }
    
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
