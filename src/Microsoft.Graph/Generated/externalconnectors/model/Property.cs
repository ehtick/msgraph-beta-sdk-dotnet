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
    /// The type Property.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<Property>))]
    public partial class Property
    {

        /// <summary>
        /// Gets or sets aliases.
        /// A set of aliases or a friendly names for the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, each string might not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &amp;, ?, @, #, /, ~, ', ', &amp;lt;, &amp;gt;, `, ^. Optional.
        /// </summary>
        [JsonPropertyName("aliases")]
        public IEnumerable<string> Aliases { get; set; }
    
        /// <summary>
        /// Gets or sets isExactMatchRequired.
        /// Specifies if the property will be matched exactly for queries. Exact matching can only be set to true for non-searchable properties of type string or stringCollection. Optional.
        /// </summary>
        [JsonPropertyName("isExactMatchRequired")]
        public bool? IsExactMatchRequired { get; set; }
    
        /// <summary>
        /// Gets or sets isQueryable.
        /// Specifies if the property is queryable. Queryable properties can be used in Keyword Query Language (KQL) queries. Optional.
        /// </summary>
        [JsonPropertyName("isQueryable")]
        public bool? IsQueryable { get; set; }
    
        /// <summary>
        /// Gets or sets isRefinable.
        /// Specifies if the property is refinable.  Refinable properties can be used to filter search results in the Search API and add a refiner control in the Microsoft Search user experience. Optional.
        /// </summary>
        [JsonPropertyName("isRefinable")]
        public bool? IsRefinable { get; set; }
    
        /// <summary>
        /// Gets or sets isRetrievable.
        /// Specifies if the property is retrievable. Retrievable properties are returned in the result set when items are returned by the search API. Retrievable properties are also available to add to the display template used to render search results. Optional.
        /// </summary>
        [JsonPropertyName("isRetrievable")]
        public bool? IsRetrievable { get; set; }
    
        /// <summary>
        /// Gets or sets isSearchable.
        /// Specifies if the property is searchable. Only properties of type string or stringCollection can be searchable. Non-searchable properties are not added to the search index. Optional.
        /// </summary>
        [JsonPropertyName("isSearchable")]
        public bool? IsSearchable { get; set; }
    
        /// <summary>
        /// Gets or sets labels.
        /// Specifies one or more well-known tags added against a property. Labels help Microsoft Search understand the semantics of the data in the connection. Adding appropriate labels would result in an enhanced search experience (e.g. better relevance). Optional.The possible values are: title, url, createdBy, lastModifiedBy, authors, createdDateTime, lastModifiedDateTime, fileName, fileExtension, unknownFutureValue, iconUrl, containerName, containerUrl. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: iconUrl, containerName, containerUrl.
        /// </summary>
        [JsonPropertyName("labels")]
        public IEnumerable<Label> Labels { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name of the property. Maximum 32 characters. Only alphanumeric characters allowed. For example, the property name may not contain control characters, whitespace, or any of the following: :, ;, ,, (, ), [, ], {, }, %, $, +, !, *, =, &amp;, ?, @, #, /, ~, ', ', &amp;lt;, &amp;gt;, `, ^.  Required.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The data type of the property. Possible values are: string, int64, double, dateTime, boolean, stringCollection, int64Collection, doubleCollection, dateTimeCollection, unknownFutureValue. Required.
        /// </summary>
        [JsonPropertyName("type")]
        public PropertyType? Type { get; set; }
    
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
