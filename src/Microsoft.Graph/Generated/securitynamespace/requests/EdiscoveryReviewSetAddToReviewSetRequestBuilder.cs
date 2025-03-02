// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type EdiscoveryReviewSetAddToReviewSetRequestBuilder.
    /// </summary>
    public partial class EdiscoveryReviewSetAddToReviewSetRequestBuilder : Microsoft.Graph.BaseActionMethodRequestBuilder<IEdiscoveryReviewSetAddToReviewSetRequest>, IEdiscoveryReviewSetAddToReviewSetRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="EdiscoveryReviewSetAddToReviewSetRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        /// <param name="search">A search parameter for the OData method call.</param>
        /// <param name="additionalDataOptions">A additionalDataOptions parameter for the OData method call.</param>
        public EdiscoveryReviewSetAddToReviewSetRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client,
            EdiscoverySearch search,
            AdditionalDataOptions? additionalDataOptions)
            : base(requestUrl, client)
        {
            this.SetParameter("search", search, true);
            this.SetParameter("additionalDataOptions", additionalDataOptions, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IEdiscoveryReviewSetAddToReviewSetRequest CreateRequest(string functionUrl, IEnumerable<Microsoft.Graph.Option> options)
        {
            var request = new EdiscoveryReviewSetAddToReviewSetRequest(functionUrl, this.Client, options);

            if (this.HasParameter("search"))
            {
                request.RequestBody.Search = this.GetParameter<EdiscoverySearch>("search");
            }

            if (this.HasParameter("additionalDataOptions"))
            {
                request.RequestBody.AdditionalDataOptions = this.GetParameter<AdditionalDataOptions?>("additionalDataOptions");
            }

            return request;
        }
    }
}
