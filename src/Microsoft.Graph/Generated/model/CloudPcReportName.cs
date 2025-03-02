// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum CloudPcReportName.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CloudPcReportName
    {
    
        /// <summary>
        /// Remote Connection Historical Reports
        /// </summary>
        RemoteConnectionHistoricalReports = 0,
	
        /// <summary>
        /// Daily Aggregated Remote Connection Reports
        /// </summary>
        DailyAggregatedRemoteConnectionReports = 1,
	
        /// <summary>
        /// Total Aggregated Remote Connection Reports
        /// </summary>
        TotalAggregatedRemoteConnectionReports = 2,
	
        /// <summary>
        /// Shared Use License Usage Report
        /// </summary>
        SharedUseLicenseUsageReport = 3,
	
        /// <summary>
        /// Shared Use License Usage Real Time Report
        /// </summary>
        SharedUseLicenseUsageRealTimeReport = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 999,
	
    }
}
