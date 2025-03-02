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
    /// The interface IConditionalAccessTemplateRequest.
    /// </summary>
    public partial interface IConditionalAccessTemplateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ConditionalAccessTemplate using POST.
        /// </summary>
        /// <param name="conditionalAccessTemplateToCreate">The ConditionalAccessTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ConditionalAccessTemplate.</returns>
        System.Threading.Tasks.Task<ConditionalAccessTemplate> CreateAsync(ConditionalAccessTemplate conditionalAccessTemplateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified ConditionalAccessTemplate using POST and returns a <see cref="GraphResponse{ConditionalAccessTemplate}"/> object.
        /// </summary>
        /// <param name="conditionalAccessTemplateToCreate">The ConditionalAccessTemplate to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConditionalAccessTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConditionalAccessTemplate>> CreateResponseAsync(ConditionalAccessTemplate conditionalAccessTemplateToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ConditionalAccessTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified ConditionalAccessTemplate and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ConditionalAccessTemplate.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ConditionalAccessTemplate.</returns>
        System.Threading.Tasks.Task<ConditionalAccessTemplate> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified ConditionalAccessTemplate and returns a <see cref="GraphResponse{ConditionalAccessTemplate}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{ConditionalAccessTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConditionalAccessTemplate>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConditionalAccessTemplate using PATCH.
        /// </summary>
        /// <param name="conditionalAccessTemplateToUpdate">The ConditionalAccessTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ConditionalAccessTemplate.</returns>
        System.Threading.Tasks.Task<ConditionalAccessTemplate> UpdateAsync(ConditionalAccessTemplate conditionalAccessTemplateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConditionalAccessTemplate using PATCH and returns a <see cref="GraphResponse{ConditionalAccessTemplate}"/> object.
        /// </summary>
        /// <param name="conditionalAccessTemplateToUpdate">The ConditionalAccessTemplate to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{ConditionalAccessTemplate}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConditionalAccessTemplate>> UpdateResponseAsync(ConditionalAccessTemplate conditionalAccessTemplateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConditionalAccessTemplate using PUT.
        /// </summary>
        /// <param name="conditionalAccessTemplateToUpdate">The ConditionalAccessTemplate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<ConditionalAccessTemplate> PutAsync(ConditionalAccessTemplate conditionalAccessTemplateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified ConditionalAccessTemplate using PUT and returns a <see cref="GraphResponse{ConditionalAccessTemplate}"/> object.
        /// </summary>
        /// <param name="conditionalAccessTemplateToUpdate">The ConditionalAccessTemplate object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{ConditionalAccessTemplate}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<ConditionalAccessTemplate>> PutResponseAsync(ConditionalAccessTemplate conditionalAccessTemplateToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessTemplateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessTemplateRequest Expand(Expression<Func<ConditionalAccessTemplate, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessTemplateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IConditionalAccessTemplateRequest Select(Expression<Func<ConditionalAccessTemplate, object>> selectExpression);

    }
}
