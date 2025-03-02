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
    /// The type LearningProviderLearningContentsCollectionRequestBuilder.
    /// </summary>
    public partial class LearningProviderLearningContentsCollectionRequestBuilder : BaseRequestBuilder, ILearningProviderLearningContentsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new LearningProviderLearningContentsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public LearningProviderLearningContentsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ILearningProviderLearningContentsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ILearningProviderLearningContentsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new LearningProviderLearningContentsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ILearningContentRequestBuilder"/> for the specified LearningProviderLearningContent.
        /// </summary>
        /// <param name="id">The ID for the LearningProviderLearningContent.</param>
        /// <returns>The <see cref="ILearningContentRequestBuilder"/>.</returns>
        public ILearningContentRequestBuilder this[string id]
        {
            get
            {
                return new LearningContentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
