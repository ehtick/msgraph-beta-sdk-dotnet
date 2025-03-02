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
    /// The type Media.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Media>))]
    public partial class Media
    {

        /// <summary>
        /// Gets or sets isTranscriptionShown.
        /// If a file has a transcript, this setting controls if the closed captions / transcription for the media file should be shown to people during viewing. Read-Write.
        /// </summary>
        [JsonPropertyName("isTranscriptionShown")]
        public bool? IsTranscriptionShown { get; set; }
    
        /// <summary>
        /// Gets or sets mediaSource.
        /// Information about the source of media. Read-only.
        /// </summary>
        [JsonPropertyName("mediaSource")]
        public MediaSource MediaSource { get; set; }
    
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
