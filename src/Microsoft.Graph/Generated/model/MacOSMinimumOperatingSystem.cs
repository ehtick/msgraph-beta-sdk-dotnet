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
    /// The type MacOSMinimumOperatingSystem.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MacOSMinimumOperatingSystem>))]
    public partial class MacOSMinimumOperatingSystem
    {

        /// <summary>
        /// Gets or sets v10_10.
        /// When TRUE, indicates macOS 10.10 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v10_10")]
        public bool? V10_10 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_11.
        /// When TRUE, indicates macOS 10.11 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v10_11")]
        public bool? V10_11 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_12.
        /// When TRUE, indicates macOS 10.12 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v10_12")]
        public bool? V10_12 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_13.
        /// When TRUE, indicates macOS 10.13 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v10_13")]
        public bool? V10_13 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_14.
        /// When TRUE, indicates macOS 10.14 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v10_14")]
        public bool? V10_14 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_15.
        /// When TRUE, indicates macOS 10.15 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v10_15")]
        public bool? V10_15 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_7.
        /// When TRUE, indicates macOS 10.7 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v10_7")]
        public bool? V10_7 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_8.
        /// When TRUE, indicates macOS 10.8 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v10_8")]
        public bool? V10_8 { get; set; }
    
        /// <summary>
        /// Gets or sets v10_9.
        /// When TRUE, indicates macOS 10.9 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v10_9")]
        public bool? V10_9 { get; set; }
    
        /// <summary>
        /// Gets or sets v11_0.
        /// When TRUE, indicates macOS 11.0 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v11_0")]
        public bool? V11_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v12_0.
        /// When TRUE, indicates macOS 12.0 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v12_0")]
        public bool? V12_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v13_0.
        /// When TRUE, indicates macOS 13.0 or later is required to install the app. When FALSE, indicates some other OS version is the minimum OS to install the app. Default value is FALSE.
        /// </summary>
        [JsonPropertyName("v13_0")]
        public bool? V13_0 { get; set; }
    
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
