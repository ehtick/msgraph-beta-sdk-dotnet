// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type BrowserSiteListRequestBuilder.
    /// </summary>
    public partial class BrowserSiteListRequestBuilder : EntityRequestBuilder, IBrowserSiteListRequestBuilder
    {

        /// <summary>
        /// Constructs a new BrowserSiteListRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public BrowserSiteListRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IBrowserSiteListRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IBrowserSiteListRequest Request(IEnumerable<Option> options)
        {
            return new BrowserSiteListRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for SharedCookies.
        /// </summary>
        /// <returns>The <see cref="IBrowserSiteListSharedCookiesCollectionRequestBuilder"/>.</returns>
        public IBrowserSiteListSharedCookiesCollectionRequestBuilder SharedCookies
        {
            get
            {
                return new BrowserSiteListSharedCookiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sharedCookies"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Sites.
        /// </summary>
        /// <returns>The <see cref="IBrowserSiteListSitesCollectionRequestBuilder"/>.</returns>
        public IBrowserSiteListSitesCollectionRequestBuilder Sites
        {
            get
            {
                return new BrowserSiteListSitesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("sites"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for BrowserSiteListPublish.
        /// </summary>
        /// <returns>The <see cref="IBrowserSiteListPublishRequestBuilder"/>.</returns>
        public IBrowserSiteListPublishRequestBuilder Publish(
            string revision,
            IEnumerable<BrowserSite> sites = null,
            IEnumerable<BrowserSharedCookie> sharedCookies = null)
        {
            return new BrowserSiteListPublishRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.publish"),
                this.Client,
                revision,
                sites,
                sharedCookies);
        }
    
    }
}
