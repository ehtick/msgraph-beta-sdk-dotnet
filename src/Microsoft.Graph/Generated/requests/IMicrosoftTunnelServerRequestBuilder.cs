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
    /// The interface IMicrosoftTunnelServerRequestBuilder.
    /// </summary>
    public partial interface IMicrosoftTunnelServerRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IMicrosoftTunnelServerRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IMicrosoftTunnelServerRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for MicrosoftTunnelServerCreateServerLogCollectionRequest.
        /// </summary>
        /// <returns>The <see cref="IMicrosoftTunnelServerCreateServerLogCollectionRequestRequestBuilder"/>.</returns>
        IMicrosoftTunnelServerCreateServerLogCollectionRequestRequestBuilder CreateServerLogCollectionRequest(
            DateTimeOffset startDateTime,
            DateTimeOffset endDateTime);

        /// <summary>
        /// Gets the request builder for MicrosoftTunnelServerGenerateServerLogCollectionRequest.
        /// </summary>
        /// <returns>The <see cref="IMicrosoftTunnelServerGenerateServerLogCollectionRequestRequestBuilder"/>.</returns>
        IMicrosoftTunnelServerGenerateServerLogCollectionRequestRequestBuilder GenerateServerLogCollectionRequest(
            DateTimeOffset startDateTime,
            DateTimeOffset endDateTime);

        /// <summary>
        /// Gets the request builder for MicrosoftTunnelServerGetHealthMetrics.
        /// </summary>
        /// <returns>The <see cref="IMicrosoftTunnelServerGetHealthMetricsRequestBuilder"/>.</returns>
        IMicrosoftTunnelServerGetHealthMetricsRequestBuilder GetHealthMetrics(
            IEnumerable<string> metricNames = null);

        /// <summary>
        /// Gets the request builder for MicrosoftTunnelServerGetHealthMetricTimeSeries.
        /// </summary>
        /// <returns>The <see cref="IMicrosoftTunnelServerGetHealthMetricTimeSeriesRequestBuilder"/>.</returns>
        IMicrosoftTunnelServerGetHealthMetricTimeSeriesRequestBuilder GetHealthMetricTimeSeries(
            DateTimeOffset startDateTime,
            DateTimeOffset endDateTime,
            string metricName = null);
    
    }
}
