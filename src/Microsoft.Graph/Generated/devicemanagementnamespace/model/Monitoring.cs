// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.DeviceManagementNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Monitoring.
    /// </summary>
    public partial class Monitoring : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets alert records.
        /// </summary>
        [JsonPropertyName("alertRecords")]
        public IMonitoringAlertRecordsCollectionPage AlertRecords { get; set; }

        /// <summary>
        /// Gets or sets alertRecordsNextLink.
        /// </summary>
        [JsonPropertyName("alertRecords@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AlertRecordsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets alert rules.
        /// </summary>
        [JsonPropertyName("alertRules")]
        public IMonitoringAlertRulesCollectionPage AlertRules { get; set; }

        /// <summary>
        /// Gets or sets alertRulesNextLink.
        /// </summary>
        [JsonPropertyName("alertRules@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AlertRulesNextLink { get; set; }
    
    }
}

