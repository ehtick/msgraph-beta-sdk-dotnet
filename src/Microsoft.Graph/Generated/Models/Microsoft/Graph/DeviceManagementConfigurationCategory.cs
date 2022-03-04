using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagementConfigurationCategory : Entity, IParsable {
        /// <summary>Description of the category header</summary>
        public string CategoryDescription { get; set; }
        /// <summary>List of child ids of the category.</summary>
        public List<string> ChildCategoryIds { get; set; }
        /// <summary>Description of the item</summary>
        public string Description { get; set; }
        /// <summary>Display name of the item</summary>
        public string DisplayName { get; set; }
        /// <summary>Help text of the item</summary>
        public string HelpText { get; set; }
        /// <summary>Name of the item</summary>
        public string Name { get; set; }
        /// <summary>Parent id of the category.</summary>
        public string ParentCategoryId { get; set; }
        /// <summary>Platforms types, which settings in the category have. Possible values are: none, android, iOS, macOS, windows10X, windows10, linux, unknownFutureValue.</summary>
        public DeviceManagementConfigurationPlatforms? Platforms { get; set; }
        /// <summary>Root id of the category.</summary>
        public string RootCategoryId { get; set; }
        /// <summary>Indicates that the category contains settings that are used for Compliance or Configuration. Possible values are: none, configuration, compliance.</summary>
        public DeviceManagementConfigurationSettingUsage? SettingUsage { get; set; }
        /// <summary>Technologies types, which settings in the category have. Possible values are: none, mdm, windows10XManagement, configManager, microsoftSense, exchangeOnline, linuxMdm, unknownFutureValue.</summary>
        public DeviceManagementConfigurationTechnologies? Technologies { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementConfigurationCategory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationCategory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"categoryDescription", (o,n) => { (o as DeviceManagementConfigurationCategory).CategoryDescription = n.GetStringValue(); } },
                {"childCategoryIds", (o,n) => { (o as DeviceManagementConfigurationCategory).ChildCategoryIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"description", (o,n) => { (o as DeviceManagementConfigurationCategory).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as DeviceManagementConfigurationCategory).DisplayName = n.GetStringValue(); } },
                {"helpText", (o,n) => { (o as DeviceManagementConfigurationCategory).HelpText = n.GetStringValue(); } },
                {"name", (o,n) => { (o as DeviceManagementConfigurationCategory).Name = n.GetStringValue(); } },
                {"parentCategoryId", (o,n) => { (o as DeviceManagementConfigurationCategory).ParentCategoryId = n.GetStringValue(); } },
                {"platforms", (o,n) => { (o as DeviceManagementConfigurationCategory).Platforms = n.GetEnumValue<DeviceManagementConfigurationPlatforms>(); } },
                {"rootCategoryId", (o,n) => { (o as DeviceManagementConfigurationCategory).RootCategoryId = n.GetStringValue(); } },
                {"settingUsage", (o,n) => { (o as DeviceManagementConfigurationCategory).SettingUsage = n.GetEnumValue<DeviceManagementConfigurationSettingUsage>(); } },
                {"technologies", (o,n) => { (o as DeviceManagementConfigurationCategory).Technologies = n.GetEnumValue<DeviceManagementConfigurationTechnologies>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("categoryDescription", CategoryDescription);
            writer.WriteCollectionOfPrimitiveValues<string>("childCategoryIds", ChildCategoryIds);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("helpText", HelpText);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("parentCategoryId", ParentCategoryId);
            writer.WriteEnumValue<DeviceManagementConfigurationPlatforms>("platforms", Platforms);
            writer.WriteStringValue("rootCategoryId", RootCategoryId);
            writer.WriteEnumValue<DeviceManagementConfigurationSettingUsage>("settingUsage", SettingUsage);
            writer.WriteEnumValue<DeviceManagementConfigurationTechnologies>("technologies", Technologies);
        }
    }
}
