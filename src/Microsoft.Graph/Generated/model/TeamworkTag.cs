// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Teamwork Tag.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamworkTag>))]
    public partial class TeamworkTag : Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// Tag description as it will appear to the user in Microsoft Teams.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Tag name as it will appear to the user in Microsoft Teams.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets member count.
        /// The number of users assigned to the tag.
        /// </summary>
        [JsonPropertyName("memberCount")]
        public Int32? MemberCount { get; set; }
    
        /// <summary>
        /// Gets or sets tag type.
        /// The type of tag. Default is standard.
        /// </summary>
        [JsonPropertyName("tagType")]
        public TeamworkTagType? TagType { get; set; }
    
        /// <summary>
        /// Gets or sets team id.
        /// ID of the team in which the tag is defined.
        /// </summary>
        [JsonPropertyName("teamId")]
        public string TeamId { get; set; }
    
        /// <summary>
        /// Gets or sets members.
        /// Users assigned to the tag.
        /// </summary>
        [JsonPropertyName("members")]
        public ITeamworkTagMembersCollectionPage Members { get; set; }

        /// <summary>
        /// Gets or sets membersNextLink.
        /// </summary>
        [JsonPropertyName("members@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MembersNextLink { get; set; }
    
    }
}

