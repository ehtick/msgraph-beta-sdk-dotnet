using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CommsOperation : Entity, IParsable {
        /// <summary>Unique Client Context string. Max limit is 256 chars.</summary>
        public string ClientContext { get; set; }
        /// <summary>The result information. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ResultInfo ResultInfo { get; set; }
        /// <summary>Possible values are: notStarted, running, completed, failed. Read-only.</summary>
        public OperationStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CommsOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CommsOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"clientContext", (o,n) => { (o as CommsOperation).ClientContext = n.GetStringValue(); } },
                {"resultInfo", (o,n) => { (o as CommsOperation).ResultInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ResultInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.ResultInfo.CreateFromDiscriminatorValue); } },
                {"status", (o,n) => { (o as CommsOperation).Status = n.GetEnumValue<OperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteEnumValue<OperationStatus>("status", Status);
        }
    }
}
