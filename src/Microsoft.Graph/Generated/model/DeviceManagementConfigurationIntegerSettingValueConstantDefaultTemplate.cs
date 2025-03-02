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
    /// The type DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate.
    /// </summary>
    public partial class DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate : DeviceManagementConfigurationIntegerSettingValueDefaultTemplate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate"/> class.
        /// </summary>
        public DeviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationIntegerSettingValueConstantDefaultTemplate";
        }

        /// <summary>
        /// Gets or sets constantValue.
        /// Default Constant Value. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("constantValue")]
        public Int32? ConstantValue { get; set; }
    
    }
}
