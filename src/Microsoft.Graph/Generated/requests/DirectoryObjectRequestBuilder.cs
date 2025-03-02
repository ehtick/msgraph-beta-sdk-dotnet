// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DirectoryObjectRequestBuilder.
    /// </summary>
    public partial class DirectoryObjectRequestBuilder : EntityRequestBuilder, IDirectoryObjectRequestBuilder
    {

        /// <summary>
        /// Constructs a new DirectoryObjectRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DirectoryObjectRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IDirectoryObjectRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IDirectoryObjectRequest Request(IEnumerable<Option> options)
        {
            return new DirectoryObjectRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for DirectoryObjectRestore.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectRestoreRequestBuilder"/>.</returns>
        public IDirectoryObjectRestoreRequestBuilder Restore()
        {
            return new DirectoryObjectRestoreRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.restore"),
                this.Client);
        }

        /// <summary>
        /// Gets the request builder for DirectoryObjectCheckMemberGroups.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectCheckMemberGroupsRequestBuilder"/>.</returns>
        public IDirectoryObjectCheckMemberGroupsRequestBuilder CheckMemberGroups(
            IEnumerable<string> groupIds)
        {
            return new DirectoryObjectCheckMemberGroupsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.checkMemberGroups"),
                this.Client,
                groupIds);
        }

        /// <summary>
        /// Gets the request builder for DirectoryObjectCheckMemberObjects.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectCheckMemberObjectsRequestBuilder"/>.</returns>
        public IDirectoryObjectCheckMemberObjectsRequestBuilder CheckMemberObjects(
            IEnumerable<string> ids)
        {
            return new DirectoryObjectCheckMemberObjectsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.checkMemberObjects"),
                this.Client,
                ids);
        }

        /// <summary>
        /// Gets the request builder for DirectoryObjectGetMemberGroups.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectGetMemberGroupsRequestBuilder"/>.</returns>
        public IDirectoryObjectGetMemberGroupsRequestBuilder GetMemberGroups(
            bool? securityEnabledOnly = null)
        {
            return new DirectoryObjectGetMemberGroupsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getMemberGroups"),
                this.Client,
                securityEnabledOnly);
        }

        /// <summary>
        /// Gets the request builder for DirectoryObjectGetMemberObjects.
        /// </summary>
        /// <returns>The <see cref="IDirectoryObjectGetMemberObjectsRequestBuilder"/>.</returns>
        public IDirectoryObjectGetMemberObjectsRequestBuilder GetMemberObjects(
            bool? securityEnabledOnly = null)
        {
            return new DirectoryObjectGetMemberObjectsRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getMemberObjects"),
                this.Client,
                securityEnabledOnly);
        }
    
    }
}
