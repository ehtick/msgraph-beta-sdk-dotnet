// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type PlannerTaskRecurrence.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PlannerTaskRecurrence>))]
    public partial class PlannerTaskRecurrence
    {

        /// <summary>
        /// Gets or sets nextInSeriesTaskId.
        /// </summary>
        [JsonPropertyName("nextInSeriesTaskId")]
        public string NextInSeriesTaskId { get; set; }
    
        /// <summary>
        /// Gets or sets occurrenceId.
        /// </summary>
        [JsonPropertyName("occurrenceId")]
        public Int32? OccurrenceId { get; set; }
    
        /// <summary>
        /// Gets or sets previousInSeriesTaskId.
        /// </summary>
        [JsonPropertyName("previousInSeriesTaskId")]
        public string PreviousInSeriesTaskId { get; set; }
    
        /// <summary>
        /// Gets or sets recurrenceStartDateTime.
        /// </summary>
        [JsonPropertyName("recurrenceStartDateTime")]
        public DateTimeOffset? RecurrenceStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets schedule.
        /// </summary>
        [JsonPropertyName("schedule")]
        public PlannerRecurrenceSchedule Schedule { get; set; }
    
        /// <summary>
        /// Gets or sets seriesId.
        /// </summary>
        [JsonPropertyName("seriesId")]
        public string SeriesId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
