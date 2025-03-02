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
    /// The type Apple Vpp Token Troubleshooting Event.
    /// </summary>
    public partial class AppleVppTokenTroubleshootingEvent : DeviceManagementTroubleshootingEvent
    {
    
        ///<summary>
        /// The AppleVppTokenTroubleshootingEvent constructor
        ///</summary>
        public AppleVppTokenTroubleshootingEvent()
        {
            this.ODataType = "microsoft.graph.appleVppTokenTroubleshootingEvent";
        }

        /// <summary>
        /// Gets or sets token id.
        /// Apple Volume Purchase Program Token Identifier.
        /// </summary>
        [JsonPropertyName("tokenId")]
        public string TokenId { get; set; }
    
    }
}

