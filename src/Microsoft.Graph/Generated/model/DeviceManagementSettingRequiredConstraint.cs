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
    /// The type DeviceManagementSettingRequiredConstraint.
    /// </summary>
    public partial class DeviceManagementSettingRequiredConstraint : DeviceManagementConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementSettingRequiredConstraint"/> class.
        /// </summary>
        public DeviceManagementSettingRequiredConstraint()
        {
            this.ODataType = "microsoft.graph.deviceManagementSettingRequiredConstraint";
        }

        /// <summary>
        /// Gets or sets notConfiguredValue.
        /// List of value which means not configured for the setting
        /// </summary>
        [JsonPropertyName("notConfiguredValue")]
        public string NotConfiguredValue { get; set; }
    
    }
}
