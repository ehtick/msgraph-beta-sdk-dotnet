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
    /// The type Role Management.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RoleManagement>))]
    public partial class RoleManagement
    {
    
        /// <summary>
        /// Gets or sets directory.
        /// </summary>
        [JsonPropertyName("directory")]
        public RbacApplication Directory { get; set; }
    
        /// <summary>
        /// Gets or sets cloud pc.
        /// </summary>
        [JsonPropertyName("cloudPC")]
        public RbacApplicationMultiple CloudPC { get; set; }
    
        /// <summary>
        /// Gets or sets exchange.
        /// </summary>
        [JsonPropertyName("exchange")]
        public UnifiedRbacApplication Exchange { get; set; }
    
        /// <summary>
        /// Gets or sets entitlement management.
        /// The RbacApplication for Entitlement Management
        /// </summary>
        [JsonPropertyName("entitlementManagement")]
        public RbacApplication EntitlementManagement { get; set; }
    
        /// <summary>
        /// Gets or sets device management.
        /// The RbacApplication for Device Management
        /// </summary>
        [JsonPropertyName("deviceManagement")]
        public RbacApplicationMultiple DeviceManagement { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

