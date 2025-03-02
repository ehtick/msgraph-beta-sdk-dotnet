// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ISearchEntityAcronymsCollectionRequestBuilder.
    /// </summary>
    public partial interface ISearchEntityAcronymsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ISearchEntityAcronymsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ISearchEntityAcronymsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="Microsoft.Graph.Search.IAcronymRequestBuilder"/> for the specified Microsoft.Graph.Search.Acronym.
        /// </summary>
        /// <param name="id">The ID for the Microsoft.Graph.Search.Acronym.</param>
        /// <returns>The <see cref="Microsoft.Graph.Search.IAcronymRequestBuilder"/>.</returns>
        Microsoft.Graph.Search.IAcronymRequestBuilder this[string id] { get; }

        
    }
}
