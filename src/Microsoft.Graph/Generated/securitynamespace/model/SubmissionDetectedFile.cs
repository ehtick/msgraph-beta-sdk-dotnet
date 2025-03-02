// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SubmissionDetectedFile.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<SubmissionDetectedFile>))]
    public partial class SubmissionDetectedFile
    {

        /// <summary>
        /// Gets or sets fileHash.
        /// The file hash.
        /// </summary>
        [JsonPropertyName("fileHash")]
        public string FileHash { get; set; }
    
        /// <summary>
        /// Gets or sets fileName.
        /// The file name.
        /// </summary>
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }
    
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
