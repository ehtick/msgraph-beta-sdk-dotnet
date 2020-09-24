// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type OrganizationalBrandingRequestBuilder.
    /// </summary>
    public partial class OrganizationalBrandingRequestBuilder : OrganizationalBrandingPropertiesRequestBuilder, IOrganizationalBrandingRequestBuilder
    {

        /// <summary>
        /// Constructs a new OrganizationalBrandingRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OrganizationalBrandingRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOrganizationalBrandingRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOrganizationalBrandingRequest Request(IEnumerable<Option> options)
        {
            return new OrganizationalBrandingRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Localizations.
        /// </summary>
        /// <returns>The <see cref="IOrganizationalBrandingLocalizationsCollectionRequestBuilder"/>.</returns>
        public IOrganizationalBrandingLocalizationsCollectionRequestBuilder Localizations
        {
            get
            {
                return new OrganizationalBrandingLocalizationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("localizations"), this.Client);
            }
        }
    
    }
}
