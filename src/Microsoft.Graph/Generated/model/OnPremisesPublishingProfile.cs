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
    /// The type On Premises Publishing Profile.
    /// </summary>
    public partial class OnPremisesPublishingProfile : Entity
    {
    
        /// <summary>
        /// Gets or sets hybrid agent updater configuration.
        /// Represents a hybridAgentUpdaterConfiguration object.
        /// </summary>
        [JsonPropertyName("hybridAgentUpdaterConfiguration")]
        public HybridAgentUpdaterConfiguration HybridAgentUpdaterConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets is default access enabled.
        /// </summary>
        [JsonPropertyName("isDefaultAccessEnabled")]
        public bool? IsDefaultAccessEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// Represents if Azure AD Application Proxy is enabled for the tenant.
        /// </summary>
        [JsonPropertyName("isEnabled")]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets agent groups.
        /// List of existing onPremisesAgentGroup objects. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("agentGroups")]
        public IOnPremisesPublishingProfileAgentGroupsCollectionPage AgentGroups { get; set; }

        /// <summary>
        /// Gets or sets agentGroupsNextLink.
        /// </summary>
        [JsonPropertyName("agentGroups@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AgentGroupsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets agents.
        /// List of existing onPremisesAgent objects. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("agents")]
        public IOnPremisesPublishingProfileAgentsCollectionPage Agents { get; set; }

        /// <summary>
        /// Gets or sets agentsNextLink.
        /// </summary>
        [JsonPropertyName("agents@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AgentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets connector groups.
        /// List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("connectorGroups")]
        public IOnPremisesPublishingProfileConnectorGroupsCollectionPage ConnectorGroups { get; set; }

        /// <summary>
        /// Gets or sets connectorGroupsNextLink.
        /// </summary>
        [JsonPropertyName("connectorGroups@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ConnectorGroupsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets connectors.
        /// List of existing connector objects for applications published through Application Proxy. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("connectors")]
        public IOnPremisesPublishingProfileConnectorsCollectionPage Connectors { get; set; }

        /// <summary>
        /// Gets or sets connectorsNextLink.
        /// </summary>
        [JsonPropertyName("connectors@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ConnectorsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets published resources.
        /// List of existing publishedResource objects. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("publishedResources")]
        public IOnPremisesPublishingProfilePublishedResourcesCollectionPage PublishedResources { get; set; }

        /// <summary>
        /// Gets or sets publishedResourcesNextLink.
        /// </summary>
        [JsonPropertyName("publishedResources@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string PublishedResourcesNextLink { get; set; }
    
    }
}

