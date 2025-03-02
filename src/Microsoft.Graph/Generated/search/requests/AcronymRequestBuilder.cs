// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph.Search
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type AcronymRequestBuilder.
    /// </summary>
    public partial class AcronymRequestBuilder : SearchAnswerRequestBuilder, IAcronymRequestBuilder
    {

        /// <summary>
        /// Constructs a new AcronymRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public AcronymRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IAcronymRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IAcronymRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new AcronymRequest(this.RequestUrl, this.Client, options);
        }
    
    }
}
