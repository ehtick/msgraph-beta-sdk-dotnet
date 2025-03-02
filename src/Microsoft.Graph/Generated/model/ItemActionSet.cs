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
    /// The type ItemActionSet.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ItemActionSet>))]
    public partial class ItemActionSet
    {

        /// <summary>
        /// Gets or sets comment.
        /// A comment was added to the item.
        /// </summary>
        [JsonPropertyName("comment")]
        public CommentAction Comment { get; set; }
    
        /// <summary>
        /// Gets or sets create.
        /// An item was created.
        /// </summary>
        [JsonPropertyName("create")]
        public CreateAction Create { get; set; }
    
        /// <summary>
        /// Gets or sets delete.
        /// An item was deleted.
        /// </summary>
        [JsonPropertyName("delete")]
        public DeleteAction Delete { get; set; }
    
        /// <summary>
        /// Gets or sets edit.
        /// An item was edited.
        /// </summary>
        [JsonPropertyName("edit")]
        public EditAction Edit { get; set; }
    
        /// <summary>
        /// Gets or sets mention.
        /// A user was mentioned in the item.
        /// </summary>
        [JsonPropertyName("mention")]
        public MentionAction Mention { get; set; }
    
        /// <summary>
        /// Gets or sets move.
        /// An item was moved.
        /// </summary>
        [JsonPropertyName("move")]
        public MoveAction Move { get; set; }
    
        /// <summary>
        /// Gets or sets rename.
        /// An item was renamed.
        /// </summary>
        [JsonPropertyName("rename")]
        public RenameAction Rename { get; set; }
    
        /// <summary>
        /// Gets or sets restore.
        /// An item was restored.
        /// </summary>
        [JsonPropertyName("restore")]
        public RestoreAction Restore { get; set; }
    
        /// <summary>
        /// Gets or sets share.
        /// An item was shared.
        /// </summary>
        [JsonPropertyName("share")]
        public ShareAction Share { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// An item was versioned.
        /// </summary>
        [JsonPropertyName("version")]
        public VersionAction Version { get; set; }
    
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
