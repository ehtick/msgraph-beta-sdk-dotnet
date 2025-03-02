// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IMethodRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IReportRootGetOffice365ServicesUserCountsRequest.
    /// </summary>
    public partial interface IReportRootGetOffice365ServicesUserCountsRequest : IBaseRequest
    {

        /// <summary>
        /// Issues the GET request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365ServicesUserCountsCollectionPage> GetAsync(
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Issues the GET request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRootGetOffice365ServicesUserCountsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);


        /// <summary>
        /// Issues the PATCH request.
        /// </summary>
        /// <param name="office365servicesusercounts">The Office365ServicesUserCounts object set with the properties to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365ServicesUserCountsCollectionPage> PatchAsync(Office365ServicesUserCounts office365servicesusercounts,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Issues the PATCH request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="office365servicesusercounts">The Office365ServicesUserCounts object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRootGetOffice365ServicesUserCountsCollectionResponse>> PatchResponseAsync(Office365ServicesUserCounts office365servicesusercounts, CancellationToken cancellationToken = default);


        /// <summary>
        /// Issues the PUT request.
        /// </summary>
        /// <param name="office365servicesusercounts">The Office365ServicesUserCounts object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await for async call.</returns>
        System.Threading.Tasks.Task<IReportRootGetOffice365ServicesUserCountsCollectionPage> PutAsync(Office365ServicesUserCounts office365servicesusercounts,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Issues the PUT request and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="office365servicesusercounts">The Office365ServicesUserCounts object set with the properties to update.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request</returns>
        System.Threading.Tasks.Task<GraphResponse<ReportRootGetOffice365ServicesUserCountsCollectionResponse>> PutResponseAsync(Office365ServicesUserCounts office365servicesusercounts, CancellationToken cancellationToken = default);


        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ServicesUserCountsRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ServicesUserCountsRequest Select(string value);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ServicesUserCountsRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ServicesUserCountsRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ServicesUserCountsRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IReportRootGetOffice365ServicesUserCountsRequest OrderBy(string value);
    }
}
