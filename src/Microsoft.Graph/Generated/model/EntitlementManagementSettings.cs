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
    /// The type Entitlement Management Settings.
    /// </summary>
    public partial class EntitlementManagementSettings : Entity
    {
    
        /// <summary>
        /// Gets or sets days until external user deleted after blocked.
        /// If externalUserLifecycleAction is BlockSignInAndDelete, the number of days after an external user is blocked from sign in before their account is deleted.
        /// </summary>
        [JsonPropertyName("daysUntilExternalUserDeletedAfterBlocked")]
        public Int32? DaysUntilExternalUserDeletedAfterBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets external user lifecycle action.
        /// One of None, BlockSignIn, or BlockSignInAndDelete.
        /// </summary>
        [JsonPropertyName("externalUserLifecycleAction")]
        public string ExternalUserLifecycleAction { get; set; }
    
    }
}

