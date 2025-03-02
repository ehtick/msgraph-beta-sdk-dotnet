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
    /// The type Cloud Pc Cross Cloud Government Organization Mapping.
    /// </summary>
    public partial class CloudPcCrossCloudGovernmentOrganizationMapping : Entity
    {
    
        /// <summary>
        /// Gets or sets organization ids in usgov cloud.
        /// The tenant ID in the Azure Government cloud corresponding to the GCC tenant in the public cloud. Currently, 1:1 mappings are supported, so this collection can only contain one tenant ID.
        /// </summary>
        [JsonPropertyName("organizationIdsInUSGovCloud")]
        public IEnumerable<string> OrganizationIdsInUSGovCloud { get; set; }
    
    }
}

