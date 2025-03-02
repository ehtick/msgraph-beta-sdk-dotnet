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
    /// The interface ICloudPcDeviceImageRequest.
    /// </summary>
    public partial interface ICloudPcDeviceImageRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified CloudPcDeviceImage using POST.
        /// </summary>
        /// <param name="cloudPcDeviceImageToCreate">The CloudPcDeviceImage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created CloudPcDeviceImage.</returns>
        System.Threading.Tasks.Task<CloudPcDeviceImage> CreateAsync(CloudPcDeviceImage cloudPcDeviceImageToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified CloudPcDeviceImage using POST and returns a <see cref="GraphResponse{CloudPcDeviceImage}"/> object.
        /// </summary>
        /// <param name="cloudPcDeviceImageToCreate">The CloudPcDeviceImage to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcDeviceImage}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcDeviceImage>> CreateResponseAsync(CloudPcDeviceImage cloudPcDeviceImageToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CloudPcDeviceImage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified CloudPcDeviceImage and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CloudPcDeviceImage.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The CloudPcDeviceImage.</returns>
        System.Threading.Tasks.Task<CloudPcDeviceImage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified CloudPcDeviceImage and returns a <see cref="GraphResponse{CloudPcDeviceImage}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{CloudPcDeviceImage}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcDeviceImage>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CloudPcDeviceImage using PATCH.
        /// </summary>
        /// <param name="cloudPcDeviceImageToUpdate">The CloudPcDeviceImage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated CloudPcDeviceImage.</returns>
        System.Threading.Tasks.Task<CloudPcDeviceImage> UpdateAsync(CloudPcDeviceImage cloudPcDeviceImageToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CloudPcDeviceImage using PATCH and returns a <see cref="GraphResponse{CloudPcDeviceImage}"/> object.
        /// </summary>
        /// <param name="cloudPcDeviceImageToUpdate">The CloudPcDeviceImage to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{CloudPcDeviceImage}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcDeviceImage>> UpdateResponseAsync(CloudPcDeviceImage cloudPcDeviceImageToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CloudPcDeviceImage using PUT.
        /// </summary>
        /// <param name="cloudPcDeviceImageToUpdate">The CloudPcDeviceImage object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<CloudPcDeviceImage> PutAsync(CloudPcDeviceImage cloudPcDeviceImageToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified CloudPcDeviceImage using PUT and returns a <see cref="GraphResponse{CloudPcDeviceImage}"/> object.
        /// </summary>
        /// <param name="cloudPcDeviceImageToUpdate">The CloudPcDeviceImage object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{CloudPcDeviceImage}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<CloudPcDeviceImage>> PutResponseAsync(CloudPcDeviceImage cloudPcDeviceImageToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceImageRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceImageRequest Expand(Expression<Func<CloudPcDeviceImage, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceImageRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ICloudPcDeviceImageRequest Select(Expression<Func<CloudPcDeviceImage, object>> selectExpression);

    }
}
