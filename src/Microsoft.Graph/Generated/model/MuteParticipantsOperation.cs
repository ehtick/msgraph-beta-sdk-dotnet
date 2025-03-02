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
    /// The type Mute Participants Operation.
    /// </summary>
    public partial class MuteParticipantsOperation : CommsOperation
    {
    
        ///<summary>
        /// The MuteParticipantsOperation constructor
        ///</summary>
        public MuteParticipantsOperation()
        {
            this.ODataType = "microsoft.graph.muteParticipantsOperation";
        }

        /// <summary>
        /// Gets or sets participants.
        /// </summary>
        [JsonPropertyName("participants")]
        public IEnumerable<string> Participants { get; set; }
    
    }
}

