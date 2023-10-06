// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class MicrosoftCustomTrainingSetting : TrainingSetting, IParsable {
        /// <summary>The completion date and time of the training. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completionDateTime"); }
            set { BackingStore?.Set("completionDateTime", value); }
        }
        /// <summary>The mapping details of the associated training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MicrosoftTrainingAssignmentMapping>? TrainingAssignmentMappings {
            get { return BackingStore?.Get<List<MicrosoftTrainingAssignmentMapping>?>("trainingAssignmentMappings"); }
            set { BackingStore?.Set("trainingAssignmentMappings", value); }
        }
#nullable restore
#else
        public List<MicrosoftTrainingAssignmentMapping> TrainingAssignmentMappings {
            get { return BackingStore?.Get<List<MicrosoftTrainingAssignmentMapping>>("trainingAssignmentMappings"); }
            set { BackingStore?.Set("trainingAssignmentMappings", value); }
        }
#endif
        /// <summary>The training completion duration that needs to be provided before scheduling the training. Possible values are: week, fortnite, month, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.TrainingCompletionDuration? TrainingCompletionDuration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TrainingCompletionDuration?>("trainingCompletionDuration"); }
            set { BackingStore?.Set("trainingCompletionDuration", value); }
        }
        /// <summary>
        /// Instantiates a new microsoftCustomTrainingSetting and sets the default values.
        /// </summary>
        public MicrosoftCustomTrainingSetting() : base() {
            OdataType = "#microsoft.graph.microsoftCustomTrainingSetting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftCustomTrainingSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftCustomTrainingSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"trainingAssignmentMappings", n => { TrainingAssignmentMappings = n.GetCollectionOfObjectValues<MicrosoftTrainingAssignmentMapping>(MicrosoftTrainingAssignmentMapping.CreateFromDiscriminatorValue)?.ToList(); } },
                {"trainingCompletionDuration", n => { TrainingCompletionDuration = n.GetEnumValue<TrainingCompletionDuration>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteCollectionOfObjectValues<MicrosoftTrainingAssignmentMapping>("trainingAssignmentMappings", TrainingAssignmentMappings);
            writer.WriteEnumValue<TrainingCompletionDuration>("trainingCompletionDuration", TrainingCompletionDuration);
        }
    }
}
