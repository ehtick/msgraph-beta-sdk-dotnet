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
    /// The type AccessPackageQuestion.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AccessPackageQuestion>))]
    public partial class AccessPackageQuestion
    {

        ///<summary>
        /// The internal AccessPackageQuestion constructor
        ///</summary>
        protected internal AccessPackageQuestion()
        {
            // Don't allow initialization of abstract complex types
        }

        /// <summary>
        /// Gets or sets id.
        /// ID of the question.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets isAnswerEditable.
        /// Specifies whether the requestor is allowed to edit answers to questions.
        /// </summary>
        [JsonPropertyName("isAnswerEditable")]
        public bool? IsAnswerEditable { get; set; }
    
        /// <summary>
        /// Gets or sets isRequired.
        /// Whether the requestor is required to supply an answer or not.
        /// </summary>
        [JsonPropertyName("isRequired")]
        public bool? IsRequired { get; set; }
    
        /// <summary>
        /// Gets or sets sequence.
        /// Relative position of this question when displaying a list of questions to the requestor.
        /// </summary>
        [JsonPropertyName("sequence")]
        public Int32? Sequence { get; set; }
    
        /// <summary>
        /// Gets or sets text.
        /// The text of the question to show to the requestor.
        /// </summary>
        [JsonPropertyName("text")]
        public AccessPackageLocalizedContent Text { get; set; }
    
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
