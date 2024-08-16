// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Constraint enforcing the permitted value range for an integer setting
    /// </summary>
    public class DeviceManagementSettingIntegerConstraint : Microsoft.Graph.Beta.Models.DeviceManagementConstraint, IParsable
    {
        /// <summary>The maximum permitted value</summary>
        public int? MaximumValue
        {
            get { return BackingStore?.Get<int?>("maximumValue"); }
            set { BackingStore?.Set("maximumValue", value); }
        }
        /// <summary>The minimum permitted value</summary>
        public int? MinimumValue
        {
            get { return BackingStore?.Get<int?>("minimumValue"); }
            set { BackingStore?.Set("minimumValue", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.DeviceManagementSettingIntegerConstraint"/> and sets the default values.
        /// </summary>
        public DeviceManagementSettingIntegerConstraint() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementSettingIntegerConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceManagementSettingIntegerConstraint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DeviceManagementSettingIntegerConstraint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.DeviceManagementSettingIntegerConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "maximumValue", n => { MaximumValue = n.GetIntValue(); } },
                { "minimumValue", n => { MinimumValue = n.GetIntValue(); } },
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
            writer.WriteIntValue("maximumValue", MaximumValue);
            writer.WriteIntValue("minimumValue", MinimumValue);
        }
    }
}
