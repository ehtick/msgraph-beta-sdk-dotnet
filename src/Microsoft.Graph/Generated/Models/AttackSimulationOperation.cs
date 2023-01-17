using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AttackSimulationOperation : LongRunningOperation, IParsable {
        /// <summary>The percentageCompleted property</summary>
        public int? PercentageCompleted {
            get { return BackingStore?.Get<int?>("percentageCompleted"); }
            set { BackingStore?.Set("percentageCompleted", value); }
        }
        /// <summary>The tenantId property</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>The type property</summary>
        public AttackSimulationOperationType? Type {
            get { return BackingStore?.Get<AttackSimulationOperationType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AttackSimulationOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"percentageCompleted", n => { PercentageCompleted = n.GetIntValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<AttackSimulationOperationType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("percentageCompleted", PercentageCompleted);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteEnumValue<AttackSimulationOperationType>("type", Type);
        }
    }
}
