using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Provides operations to manage the collection of activityStatistics entities.
    /// </summary>
    public class PlannerPlanConfigurationLocalization : Entity, IParsable {
        /// <summary>The buckets property</summary>
        public List<PlannerPlanConfigurationBucketLocalization> Buckets {
            get { return BackingStore?.Get<List<PlannerPlanConfigurationBucketLocalization>>("buckets"); }
            set { BackingStore?.Set("buckets", value); }
        }
        /// <summary>The languageTag property</summary>
        public string LanguageTag {
            get { return BackingStore?.Get<string>("languageTag"); }
            set { BackingStore?.Set("languageTag", value); }
        }
        /// <summary>The planTitle property</summary>
        public string PlanTitle {
            get { return BackingStore?.Get<string>("planTitle"); }
            set { BackingStore?.Set("planTitle", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlannerPlanConfigurationLocalization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerPlanConfigurationLocalization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"buckets", n => { Buckets = n.GetCollectionOfObjectValues<PlannerPlanConfigurationBucketLocalization>(PlannerPlanConfigurationBucketLocalization.CreateFromDiscriminatorValue)?.ToList(); } },
                {"languageTag", n => { LanguageTag = n.GetStringValue(); } },
                {"planTitle", n => { PlanTitle = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PlannerPlanConfigurationBucketLocalization>("buckets", Buckets);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteStringValue("planTitle", PlanTitle);
        }
    }
}
