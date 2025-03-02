// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceRiskyUsersCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceRiskyUsersCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceRiskyUsersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceRiskyUsersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceRiskyUsersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceRiskyUsersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceRiskyUsersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceRiskyUsersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IRiskyUserRequestBuilder"/> for the specified GraphServiceRiskyUser.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceRiskyUser.</param>
        /// <returns>The <see cref="IRiskyUserRequestBuilder"/>.</returns>
        public IRiskyUserRequestBuilder this[string id]
        {
            get
            {
                return new RiskyUserRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RiskyUserDismiss.
        /// </summary>
        /// <returns>The <see cref="IRiskyUserDismissRequestBuilder"/>.</returns>
        public IRiskyUserDismissRequestBuilder Dismiss(
            IEnumerable<string> userIds = null)
        {
            return new RiskyUserDismissRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.dismiss"),
                this.Client,
                userIds);
        }

        /// <summary>
        /// Gets the request builder for RiskyUserConfirmCompromised.
        /// </summary>
        /// <returns>The <see cref="IRiskyUserConfirmCompromisedRequestBuilder"/>.</returns>
        public IRiskyUserConfirmCompromisedRequestBuilder ConfirmCompromised(
            IEnumerable<string> userIds = null)
        {
            return new RiskyUserConfirmCompromisedRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.confirmCompromised"),
                this.Client,
                userIds);
        }
    }
}
