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
    /// The type AndroidMinimumOperatingSystem.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AndroidMinimumOperatingSystem>))]
    public partial class AndroidMinimumOperatingSystem
    {

        /// <summary>
        /// Gets or sets v10_0.
        /// When TRUE, only Version 10.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v10_0")]
        public bool? V10_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v11_0.
        /// When TRUE, only Version 11.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v11_0")]
        public bool? V11_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v4_0.
        /// When TRUE, only Version 4.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v4_0")]
        public bool? V4_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v4_0_3.
        /// When TRUE, only Version 4.0.3 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v4_0_3")]
        public bool? V4_0_3 { get; set; }
    
        /// <summary>
        /// Gets or sets v4_1.
        /// When TRUE, only Version 4.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v4_1")]
        public bool? V4_1 { get; set; }
    
        /// <summary>
        /// Gets or sets v4_2.
        /// When TRUE, only Version 4.2 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v4_2")]
        public bool? V4_2 { get; set; }
    
        /// <summary>
        /// Gets or sets v4_3.
        /// When TRUE, only Version 4.3 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v4_3")]
        public bool? V4_3 { get; set; }
    
        /// <summary>
        /// Gets or sets v4_4.
        /// When TRUE, only Version 4.4 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v4_4")]
        public bool? V4_4 { get; set; }
    
        /// <summary>
        /// Gets or sets v5_0.
        /// When TRUE, only Version 5.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v5_0")]
        public bool? V5_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v5_1.
        /// When TRUE, only Version 5.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v5_1")]
        public bool? V5_1 { get; set; }
    
        /// <summary>
        /// Gets or sets v6_0.
        /// When TRUE, only Version 6.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v6_0")]
        public bool? V6_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v7_0.
        /// When TRUE, only Version 7.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v7_0")]
        public bool? V7_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v7_1.
        /// When TRUE, only Version 7.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v7_1")]
        public bool? V7_1 { get; set; }
    
        /// <summary>
        /// Gets or sets v8_0.
        /// When TRUE, only Version 8.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v8_0")]
        public bool? V8_0 { get; set; }
    
        /// <summary>
        /// Gets or sets v8_1.
        /// When TRUE, only Version 8.1 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v8_1")]
        public bool? V8_1 { get; set; }
    
        /// <summary>
        /// Gets or sets v9_0.
        /// When TRUE, only Version 9.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.
        /// </summary>
        [JsonPropertyName("v9_0")]
        public bool? V9_0 { get; set; }
    
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
