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
    /// The interface IPrivilegedAccessGroupAssignmentSchedulesCollectionRequestBuilder.
    /// </summary>
    public partial interface IPrivilegedAccessGroupAssignmentSchedulesCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IPrivilegedAccessGroupAssignmentSchedulesCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IPrivilegedAccessGroupAssignmentSchedulesCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPrivilegedAccessGroupAssignmentScheduleRequestBuilder"/> for the specified PrivilegedAccessGroupAssignmentSchedule.
        /// </summary>
        /// <param name="id">The ID for the PrivilegedAccessGroupAssignmentSchedule.</param>
        /// <returns>The <see cref="IPrivilegedAccessGroupAssignmentScheduleRequestBuilder"/>.</returns>
        IPrivilegedAccessGroupAssignmentScheduleRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for PrivilegedAccessGroupAssignmentScheduleFilterByCurrentUser.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedAccessGroupAssignmentScheduleFilterByCurrentUserRequestBuilder"/>.</returns>
        IPrivilegedAccessGroupAssignmentScheduleFilterByCurrentUserRequestBuilder FilterByCurrentUser(
            AssignmentScheduleFilterByCurrentUserOptions on);
    }
}
