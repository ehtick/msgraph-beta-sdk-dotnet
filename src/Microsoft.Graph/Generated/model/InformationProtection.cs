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
    /// The type Information Protection.
    /// </summary>
    public partial class InformationProtection : Entity
    {
    
        /// <summary>
        /// Gets or sets bitlocker.
        /// </summary>
        [JsonPropertyName("bitlocker")]
        public Bitlocker Bitlocker { get; set; }
    
        /// <summary>
        /// Gets or sets data loss prevention policies.
        /// </summary>
        [JsonPropertyName("dataLossPreventionPolicies")]
        public IInformationProtectionDataLossPreventionPoliciesCollectionPage DataLossPreventionPolicies { get; set; }

        /// <summary>
        /// Gets or sets dataLossPreventionPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("dataLossPreventionPolicies@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DataLossPreventionPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets sensitivity labels.
        /// </summary>
        [JsonPropertyName("sensitivityLabels")]
        public IInformationProtectionSensitivityLabelsCollectionPage SensitivityLabels { get; set; }

        /// <summary>
        /// Gets or sets sensitivityLabelsNextLink.
        /// </summary>
        [JsonPropertyName("sensitivityLabels@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SensitivityLabelsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets sensitivity policy settings.
        /// </summary>
        [JsonPropertyName("sensitivityPolicySettings")]
        public SensitivityPolicySettings SensitivityPolicySettings { get; set; }
    
        /// <summary>
        /// Gets or sets policy.
        /// </summary>
        [Obsolete("This API will no longer be accessible, please see microsoft.graph.security.informationProtection APIs.")]
        [JsonPropertyName("policy")]
        public InformationProtectionPolicy Policy { get; set; }
    
        /// <summary>
        /// Gets or sets threat assessment requests.
        /// </summary>
        [JsonPropertyName("threatAssessmentRequests")]
        public IInformationProtectionThreatAssessmentRequestsCollectionPage ThreatAssessmentRequests { get; set; }

        /// <summary>
        /// Gets or sets threatAssessmentRequestsNextLink.
        /// </summary>
        [JsonPropertyName("threatAssessmentRequests@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ThreatAssessmentRequestsNextLink { get; set; }
    
    }
}

