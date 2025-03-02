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
    /// The type User Experience Analytics Category.
    /// </summary>
    public partial class UserExperienceAnalyticsCategory : Entity
    {
    
        /// <summary>
        /// Gets or sets insights.
        /// The insights for the user experience analytics category.
        /// </summary>
        [JsonPropertyName("insights")]
        public IEnumerable<UserExperienceAnalyticsInsight> Insights { get; set; }
    
        /// <summary>
        /// Gets or sets metric values.
        /// The metric values for the user experience analytics category.
        /// </summary>
        [JsonPropertyName("metricValues")]
        public IUserExperienceAnalyticsCategoryMetricValuesCollectionPage MetricValues { get; set; }

        /// <summary>
        /// Gets or sets metricValuesNextLink.
        /// </summary>
        [JsonPropertyName("metricValues@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MetricValuesNextLink { get; set; }
    
    }
}

