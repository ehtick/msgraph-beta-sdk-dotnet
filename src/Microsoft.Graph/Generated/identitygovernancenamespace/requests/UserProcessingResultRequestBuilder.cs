// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type UserProcessingResultRequestBuilder.
    /// </summary>
    public partial class UserProcessingResultRequestBuilder : Microsoft.Graph.EntityRequestBuilder, IUserProcessingResultRequestBuilder
    {

        /// <summary>
        /// Constructs a new UserProcessingResultRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public UserProcessingResultRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IUserProcessingResultRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IUserProcessingResultRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new UserProcessingResultRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Subject.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.IUserWithReferenceRequestBuilder"/>.</returns>
        public Microsoft.Graph.IUserWithReferenceRequestBuilder Subject
        {
            get
            {
                return new Microsoft.Graph.UserWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("subject"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for TaskProcessingResults.
        /// </summary>
        /// <returns>The <see cref="IUserProcessingResultTaskProcessingResultsCollectionRequestBuilder"/>.</returns>
        public IUserProcessingResultTaskProcessingResultsCollectionRequestBuilder TaskProcessingResults
        {
            get
            {
                return new UserProcessingResultTaskProcessingResultsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("taskProcessingResults"), this.Client);
            }
        }
    
        
    
    }
}
