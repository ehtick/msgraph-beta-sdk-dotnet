// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ManagedTenantManagementTemplateStepTenantSummariesCollectionRequestBuilder.
    /// </summary>
    public partial class ManagedTenantManagementTemplateStepTenantSummariesCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IManagedTenantManagementTemplateStepTenantSummariesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ManagedTenantManagementTemplateStepTenantSummariesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public ManagedTenantManagementTemplateStepTenantSummariesCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IManagedTenantManagementTemplateStepTenantSummariesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IManagedTenantManagementTemplateStepTenantSummariesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new ManagedTenantManagementTemplateStepTenantSummariesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IManagementTemplateStepTenantSummaryRequestBuilder"/> for the specified ManagedTenantManagementTemplateStepTenantSummary.
        /// </summary>
        /// <param name="id">The ID for the ManagedTenantManagementTemplateStepTenantSummary.</param>
        /// <returns>The <see cref="IManagementTemplateStepTenantSummaryRequestBuilder"/>.</returns>
        public IManagementTemplateStepTenantSummaryRequestBuilder this[string id]
        {
            get
            {
                return new ManagementTemplateStepTenantSummaryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
