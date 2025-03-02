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
    /// The type RequestRequestBuilder.
    /// </summary>
    public partial class RequestRequestBuilder : EntityRequestBuilder, IRequestRequestBuilder
    {

        /// <summary>
        /// Constructs a new RequestRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public RequestRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IRequestRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IRequestRequest Request(IEnumerable<Option> options)
        {
            return new RequestRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for RequestStop.
        /// </summary>
        /// <returns>The <see cref="IRequestStopRequestBuilder"/>.</returns>
        public IRequestStopRequestBuilder Stop()
        {
            return new RequestStopRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.stop"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for RequestRecordDecisions.
        /// </summary>
        /// <returns>The <see cref="IRequestRecordDecisionsRequestBuilder"/>.</returns>
        public IRequestRecordDecisionsRequestBuilder RecordDecisions(
            string reviewResult = null,
            string justification = null)
        {
            return new RequestRecordDecisionsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.recordDecisions"),
                this.Client,
                reviewResult,
                justification);
        }
    
    }
}
