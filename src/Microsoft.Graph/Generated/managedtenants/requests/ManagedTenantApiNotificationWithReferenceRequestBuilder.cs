// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedTenantApiNotificationWithReferenceRequestBuilder.
    /// </summary>
    public partial class ManagedTenantApiNotificationWithReferenceRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IManagedTenantApiNotificationWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedTenantApiNotificationWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagedTenantApiNotificationWithReferenceRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedTenantApiNotificationWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedTenantApiNotificationWithReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagedTenantApiNotificationWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the managedTenantApiNotification.
        /// </summary>
        /// <returns>The <see cref="IManagedTenantApiNotificationReferenceRequestBuilder"/>.</returns>
        public IManagedTenantApiNotificationReferenceRequestBuilder Reference
        {
            get
            {
                return new ManagedTenantApiNotificationReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
