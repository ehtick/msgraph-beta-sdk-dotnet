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
    /// The type Authentication Methods Root.
    /// </summary>
    public partial class AuthenticationMethodsRoot : Entity
    {
    
        /// <summary>
        /// Gets or sets user registration details.
        /// Represents the state of a user's authentication methods, including which methods are registered and which features the user is registered and capable of (such as multi-factor authentication, self-service password reset, and passwordless authentication).
        /// </summary>
        [JsonPropertyName("userRegistrationDetails")]
        public IAuthenticationMethodsRootUserRegistrationDetailsCollectionPage UserRegistrationDetails { get; set; }

        /// <summary>
        /// Gets or sets userRegistrationDetailsNextLink.
        /// </summary>
        [JsonPropertyName("userRegistrationDetails@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string UserRegistrationDetailsNextLink { get; set; }
    
    }
}

