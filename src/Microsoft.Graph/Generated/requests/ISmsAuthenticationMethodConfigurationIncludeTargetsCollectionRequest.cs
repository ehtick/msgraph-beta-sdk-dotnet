// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISmsAuthenticationMethodConfigurationIncludeTargetsCollectionRequest.
    /// </summary>
    public partial interface ISmsAuthenticationMethodConfigurationIncludeTargetsCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified SmsAuthenticationMethodTarget to the collection via POST.
        /// </summary>
        /// <param name="smsAuthenticationMethodTarget">The SmsAuthenticationMethodTarget to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SmsAuthenticationMethodTarget.</returns>
        System.Threading.Tasks.Task<SmsAuthenticationMethodTarget> AddAsync(SmsAuthenticationMethodTarget smsAuthenticationMethodTarget, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified SmsAuthenticationMethodTarget to the collection via POST and returns a <see cref="GraphResponse{SmsAuthenticationMethodTarget}"/> object of the request.
        /// </summary>
        /// <param name="smsAuthenticationMethodTarget">The SmsAuthenticationMethodTarget to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SmsAuthenticationMethodTarget}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SmsAuthenticationMethodTarget>> AddResponseAsync(SmsAuthenticationMethodTarget smsAuthenticationMethodTarget, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ISmsAuthenticationMethodConfigurationIncludeTargetsCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{SmsAuthenticationMethodConfigurationIncludeTargetsCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SmsAuthenticationMethodConfigurationIncludeTargetsCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<SmsAuthenticationMethodConfigurationIncludeTargetsCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISmsAuthenticationMethodConfigurationIncludeTargetsCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISmsAuthenticationMethodConfigurationIncludeTargetsCollectionRequest Expand(Expression<Func<SmsAuthenticationMethodTarget, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISmsAuthenticationMethodConfigurationIncludeTargetsCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISmsAuthenticationMethodConfigurationIncludeTargetsCollectionRequest Select(Expression<Func<SmsAuthenticationMethodTarget, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ISmsAuthenticationMethodConfigurationIncludeTargetsCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ISmsAuthenticationMethodConfigurationIncludeTargetsCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ISmsAuthenticationMethodConfigurationIncludeTargetsCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ISmsAuthenticationMethodConfigurationIncludeTargetsCollectionRequest OrderBy(string value);
    }
}
