// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementManagedDevicesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementManagedDevicesCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementManagedDevicesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementManagedDevicesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementManagedDevicesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementManagedDevicesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementManagedDevicesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementManagedDevicesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagedDeviceRequestBuilder"/> for the specified DeviceManagementManagedDevice.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementManagedDevice.</param>
        /// <returns>The <see cref="IManagedDeviceRequestBuilder"/>.</returns>
        public IManagedDeviceRequestBuilder this[string id]
        {
            get
            {
                return new ManagedDeviceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceBulkReprovisionCloudPc.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceBulkReprovisionCloudPcRequestBuilder"/>.</returns>
        public IManagedDeviceBulkReprovisionCloudPcRequestBuilder BulkReprovisionCloudPc(
            IEnumerable<string> managedDeviceIds = null)
        {
            return new ManagedDeviceBulkReprovisionCloudPcRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.bulkReprovisionCloudPc"),
                this.Client,
                managedDeviceIds);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceBulkRestoreCloudPc.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceBulkRestoreCloudPcRequestBuilder"/>.</returns>
        public IManagedDeviceBulkRestoreCloudPcRequestBuilder BulkRestoreCloudPc(
            IEnumerable<string> managedDeviceIds = null,
            DateTimeOffset? restorePointDateTime = null,
            RestoreTimeRange? timeRange = null)
        {
            return new ManagedDeviceBulkRestoreCloudPcRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.bulkRestoreCloudPc"),
                this.Client,
                managedDeviceIds,
                restorePointDateTime,
                timeRange);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceBulkSetCloudPcReviewStatus.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceBulkSetCloudPcReviewStatusRequestBuilder"/>.</returns>
        public IManagedDeviceBulkSetCloudPcReviewStatusRequestBuilder BulkSetCloudPcReviewStatus(
            IEnumerable<string> managedDeviceIds = null,
            CloudPcReviewStatus reviewStatus = null)
        {
            return new ManagedDeviceBulkSetCloudPcReviewStatusRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.bulkSetCloudPcReviewStatus"),
                this.Client,
                managedDeviceIds,
                reviewStatus);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceDownloadAppDiagnostics.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceDownloadAppDiagnosticsRequestBuilder"/>.</returns>
        public IManagedDeviceDownloadAppDiagnosticsRequestBuilder DownloadAppDiagnostics(
            PowerliftDownloadRequestObject request = null)
        {
            return new ManagedDeviceDownloadAppDiagnosticsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.downloadAppDiagnostics"),
                this.Client,
                request);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceExecuteAction.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceExecuteActionRequestBuilder"/>.</returns>
        public IManagedDeviceExecuteActionRequestBuilder ExecuteAction(
            ManagedDeviceRemoteAction actionName,
            bool? keepEnrollmentData = null,
            bool? keepUserData = null,
            bool? persistEsimDataPlan = null,
            IEnumerable<string> deviceIds = null,
            string notificationTitle = null,
            string notificationBody = null,
            string deviceName = null,
            string carrierUrl = null,
            string deprovisionReason = null,
            string organizationalUnitPath = null)
        {
            return new ManagedDeviceExecuteActionRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.executeAction"),
                this.Client,
                actionName,
                keepEnrollmentData,
                keepUserData,
                persistEsimDataPlan,
                deviceIds,
                notificationTitle,
                notificationBody,
                deviceName,
                carrierUrl,
                deprovisionReason,
                organizationalUnitPath);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceMoveDevicesToOU.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceMoveDevicesToOURequestBuilder"/>.</returns>
        public IManagedDeviceMoveDevicesToOURequestBuilder MoveDevicesToOU(
            IEnumerable<Guid> deviceIds,
            string organizationalUnitPath = null)
        {
            return new ManagedDeviceMoveDevicesToOURequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.moveDevicesToOU"),
                this.Client,
                deviceIds,
                organizationalUnitPath);
        }

        /// <summary>
        /// Gets the request builder for ManagedDeviceAppDiagnostics.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceAppDiagnosticsRequestBuilder"/>.</returns>
        public IManagedDeviceAppDiagnosticsRequestBuilder AppDiagnostics(
            string upn = null)
        {
            return new ManagedDeviceAppDiagnosticsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.appDiagnostics"),
                this.Client,
                upn);
        }
    }
}
