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
    /// The interface IPolicyRootAuthenticationStrengthPoliciesCollectionRequestBuilder.
    /// </summary>
    public partial interface IPolicyRootAuthenticationStrengthPoliciesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPolicyRootAuthenticationStrengthPoliciesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPolicyRootAuthenticationStrengthPoliciesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IAuthenticationStrengthPolicyRequestBuilder"/> for the specified AuthenticationStrengthPolicy.
        /// </summary>
        /// <param name="id">The ID for the AuthenticationStrengthPolicy.</param>
        /// <returns>The <see cref="IAuthenticationStrengthPolicyRequestBuilder"/>.</returns>
        IAuthenticationStrengthPolicyRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for AuthenticationStrengthPolicyFindByMethodMode.
        /// </summary>
        /// <returns>The <see cref="IAuthenticationStrengthPolicyFindByMethodModeRequestBuilder"/>.</returns>
        IAuthenticationStrengthPolicyFindByMethodModeRequestBuilder FindByMethodMode(
            IEnumerable<AuthenticationMethodModes> authenticationMethodModes);
    }
}
