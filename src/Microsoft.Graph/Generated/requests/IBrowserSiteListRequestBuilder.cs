// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IBrowserSiteListRequestBuilder.
    /// </summary>
    public partial interface IBrowserSiteListRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IBrowserSiteListRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IBrowserSiteListRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for SharedCookies.
        /// </summary>
        /// <returns>The <see cref="IBrowserSiteListSharedCookiesCollectionRequestBuilder"/>.</returns>
        IBrowserSiteListSharedCookiesCollectionRequestBuilder SharedCookies { get; }

        /// <summary>
        /// Gets the request builder for Sites.
        /// </summary>
        /// <returns>The <see cref="IBrowserSiteListSitesCollectionRequestBuilder"/>.</returns>
        IBrowserSiteListSitesCollectionRequestBuilder Sites { get; }
    
        /// <summary>
        /// Gets the request builder for BrowserSiteListPublish.
        /// </summary>
        /// <returns>The <see cref="IBrowserSiteListPublishRequestBuilder"/>.</returns>
        IBrowserSiteListPublishRequestBuilder Publish(
            string revision,
            IEnumerable<BrowserSite> sites = null,
            IEnumerable<BrowserSharedCookie> sharedCookies = null);
    
    }
}
