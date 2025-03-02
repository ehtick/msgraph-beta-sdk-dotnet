// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type GraphServiceTeamTemplateDefinitionCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceTeamTemplateDefinitionCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceTeamTemplateDefinitionCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceTeamTemplateDefinitionCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceTeamTemplateDefinitionCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceTeamTemplateDefinitionCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceTeamTemplateDefinitionCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceTeamTemplateDefinitionCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITeamTemplateDefinitionRequestBuilder"/> for the specified GraphServiceTeamTemplateDefinition.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceTeamTemplateDefinition.</param>
        /// <returns>The <see cref="ITeamTemplateDefinitionRequestBuilder"/>.</returns>
        public ITeamTemplateDefinitionRequestBuilder this[string id]
        {
            get
            {
                return new TeamTemplateDefinitionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
