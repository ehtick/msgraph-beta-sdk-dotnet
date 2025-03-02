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
    /// The type File Attachment.
    /// </summary>
    public partial class FileAttachment : Attachment
    {
    
        ///<summary>
        /// The FileAttachment constructor
        ///</summary>
        public FileAttachment()
        {
            this.ODataType = "microsoft.graph.fileAttachment";
        }

        /// <summary>
        /// Gets or sets content bytes.
        /// The base64-encoded contents of the file.
        /// </summary>
        [JsonPropertyName("contentBytes")]
        public byte[] ContentBytes { get; set; }
    
        /// <summary>
        /// Gets or sets content id.
        /// The ID of the attachment in the Exchange store.
        /// </summary>
        [JsonPropertyName("contentId")]
        public string ContentId { get; set; }
    
        /// <summary>
        /// Gets or sets content location.
        /// Do not use this property as it is not supported.
        /// </summary>
        [JsonPropertyName("contentLocation")]
        public string ContentLocation { get; set; }
    
    }
}

