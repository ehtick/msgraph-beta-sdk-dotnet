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
    /// The type File Url Threat Submission.
    /// </summary>
    public partial class FileUrlThreatSubmission : FileThreatSubmission
    {
    
        ///<summary>
        /// The FileUrlThreatSubmission constructor
        ///</summary>
        public FileUrlThreatSubmission()
        {
            this.ODataType = "microsoft.graph.security.fileUrlThreatSubmission";
        }

        /// <summary>
        /// Gets or sets file url.
        /// It specifies the URL of the file which needs to be submitted.
        /// </summary>
        [JsonPropertyName("fileUrl")]
        public string FileUrl { get; set; }
    
    }
}

