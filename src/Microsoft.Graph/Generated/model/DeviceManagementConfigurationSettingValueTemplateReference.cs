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
    /// The type DeviceManagementConfigurationSettingValueTemplateReference.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceManagementConfigurationSettingValueTemplateReference>))]
    public partial class DeviceManagementConfigurationSettingValueTemplateReference
    {

        /// <summary>
        /// Gets or sets settingValueTemplateId.
        /// Setting value template id
        /// </summary>
        [JsonPropertyName("settingValueTemplateId")]
        public string SettingValueTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets useTemplateDefault.
        /// Indicates whether to update policy setting value to match template setting default value
        /// </summary>
        [JsonPropertyName("useTemplateDefault")]
        public bool? UseTemplateDefault { get; set; }
    
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
