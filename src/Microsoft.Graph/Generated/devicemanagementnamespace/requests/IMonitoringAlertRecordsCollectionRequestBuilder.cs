// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.DeviceManagementNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IMonitoringAlertRecordsCollectionRequestBuilder.
    /// </summary>
    public partial interface IMonitoringAlertRecordsCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IMonitoringAlertRecordsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IMonitoringAlertRecordsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IAlertRecordRequestBuilder"/> for the specified AlertRecord.
        /// </summary>
        /// <param name="id">The ID for the AlertRecord.</param>
        /// <returns>The <see cref="IAlertRecordRequestBuilder"/>.</returns>
        IAlertRecordRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for AlertRecordGetPortalNotifications.
        /// </summary>
        /// <returns>The <see cref="IAlertRecordGetPortalNotificationsRequestBuilder"/>.</returns>
        IAlertRecordGetPortalNotificationsRequestBuilder GetPortalNotifications();
    }
}
