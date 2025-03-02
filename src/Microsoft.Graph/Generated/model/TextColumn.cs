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
    /// The type TextColumn.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TextColumn>))]
    public partial class TextColumn
    {

        /// <summary>
        /// Gets or sets allowMultipleLines.
        /// Whether to allow multiple lines of text.
        /// </summary>
        [JsonPropertyName("allowMultipleLines")]
        public bool? AllowMultipleLines { get; set; }
    
        /// <summary>
        /// Gets or sets appendChangesToExistingText.
        /// Whether updates to this column should replace existing text, or append to it.
        /// </summary>
        [JsonPropertyName("appendChangesToExistingText")]
        public bool? AppendChangesToExistingText { get; set; }
    
        /// <summary>
        /// Gets or sets linesForEditing.
        /// The size of the text box.
        /// </summary>
        [JsonPropertyName("linesForEditing")]
        public Int32? LinesForEditing { get; set; }
    
        /// <summary>
        /// Gets or sets maxLength.
        /// The maximum number of characters for the value.
        /// </summary>
        [JsonPropertyName("maxLength")]
        public Int32? MaxLength { get; set; }
    
        /// <summary>
        /// Gets or sets textType.
        /// The type of text being stored. Must be one of plain or richText
        /// </summary>
        [JsonPropertyName("textType")]
        public string TextType { get; set; }
    
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
