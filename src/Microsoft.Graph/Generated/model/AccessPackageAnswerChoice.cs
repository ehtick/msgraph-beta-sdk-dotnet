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
    /// The type AccessPackageAnswerChoice.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AccessPackageAnswerChoice>))]
    public partial class AccessPackageAnswerChoice
    {

        /// <summary>
        /// Gets or sets actualValue.
        /// The actual value of the selected choice. This is typically a string value which is understandable by applications. Required.
        /// </summary>
        [JsonPropertyName("actualValue")]
        public string ActualValue { get; set; }
    
        /// <summary>
        /// Gets or sets displayValue.
        /// The localized display values shown to the requestor and approvers. Required.
        /// </summary>
        [JsonPropertyName("displayValue")]
        public AccessPackageLocalizedContent DisplayValue { get; set; }
    
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
