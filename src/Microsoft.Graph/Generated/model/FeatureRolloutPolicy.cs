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
    /// The type Feature Rollout Policy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<FeatureRolloutPolicy>))]
    public partial class FeatureRolloutPolicy : Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// A description for this feature rollout policy.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for this  feature rollout policy.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets feature.
        /// Possible values are: passthroughAuthentication, seamlessSso, passwordHashSync, emailAsAlternateId, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("feature")]
        public StagedFeatureName? Feature { get; set; }
    
        /// <summary>
        /// Gets or sets is applied to organization.
        /// Indicates whether this feature rollout policy should be applied to the entire organization.
        /// </summary>
        [JsonPropertyName("isAppliedToOrganization")]
        public bool? IsAppliedToOrganization { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// Indicates whether the feature rollout is enabled.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets applies to.
        /// Nullable. Specifies a list of directoryObjects that feature is enabled for.
        /// </summary>
        [JsonPropertyName("appliesTo")]
        public IFeatureRolloutPolicyAppliesToCollectionPage AppliesTo { get; set; }

        /// <summary>
        /// Gets or sets appliesToNextLink.
        /// </summary>
        [JsonPropertyName("appliesTo@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AppliesToNextLink { get; set; }
    
    }
}

