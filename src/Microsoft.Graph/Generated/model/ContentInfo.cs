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
    /// The type ContentInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ContentInfo>))]
    public partial class ContentInfo
    {

        /// <summary>
        /// Gets or sets format.
        /// Possible values are: default, email.
        /// </summary>
        [JsonPropertyName("format")]
        public ContentFormat? Format { get; set; }
    
        /// <summary>
        /// Gets or sets identifier.
        /// Identifier used for Azure Information Protection Analytics.
        /// </summary>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }
    
        /// <summary>
        /// Gets or sets metadata.
        /// Existing Microsoft Purview Information Protection metadata is passed as key/value pairs, where the key is the MSIP_Label_GUID_PropName.
        /// </summary>
        [JsonPropertyName("metadata")]
        public IEnumerable<KeyValuePair> Metadata { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Possible values are: rest, motion, use.
        /// </summary>
        [JsonPropertyName("state")]
        public ContentState? State { get; set; }
    
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
