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
    /// The type Group Policy Uploaded Definition File.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<GroupPolicyUploadedDefinitionFile>))]
    public partial class GroupPolicyUploadedDefinitionFile : GroupPolicyDefinitionFile
    {
    
        ///<summary>
        /// The GroupPolicyUploadedDefinitionFile constructor
        ///</summary>
        public GroupPolicyUploadedDefinitionFile()
        {
            this.ODataType = "microsoft.graph.groupPolicyUploadedDefinitionFile";
        }

        /// <summary>
        /// Gets or sets content.
        /// The contents of the uploaded ADMX file.
        /// </summary>
        [JsonPropertyName("content")]
        public byte[] Content { get; set; }
    
        /// <summary>
        /// Gets or sets default language code.
        /// The default language of the uploaded ADMX file.
        /// </summary>
        [JsonPropertyName("defaultLanguageCode")]
        public string DefaultLanguageCode { get; set; }
    
        /// <summary>
        /// Gets or sets group policy uploaded language files.
        /// The list of ADML files associated with the uploaded ADMX file.
        /// </summary>
        [JsonPropertyName("groupPolicyUploadedLanguageFiles")]
        public IEnumerable<GroupPolicyUploadedLanguageFile> GroupPolicyUploadedLanguageFiles { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The upload status of the uploaded ADMX file. Possible values are: none, uploadInProgress, available, assigned, removalInProgress, uploadFailed, removalFailed.
        /// </summary>
        [JsonPropertyName("status")]
        public GroupPolicyUploadedDefinitionFileStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets upload date time.
        /// The uploaded time of the uploaded ADMX file.
        /// </summary>
        [JsonPropertyName("uploadDateTime")]
        public DateTimeOffset? UploadDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets group policy operations.
        /// The list of operations on the uploaded ADMX file.
        /// </summary>
        [JsonPropertyName("groupPolicyOperations")]
        public IGroupPolicyUploadedDefinitionFileGroupPolicyOperationsCollectionPage GroupPolicyOperations { get; set; }

        /// <summary>
        /// Gets or sets groupPolicyOperationsNextLink.
        /// </summary>
        [JsonPropertyName("groupPolicyOperations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string GroupPolicyOperationsNextLink { get; set; }
    
    }
}

