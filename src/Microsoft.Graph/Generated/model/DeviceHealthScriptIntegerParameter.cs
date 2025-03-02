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
    /// The type DeviceHealthScriptIntegerParameter.
    /// </summary>
    public partial class DeviceHealthScriptIntegerParameter : DeviceHealthScriptParameter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceHealthScriptIntegerParameter"/> class.
        /// </summary>
        public DeviceHealthScriptIntegerParameter()
        {
            this.ODataType = "microsoft.graph.deviceHealthScriptIntegerParameter";
        }

        /// <summary>
        /// Gets or sets defaultValue.
        /// The default value of Integer param. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("defaultValue")]
        public Int32? DefaultValue { get; set; }
    
    }
}
