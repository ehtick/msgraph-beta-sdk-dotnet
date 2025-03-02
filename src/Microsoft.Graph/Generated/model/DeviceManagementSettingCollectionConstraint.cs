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
    /// The type DeviceManagementSettingCollectionConstraint.
    /// </summary>
    public partial class DeviceManagementSettingCollectionConstraint : DeviceManagementConstraint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceManagementSettingCollectionConstraint"/> class.
        /// </summary>
        public DeviceManagementSettingCollectionConstraint()
        {
            this.ODataType = "microsoft.graph.deviceManagementSettingCollectionConstraint";
        }

        /// <summary>
        /// Gets or sets maximumLength.
        /// The maximum number of elements in the collection
        /// </summary>
        [JsonPropertyName("maximumLength")]
        public Int32? MaximumLength { get; set; }
    
        /// <summary>
        /// Gets or sets minimumLength.
        /// The minimum number of elements in the collection
        /// </summary>
        [JsonPropertyName("minimumLength")]
        public Int32? MinimumLength { get; set; }
    
    }
}
