// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface ICustodianUserSourcesCollectionRequestBuilder.
    /// </summary>
    public partial interface ICustodianUserSourcesCollectionRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ICustodianUserSourcesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ICustodianUserSourcesCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IUserSourceRequestBuilder"/> for the specified UserSource.
        /// </summary>
        /// <param name="id">The ID for the UserSource.</param>
        /// <returns>The <see cref="IUserSourceRequestBuilder"/>.</returns>
        IUserSourceRequestBuilder this[string id] { get; }

        
    }
}
