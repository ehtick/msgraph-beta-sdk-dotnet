// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Entity representing a setting category
    /// </summary>
    public class DeviceManagementSettingCategory : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The category name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The category contains top level required setting</summary>
        public bool? HasRequiredSetting
        {
            get { return BackingStore?.Get<bool?>("hasRequiredSetting"); }
            set { BackingStore?.Set("hasRequiredSetting", value); }
        }
        /// <summary>The setting definitions this category contains</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition>? SettingDefinitions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition>?>("settingDefinitions"); }
            set { BackingStore?.Set("settingDefinitions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition> SettingDefinitions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition>>("settingDefinitions"); }
            set { BackingStore?.Set("settingDefinitions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceManagementSettingCategory"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DeviceManagementSettingCategory CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.deviceManagementIntentSettingCategory" => new Microsoft.Graph.Beta.Models.DeviceManagementIntentSettingCategory(),
                "#microsoft.graph.deviceManagementTemplateSettingCategory" => new Microsoft.Graph.Beta.Models.DeviceManagementTemplateSettingCategory(),
                _ => new Microsoft.Graph.Beta.Models.DeviceManagementSettingCategory(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "hasRequiredSetting", n => { HasRequiredSetting = n.GetBoolValue(); } },
                { "settingDefinitions", n => { SettingDefinitions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition>(Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("hasRequiredSetting", HasRequiredSetting);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementSettingDefinition>("settingDefinitions", SettingDefinitions);
        }
    }
}
