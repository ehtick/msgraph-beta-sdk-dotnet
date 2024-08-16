// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class PlannerPlanConfigurationLocalization : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Localized names for configured buckets in the plan configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PlannerPlanConfigurationBucketLocalization>? Buckets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerPlanConfigurationBucketLocalization>?>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PlannerPlanConfigurationBucketLocalization> Buckets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlannerPlanConfigurationBucketLocalization>>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
#endif
        /// <summary>The language code associated with the localized names in this object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageTag
        {
            get { return BackingStore?.Get<string?>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#nullable restore
#else
        public string LanguageTag
        {
            get { return BackingStore?.Get<string>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
#endif
        /// <summary>Localized title of the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlanTitle
        {
            get { return BackingStore?.Get<string?>("planTitle"); }
            set { BackingStore?.Set("planTitle", value); }
        }
#nullable restore
#else
        public string PlanTitle
        {
            get { return BackingStore?.Get<string>("planTitle"); }
            set { BackingStore?.Set("planTitle", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.PlannerPlanConfigurationLocalization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.PlannerPlanConfigurationLocalization CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.PlannerPlanConfigurationLocalization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "buckets", n => { Buckets = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerPlanConfigurationBucketLocalization>(Microsoft.Graph.Beta.Models.PlannerPlanConfigurationBucketLocalization.CreateFromDiscriminatorValue)?.ToList(); } },
                { "languageTag", n => { LanguageTag = n.GetStringValue(); } },
                { "planTitle", n => { PlanTitle = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlannerPlanConfigurationBucketLocalization>("buckets", Buckets);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteStringValue("planTitle", PlanTitle);
        }
    }
}
