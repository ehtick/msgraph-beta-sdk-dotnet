// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class PermissionsAnalytics : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The output of the permissions usage data analysis performed by Permissions Management to assess risk with identities and resources.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Finding>? Findings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Finding>?>("findings"); }
            set { BackingStore?.Set("findings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Finding> Findings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Finding>>("findings"); }
            set { BackingStore?.Set("findings", value); }
        }
#endif
        /// <summary>Represents the Permissions Creep Index (PCI) for the authorization system. PCI distribution chart shows the classification of human and nonhuman identities based on the PCI score in three buckets (low, medium, high).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PermissionsCreepIndexDistribution>? PermissionsCreepIndexDistributions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PermissionsCreepIndexDistribution>?>("permissionsCreepIndexDistributions"); }
            set { BackingStore?.Set("permissionsCreepIndexDistributions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PermissionsCreepIndexDistribution> PermissionsCreepIndexDistributions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PermissionsCreepIndexDistribution>>("permissionsCreepIndexDistributions"); }
            set { BackingStore?.Set("permissionsCreepIndexDistributions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.PermissionsAnalytics"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.PermissionsAnalytics CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.PermissionsAnalytics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "findings", n => { Findings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Finding>(Microsoft.Graph.Beta.Models.Finding.CreateFromDiscriminatorValue)?.ToList(); } },
                { "permissionsCreepIndexDistributions", n => { PermissionsCreepIndexDistributions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PermissionsCreepIndexDistribution>(Microsoft.Graph.Beta.Models.PermissionsCreepIndexDistribution.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Finding>("findings", Findings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PermissionsCreepIndexDistribution>("permissionsCreepIndexDistributions", PermissionsCreepIndexDistributions);
        }
    }
}
