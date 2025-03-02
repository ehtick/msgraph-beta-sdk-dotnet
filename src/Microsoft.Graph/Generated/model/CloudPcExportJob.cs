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
    /// The type Cloud Pc Export Job.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CloudPcExportJob>))]
    public partial class CloudPcExportJob : Entity
    {
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// The date and time when the export job expires.
        /// </summary>
        [JsonPropertyName("expirationDateTime")]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets export job status.
        /// The status of the export job. The possible values are: notStarted, inProgress, completed, unknownFutureValue. Read-only.
        /// </summary>
        [JsonPropertyName("exportJobStatus")]
        public CloudPcExportJobStatus? ExportJobStatus { get; set; }
    
        /// <summary>
        /// Gets or sets export url.
        /// The storage account URL of the exported report. It can be used to download the file.
        /// </summary>
        [JsonPropertyName("exportUrl")]
        public string ExportUrl { get; set; }
    
        /// <summary>
        /// Gets or sets filter.
        /// The filter applied on the report.
        /// </summary>
        [JsonPropertyName("filter")]
        public string Filter { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// The format of the exported report.
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }
    
        /// <summary>
        /// Gets or sets report name.
        /// The report name. The possible values are: remoteConnectionHistoricalReports, dailyAggregatedRemoteConnectionReports, totalAggregatedRemoteConnectionReports, sharedUseLicenseUsageReport, sharedUseLicenseUsageRealTimeReport, or unknownFutureValue.
        /// </summary>
        [JsonPropertyName("reportName")]
        public CloudPcReportName? ReportName { get; set; }
    
        /// <summary>
        /// Gets or sets request date time.
        /// The date and time when the export job was requested.
        /// </summary>
        [JsonPropertyName("requestDateTime")]
        public DateTimeOffset? RequestDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets select.
        /// The selected columns of the report.
        /// </summary>
        [JsonPropertyName("select")]
        public IEnumerable<string> Select { get; set; }
    
    }
}

