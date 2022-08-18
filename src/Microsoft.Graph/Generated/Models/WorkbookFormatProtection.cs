using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WorkbookFormatProtection : Entity, IParsable {
        /// <summary>The formulaHidden property</summary>
        public bool? FormulaHidden {
            get { return BackingStore?.Get<bool?>("formulaHidden"); }
            set { BackingStore?.Set("formulaHidden", value); }
        }
        /// <summary>The locked property</summary>
        public bool? Locked {
            get { return BackingStore?.Get<bool?>("locked"); }
            set { BackingStore?.Set("locked", value); }
        }
        /// <summary>
        /// Instantiates a new WorkbookFormatProtection and sets the default values.
        /// </summary>
        public WorkbookFormatProtection() : base() {
            OdataType = "#microsoft.graph.workbookFormatProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkbookFormatProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookFormatProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"formulaHidden", n => { FormulaHidden = n.GetBoolValue(); } },
                {"locked", n => { Locked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("formulaHidden", FormulaHidden);
            writer.WriteBoolValue("locked", Locked);
        }
    }
}
