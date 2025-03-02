// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type InvitationParticipantInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<InvitationParticipantInfo>))]
    public partial class InvitationParticipantInfo
    {

        /// <summary>
        /// Gets or sets endpointType.
        /// The type of endpoint. Possible values are: default, voicemail, skypeForBusiness, skypeForBusinessVoipPhone and unknownFutureValue.
        /// </summary>
        [JsonPropertyName("endpointType")]
        public EndpointType? EndpointType { get; set; }
    
        /// <summary>
        /// Gets or sets hidden.
        /// Optional. Whether to hide the participant from the roster.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden { get; set; }
    
        /// <summary>
        /// Gets or sets identity.
        /// The identitySet associated with this invitation.
        /// </summary>
        [JsonPropertyName("identity")]
        public IdentitySet Identity { get; set; }
    
        /// <summary>
        /// Gets or sets participantId.
        /// Optional. The ID of the target participant.
        /// </summary>
        [JsonPropertyName("participantId")]
        public string ParticipantId { get; set; }
    
        /// <summary>
        /// Gets or sets removeFromDefaultAudioRoutingGroup.
        /// Optional. Whether to remove them from the main mixer.
        /// </summary>
        [JsonPropertyName("removeFromDefaultAudioRoutingGroup")]
        public bool? RemoveFromDefaultAudioRoutingGroup { get; set; }
    
        /// <summary>
        /// Gets or sets replacesCallId.
        /// Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.
        /// </summary>
        [JsonPropertyName("replacesCallId")]
        public string ReplacesCallId { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
