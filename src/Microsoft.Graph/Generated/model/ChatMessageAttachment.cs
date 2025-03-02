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
    /// The type ChatMessageAttachment.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ChatMessageAttachment>))]
    public partial class ChatMessageAttachment
    {

        /// <summary>
        /// Gets or sets content.
        /// The content of the attachment. If the attachment is a rich card, set the property to the rich card object. This property and contentUrl are mutually exclusive.
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    
        /// <summary>
        /// Gets or sets contentType.
        /// The media type of the content attachment. It can have the following values: reference: Attachment is a link to another file. Populate the contentURL with the link to the object.Any contentTypes supported by the Bot Framework's Attachment objectapplication/vnd.microsoft.card.codesnippet: A code snippet. application/vnd.microsoft.card.announcement: An announcement header.
        /// </summary>
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Gets or sets contentUrl.
        /// URL for the content of the attachment. Supported protocols: http, https, file and data.
        /// </summary>
        [JsonPropertyName("contentUrl")]
        public string ContentUrl { get; set; }
    
        /// <summary>
        /// Gets or sets id.
        /// Read-only. Unique id of the attachment.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Name of the attachment.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets teamsAppId.
        /// The ID of the Teams app that is associated with the attachment. The property is specifically used to attribute a Teams message card to the specified app.
        /// </summary>
        [JsonPropertyName("teamsAppId")]
        public string TeamsAppId { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnailUrl.
        /// URL to a thumbnail image that the channel can use if it supports using an alternative, smaller form of content or contentUrl. For example, if you set contentType to application/word and set contentUrl to the location of the Word document, you might include a thumbnail image that represents the document. The channel could display the thumbnail image instead of the document. When the user clicks the image, the channel would open the document.
        /// </summary>
        [JsonPropertyName("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    
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
