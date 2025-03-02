// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Contact Folder.
    /// </summary>
    public partial class ContactFolder : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// The folder's display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets parent folder id.
        /// The ID of the folder's parent folder.
        /// </summary>
        [JsonPropertyName("parentFolderId")]
        public string ParentFolderId { get; set; }
    
        /// <summary>
        /// Gets or sets well known name.
        /// The name of the folder if the folder is a recognized folder. Currently contacts is the only recognized contacts folder.
        /// </summary>
        [JsonPropertyName("wellKnownName")]
        public string WellKnownName { get; set; }
    
        /// <summary>
        /// Gets or sets child folders.
        /// The collection of child folders in the folder. Navigation property. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("childFolders")]
        public IContactFolderChildFoldersCollectionPage ChildFolders { get; set; }

        /// <summary>
        /// Gets or sets childFoldersNextLink.
        /// </summary>
        [JsonPropertyName("childFolders@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ChildFoldersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets contacts.
        /// The contacts in the folder. Navigation property. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("contacts")]
        public IContactFolderContactsCollectionPage Contacts { get; set; }

        /// <summary>
        /// Gets or sets contactsNextLink.
        /// </summary>
        [JsonPropertyName("contacts@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ContactsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the contactFolder. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties")]
        public IContactFolderMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets multiValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MultiValueExtendedPropertiesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the contactFolder. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties")]
        public IContactFolderSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets singleValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SingleValueExtendedPropertiesNextLink { get; set; }
    
    }
}

