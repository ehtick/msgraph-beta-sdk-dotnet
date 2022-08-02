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
    /// The type OrganizationalBrandingPropertiesRequestBuilder.
    /// </summary>
    public partial class OrganizationalBrandingPropertiesRequestBuilder : EntityRequestBuilder, IOrganizationalBrandingPropertiesRequestBuilder
    {

        /// <summary>
        /// Constructs a new OrganizationalBrandingPropertiesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public OrganizationalBrandingPropertiesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IOrganizationalBrandingPropertiesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IOrganizationalBrandingPropertiesRequest Request(IEnumerable<Option> options)
        {
            return new OrganizationalBrandingPropertiesRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for BackgroundImage.
        /// </summary>
        /// <returns>The <see cref="IOrganizationalBrandingPropertiesBackgroundImageRequestBuilder"/>.</returns>
        public IOrganizationalBrandingPropertiesBackgroundImageRequestBuilder BackgroundImage
        {
            get
            {
                return new OrganizationalBrandingPropertiesBackgroundImageRequestBuilder(this.AppendSegmentToRequestUrl("backgroundImage"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for BannerLogo.
        /// </summary>
        /// <returns>The <see cref="IOrganizationalBrandingPropertiesBannerLogoRequestBuilder"/>.</returns>
        public IOrganizationalBrandingPropertiesBannerLogoRequestBuilder BannerLogo
        {
            get
            {
                return new OrganizationalBrandingPropertiesBannerLogoRequestBuilder(this.AppendSegmentToRequestUrl("bannerLogo"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Favicon.
        /// </summary>
        /// <returns>The <see cref="IOrganizationalBrandingPropertiesFaviconRequestBuilder"/>.</returns>
        public IOrganizationalBrandingPropertiesFaviconRequestBuilder Favicon
        {
            get
            {
                return new OrganizationalBrandingPropertiesFaviconRequestBuilder(this.AppendSegmentToRequestUrl("favicon"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SquareLogo.
        /// </summary>
        /// <returns>The <see cref="IOrganizationalBrandingPropertiesSquareLogoRequestBuilder"/>.</returns>
        public IOrganizationalBrandingPropertiesSquareLogoRequestBuilder SquareLogo
        {
            get
            {
                return new OrganizationalBrandingPropertiesSquareLogoRequestBuilder(this.AppendSegmentToRequestUrl("squareLogo"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SquareLogoDark.
        /// </summary>
        /// <returns>The <see cref="IOrganizationalBrandingPropertiesSquareLogoDarkRequestBuilder"/>.</returns>
        public IOrganizationalBrandingPropertiesSquareLogoDarkRequestBuilder SquareLogoDark
        {
            get
            {
                return new OrganizationalBrandingPropertiesSquareLogoDarkRequestBuilder(this.AppendSegmentToRequestUrl("squareLogoDark"), this.Client);
            }
        }
    
    }
}
