// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class OnPremisesPublishingProfile : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of existing onPremisesAgentGroup objects. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.OnPremisesAgentGroup>? AgentGroups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OnPremisesAgentGroup>?>("agentGroups"); }
            set { BackingStore?.Set("agentGroups", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.OnPremisesAgentGroup> AgentGroups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OnPremisesAgentGroup>>("agentGroups"); }
            set { BackingStore?.Set("agentGroups", value); }
        }
#endif
        /// <summary>List of existing onPremisesAgent objects. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.OnPremisesAgent>? Agents
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OnPremisesAgent>?>("agents"); }
            set { BackingStore?.Set("agents", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.OnPremisesAgent> Agents
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OnPremisesAgent>>("agents"); }
            set { BackingStore?.Set("agents", value); }
        }
#endif
        /// <summary>The applicationSegments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IpApplicationSegment>? ApplicationSegments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IpApplicationSegment>?>("applicationSegments"); }
            set { BackingStore?.Set("applicationSegments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IpApplicationSegment> ApplicationSegments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IpApplicationSegment>>("applicationSegments"); }
            set { BackingStore?.Set("applicationSegments", value); }
        }
#endif
        /// <summary>List of existing connectorGroup objects for applications published through Application Proxy. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ConnectorGroup>? ConnectorGroups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ConnectorGroup>?>("connectorGroups"); }
            set { BackingStore?.Set("connectorGroups", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ConnectorGroup> ConnectorGroups
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ConnectorGroup>>("connectorGroups"); }
            set { BackingStore?.Set("connectorGroups", value); }
        }
#endif
        /// <summary>List of existing connector objects for applications published through Application Proxy. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Connector>? Connectors
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Connector>?>("connectors"); }
            set { BackingStore?.Set("connectors", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Connector> Connectors
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Connector>>("connectors"); }
            set { BackingStore?.Set("connectors", value); }
        }
#endif
        /// <summary>Represents a hybridAgentUpdaterConfiguration object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration? HybridAgentUpdaterConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration?>("hybridAgentUpdaterConfiguration"); }
            set { BackingStore?.Set("hybridAgentUpdaterConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration HybridAgentUpdaterConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration>("hybridAgentUpdaterConfiguration"); }
            set { BackingStore?.Set("hybridAgentUpdaterConfiguration", value); }
        }
#endif
        /// <summary>The isDefaultAccessEnabled property</summary>
        public bool? IsDefaultAccessEnabled
        {
            get { return BackingStore?.Get<bool?>("isDefaultAccessEnabled"); }
            set { BackingStore?.Set("isDefaultAccessEnabled", value); }
        }
        /// <summary>Represents if Microsoft Entra application proxy is enabled for the tenant.</summary>
        public bool? IsEnabled
        {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>List of existing publishedResource objects. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PublishedResource>? PublishedResources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PublishedResource>?>("publishedResources"); }
            set { BackingStore?.Set("publishedResources", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PublishedResource> PublishedResources
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PublishedResource>>("publishedResources"); }
            set { BackingStore?.Set("publishedResources", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.OnPremisesPublishingProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.OnPremisesPublishingProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.OnPremisesPublishingProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "agentGroups", n => { AgentGroups = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OnPremisesAgentGroup>(Microsoft.Graph.Beta.Models.OnPremisesAgentGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                { "agents", n => { Agents = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OnPremisesAgent>(Microsoft.Graph.Beta.Models.OnPremisesAgent.CreateFromDiscriminatorValue)?.ToList(); } },
                { "applicationSegments", n => { ApplicationSegments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IpApplicationSegment>(Microsoft.Graph.Beta.Models.IpApplicationSegment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "connectorGroups", n => { ConnectorGroups = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConnectorGroup>(Microsoft.Graph.Beta.Models.ConnectorGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                { "connectors", n => { Connectors = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Connector>(Microsoft.Graph.Beta.Models.Connector.CreateFromDiscriminatorValue)?.ToList(); } },
                { "hybridAgentUpdaterConfiguration", n => { HybridAgentUpdaterConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration>(Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration.CreateFromDiscriminatorValue); } },
                { "isDefaultAccessEnabled", n => { IsDefaultAccessEnabled = n.GetBoolValue(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "publishedResources", n => { PublishedResources = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PublishedResource>(Microsoft.Graph.Beta.Models.PublishedResource.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OnPremisesAgentGroup>("agentGroups", AgentGroups);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OnPremisesAgent>("agents", Agents);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IpApplicationSegment>("applicationSegments", ApplicationSegments);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConnectorGroup>("connectorGroups", ConnectorGroups);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Connector>("connectors", Connectors);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.HybridAgentUpdaterConfiguration>("hybridAgentUpdaterConfiguration", HybridAgentUpdaterConfiguration);
            writer.WriteBoolValue("isDefaultAccessEnabled", IsDefaultAccessEnabled);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PublishedResource>("publishedResources", PublishedResources);
        }
    }
}
