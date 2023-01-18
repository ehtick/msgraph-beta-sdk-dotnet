using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserAnalytics : Entity, IParsable {
        /// <summary>The collection of work activities that a user spent time on during and outside of working hours. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<Microsoft.Graph.Beta.Models.ActivityStatistics>? ActivityStatistics {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ActivityStatistics>?>("activityStatistics"); }
            set { BackingStore?.Set("activityStatistics", value); }
        }
#else
        public List<Microsoft.Graph.Beta.Models.ActivityStatistics> ActivityStatistics {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ActivityStatistics>>("activityStatistics"); }
            set { BackingStore?.Set("activityStatistics", value); }
        }
#endif
        /// <summary>The current settings for a user to use the analytics API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Beta.Models.Settings? Settings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Settings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#else
        public Microsoft.Graph.Beta.Models.Settings Settings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Settings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserAnalytics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserAnalytics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityStatistics", n => { ActivityStatistics = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ActivityStatistics>(Microsoft.Graph.Beta.Models.ActivityStatistics.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<Microsoft.Graph.Beta.Models.Settings>(Microsoft.Graph.Beta.Models.Settings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ActivityStatistics>("activityStatistics", ActivityStatistics);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Settings>("settings", Settings);
        }
    }
}
