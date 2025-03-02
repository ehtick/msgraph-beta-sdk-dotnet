// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ApplicationAppManagementPoliciesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class ApplicationAppManagementPoliciesCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IApplicationAppManagementPoliciesCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new ApplicationAppManagementPoliciesCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ApplicationAppManagementPoliciesCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IApplicationAppManagementPoliciesCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IApplicationAppManagementPoliciesCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new ApplicationAppManagementPoliciesCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAppManagementPolicyWithReferenceRequestBuilder"/> for the specified ApplicationAppManagementPolicy.
        /// </summary>
        /// <param name="id">The ID for the ApplicationAppManagementPolicy.</param>
        /// <returns>The <see cref="IAppManagementPolicyWithReferenceRequestBuilder"/>.</returns>
        public IAppManagementPolicyWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new AppManagementPolicyWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IApplicationAppManagementPoliciesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IApplicationAppManagementPoliciesCollectionReferencesRequestBuilder"/>.</returns>
        public IApplicationAppManagementPoliciesCollectionReferencesRequestBuilder References
        {
            get
            {
                return new ApplicationAppManagementPoliciesCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
