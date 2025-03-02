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
    /// The type AccessReviewSetRequestBuilder.
    /// </summary>
    public partial class AccessReviewSetRequestBuilder : EntityRequestBuilder, IAccessReviewSetRequestBuilder
    {

        /// <summary>
        /// Constructs a new AccessReviewSetRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessReviewSetRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAccessReviewSetRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAccessReviewSetRequest Request(IEnumerable<Option> options)
        {
            return new AccessReviewSetRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Decisions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewSetDecisionsCollectionRequestBuilder"/>.</returns>
        public IAccessReviewSetDecisionsCollectionRequestBuilder Decisions
        {
            get
            {
                return new AccessReviewSetDecisionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("decisions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Definitions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewSetDefinitionsCollectionRequestBuilder"/>.</returns>
        public IAccessReviewSetDefinitionsCollectionRequestBuilder Definitions
        {
            get
            {
                return new AccessReviewSetDefinitionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("definitions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for HistoryDefinitions.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewSetHistoryDefinitionsCollectionRequestBuilder"/>.</returns>
        public IAccessReviewSetHistoryDefinitionsCollectionRequestBuilder HistoryDefinitions
        {
            get
            {
                return new AccessReviewSetHistoryDefinitionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("historyDefinitions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Policy.
        /// </summary>
        /// <returns>The <see cref="IAccessReviewPolicyRequestBuilder"/>.</returns>
        public IAccessReviewPolicyRequestBuilder Policy
        {
            get
            {
                return new AccessReviewPolicyRequestBuilder(this.AppendSegmentToRequestUrl("policy"), this.Client);
            }
        }
    
    }
}
