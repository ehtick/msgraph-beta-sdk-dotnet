// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type ChatMarkChatReadForUserRequestBuilder.
    /// </summary>
    public partial class ChatMarkChatReadForUserRequestBuilder : BaseActionMethodRequestBuilder<IChatMarkChatReadForUserRequest>, IChatMarkChatReadForUserRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="ChatMarkChatReadForUserRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="user">A user parameter for the OData method call.</param>
        /// <param name="tenantId">A tenantId parameter for the OData method call.</param>
        public ChatMarkChatReadForUserRequestBuilder(
            string requestUrl,
            IBaseClient client,
            TeamworkUserIdentity user,
            string tenantId)
            : base(requestUrl, client)
        {
            this.SetParameter("user", user, true);
            this.SetParameter("tenantId", tenantId, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IChatMarkChatReadForUserRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new ChatMarkChatReadForUserRequest(functionUrl, this.Client, options);

            if (this.HasParameter("user"))
            {
                request.RequestBody.User = this.GetParameter<TeamworkUserIdentity>("user");
            }

            if (this.HasParameter("tenantId"))
            {
                request.RequestBody.TenantId = this.GetParameter<string>("tenantId");
            }

            return request;
        }
    }
}
