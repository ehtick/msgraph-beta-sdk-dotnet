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
    /// The interface IUserExperienceAnalyticsWorkFromAnywhereMetricRequest.
    /// </summary>
    public partial interface IUserExperienceAnalyticsWorkFromAnywhereMetricRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified UserExperienceAnalyticsWorkFromAnywhereMetric using POST.
        /// </summary>
        /// <param name="userExperienceAnalyticsWorkFromAnywhereMetricToCreate">The UserExperienceAnalyticsWorkFromAnywhereMetric to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created UserExperienceAnalyticsWorkFromAnywhereMetric.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsWorkFromAnywhereMetric> CreateAsync(UserExperienceAnalyticsWorkFromAnywhereMetric userExperienceAnalyticsWorkFromAnywhereMetricToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified UserExperienceAnalyticsWorkFromAnywhereMetric using POST and returns a <see cref="GraphResponse{UserExperienceAnalyticsWorkFromAnywhereMetric}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsWorkFromAnywhereMetricToCreate">The UserExperienceAnalyticsWorkFromAnywhereMetric to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsWorkFromAnywhereMetric}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsWorkFromAnywhereMetric>> CreateResponseAsync(UserExperienceAnalyticsWorkFromAnywhereMetric userExperienceAnalyticsWorkFromAnywhereMetricToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsWorkFromAnywhereMetric.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified UserExperienceAnalyticsWorkFromAnywhereMetric and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsWorkFromAnywhereMetric.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The UserExperienceAnalyticsWorkFromAnywhereMetric.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsWorkFromAnywhereMetric> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified UserExperienceAnalyticsWorkFromAnywhereMetric and returns a <see cref="GraphResponse{UserExperienceAnalyticsWorkFromAnywhereMetric}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsWorkFromAnywhereMetric}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsWorkFromAnywhereMetric>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsWorkFromAnywhereMetric using PATCH.
        /// </summary>
        /// <param name="userExperienceAnalyticsWorkFromAnywhereMetricToUpdate">The UserExperienceAnalyticsWorkFromAnywhereMetric to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated UserExperienceAnalyticsWorkFromAnywhereMetric.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsWorkFromAnywhereMetric> UpdateAsync(UserExperienceAnalyticsWorkFromAnywhereMetric userExperienceAnalyticsWorkFromAnywhereMetricToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsWorkFromAnywhereMetric using PATCH and returns a <see cref="GraphResponse{UserExperienceAnalyticsWorkFromAnywhereMetric}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsWorkFromAnywhereMetricToUpdate">The UserExperienceAnalyticsWorkFromAnywhereMetric to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{UserExperienceAnalyticsWorkFromAnywhereMetric}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsWorkFromAnywhereMetric>> UpdateResponseAsync(UserExperienceAnalyticsWorkFromAnywhereMetric userExperienceAnalyticsWorkFromAnywhereMetricToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsWorkFromAnywhereMetric using PUT.
        /// </summary>
        /// <param name="userExperienceAnalyticsWorkFromAnywhereMetricToUpdate">The UserExperienceAnalyticsWorkFromAnywhereMetric object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<UserExperienceAnalyticsWorkFromAnywhereMetric> PutAsync(UserExperienceAnalyticsWorkFromAnywhereMetric userExperienceAnalyticsWorkFromAnywhereMetricToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified UserExperienceAnalyticsWorkFromAnywhereMetric using PUT and returns a <see cref="GraphResponse{UserExperienceAnalyticsWorkFromAnywhereMetric}"/> object.
        /// </summary>
        /// <param name="userExperienceAnalyticsWorkFromAnywhereMetricToUpdate">The UserExperienceAnalyticsWorkFromAnywhereMetric object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{UserExperienceAnalyticsWorkFromAnywhereMetric}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<UserExperienceAnalyticsWorkFromAnywhereMetric>> PutResponseAsync(UserExperienceAnalyticsWorkFromAnywhereMetric userExperienceAnalyticsWorkFromAnywhereMetricToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsWorkFromAnywhereMetricRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsWorkFromAnywhereMetricRequest Expand(Expression<Func<UserExperienceAnalyticsWorkFromAnywhereMetric, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsWorkFromAnywhereMetricRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IUserExperienceAnalyticsWorkFromAnywhereMetricRequest Select(Expression<Func<UserExperienceAnalyticsWorkFromAnywhereMetric, object>> selectExpression);

    }
}
