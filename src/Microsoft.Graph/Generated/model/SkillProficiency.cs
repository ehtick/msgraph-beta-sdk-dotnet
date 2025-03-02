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
    /// The type Skill Proficiency.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SkillProficiency>))]
    public partial class SkillProficiency : ItemFacet
    {
    
        ///<summary>
        /// The SkillProficiency constructor
        ///</summary>
        public SkillProficiency()
        {
            this.ODataType = "microsoft.graph.skillProficiency";
        }

        /// <summary>
        /// Gets or sets categories.
        /// Contains categories a user has associated with the skill (for example, personal, professional, hobby).
        /// </summary>
        [JsonPropertyName("categories")]
        public IEnumerable<string> Categories { get; set; }
    
        /// <summary>
        /// Gets or sets collaboration tags.
        /// Contains experience scenario tags a user has associated with the interest. Allowed values in the collection are: askMeAbout, ableToMentor, wantsToLearn, wantsToImprove.
        /// </summary>
        [JsonPropertyName("collaborationTags")]
        public IEnumerable<string> CollaborationTags { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Contains a friendly name for the skill.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets proficiency.
        /// Detail of the users proficiency with this skill. Possible values are: elementary, limitedWorking, generalProfessional, advancedProfessional, expert, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("proficiency")]
        public SkillProficiencyLevel? Proficiency { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnail url.
        /// </summary>
        [JsonPropertyName("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// Contains a link to an information source about the skill.
        /// </summary>
        [JsonPropertyName("webUrl")]
        public string WebUrl { get; set; }
    
    }
}

