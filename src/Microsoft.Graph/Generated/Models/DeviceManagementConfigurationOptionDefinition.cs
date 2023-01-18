using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementConfigurationOptionDefinition : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>List of Settings that depends on this option</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DeviceManagementConfigurationSettingDependedOnBy>? DependedOnBy {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDependedOnBy>?>("dependedOnBy"); }
            set { BackingStore?.Set("dependedOnBy", value); }
        }
#else
        public List<DeviceManagementConfigurationSettingDependedOnBy> DependedOnBy {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationSettingDependedOnBy>>("dependedOnBy"); }
            set { BackingStore?.Set("dependedOnBy", value); }
        }
#endif
        /// <summary>List of dependent settings for this option</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DeviceManagementConfigurationDependentOn>? DependentOn {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationDependentOn>?>("dependentOn"); }
            set { BackingStore?.Set("dependentOn", value); }
        }
#else
        public List<DeviceManagementConfigurationDependentOn> DependentOn {
            get { return BackingStore?.Get<List<DeviceManagementConfigurationDependentOn>>("dependentOn"); }
            set { BackingStore?.Set("dependentOn", value); }
        }
#endif
        /// <summary>Description of the option</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Friendly name of the option</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Help text of the option</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? HelpText {
            get { return BackingStore?.Get<string?>("helpText"); }
            set { BackingStore?.Set("helpText", value); }
        }
#else
        public string HelpText {
            get { return BackingStore?.Get<string>("helpText"); }
            set { BackingStore?.Set("helpText", value); }
        }
#endif
        /// <summary>Identifier of option</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ItemId {
            get { return BackingStore?.Get<string?>("itemId"); }
            set { BackingStore?.Set("itemId", value); }
        }
#else
        public string ItemId {
            get { return BackingStore?.Get<string>("itemId"); }
            set { BackingStore?.Set("itemId", value); }
        }
#endif
        /// <summary>Name of the option</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Value of the option</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceManagementConfigurationSettingValue? OptionValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingValue?>("optionValue"); }
            set { BackingStore?.Set("optionValue", value); }
        }
#else
        public DeviceManagementConfigurationSettingValue OptionValue {
            get { return BackingStore?.Get<DeviceManagementConfigurationSettingValue>("optionValue"); }
            set { BackingStore?.Set("optionValue", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceManagementConfigurationOptionDefinition and sets the default values.
        /// </summary>
        public DeviceManagementConfigurationOptionDefinition() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceManagementConfigurationOptionDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementConfigurationOptionDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dependedOnBy", n => { DependedOnBy = n.GetCollectionOfObjectValues<DeviceManagementConfigurationSettingDependedOnBy>(DeviceManagementConfigurationSettingDependedOnBy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"dependentOn", n => { DependentOn = n.GetCollectionOfObjectValues<DeviceManagementConfigurationDependentOn>(DeviceManagementConfigurationDependentOn.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"helpText", n => { HelpText = n.GetStringValue(); } },
                {"itemId", n => { ItemId = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"optionValue", n => { OptionValue = n.GetObjectValue<DeviceManagementConfigurationSettingValue>(DeviceManagementConfigurationSettingValue.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationSettingDependedOnBy>("dependedOnBy", DependedOnBy);
            writer.WriteCollectionOfObjectValues<DeviceManagementConfigurationDependentOn>("dependentOn", DependentOn);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("helpText", HelpText);
            writer.WriteStringValue("itemId", ItemId);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<DeviceManagementConfigurationSettingValue>("optionValue", OptionValue);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
