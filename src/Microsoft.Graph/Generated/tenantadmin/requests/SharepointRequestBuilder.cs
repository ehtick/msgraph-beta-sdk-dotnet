// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.TenantAdmin
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SharepointRequestBuilder.
    /// </summary>
    public partial class SharepointRequestBuilder : Microsoft.Graph.EntityRequestBuilder, ISharepointRequestBuilder
    {

        /// <summary>
        /// Constructs a new SharepointRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public SharepointRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ISharepointRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ISharepointRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new SharepointRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="ISettingsRequestBuilder"/>.</returns>
        public ISettingsRequestBuilder Settings
        {
            get
            {
                return new SettingsRequestBuilder(this.AppendSegmentToRequestUrl("settings"), this.Client);
            }
        }
    
    }
}
