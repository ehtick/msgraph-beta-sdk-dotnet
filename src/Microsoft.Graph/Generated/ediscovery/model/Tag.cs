// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Tag.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<Tag>))]
    public partial class Tag : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets child selectability.
        /// Indicates whether a single or multiple child tags can be associated with a document. Possible values are: One, Many.  This value controls whether the UX presents the tags as checkboxes or a radio button group.
        /// </summary>
        [JsonPropertyName("childSelectability")]
        public ChildSelectability? ChildSelectability { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// The user who created the tag.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public Microsoft.Graph.IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description for the tag.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the tag.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time the tag was last modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets child tags.
        /// Returns the tags that are a child of a tag.
        /// </summary>
        [JsonPropertyName("childTags")]
        public ITagChildTagsCollectionWithReferencesPage ChildTags { get; set; }

        /// <summary>
        /// Gets or sets childTagsNextLink.
        /// </summary>
        [JsonPropertyName("childTags@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ChildTagsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets parent.
        /// Returns the parent tag of the specified tag.
        /// </summary>
        [JsonPropertyName("parent")]
        public Tag Parent { get; set; }
    
    }
}

