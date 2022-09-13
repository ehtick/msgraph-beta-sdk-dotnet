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
    /// The type Microsoft Authenticator Authentication Method Target.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MicrosoftAuthenticatorAuthenticationMethodTarget>))]
    public partial class MicrosoftAuthenticatorAuthenticationMethodTarget : AuthenticationMethodTarget
    {
    
        ///<summary>
        /// The MicrosoftAuthenticatorAuthenticationMethodTarget constructor
        ///</summary>
        public MicrosoftAuthenticatorAuthenticationMethodTarget()
        {
            this.ODataType = "microsoft.graph.microsoftAuthenticatorAuthenticationMethodTarget";
        }

        /// <summary>
        /// Gets or sets authentication mode.
        /// Determines which types of notifications can be used for sign-in. The possible values are: deviceBasedPush (passwordless only), push, and any.
        /// </summary>
        [JsonPropertyName("authenticationMode")]
        public MicrosoftAuthenticatorAuthenticationMode? AuthenticationMode { get; set; }
    
        /// <summary>
        /// Gets or sets display app information required state.
        /// </summary>
        [Obsolete("The DisplayAppInformationRequiredState property is deprecated and will stop returning data on September 9, 2022. Please use the new featureSetting DisplayAppInformationRequiredState property.")]
        [JsonPropertyName("displayAppInformationRequiredState")]
        public AdvancedConfigState? DisplayAppInformationRequiredState { get; set; }
    
        /// <summary>
        /// Gets or sets number matching required state.
        /// </summary>
        [Obsolete("The NumberMatchingRequiredState property is deprecated and will stop returning data on September 9, 2022. Please use the new featureSetting NumberMatchingRequiredState property.")]
        [JsonPropertyName("numberMatchingRequiredState")]
        public AdvancedConfigState? NumberMatchingRequiredState { get; set; }
    
    }
}

