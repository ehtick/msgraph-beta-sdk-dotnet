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
    /// The type MediaConfig.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MediaConfig>))]
    public partial class MediaConfig
    {

        ///<summary>
        /// The internal MediaConfig constructor
        ///</summary>
        protected internal MediaConfig()
        {
            // Don't allow initialization of abstract complex types
        }

        /// <summary>
        /// Gets or sets removeFromDefaultAudioGroup.
        /// </summary>
        [JsonPropertyName("removeFromDefaultAudioGroup")]
        public bool? RemoveFromDefaultAudioGroup { get; set; }
    
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
