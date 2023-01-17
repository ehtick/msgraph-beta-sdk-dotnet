// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IPrivilegedAccessGroupAssignmentScheduleInstanceRequestBuilder.
    /// </summary>
    public partial interface IPrivilegedAccessGroupAssignmentScheduleInstanceRequestBuilder : IPrivilegedAccessScheduleInstanceRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IPrivilegedAccessGroupAssignmentScheduleInstanceRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IPrivilegedAccessGroupAssignmentScheduleInstanceRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for ActivatedUsing.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedAccessGroupEligibilityScheduleInstanceWithReferenceRequestBuilder"/>.</returns>
        IPrivilegedAccessGroupEligibilityScheduleInstanceWithReferenceRequestBuilder ActivatedUsing { get; }

        /// <summary>
        /// Gets the request builder for Group.
        /// </summary>
        /// <returns>The <see cref="IGroupWithReferenceRequestBuilder"/>.</returns>
        IGroupWithReferenceRequestBuilder Group { get; }

        /// <summary>
        /// Gets the request builder for Principal.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectWithReferenceRequestBuilder"/>.</returns>
        IDirectoryObjectWithReferenceRequestBuilder Principal { get; }
    
        
    
    }
}
