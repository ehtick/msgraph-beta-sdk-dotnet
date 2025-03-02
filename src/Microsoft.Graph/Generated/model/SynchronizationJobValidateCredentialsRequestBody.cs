// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SynchronizationJobValidateCredentialsRequestBody.
    /// </summary>
    public partial class SynchronizationJobValidateCredentialsRequestBody
    {
    
        /// <summary>
        /// Gets or sets ApplicationIdentifier.
        /// </summary>
        [JsonPropertyName("applicationIdentifier")]
        public string ApplicationIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets TemplateId.
        /// </summary>
        [JsonPropertyName("templateId")]
        public string TemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets UseSavedCredentials.
        /// </summary>
        [JsonPropertyName("useSavedCredentials")]
        public bool? UseSavedCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonPropertyName("credentials")]
        public IEnumerable<SynchronizationSecretKeyStringValuePair> Credentials { get; set; }
    
    }
}
