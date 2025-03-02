// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.TenantAdmin
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Sharepoint.
    /// </summary>
    public partial class Sharepoint : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets settings.
        /// Represents the tenant-level settings for SharePoint and OneDrive.
        /// </summary>
        [JsonPropertyName("settings")]
        public Settings Settings { get; set; }
    
    }
}

