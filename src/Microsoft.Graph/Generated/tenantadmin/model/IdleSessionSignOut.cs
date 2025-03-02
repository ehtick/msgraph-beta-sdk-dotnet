// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.TenantAdmin
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type IdleSessionSignOut.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<IdleSessionSignOut>))]
    public partial class IdleSessionSignOut
    {

        /// <summary>
        /// Gets or sets isEnabled.
        /// Indicates whether the idle session sign-out policy is enabled.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets signOutAfterInSeconds.
        /// Number of seconds of inactivity after which a user is signed out.
        /// </summary>
        [JsonPropertyName("signOutAfterInSeconds")]
        public Int64? SignOutAfterInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets warnAfterInSeconds.
        /// Number of seconds of inactivity after which a user is notified that they'll be signed out.
        /// </summary>
        [JsonPropertyName("warnAfterInSeconds")]
        public Int64? WarnAfterInSeconds { get; set; }
    
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
