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
    /// The type Microsoft Tunnel Site.
    /// </summary>
    public partial class MicrosoftTunnelSite : Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// The site's description (optional)
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the site. This property is required when a site is created.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets internal network probe url.
        /// The site's Internal Network Access Probe URL
        /// </summary>
        [JsonPropertyName("internalNetworkProbeUrl")]
        public string InternalNetworkProbeUrl { get; set; }
    
        /// <summary>
        /// Gets or sets public address.
        /// The site's public domain name or IP address
        /// </summary>
        [JsonPropertyName("publicAddress")]
        public string PublicAddress { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets upgrade automatically.
        /// The site's automatic upgrade setting. True for automatic upgrades, false for manual control
        /// </summary>
        [JsonPropertyName("upgradeAutomatically")]
        public bool? UpgradeAutomatically { get; set; }
    
        /// <summary>
        /// Gets or sets upgrade available.
        /// The site provides the state of when an upgrade is available
        /// </summary>
        [JsonPropertyName("upgradeAvailable")]
        public bool? UpgradeAvailable { get; set; }
    
        /// <summary>
        /// Gets or sets upgrade window end time.
        /// The site's upgrade window end time of day
        /// </summary>
        [JsonPropertyName("upgradeWindowEndTime")]
        public TimeOfDay UpgradeWindowEndTime { get; set; }
    
        /// <summary>
        /// Gets or sets upgrade window start time.
        /// The site's upgrade window start time of day
        /// </summary>
        [JsonPropertyName("upgradeWindowStartTime")]
        public TimeOfDay UpgradeWindowStartTime { get; set; }
    
        /// <summary>
        /// Gets or sets upgrade window utc offset in minutes.
        /// The site's timezone represented as a minute offset from UTC
        /// </summary>
        [JsonPropertyName("upgradeWindowUtcOffsetInMinutes")]
        public Int32? UpgradeWindowUtcOffsetInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft tunnel configuration.
        /// The MicrosoftTunnelConfiguration that has been applied to this MicrosoftTunnelSite
        /// </summary>
        [JsonPropertyName("microsoftTunnelConfiguration")]
        public MicrosoftTunnelConfiguration MicrosoftTunnelConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft tunnel servers.
        /// A list of MicrosoftTunnelServers that are registered to this MicrosoftTunnelSite
        /// </summary>
        [JsonPropertyName("microsoftTunnelServers")]
        public IMicrosoftTunnelSiteMicrosoftTunnelServersCollectionPage MicrosoftTunnelServers { get; set; }

        /// <summary>
        /// Gets or sets microsoftTunnelServersNextLink.
        /// </summary>
        [JsonPropertyName("microsoftTunnelServers@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string MicrosoftTunnelServersNextLink { get; set; }
    
    }
}

