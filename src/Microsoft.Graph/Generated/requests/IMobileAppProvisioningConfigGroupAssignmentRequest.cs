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
    /// The interface IMobileAppProvisioningConfigGroupAssignmentRequest.
    /// </summary>
    public partial interface IMobileAppProvisioningConfigGroupAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MobileAppProvisioningConfigGroupAssignment using POST.
        /// </summary>
        /// <param name="mobileAppProvisioningConfigGroupAssignmentToCreate">The MobileAppProvisioningConfigGroupAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileAppProvisioningConfigGroupAssignment.</returns>
        System.Threading.Tasks.Task<MobileAppProvisioningConfigGroupAssignment> CreateAsync(MobileAppProvisioningConfigGroupAssignment mobileAppProvisioningConfigGroupAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified MobileAppProvisioningConfigGroupAssignment using POST and returns a <see cref="GraphResponse{MobileAppProvisioningConfigGroupAssignment}"/> object.
        /// </summary>
        /// <param name="mobileAppProvisioningConfigGroupAssignmentToCreate">The MobileAppProvisioningConfigGroupAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppProvisioningConfigGroupAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppProvisioningConfigGroupAssignment>> CreateResponseAsync(MobileAppProvisioningConfigGroupAssignment mobileAppProvisioningConfigGroupAssignmentToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MobileAppProvisioningConfigGroupAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified MobileAppProvisioningConfigGroupAssignment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MobileAppProvisioningConfigGroupAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileAppProvisioningConfigGroupAssignment.</returns>
        System.Threading.Tasks.Task<MobileAppProvisioningConfigGroupAssignment> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified MobileAppProvisioningConfigGroupAssignment and returns a <see cref="GraphResponse{MobileAppProvisioningConfigGroupAssignment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MobileAppProvisioningConfigGroupAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppProvisioningConfigGroupAssignment>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MobileAppProvisioningConfigGroupAssignment using PATCH.
        /// </summary>
        /// <param name="mobileAppProvisioningConfigGroupAssignmentToUpdate">The MobileAppProvisioningConfigGroupAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MobileAppProvisioningConfigGroupAssignment.</returns>
        System.Threading.Tasks.Task<MobileAppProvisioningConfigGroupAssignment> UpdateAsync(MobileAppProvisioningConfigGroupAssignment mobileAppProvisioningConfigGroupAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MobileAppProvisioningConfigGroupAssignment using PATCH and returns a <see cref="GraphResponse{MobileAppProvisioningConfigGroupAssignment}"/> object.
        /// </summary>
        /// <param name="mobileAppProvisioningConfigGroupAssignmentToUpdate">The MobileAppProvisioningConfigGroupAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MobileAppProvisioningConfigGroupAssignment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppProvisioningConfigGroupAssignment>> UpdateResponseAsync(MobileAppProvisioningConfigGroupAssignment mobileAppProvisioningConfigGroupAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MobileAppProvisioningConfigGroupAssignment using PUT.
        /// </summary>
        /// <param name="mobileAppProvisioningConfigGroupAssignmentToUpdate">The MobileAppProvisioningConfigGroupAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<MobileAppProvisioningConfigGroupAssignment> PutAsync(MobileAppProvisioningConfigGroupAssignment mobileAppProvisioningConfigGroupAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified MobileAppProvisioningConfigGroupAssignment using PUT and returns a <see cref="GraphResponse{MobileAppProvisioningConfigGroupAssignment}"/> object.
        /// </summary>
        /// <param name="mobileAppProvisioningConfigGroupAssignmentToUpdate">The MobileAppProvisioningConfigGroupAssignment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{MobileAppProvisioningConfigGroupAssignment}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<MobileAppProvisioningConfigGroupAssignment>> PutResponseAsync(MobileAppProvisioningConfigGroupAssignment mobileAppProvisioningConfigGroupAssignmentToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppProvisioningConfigGroupAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppProvisioningConfigGroupAssignmentRequest Expand(Expression<Func<MobileAppProvisioningConfigGroupAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppProvisioningConfigGroupAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMobileAppProvisioningConfigGroupAssignmentRequest Select(Expression<Func<MobileAppProvisioningConfigGroupAssignment, object>> selectExpression);

    }
}
