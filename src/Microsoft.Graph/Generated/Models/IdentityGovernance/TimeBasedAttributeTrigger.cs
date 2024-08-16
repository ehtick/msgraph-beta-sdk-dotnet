// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance
{
    #pragma warning disable CS1591
    public class TimeBasedAttributeTrigger : Microsoft.Graph.Beta.Models.IdentityGovernance.WorkflowExecutionTrigger, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>How many days before or after the time-based attribute specified the workflow should trigger. For example, if the attribute is employeeHireDate and offsetInDays is -1, then the workflow should trigger one day before the employee hire date. The value can range between -180 and 180 days.</summary>
        public int? OffsetInDays
        {
            get { return BackingStore?.Get<int?>("offsetInDays"); }
            set { BackingStore?.Set("offsetInDays", value); }
        }
        /// <summary>The timeBasedAttribute property</summary>
        public Microsoft.Graph.Beta.Models.IdentityGovernance.WorkflowTriggerTimeBasedAttribute? TimeBasedAttribute
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.WorkflowTriggerTimeBasedAttribute?>("timeBasedAttribute"); }
            set { BackingStore?.Set("timeBasedAttribute", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.IdentityGovernance.TimeBasedAttributeTrigger"/> and sets the default values.
        /// </summary>
        public TimeBasedAttributeTrigger() : base()
        {
            OdataType = "#microsoft.graph.identityGovernance.timeBasedAttributeTrigger";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.IdentityGovernance.TimeBasedAttributeTrigger"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.IdentityGovernance.TimeBasedAttributeTrigger CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.IdentityGovernance.TimeBasedAttributeTrigger();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "offsetInDays", n => { OffsetInDays = n.GetIntValue(); } },
                { "timeBasedAttribute", n => { TimeBasedAttribute = n.GetEnumValue<Microsoft.Graph.Beta.Models.IdentityGovernance.WorkflowTriggerTimeBasedAttribute>(); } },
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
            writer.WriteIntValue("offsetInDays", OffsetInDays);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.IdentityGovernance.WorkflowTriggerTimeBasedAttribute>("timeBasedAttribute", TimeBasedAttribute);
        }
    }
}
