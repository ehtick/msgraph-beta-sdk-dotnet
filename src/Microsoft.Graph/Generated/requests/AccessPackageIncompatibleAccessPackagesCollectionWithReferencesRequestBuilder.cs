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
    /// The type AccessPackageIncompatibleAccessPackagesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class AccessPackageIncompatibleAccessPackagesCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IAccessPackageIncompatibleAccessPackagesCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new AccessPackageIncompatibleAccessPackagesCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessPackageIncompatibleAccessPackagesCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAccessPackageIncompatibleAccessPackagesCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAccessPackageIncompatibleAccessPackagesCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new AccessPackageIncompatibleAccessPackagesCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAccessPackageWithReferenceRequestBuilder"/> for the specified AccessPackageAccessPackage.
        /// </summary>
        /// <param name="id">The ID for the AccessPackageAccessPackage.</param>
        /// <returns>The <see cref="IAccessPackageWithReferenceRequestBuilder"/>.</returns>
        public IAccessPackageWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new AccessPackageWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IAccessPackageIncompatibleAccessPackagesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageIncompatibleAccessPackagesCollectionReferencesRequestBuilder"/>.</returns>
        public IAccessPackageIncompatibleAccessPackagesCollectionReferencesRequestBuilder References
        {
            get
            {
                return new AccessPackageIncompatibleAccessPackagesCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
