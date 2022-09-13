// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.DeviceManagementNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AlertRecordRequestBuilder.
    /// </summary>
    public partial class AlertRecordRequestBuilder : Microsoft.Graph.EntityRequestBuilder, IAlertRecordRequestBuilder
    {

        /// <summary>
        /// Constructs a new AlertRecordRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public AlertRecordRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAlertRecordRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAlertRecordRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new AlertRecordRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for AlertRecordSetPortalNotificationAsSent.
        /// </summary>
        /// <returns>The <see cref="IAlertRecordSetPortalNotificationAsSentRequestBuilder"/>.</returns>
        public IAlertRecordSetPortalNotificationAsSentRequestBuilder SetPortalNotificationAsSent()
        {
            return new AlertRecordSetPortalNotificationAsSentRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.deviceManagement.setPortalNotificationAsSent"),
                this.Client);
        }
    
    }
}
