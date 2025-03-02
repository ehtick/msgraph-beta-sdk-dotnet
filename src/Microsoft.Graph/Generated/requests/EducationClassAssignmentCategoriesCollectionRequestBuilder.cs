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
    /// The type EducationClassAssignmentCategoriesCollectionRequestBuilder.
    /// </summary>
    public partial class EducationClassAssignmentCategoriesCollectionRequestBuilder : BaseRequestBuilder, IEducationClassAssignmentCategoriesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new EducationClassAssignmentCategoriesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationClassAssignmentCategoriesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEducationClassAssignmentCategoriesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEducationClassAssignmentCategoriesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new EducationClassAssignmentCategoriesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEducationCategoryRequestBuilder"/> for the specified EducationClassEducationCategory.
        /// </summary>
        /// <param name="id">The ID for the EducationClassEducationCategory.</param>
        /// <returns>The <see cref="IEducationCategoryRequestBuilder"/>.</returns>
        public IEducationCategoryRequestBuilder this[string id]
        {
            get
            {
                return new EducationCategoryRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for EducationCategoryDelta.
        /// </summary>
        /// <returns>The <see cref="IEducationCategoryDeltaRequestBuilder"/>.</returns>
        public IEducationCategoryDeltaRequestBuilder Delta()
        {
            return new EducationCategoryDeltaRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.delta"),
                this.Client);
        }
    }
}
