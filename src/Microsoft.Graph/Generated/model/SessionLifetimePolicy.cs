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
    /// The type SessionLifetimePolicy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SessionLifetimePolicy>))]
    public partial class SessionLifetimePolicy
    {

        /// <summary>
        /// Gets or sets detail.
        /// The human-readable details of the conditional access session management policy applied to the sign-in.
        /// </summary>
        [JsonPropertyName("detail")]
        public string Detail { get; set; }
    
        /// <summary>
        /// Gets or sets expirationRequirement.
        /// If a conditional access session management policy required the user to authenticate in this sign-in event, this field describes the policy type that required authentication. The possible values are: rememberMultifactorAuthenticationOnTrustedDevices, tenantTokenLifetimePolicy, audienceTokenLifetimePolicy, signInFrequencyPeriodicReauthentication, ngcMfa, signInFrequencyEveryTime, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("expirationRequirement")]
        public ExpirationRequirement? ExpirationRequirement { get; set; }
    
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
