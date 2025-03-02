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
    /// The type CrossTenantAccessPolicyRequestBuilder.
    /// </summary>
    public partial class CrossTenantAccessPolicyRequestBuilder : TenantRelationshipAccessPolicyBaseRequestBuilder, ICrossTenantAccessPolicyRequestBuilder
    {

        /// <summary>
        /// Constructs a new CrossTenantAccessPolicyRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CrossTenantAccessPolicyRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ICrossTenantAccessPolicyRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ICrossTenantAccessPolicyRequest Request(IEnumerable<Option> options)
        {
            return new CrossTenantAccessPolicyRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Default.
        /// </summary>
        /// <returns>The <see cref="ICrossTenantAccessPolicyConfigurationDefaultRequestBuilder"/>.</returns>
        public ICrossTenantAccessPolicyConfigurationDefaultRequestBuilder Default
        {
            get
            {
                return new CrossTenantAccessPolicyConfigurationDefaultRequestBuilder(this.AppendSegmentToRequestUrl("default"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Partners.
        /// </summary>
        /// <returns>The <see cref="ICrossTenantAccessPolicyPartnersCollectionRequestBuilder"/>.</returns>
        public ICrossTenantAccessPolicyPartnersCollectionRequestBuilder Partners
        {
            get
            {
                return new CrossTenantAccessPolicyPartnersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("partners"), this.Client);
            }
        }
    
    }
}
