// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ManagedTenantEmailNotificationRequestBuilder.
    /// </summary>
    public partial class ManagedTenantEmailNotificationRequestBuilder : Microsoft.Graph.EntityRequestBuilder, IManagedTenantEmailNotificationRequestBuilder
    {

        /// <summary>
        /// Constructs a new ManagedTenantEmailNotificationRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagedTenantEmailNotificationRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IManagedTenantEmailNotificationRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IManagedTenantEmailNotificationRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagedTenantEmailNotificationRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Alert.
        /// </summary>
        /// <returns>The <see cref="IManagedTenantAlertWithReferenceRequestBuilder"/>.</returns>
        public IManagedTenantAlertWithReferenceRequestBuilder Alert
        {
            get
            {
                return new ManagedTenantAlertWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("alert"), this.Client);
            }
        }
    
    }
}
