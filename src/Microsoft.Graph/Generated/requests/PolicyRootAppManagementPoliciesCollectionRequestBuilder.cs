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
    /// The type PolicyRootAppManagementPoliciesCollectionRequestBuilder.
    /// </summary>
    public partial class PolicyRootAppManagementPoliciesCollectionRequestBuilder : BaseRequestBuilder, IPolicyRootAppManagementPoliciesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new PolicyRootAppManagementPoliciesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PolicyRootAppManagementPoliciesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPolicyRootAppManagementPoliciesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPolicyRootAppManagementPoliciesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new PolicyRootAppManagementPoliciesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAppManagementPolicyRequestBuilder"/> for the specified PolicyRootAppManagementPolicy.
        /// </summary>
        /// <param name="id">The ID for the PolicyRootAppManagementPolicy.</param>
        /// <returns>The <see cref="IAppManagementPolicyRequestBuilder"/>.</returns>
        public IAppManagementPolicyRequestBuilder this[string id]
        {
            get
            {
                return new AppManagementPolicyRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
