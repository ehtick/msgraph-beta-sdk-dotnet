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
    /// The interface IPrivilegedAccessGroupEligibilitySchedulesCollectionRequestBuilder.
    /// </summary>
    public partial interface IPrivilegedAccessGroupEligibilitySchedulesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPrivilegedAccessGroupEligibilitySchedulesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPrivilegedAccessGroupEligibilitySchedulesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPrivilegedAccessGroupEligibilityScheduleRequestBuilder"/> for the specified PrivilegedAccessGroupEligibilitySchedule.
        /// </summary>
        /// <param name="id">The ID for the PrivilegedAccessGroupEligibilitySchedule.</param>
        /// <returns>The <see cref="IPrivilegedAccessGroupEligibilityScheduleRequestBuilder"/>.</returns>
        IPrivilegedAccessGroupEligibilityScheduleRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for PrivilegedAccessGroupEligibilityScheduleFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedAccessGroupEligibilityScheduleFilterByCurrentUserRequestBuilder"/>.</returns>
        IPrivilegedAccessGroupEligibilityScheduleFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            EligibilityScheduleFilterByCurrentUserOptions on);
    }
}
