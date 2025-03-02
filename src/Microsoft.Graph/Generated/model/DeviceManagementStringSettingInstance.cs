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
    /// The type Device Management String Setting Instance.
    /// </summary>
    public partial class DeviceManagementStringSettingInstance : DeviceManagementSettingInstance
    {
    
        ///<summary>
        /// The DeviceManagementStringSettingInstance constructor
        ///</summary>
        public DeviceManagementStringSettingInstance()
        {
            this.ODataType = "microsoft.graph.deviceManagementStringSettingInstance";
        }

        /// <summary>
        /// Gets or sets value.
        /// The string value
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    
    }
}

