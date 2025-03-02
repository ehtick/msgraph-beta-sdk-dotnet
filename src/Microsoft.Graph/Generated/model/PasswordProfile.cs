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
    /// The type PasswordProfile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PasswordProfile>))]
    public partial class PasswordProfile
    {

        /// <summary>
        /// Gets or sets forceChangePasswordNextSignIn.
        /// true if the user must change her password on the next login; otherwise false. If not set, default is false.
        /// </summary>
        [JsonPropertyName("forceChangePasswordNextSignIn")]
        public bool? ForceChangePasswordNextSignIn { get; set; }
    
        /// <summary>
        /// Gets or sets forceChangePasswordNextSignInWithMfa.
        /// If true, at next sign-in, the user must perform a multi-factor authentication (MFA) before being forced to change their password. The behavior is identical to forceChangePasswordNextSignIn except that the user is required to first perform a multi-factor authentication before password change. After a password change, this property will be automatically reset to false. If not set, default is false.
        /// </summary>
        [JsonPropertyName("forceChangePasswordNextSignInWithMfa")]
        public bool? ForceChangePasswordNextSignInWithMfa { get; set; }
    
        /// <summary>
        /// Gets or sets password.
        /// The password for the user. This property is required when a user is created. It can be updated, but the user will be required to change the password on the next login. The password must satisfy minimum requirements as specified by the user’s passwordPolicies property. By default, a strong password is required.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }
    
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
