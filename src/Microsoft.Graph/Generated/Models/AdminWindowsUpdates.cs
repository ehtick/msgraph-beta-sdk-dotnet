// <auto-generated/>
using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AdminWindowsUpdates : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Catalog of content that can be approved for deployment by the deployment service. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog? Catalog
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog?>("catalog"); }
            set { BackingStore?.Set("catalog", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog Catalog
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog>("catalog"); }
            set { BackingStore?.Set("catalog", value); }
        }
#endif
        /// <summary>The set of updatableAsset resources to which a deployment can apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience>? DeploymentAudiences
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience>?>("deploymentAudiences"); }
            set { BackingStore?.Set("deploymentAudiences", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience> DeploymentAudiences
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience>>("deploymentAudiences"); }
            set { BackingStore?.Set("deploymentAudiences", value); }
        }
#endif
        /// <summary>Deployments created using the deployment service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment>? Deployments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment>?>("deployments"); }
            set { BackingStore?.Set("deployments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment> Deployments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment>>("deployments"); }
            set { BackingStore?.Set("deployments", value); }
        }
#endif
        /// <summary>A collection of Windows products.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.Product>? Products
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.Product>?>("products"); }
            set { BackingStore?.Set("products", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.Product> Products
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.Product>>("products"); }
            set { BackingStore?.Set("products", value); }
        }
#endif
        /// <summary>Service connections to external resources such as analytics workspaces.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.ResourceConnection>? ResourceConnections
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.ResourceConnection>?>("resourceConnections"); }
            set { BackingStore?.Set("resourceConnections", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.ResourceConnection> ResourceConnections
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.ResourceConnection>>("resourceConnections"); }
            set { BackingStore?.Set("resourceConnections", value); }
        }
#endif
        /// <summary>Assets registered with the deployment service that can receive updates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>? UpdatableAssets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>?>("updatableAssets"); }
            set { BackingStore?.Set("updatableAssets", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset> UpdatableAssets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>>("updatableAssets"); }
            set { BackingStore?.Set("updatableAssets", value); }
        }
#endif
        /// <summary>A collection of policies for approving the deployment of different content to an audience over time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>? UpdatePolicies
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>?>("updatePolicies"); }
            set { BackingStore?.Set("updatePolicies", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy> UpdatePolicies
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>>("updatePolicies"); }
            set { BackingStore?.Set("updatePolicies", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AdminWindowsUpdates"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AdminWindowsUpdates CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AdminWindowsUpdates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "catalog", n => { Catalog = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog>(Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog.CreateFromDiscriminatorValue); } },
                { "deploymentAudiences", n => { DeploymentAudiences = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience>(Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience.CreateFromDiscriminatorValue)?.ToList(); } },
                { "deployments", n => { Deployments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment>(Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "products", n => { Products = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.Product>(Microsoft.Graph.Beta.Models.WindowsUpdates.Product.CreateFromDiscriminatorValue)?.ToList(); } },
                { "resourceConnections", n => { ResourceConnections = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.ResourceConnection>(Microsoft.Graph.Beta.Models.WindowsUpdates.ResourceConnection.CreateFromDiscriminatorValue)?.ToList(); } },
                { "updatableAssets", n => { UpdatableAssets = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>(Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset.CreateFromDiscriminatorValue)?.ToList(); } },
                { "updatePolicies", n => { UpdatePolicies = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>(Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsUpdates.Catalog>("catalog", Catalog);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.DeploymentAudience>("deploymentAudiences", DeploymentAudiences);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.Deployment>("deployments", Deployments);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.Product>("products", Products);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.ResourceConnection>("resourceConnections", ResourceConnections);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset>("updatableAssets", UpdatableAssets);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatePolicy>("updatePolicies", UpdatePolicies);
        }
    }
}
