// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Management Template Step Deployment.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ManagementTemplateStepDeployment>))]
    public partial class ManagementTemplateStepDeployment : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets created by user id.
        /// </summary>
        [JsonPropertyName("createdByUserId")]
        public string CreatedByUserId { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets error.
        /// </summary>
        [JsonPropertyName("error")]
        public GraphAPIErrorDetails Error { get; set; }
    
        /// <summary>
        /// Gets or sets last action by user id.
        /// </summary>
        [JsonPropertyName("lastActionByUserId")]
        public string LastActionByUserId { get; set; }
    
        /// <summary>
        /// Gets or sets last action date time.
        /// </summary>
        [JsonPropertyName("lastActionDateTime")]
        public DateTimeOffset? LastActionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public ManagementTemplateDeploymentStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets template step version.
        /// </summary>
        [JsonPropertyName("templateStepVersion")]
        public ManagementTemplateStepVersion TemplateStepVersion { get; set; }
    
    }
}

