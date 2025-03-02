// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IUserExperienceAnalyticsBaselineRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsBaselineRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsBaseline using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsBaselineToCreate">The UserExperienceAnalyticsBaseline to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsBaseline.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsBaseline> CreateAsync(UserExperienceAnalyticsBaseline userExperienceAnalyticsBaselineToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsBaseline using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsBaseline}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsBaselineToCreate">The UserExperienceAnalyticsBaseline to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsBaseline}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsBaseline>> CreateResponseAsync(UserExperienceAnalyticsBaseline userExperienceAnalyticsBaselineToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsBaseline.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsBaseline and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsBaseline.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsBaseline.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsBaseline> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsBaseline and returns a <see cref="GraphResponse{UserExperienceAnalyticsBaseline}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsBaseline}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsBaseline>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsBaseline using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsBaselineToUpdate">The UserExperienceAnalyticsBaseline to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsBaseline.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsBaseline> UpdateAsync(UserExperienceAnalyticsBaseline userExperienceAnalyticsBaselineToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsBaseline using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsBaseline}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsBaselineToUpdate">The UserExperienceAnalyticsBaseline to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsBaseline}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsBaseline>> UpdateResponseAsync(UserExperienceAnalyticsBaseline userExperienceAnalyticsBaselineToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsBaseline using PUT.
        /// </summary>
        /// <param name="userExperienceAnalyticsBaselineToUpdate">The UserExperienceAnalyticsBaseline object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsBaseline> PutAsync(UserExperienceAnalyticsBaseline userExperienceAnalyticsBaselineToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsBaseline using PUT and returns a <see cref="GraphResponse{UserExperienceAnalyticsBaseline}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsBaselineToUpdate">The UserExperienceAnalyticsBaseline object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UserExperienceAnalyticsBaseline}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsBaseline>> PutResponseAsync(UserExperienceAnalyticsBaseline userExperienceAnalyticsBaselineToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsBaselineRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsBaselineRequest Expand(Expression<Func<UserExperienceAnalyticsBaseline, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsBaselineRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsBaselineRequest Select(Expression<Func<UserExperienceAnalyticsBaseline, object>> selectExpression);

    }
}
