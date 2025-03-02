// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type DeviceManagementTemplateCreateInstanceRequestBody.
    /// </summary>
    public partial class DeviceManagementTemplateCreateInstanceRequestBody
    {
    
        /// <summary>
        /// Gets or sets DisplayName.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets SettingsDelta.
        /// </summary>
        [JsonPropertyName("settingsDelta")]
        public IEnumerable<DeviceManagementSettingInstance> SettingsDelta { get; set; }
    
        /// <summary>
        /// Gets or sets RoleScopeTagIds.
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
    }
}
