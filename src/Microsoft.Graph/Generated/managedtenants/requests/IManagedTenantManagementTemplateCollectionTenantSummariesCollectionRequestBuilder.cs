// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IManagedTenantManagementTemplateCollectionTenantSummariesCollectionRequestBuilder.
    /// </summary>
    public partial interface IManagedTenantManagementTemplateCollectionTenantSummariesCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagedTenantManagementTemplateCollectionTenantSummariesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagedTenantManagementTemplateCollectionTenantSummariesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IManagementTemplateCollectionTenantSummaryRequestBuilder"/> for the specified ManagementTemplateCollectionTenantSummary.
        /// </summary>
        /// <param name="id">The ID for the ManagementTemplateCollectionTenantSummary.</param>
        /// <returns>The <see cref="IManagementTemplateCollectionTenantSummaryRequestBuilder"/>.</returns>
        IManagementTemplateCollectionTenantSummaryRequestBuilder this[string id] { get; }

        
    }
}
