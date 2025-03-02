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
    /// The type WindowsFirewallNetworkProfile.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsFirewallNetworkProfile>))]
    public partial class WindowsFirewallNetworkProfile
    {

        /// <summary>
        /// Gets or sets authorizedApplicationRulesFromGroupPolicyMerged.
        /// Configures the firewall to merge authorized application rules from group policy with those from local store instead of ignoring the local store rules. When AuthorizedApplicationRulesFromGroupPolicyNotMerged and AuthorizedApplicationRulesFromGroupPolicyMerged are both true, AuthorizedApplicationRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonPropertyName("authorizedApplicationRulesFromGroupPolicyMerged")]
        public bool? AuthorizedApplicationRulesFromGroupPolicyMerged { get; set; }
    
        /// <summary>
        /// Gets or sets authorizedApplicationRulesFromGroupPolicyNotMerged.
        /// Configures the firewall to prevent merging authorized application rules from group policy with those from local store instead of ignoring the local store rules. When AuthorizedApplicationRulesFromGroupPolicyNotMerged and AuthorizedApplicationRulesFromGroupPolicyMerged are both true, AuthorizedApplicationRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonPropertyName("authorizedApplicationRulesFromGroupPolicyNotMerged")]
        public bool? AuthorizedApplicationRulesFromGroupPolicyNotMerged { get; set; }
    
        /// <summary>
        /// Gets or sets connectionSecurityRulesFromGroupPolicyMerged.
        /// Configures the firewall to merge connection security rules from group policy with those from local store instead of ignoring the local store rules. When ConnectionSecurityRulesFromGroupPolicyNotMerged and ConnectionSecurityRulesFromGroupPolicyMerged are both true, ConnectionSecurityRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonPropertyName("connectionSecurityRulesFromGroupPolicyMerged")]
        public bool? ConnectionSecurityRulesFromGroupPolicyMerged { get; set; }
    
        /// <summary>
        /// Gets or sets connectionSecurityRulesFromGroupPolicyNotMerged.
        /// Configures the firewall to prevent merging connection security rules from group policy with those from local store instead of ignoring the local store rules. When ConnectionSecurityRulesFromGroupPolicyNotMerged and ConnectionSecurityRulesFromGroupPolicyMerged are both true, ConnectionSecurityRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonPropertyName("connectionSecurityRulesFromGroupPolicyNotMerged")]
        public bool? ConnectionSecurityRulesFromGroupPolicyNotMerged { get; set; }
    
        /// <summary>
        /// Gets or sets firewallEnabled.
        /// Configures the host device to allow or block the firewall and advanced security enforcement for the network profile. Possible values are: notConfigured, blocked, allowed.
        /// </summary>
        [JsonPropertyName("firewallEnabled")]
        public StateManagementSetting? FirewallEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets globalPortRulesFromGroupPolicyMerged.
        /// Configures the firewall to merge global port rules from group policy with those from local store instead of ignoring the local store rules. When GlobalPortRulesFromGroupPolicyNotMerged and GlobalPortRulesFromGroupPolicyMerged are both true, GlobalPortRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonPropertyName("globalPortRulesFromGroupPolicyMerged")]
        public bool? GlobalPortRulesFromGroupPolicyMerged { get; set; }
    
        /// <summary>
        /// Gets or sets globalPortRulesFromGroupPolicyNotMerged.
        /// Configures the firewall to prevent merging global port rules from group policy with those from local store instead of ignoring the local store rules. When GlobalPortRulesFromGroupPolicyNotMerged and GlobalPortRulesFromGroupPolicyMerged are both true, GlobalPortRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonPropertyName("globalPortRulesFromGroupPolicyNotMerged")]
        public bool? GlobalPortRulesFromGroupPolicyNotMerged { get; set; }
    
        /// <summary>
        /// Gets or sets inboundConnectionsBlocked.
        /// Configures the firewall to block all incoming connections by default. When InboundConnectionsRequired and InboundConnectionsBlocked are both true, InboundConnectionsBlocked takes priority.
        /// </summary>
        [JsonPropertyName("inboundConnectionsBlocked")]
        public bool? InboundConnectionsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets inboundConnectionsRequired.
        /// Configures the firewall to allow all incoming connections by default. When InboundConnectionsRequired and InboundConnectionsBlocked are both true, InboundConnectionsBlocked takes priority.
        /// </summary>
        [JsonPropertyName("inboundConnectionsRequired")]
        public bool? InboundConnectionsRequired { get; set; }
    
        /// <summary>
        /// Gets or sets inboundNotificationsBlocked.
        /// Prevents the firewall from displaying notifications when an application is blocked from listening on a port. When InboundNotificationsRequired and InboundNotificationsBlocked are both true, InboundNotificationsBlocked takes priority.
        /// </summary>
        [JsonPropertyName("inboundNotificationsBlocked")]
        public bool? InboundNotificationsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets inboundNotificationsRequired.
        /// Allows the firewall to display notifications when an application is blocked from listening on a port. When InboundNotificationsRequired and InboundNotificationsBlocked are both true, InboundNotificationsBlocked takes priority.
        /// </summary>
        [JsonPropertyName("inboundNotificationsRequired")]
        public bool? InboundNotificationsRequired { get; set; }
    
        /// <summary>
        /// Gets or sets incomingTrafficBlocked.
        /// Configures the firewall to block all incoming traffic regardless of other policy settings. When IncomingTrafficRequired and IncomingTrafficBlocked are both true, IncomingTrafficBlocked takes priority.
        /// </summary>
        [JsonPropertyName("incomingTrafficBlocked")]
        public bool? IncomingTrafficBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets incomingTrafficRequired.
        /// Configures the firewall to allow incoming traffic pursuant to other policy settings. When IncomingTrafficRequired and IncomingTrafficBlocked are both true, IncomingTrafficBlocked takes priority.
        /// </summary>
        [JsonPropertyName("incomingTrafficRequired")]
        public bool? IncomingTrafficRequired { get; set; }
    
        /// <summary>
        /// Gets or sets outboundConnectionsBlocked.
        /// Configures the firewall to block all outgoing connections by default. When OutboundConnectionsRequired and OutboundConnectionsBlocked are both true, OutboundConnectionsBlocked takes priority. This setting will get applied to Windows releases version 1809 and above.
        /// </summary>
        [JsonPropertyName("outboundConnectionsBlocked")]
        public bool? OutboundConnectionsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets outboundConnectionsRequired.
        /// Configures the firewall to allow all outgoing connections by default. When OutboundConnectionsRequired and OutboundConnectionsBlocked are both true, OutboundConnectionsBlocked takes priority. This setting will get applied to Windows releases version 1809 and above.
        /// </summary>
        [JsonPropertyName("outboundConnectionsRequired")]
        public bool? OutboundConnectionsRequired { get; set; }
    
        /// <summary>
        /// Gets or sets policyRulesFromGroupPolicyMerged.
        /// Configures the firewall to merge Firewall Rule policies from group policy with those from local store instead of ignoring the local store rules. When PolicyRulesFromGroupPolicyNotMerged and PolicyRulesFromGroupPolicyMerged are both true, PolicyRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonPropertyName("policyRulesFromGroupPolicyMerged")]
        public bool? PolicyRulesFromGroupPolicyMerged { get; set; }
    
        /// <summary>
        /// Gets or sets policyRulesFromGroupPolicyNotMerged.
        /// Configures the firewall to prevent merging Firewall Rule policies from group policy with those from local store instead of ignoring the local store rules. When PolicyRulesFromGroupPolicyNotMerged and PolicyRulesFromGroupPolicyMerged are both true, PolicyRulesFromGroupPolicyMerged takes priority.
        /// </summary>
        [JsonPropertyName("policyRulesFromGroupPolicyNotMerged")]
        public bool? PolicyRulesFromGroupPolicyNotMerged { get; set; }
    
        /// <summary>
        /// Gets or sets securedPacketExemptionAllowed.
        /// Configures the firewall to allow the host computer to respond to unsolicited network traffic of that traffic is secured by IPSec even when stealthModeBlocked is set to true. When SecuredPacketExemptionBlocked and SecuredPacketExemptionAllowed are both true, SecuredPacketExemptionAllowed takes priority.
        /// </summary>
        [JsonPropertyName("securedPacketExemptionAllowed")]
        public bool? SecuredPacketExemptionAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets securedPacketExemptionBlocked.
        /// Configures the firewall to block the host computer to respond to unsolicited network traffic of that traffic is secured by IPSec even when stealthModeBlocked is set to true. When SecuredPacketExemptionBlocked and SecuredPacketExemptionAllowed are both true, SecuredPacketExemptionAllowed takes priority.
        /// </summary>
        [JsonPropertyName("securedPacketExemptionBlocked")]
        public bool? SecuredPacketExemptionBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets stealthModeBlocked.
        /// Prevent the server from operating in stealth mode. When StealthModeRequired and StealthModeBlocked are both true, StealthModeBlocked takes priority.
        /// </summary>
        [JsonPropertyName("stealthModeBlocked")]
        public bool? StealthModeBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets stealthModeRequired.
        /// Allow the server to operate in stealth mode. When StealthModeRequired and StealthModeBlocked are both true, StealthModeBlocked takes priority.
        /// </summary>
        [JsonPropertyName("stealthModeRequired")]
        public bool? StealthModeRequired { get; set; }
    
        /// <summary>
        /// Gets or sets unicastResponsesToMulticastBroadcastsBlocked.
        /// Configures the firewall to block unicast responses to multicast broadcast traffic. When UnicastResponsesToMulticastBroadcastsRequired and UnicastResponsesToMulticastBroadcastsBlocked are both true, UnicastResponsesToMulticastBroadcastsBlocked takes priority.
        /// </summary>
        [JsonPropertyName("unicastResponsesToMulticastBroadcastsBlocked")]
        public bool? UnicastResponsesToMulticastBroadcastsBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets unicastResponsesToMulticastBroadcastsRequired.
        /// Configures the firewall to allow unicast responses to multicast broadcast traffic. When UnicastResponsesToMulticastBroadcastsRequired and UnicastResponsesToMulticastBroadcastsBlocked are both true, UnicastResponsesToMulticastBroadcastsBlocked takes priority.
        /// </summary>
        [JsonPropertyName("unicastResponsesToMulticastBroadcastsRequired")]
        public bool? UnicastResponsesToMulticastBroadcastsRequired { get; set; }
    
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
