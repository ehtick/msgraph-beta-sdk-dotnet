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
    /// The type Device Management Configuration Category.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceManagementConfigurationCategory>))]
    public partial class DeviceManagementConfigurationCategory : Entity
    {
    
        /// <summary>
        /// Gets or sets category description.
        /// Description of the category header
        /// </summary>
        [JsonPropertyName("categoryDescription")]
        public string CategoryDescription { get; set; }
    
        /// <summary>
        /// Gets or sets child category ids.
        /// List of child ids of the category.
        /// </summary>
        [JsonPropertyName("childCategoryIds")]
        public IEnumerable<string> ChildCategoryIds { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the item
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the item
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets help text.
        /// Help text of the item
        /// </summary>
        [JsonPropertyName("helpText")]
        public string HelpText { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Name of the item
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets parent category id.
        /// Parent id of the category.
        /// </summary>
        [JsonPropertyName("parentCategoryId")]
        public string ParentCategoryId { get; set; }
    
        /// <summary>
        /// Gets or sets platforms.
        /// Platforms types, which settings in the category have. Possible values are: none, android, iOS, macOS, windows10X, windows10, linux, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("platforms")]
        public DeviceManagementConfigurationPlatforms? Platforms { get; set; }
    
        /// <summary>
        /// Gets or sets root category id.
        /// Root id of the category.
        /// </summary>
        [JsonPropertyName("rootCategoryId")]
        public string RootCategoryId { get; set; }
    
        /// <summary>
        /// Gets or sets setting usage.
        /// Indicates that the category contains settings that are used for Compliance or Configuration. Possible values are: none, configuration, compliance.
        /// </summary>
        [JsonPropertyName("settingUsage")]
        public DeviceManagementConfigurationSettingUsage? SettingUsage { get; set; }
    
        /// <summary>
        /// Gets or sets technologies.
        /// Technologies types, which settings in the category have. Possible values are: none, mdm, windows10XManagement, configManager, appleRemoteManagement, microsoftSense, exchangeOnline, linuxMdm, enrollment, endpointPrivilegeManagement, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("technologies")]
        public DeviceManagementConfigurationTechnologies? Technologies { get; set; }
    
    }
}

