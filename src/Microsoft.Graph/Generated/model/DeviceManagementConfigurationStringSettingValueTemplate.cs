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
    /// The type DeviceManagementConfigurationStringSettingValueTemplate.
    /// </summary>
    public partial class DeviceManagementConfigurationStringSettingValueTemplate : DeviceManagementConfigurationSimpleSettingValueTemplate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementConfigurationStringSettingValueTemplate"/> class.
        /// </summary>
        public DeviceManagementConfigurationStringSettingValueTemplate()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationStringSettingValueTemplate";
        }

        /// <summary>
        /// Gets or sets defaultValue.
        /// String Setting Value Default Template.
        /// </summary>
        [JsonPropertyName("defaultValue")]
        public DeviceManagementConfigurationStringSettingValueDefaultTemplate DefaultValue { get; set; }
    
    }
}
