// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EdiscoveryNoncustodialDataSourceWithReferenceRequestBuilder.
    /// </summary>
    public partial class EdiscoveryNoncustodialDataSourceWithReferenceRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IEdiscoveryNoncustodialDataSourceWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new EdiscoveryNoncustodialDataSourceWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public EdiscoveryNoncustodialDataSourceWithReferenceRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEdiscoveryNoncustodialDataSourceWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEdiscoveryNoncustodialDataSourceWithReferenceRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new EdiscoveryNoncustodialDataSourceWithReferenceRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets the request builder for the reference of the ediscoveryNoncustodialDataSource.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryNoncustodialDataSourceReferenceRequestBuilder"/>.</returns>
        public IEdiscoveryNoncustodialDataSourceReferenceRequestBuilder Reference
        {
            get
            {
                return new EdiscoveryNoncustodialDataSourceReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
