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
    /// The type IdentityContainerRequestBuilder.
    /// </summary>
    public partial class IdentityContainerRequestBuilder : BaseRequestBuilder, IIdentityContainerRequestBuilder
    {

        /// <summary>
        /// Constructs a new IdentityContainerRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public IdentityContainerRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IIdentityContainerRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IIdentityContainerRequest Request(IEnumerable<Option> options)
        {
            return new IdentityContainerRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ApiConnectors.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerApiConnectorsCollectionRequestBuilder"/>.</returns>
        public IIdentityContainerApiConnectorsCollectionRequestBuilder ApiConnectors
        {
            get
            {
                return new IdentityContainerApiConnectorsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("apiConnectors"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AuthenticationEventListeners.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerAuthenticationEventListenersCollectionRequestBuilder"/>.</returns>
        public IIdentityContainerAuthenticationEventListenersCollectionRequestBuilder AuthenticationEventListeners
        {
            get
            {
                return new IdentityContainerAuthenticationEventListenersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("authenticationEventListeners"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for B2cUserFlows.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerB2cUserFlowsCollectionRequestBuilder"/>.</returns>
        public IIdentityContainerB2cUserFlowsCollectionRequestBuilder B2cUserFlows
        {
            get
            {
                return new IdentityContainerB2cUserFlowsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("b2cUserFlows"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for B2xUserFlows.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerB2xUserFlowsCollectionRequestBuilder"/>.</returns>
        public IIdentityContainerB2xUserFlowsCollectionRequestBuilder B2xUserFlows
        {
            get
            {
                return new IdentityContainerB2xUserFlowsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("b2xUserFlows"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for CustomAuthenticationExtensions.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerCustomAuthenticationExtensionsCollectionRequestBuilder"/>.</returns>
        public IIdentityContainerCustomAuthenticationExtensionsCollectionRequestBuilder CustomAuthenticationExtensions
        {
            get
            {
                return new IdentityContainerCustomAuthenticationExtensionsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("customAuthenticationExtensions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for IdentityProviders.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerIdentityProvidersCollectionRequestBuilder"/>.</returns>
        public IIdentityContainerIdentityProvidersCollectionRequestBuilder IdentityProviders
        {
            get
            {
                return new IdentityContainerIdentityProvidersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("identityProviders"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserFlowAttributes.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerUserFlowAttributesCollectionRequestBuilder"/>.</returns>
        public IIdentityContainerUserFlowAttributesCollectionRequestBuilder UserFlowAttributes
        {
            get
            {
                return new IdentityContainerUserFlowAttributesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userFlowAttributes"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for UserFlows.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerUserFlowsCollectionRequestBuilder"/>.</returns>
        public IIdentityContainerUserFlowsCollectionRequestBuilder UserFlows
        {
            get
            {
                return new IdentityContainerUserFlowsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userFlows"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ConditionalAccess.
        /// </summary>
        /// <returns>The <see cref="IConditionalAccessRootRequestBuilder"/>.</returns>
        public IConditionalAccessRootRequestBuilder ConditionalAccess
        {
            get
            {
                return new ConditionalAccessRootRequestBuilder(this.AppendSegmentToRequestUrl("conditionalAccess"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ContinuousAccessEvaluationPolicy.
        /// </summary>
        /// <returns>The <see cref="IContinuousAccessEvaluationPolicyRequestBuilder"/>.</returns>
        public IContinuousAccessEvaluationPolicyRequestBuilder ContinuousAccessEvaluationPolicy
        {
            get
            {
                return new ContinuousAccessEvaluationPolicyRequestBuilder(this.AppendSegmentToRequestUrl("continuousAccessEvaluationPolicy"), this.Client);
            }
        }
    
    }
}
