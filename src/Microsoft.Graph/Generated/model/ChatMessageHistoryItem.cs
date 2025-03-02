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
    /// The type ChatMessageHistoryItem.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ChatMessageHistoryItem>))]
    public partial class ChatMessageHistoryItem
    {

        /// <summary>
        /// Gets or sets actions.
        /// The modification actions of a message item.The possible values are: reactionAdded, reactionRemoved, actionUndefined, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("actions")]
        public ChatMessageActions? Actions { get; set; }
    
        /// <summary>
        /// Gets or sets modifiedDateTime.
        /// The date and time when the message was modified.
        /// </summary>
        [JsonPropertyName("modifiedDateTime")]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets reaction.
        /// The reaction in the modified message.
        /// </summary>
        [JsonPropertyName("reaction")]
        public ChatMessageReaction Reaction { get; set; }
    
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
