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
    /// The type ItemIdResolver.
    /// </summary>
    public partial class ItemIdResolver : UrlToItemResolverBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemIdResolver"/> class.
        /// </summary>
        public ItemIdResolver()
        {
            this.ODataType = "microsoft.graph.externalConnectors.itemIdResolver";
        }

        /// <summary>
        /// Gets or sets itemId.
        /// Pattern that specifies how to form the ID of the external item that the URL represents. The named groups from the regular expression in urlPattern within the urlMatchInfo can be referenced by inserting the group name inside curly brackets.
        /// </summary>
        [JsonPropertyName("itemId")]
        public string ItemId { get; set; }
    
        /// <summary>
        /// Gets or sets urlMatchInfo.
        /// Configurations to match and resolve URL.
        /// </summary>
        [JsonPropertyName("urlMatchInfo")]
        public UrlMatchInfo UrlMatchInfo { get; set; }
    
    }
}
