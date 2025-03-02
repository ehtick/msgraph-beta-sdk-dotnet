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
    /// The interface IWorkbookWorksheetRequest.
    /// </summary>
    public partial interface IWorkbookWorksheetRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookWorksheet using POST.
        /// </summary>
        /// <param name="workbookWorksheetToCreate">The WorkbookWorksheet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookWorksheet.</returns>
        System.Threading.Tasks.Task<WorkbookWorksheet> CreateAsync(WorkbookWorksheet workbookWorksheetToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified WorkbookWorksheet using POST and returns a <see cref="GraphResponse{WorkbookWorksheet}"/> object.
        /// </summary>
        /// <param name="workbookWorksheetToCreate">The WorkbookWorksheet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookWorksheet}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookWorksheet>> CreateResponseAsync(WorkbookWorksheet workbookWorksheetToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookWorksheet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified WorkbookWorksheet and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookWorksheet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookWorksheet.</returns>
        System.Threading.Tasks.Task<WorkbookWorksheet> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified WorkbookWorksheet and returns a <see cref="GraphResponse{WorkbookWorksheet}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookWorksheet}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookWorksheet>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookWorksheet using PATCH.
        /// </summary>
        /// <param name="workbookWorksheetToUpdate">The WorkbookWorksheet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookWorksheet.</returns>
        System.Threading.Tasks.Task<WorkbookWorksheet> UpdateAsync(WorkbookWorksheet workbookWorksheetToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookWorksheet using PATCH and returns a <see cref="GraphResponse{WorkbookWorksheet}"/> object.
        /// </summary>
        /// <param name="workbookWorksheetToUpdate">The WorkbookWorksheet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookWorksheet}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookWorksheet>> UpdateResponseAsync(WorkbookWorksheet workbookWorksheetToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookWorksheet using PUT.
        /// </summary>
        /// <param name="workbookWorksheetToUpdate">The WorkbookWorksheet object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookWorksheet> PutAsync(WorkbookWorksheet workbookWorksheetToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified WorkbookWorksheet using PUT and returns a <see cref="GraphResponse{WorkbookWorksheet}"/> object.
        /// </summary>
        /// <param name="workbookWorksheetToUpdate">The WorkbookWorksheet object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookWorksheet}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookWorksheet>> PutResponseAsync(WorkbookWorksheet workbookWorksheetToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookWorksheetRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookWorksheetRequest Expand(Expression<Func<WorkbookWorksheet, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookWorksheetRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookWorksheetRequest Select(Expression<Func<WorkbookWorksheet, object>> selectExpression);

    }
}
