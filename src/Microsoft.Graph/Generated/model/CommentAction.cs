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
    /// The type CommentAction.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CommentAction>))]
    public partial class CommentAction
    {

        /// <summary>
        /// Gets or sets isReply.
        /// If true, this activity was a reply to an existing comment thread.
        /// </summary>
        [JsonPropertyName("isReply")]
        public bool? IsReply { get; set; }
    
        /// <summary>
        /// Gets or sets parentAuthor.
        /// The identity of the user who started the comment thread.
        /// </summary>
        [JsonPropertyName("parentAuthor")]
        public IdentitySet ParentAuthor { get; set; }
    
        /// <summary>
        /// Gets or sets participants.
        /// The identities of the users participating in this comment thread.
        /// </summary>
        [JsonPropertyName("participants")]
        public IEnumerable<IdentitySet> Participants { get; set; }
    
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
