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
    /// The interface IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionRequest.
    /// </summary>
    public partial interface IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified WindowsUpdateState to the collection via POST.
        /// </summary>
        /// <param name="windowsUpdateState">The WindowsUpdateState to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsUpdateState.</returns>
        System.Threading.Tasks.Task<WindowsUpdateState> AddAsync(WindowsUpdateState windowsUpdateState, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified WindowsUpdateState to the collection via POST and returns a <see cref="GraphResponse{WindowsUpdateState}"/> object of the request.
        /// </summary>
        /// <param name="windowsUpdateState">The WindowsUpdateState to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsUpdateState}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsUpdateState>> AddResponseAsync(WindowsUpdateState windowsUpdateState, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{WindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<WindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionRequest Expand(Expression<Func<WindowsUpdateState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionRequest Select(Expression<Func<WindowsUpdateState, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionRequest OrderBy(string value);
    }
}
