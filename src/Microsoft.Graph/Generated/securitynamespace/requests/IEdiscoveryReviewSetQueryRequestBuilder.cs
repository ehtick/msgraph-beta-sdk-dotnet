// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IEdiscoveryReviewSetQueryRequestBuilder.
    /// </summary>
    public partial interface IEdiscoveryReviewSetQueryRequestBuilder : ISearchRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IEdiscoveryReviewSetQueryRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IEdiscoveryReviewSetQueryRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for EdiscoveryReviewSetQueryExport.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryReviewSetQueryExportRequestBuilder"/>.</returns>
        IEdiscoveryReviewSetQueryExportRequestBuilder Export(
            string outputName = null,
            string description = null,
            string azureBlobContainer = null,
            string azureBlobToken = null,
            ExportOptions? exportOptions = null,
            ExportFileStructure? exportStructure = null);

        /// <summary>
        /// Gets the request builder for EdiscoveryReviewSetQueryApplyTags.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryReviewSetQueryApplyTagsRequestBuilder"/>.</returns>
        IEdiscoveryReviewSetQueryApplyTagsRequestBuilder ApplyTags(
            IEnumerable<EdiscoveryReviewTag> tagsToAdd = null,
            IEnumerable<EdiscoveryReviewTag> tagsToRemove = null);

        /// <summary>
        /// Gets the request builder for EdiscoveryReviewSetQueryRun.
        /// </summary>
        /// <returns>The <see cref="IEdiscoveryReviewSetQueryRunRequestBuilder"/>.</returns>
        IEdiscoveryReviewSetQueryRunRequestBuilder Run();
    
    }
}
