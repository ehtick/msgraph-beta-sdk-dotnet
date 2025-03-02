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
    /// The interface IReportRootDailyPrintUsageCollectionRequestBuilder.
    /// </summary>
    public partial interface IReportRootDailyPrintUsageCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IReportRootDailyPrintUsageCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IReportRootDailyPrintUsageCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPrintUsageRequestBuilder"/> for the specified PrintUsage.
        /// </summary>
        /// <param name="id">The ID for the PrintUsage.</param>
        /// <returns>The <see cref="IPrintUsageRequestBuilder"/>.</returns>
        IPrintUsageRequestBuilder this[string id] { get; }

        
    }
}
