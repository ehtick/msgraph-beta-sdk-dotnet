// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type UrlToItemResolverBase.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<UrlToItemResolverBase>))]
    public partial class UrlToItemResolverBase
    {

        ///<summary>
        /// The internal UrlToItemResolverBase constructor
        ///</summary>
        protected internal UrlToItemResolverBase()
        {
            // Don't allow initialization of abstract complex types
        }

        /// <summary>
        /// Gets or sets priority.
        /// The priority which defines the sequence in which the urlToItemResolverBase instances are evaluated.
        /// </summary>
        [JsonPropertyName("priority")]
        public Int32? Priority { get; set; }
    
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
