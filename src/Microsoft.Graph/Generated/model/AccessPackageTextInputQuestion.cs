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
    /// The type AccessPackageTextInputQuestion.
    /// </summary>
    public partial class AccessPackageTextInputQuestion : AccessPackageQuestion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessPackageTextInputQuestion"/> class.
        /// </summary>
        public AccessPackageTextInputQuestion()
        {
            this.ODataType = "microsoft.graph.accessPackageTextInputQuestion";
        }

        /// <summary>
        /// Gets or sets isSingleLineQuestion.
        /// Indicates whether the answer will be in single or multiple line format.
        /// </summary>
        [JsonPropertyName("isSingleLineQuestion")]
        public bool? IsSingleLineQuestion { get; set; }
    
        /// <summary>
        /// Gets or sets regexPattern.
        /// This is the regex pattern that the corresponding text answer must follow.
        /// </summary>
        [JsonPropertyName("regexPattern")]
        public string RegexPattern { get; set; }
    
    }
}
