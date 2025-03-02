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
    /// The type On Premises Directory Synchronization.
    /// </summary>
    public partial class OnPremisesDirectorySynchronization : Entity
    {
    
        /// <summary>
        /// Gets or sets configuration.
        /// Consists of configurations that can be fine-tuned and impact the on-premises directory synchronization process for a tenant.
        /// </summary>
        [JsonPropertyName("configuration")]
        public OnPremisesDirectorySynchronizationConfiguration Configuration { get; set; }
    
        /// <summary>
        /// Gets or sets features.
        /// Consists of directory synchronization features that can be enabled or disabled.
        /// </summary>
        [JsonPropertyName("features")]
        public OnPremisesDirectorySynchronizationFeature Features { get; set; }
    
    }
}

