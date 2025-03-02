// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type File Threat Submission.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<FileThreatSubmission>))]
    public partial class FileThreatSubmission : ThreatSubmission
    {
    
        ///<summary>
        /// The FileThreatSubmission constructor
        ///</summary>
        public FileThreatSubmission()
        {
            this.ODataType = "microsoft.graph.security.fileThreatSubmission";
        }

        /// <summary>
        /// Gets or sets file name.
        /// It specifies the file name to be submitted.
        /// </summary>
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }
    
    }
}

