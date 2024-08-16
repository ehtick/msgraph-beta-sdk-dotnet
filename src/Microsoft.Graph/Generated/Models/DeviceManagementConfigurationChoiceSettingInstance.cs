// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Setting instance within policy
    /// </summary>
    public class DeviceManagementConfigurationChoiceSettingInstance : Microsoft.Graph.Beta.Models.DeviceManagementConfigurationSettingInstance, IParsable
    {
        /// <summary>The choiceSettingValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValue? ChoiceSettingValue
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValue?>("choiceSettingValue"); }
            set { BackingStore?.Set("choiceSettingValue", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValue ChoiceSettingValue
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValue>("choiceSettingValue"); }
            set { BackingStore?.Set("choiceSettingValue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingInstance"/> and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationChoiceSettingInstance() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementConfigurationChoiceSettingInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingInstance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingInstance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "choiceSettingValue", n => { ChoiceSettingValue = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValue>(Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValue.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementConfigurationChoiceSettingValue>("choiceSettingValue", ChoiceSettingValue);
        }
    }
}
