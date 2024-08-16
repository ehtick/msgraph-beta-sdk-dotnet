// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// A class containing the properties used for Payload Compatible Assignment Filter.
    /// </summary>
    public class PayloadCompatibleAssignmentFilter : Microsoft.Graph.Beta.Models.DeviceAndAppManagementAssignmentFilter, IParsable
    {
        /// <summary>Represents the payload type AssignmentFilter is being assigned to.</summary>
        public Microsoft.Graph.Beta.Models.AssignmentFilterPayloadType? PayloadType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AssignmentFilterPayloadType?>("payloadType"); }
            set { BackingStore?.Set("payloadType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.PayloadCompatibleAssignmentFilter"/> and sets the default values.
        /// </summary>
        public PayloadCompatibleAssignmentFilter() : base()
        {
            OdataType = "#microsoft.graph.payloadCompatibleAssignmentFilter";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.PayloadCompatibleAssignmentFilter"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.PayloadCompatibleAssignmentFilter CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.PayloadCompatibleAssignmentFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "payloadType", n => { PayloadType = n.GetEnumValue<Microsoft.Graph.Beta.Models.AssignmentFilterPayloadType>(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.AssignmentFilterPayloadType>("payloadType", PayloadType);
        }
    }
}
