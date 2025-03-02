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
    /// The type Authentication Method Mode Detail.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AuthenticationMethodModeDetail>))]
    public partial class AuthenticationMethodModeDetail : Entity
    {
    
        /// <summary>
        /// Gets or sets authentication method.
        /// The authentication method that this mode modifies. The possible values are: password, voice, hardwareOath, softwareOath, sms, fido2, windowsHelloForBusiness, microsoftAuthenticator, temporaryAccessPass, email, x509Certificate, federation, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("authenticationMethod")]
        public BaseAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of this mode
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
    }
}

