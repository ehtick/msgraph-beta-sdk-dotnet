// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Graph model for a secret setting value
    /// </summary>
    public class DeviceManagementConfigurationSecretSettingValue : Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSimpleSettingValue, IParsable
    {
        /// <summary>Value of the secret setting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value
        {
            get { return BackingStore?.Get<string?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#nullable restore
#else
        public string Value
        {
            get { return BackingStore?.Get<string>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#endif
        /// <summary>type tracking the encryption state of a secret setting value</summary>
        public Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSecretSettingValueState? ValueState
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSecretSettingValueState?>("valueState"); }
            set { BackingStore?.Set("valueState", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSecretSettingValue"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationSecretSettingValue() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationSecretSettingValue";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSecretSettingValue"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSecretSettingValue CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSecretSettingValue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "value", n => { Value = n.GetStringValue(); } },
                { "valueState", n => { ValueState = n.GetEnumValue<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSecretSettingValueState>(); } },
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
            writer.WriteStringValue("value", Value);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSecretSettingValueState>("valueState", ValueState);
        }
    }
}
