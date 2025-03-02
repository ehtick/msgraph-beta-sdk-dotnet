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
    /// The type Directory Setting.
    /// </summary>
    public partial class DirectorySetting : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of this group of settings, which comes from the associated template. Read-only.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets template id.
        /// Unique identifier for the template used to create this group of settings. Read-only.
        /// </summary>
        [JsonPropertyName("templateId")]
        public string TemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// Collection of name-value pairs corresponding to the name and defaultValue properties in the referenced directorySettingTemplates object.
        /// </summary>
        [JsonPropertyName("values")]
        public IEnumerable<SettingValue> Values { get; set; }
    
    }
}

