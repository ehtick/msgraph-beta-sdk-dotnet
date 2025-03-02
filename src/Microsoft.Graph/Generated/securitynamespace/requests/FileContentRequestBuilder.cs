// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: StreamRequestBuilder.cs.tt

namespace Microsoft.Graph.SecurityNamespace
{
    using System.Collections.Generic;

    /// <summary>
    /// The type FileContentRequestBuilder.
    /// </summary>
    public partial class FileContentRequestBuilder : Microsoft.Graph.BaseRequestBuilder, IFileContentRequestBuilder
    {
        /// <summary>
        /// Constructs a new FileContentRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public FileContentRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IFileContentRequest Request(IEnumerable<Microsoft.Graph.Option> options = null)
        {
            return new FileContentRequest(this.RequestUrl, this.Client, options);
        }
    }
}
