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
    /// The type OmaSetting.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OmaSetting>))]
    public partial class OmaSetting
    {

        ///<summary>
        /// The internal OmaSetting constructor
        ///</summary>
        protected internal OmaSetting()
        {
            // Don't allow initialization of abstract complex types
        }

        /// <summary>
        /// Gets or sets description.
        /// Description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// Display Name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets isEncrypted.
        /// Indicates whether the value field is encrypted. This property is read-only.
        /// </summary>
        [JsonPropertyName("isEncrypted")]
        public bool? IsEncrypted { get; set; }
    
        /// <summary>
        /// Gets or sets omaUri.
        /// OMA.
        /// </summary>
        [JsonPropertyName("omaUri")]
        public string OmaUri { get; set; }
    
        /// <summary>
        /// Gets or sets secretReferenceValueId.
        /// ReferenceId for looking up secret for decryption. This property is read-only.
        /// </summary>
        [JsonPropertyName("secretReferenceValueId")]
        public string SecretReferenceValueId { get; set; }
    
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
