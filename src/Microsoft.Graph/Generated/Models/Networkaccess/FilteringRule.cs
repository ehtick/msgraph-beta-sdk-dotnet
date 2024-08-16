// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess
{
    #pragma warning disable CS1591
    public class FilteringRule : Microsoft.Graph.Beta.Models.Networkaccess.PolicyRule, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Possible destinations and types of destinations accessed by the user in accordance with the network filtering policy, such as IP addresses and FQDNs/URLs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination>? Destinations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination>?>("destinations"); }
            set { BackingStore?.Set("destinations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination> Destinations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination>>("destinations"); }
            set { BackingStore?.Set("destinations", value); }
        }
#endif
        /// <summary>The ruleType property</summary>
        public Microsoft.Graph.Beta.Models.Networkaccess.NetworkDestinationType? RuleType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Networkaccess.NetworkDestinationType?>("ruleType"); }
            set { BackingStore?.Set("ruleType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Networkaccess.FilteringRule"/> and sets the default values.
        /// </summary>
        public FilteringRule() : base()
        {
            OdataType = "#microsoft.graph.networkaccess.filteringRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Networkaccess.FilteringRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Networkaccess.FilteringRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.networkaccess.fqdnFilteringRule" => new Microsoft.Graph.Beta.Models.Networkaccess.FqdnFilteringRule(),
                "#microsoft.graph.networkaccess.webCategoryFilteringRule" => new Microsoft.Graph.Beta.Models.Networkaccess.WebCategoryFilteringRule(),
                _ => new Microsoft.Graph.Beta.Models.Networkaccess.FilteringRule(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "destinations", n => { Destinations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination>(Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination.CreateFromDiscriminatorValue)?.ToList(); } },
                { "ruleType", n => { RuleType = n.GetEnumValue<Microsoft.Graph.Beta.Models.Networkaccess.NetworkDestinationType>(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Networkaccess.RuleDestination>("destinations", Destinations);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Networkaccess.NetworkDestinationType>("ruleType", RuleType);
        }
    }
}
