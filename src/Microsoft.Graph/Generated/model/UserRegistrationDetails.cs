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
    /// The type User Registration Details.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserRegistrationDetails>))]
    public partial class UserRegistrationDetails : Entity
    {
    
        /// <summary>
        /// Gets or sets default mfa method.
        /// The method the user or admin selected as default for performing multi-factor authentication for the user. The possible values are: none, mobilePhone, alternateMobilePhone, officePhone, microsoftAuthenticatorPush, softwareOneTimePasscode, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("defaultMfaMethod")]
        public DefaultMfaMethodType? DefaultMfaMethod { get; set; }
    
        /// <summary>
        /// Gets or sets is admin.
        /// Whether the user has an admin role in the tenant. This value can be used to check the authentication methods that privileged accounts are registered for and capable of.
        /// </summary>
        [JsonPropertyName("isAdmin")]
        public bool? IsAdmin { get; set; }
    
        /// <summary>
        /// Gets or sets is mfa capable.
        /// Whether the user has registered a strong authentication method for multi-factor authentication. The method must be allowed by the authentication methods policy. Supports $filter (eq).
        /// </summary>
        [JsonPropertyName("isMfaCapable")]
        public bool? IsMfaCapable { get; set; }
    
        /// <summary>
        /// Gets or sets is mfa registered.
        /// Whether the user has registered a strong authentication method for multi-factor authentication. The method may not necessarily be allowed by the authentication methods policy.  Supports $filter (eq).
        /// </summary>
        [JsonPropertyName("isMfaRegistered")]
        public bool? IsMfaRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets is passwordless capable.
        /// Whether the user has registered a passwordless strong authentication method (including FIDO2, Windows Hello for Business, and Microsoft Authenticator (Passwordless)) that is allowed by the authentication methods policy. Supports $filter (eq).
        /// </summary>
        [JsonPropertyName("isPasswordlessCapable")]
        public bool? IsPasswordlessCapable { get; set; }
    
        /// <summary>
        /// Gets or sets is sspr capable.
        /// Whether the user has registered the required number of authentication methods for self-service password reset and the user is allowed to perform self-service password reset by policy. Supports $filter (eq).
        /// </summary>
        [JsonPropertyName("isSsprCapable")]
        public bool? IsSsprCapable { get; set; }
    
        /// <summary>
        /// Gets or sets is sspr enabled.
        /// Whether the user is allowed to perform self-service password reset by policy. The user may not necessarily have registered the required number of authentication methods for self-service password reset. Supports $filter (eq).
        /// </summary>
        [JsonPropertyName("isSsprEnabled")]
        public bool? IsSsprEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets is sspr registered.
        /// Whether the user has registered the required number of authentication methods for self-service password reset. The user may not necessarily be allowed to perform self-service password reset by policy. Supports $filter (eq).
        /// </summary>
        [JsonPropertyName("isSsprRegistered")]
        public bool? IsSsprRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets methods registered.
        /// Collection of authentication methods registered, such as mobilePhone, email, fido2. Supports $filter (any with eq).
        /// </summary>
        [JsonPropertyName("methodsRegistered")]
        public IEnumerable<string> MethodsRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// The user display name, such as Adele Vance. Supports $filter (eq, startsWith) and $orderBy.
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The user principal name, such as AdeleV@contoso.com. Supports $filter (eq, startsWith) and $orderBy.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets user type.
        /// Identifies whether the user is a member or guest in the tenant. The possible values are: member, guest, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("userType")]
        public SignInUserType? UserType { get; set; }
    
    }
}

