// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IOnPremisesAgentAgentGroupsCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IOnPremisesAgentAgentGroupsCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IOnPremisesAgentAgentGroupsCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IOnPremisesAgentAgentGroupsCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IOnPremisesAgentGroupWithReferenceRequestBuilder"/> for the specified OnPremisesAgentGroup.
        /// </summary>
        /// <param name="id">The ID for the OnPremisesAgentGroup.</param>
        /// <returns>The <see cref="IOnPremisesAgentGroupWithReferenceRequestBuilder"/>.</returns>
        IOnPremisesAgentGroupWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IOnPremisesAgentAgentGroupsCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesAgentAgentGroupsCollectionReferencesRequestBuilder"/>.</returns>
        IOnPremisesAgentAgentGroupsCollectionReferencesRequestBuilder References { get; }

    }
}
