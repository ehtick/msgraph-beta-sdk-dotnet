// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDeviceManagementReportsRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementReportsRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceManagementReportsRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceManagementReportsRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for CachedReportConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsCachedReportConfigurationsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementReportsCachedReportConfigurationsCollectionRequestBuilder CachedReportConfigurations { get; }

        /// <summary>
        /// Gets the request builder for ExportJobs.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsExportJobsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementReportsExportJobsCollectionRequestBuilder ExportJobs { get; }

        /// <summary>
        /// Gets the request builder for ReportSchedules.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsReportSchedulesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementReportsReportSchedulesCollectionRequestBuilder ReportSchedules { get; }
    
        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetAppsInstallSummaryReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetAppsInstallSummaryReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetAppsInstallSummaryReportRequestBuilder GetAppsInstallSummaryReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetAppStatusOverviewReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetAppStatusOverviewReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetAppStatusOverviewReportRequestBuilder GetAppStatusOverviewReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetDeviceInstallStatusReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetDeviceInstallStatusReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetDeviceInstallStatusReportRequestBuilder GetDeviceInstallStatusReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetUserInstallStatusReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetUserInstallStatusReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetUserInstallStatusReportRequestBuilder GetUserInstallStatusReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetActiveMalwareReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetActiveMalwareReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetActiveMalwareReportRequestBuilder GetActiveMalwareReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetMalwareSummaryReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetMalwareSummaryReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetMalwareSummaryReportRequestBuilder GetMalwareSummaryReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetUnhealthyDefenderAgentsReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetUnhealthyDefenderAgentsReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetUnhealthyDefenderAgentsReportRequestBuilder GetUnhealthyDefenderAgentsReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetCachedReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetCachedReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetCachedReportRequestBuilder GetCachedReport(
            string id = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetDeviceNonComplianceReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetDeviceNonComplianceReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetDeviceNonComplianceReportRequestBuilder GetDeviceNonComplianceReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetHistoricalReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetHistoricalReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetHistoricalReportRequestBuilder GetHistoricalReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetPolicyNonComplianceMetadata.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetPolicyNonComplianceMetadataRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetPolicyNonComplianceMetadataRequestBuilder GetPolicyNonComplianceMetadata(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetPolicyNonComplianceReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetPolicyNonComplianceReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetPolicyNonComplianceReportRequestBuilder GetPolicyNonComplianceReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetPolicyNonComplianceSummaryReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetPolicyNonComplianceSummaryReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetPolicyNonComplianceSummaryReportRequestBuilder GetPolicyNonComplianceSummaryReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetReportFilters.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetReportFiltersRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetReportFiltersRequestBuilder GetReportFilters(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetSettingNonComplianceReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetSettingNonComplianceReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetSettingNonComplianceReportRequestBuilder GetSettingNonComplianceReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetWindowsUpdateAlertsPerPolicyPerDeviceReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetWindowsUpdateAlertsPerPolicyPerDeviceReportRequestBuilder GetWindowsUpdateAlertsPerPolicyPerDeviceReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementReportsGetWindowsUpdateAlertSummaryReport.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementReportsGetWindowsUpdateAlertSummaryReportRequestBuilder"/>.</returns>
        IDeviceManagementReportsGetWindowsUpdateAlertSummaryReportRequestBuilder GetWindowsUpdateAlertSummaryReport(
            string name = null,
            IEnumerable<string> select = null,
            string search = null,
            IEnumerable<string> groupBy = null,
            IEnumerable<string> orderBy = null,
            Int32? skip = null,
            Int32? top = null,
            string sessionId = null,
            string filter = null);
    
    }
}
