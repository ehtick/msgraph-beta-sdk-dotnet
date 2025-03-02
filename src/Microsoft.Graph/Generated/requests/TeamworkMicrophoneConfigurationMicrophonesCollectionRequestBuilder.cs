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
    /// The type TeamworkMicrophoneConfigurationMicrophonesCollectionRequestBuilder.
    /// </summary>
    public partial class TeamworkMicrophoneConfigurationMicrophonesCollectionRequestBuilder : BaseRequestBuilder, ITeamworkMicrophoneConfigurationMicrophonesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new TeamworkMicrophoneConfigurationMicrophonesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TeamworkMicrophoneConfigurationMicrophonesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ITeamworkMicrophoneConfigurationMicrophonesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ITeamworkMicrophoneConfigurationMicrophonesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new TeamworkMicrophoneConfigurationMicrophonesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITeamworkPeripheralRequestBuilder"/> for the specified TeamworkMicrophoneConfigurationTeamworkPeripheral.
        /// </summary>
        /// <param name="id">The ID for the TeamworkMicrophoneConfigurationTeamworkPeripheral.</param>
        /// <returns>The <see cref="ITeamworkPeripheralRequestBuilder"/>.</returns>
        public ITeamworkPeripheralRequestBuilder this[string id]
        {
            get
            {
                return new TeamworkPeripheralRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
