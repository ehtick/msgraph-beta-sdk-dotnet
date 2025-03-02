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
    /// The type Tenant Detailed Information.
    /// </summary>
    public partial class TenantDetailedInformation : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets city.
        /// The city where the managed tenant is located. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or sets country code.
        /// The code for the country where the managed tenant is located. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }
    
        /// <summary>
        /// Gets or sets country name.
        /// The name for the country where the managed tenant is located. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("countryName")]
        public string CountryName { get; set; }
    
        /// <summary>
        /// Gets or sets default domain name.
        /// The default domain name for the managed tenant. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("defaultDomainName")]
        public string DefaultDomainName { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the managed tenant.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets industry name.
        /// The business industry associated with the managed tenant. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("industryName")]
        public string IndustryName { get; set; }
    
        /// <summary>
        /// Gets or sets region.
        /// The region where the managed tenant is located. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }
    
        /// <summary>
        /// Gets or sets segment name.
        /// The business segment associated with the managed tenant. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("segmentName")]
        public string SegmentName { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// The Azure Active Directory tenant identifier for the managed tenant.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets vertical name.
        /// The vertical associated with the managed tenant. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("verticalName")]
        public string VerticalName { get; set; }
    
    }
}

