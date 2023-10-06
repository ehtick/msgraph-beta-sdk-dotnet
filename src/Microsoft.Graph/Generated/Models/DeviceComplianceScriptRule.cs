// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceComplianceScriptRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Data types for rules.</summary>
        public Microsoft.Graph.Beta.Models.DataType? DataType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DataType?>("dataType"); }
            set { BackingStore?.Set("dataType", value); }
        }
        /// <summary>Data types for rules.</summary>
        public Microsoft.Graph.Beta.Models.DeviceComplianceScriptRuleDataType? DeviceComplianceScriptRuleDataType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceComplianceScriptRuleDataType?>("deviceComplianceScriptRuleDataType"); }
            set { BackingStore?.Set("deviceComplianceScriptRuleDataType", value); }
        }
        /// <summary>Operator for rules.</summary>
        public Microsoft.Graph.Beta.Models.DeviceComplianceScriptRulOperator? DeviceComplianceScriptRulOperator {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceComplianceScriptRulOperator?>("deviceComplianceScriptRulOperator"); }
            set { BackingStore?.Set("deviceComplianceScriptRulOperator", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Operand specified in the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Operand {
            get { return BackingStore?.Get<string?>("operand"); }
            set { BackingStore?.Set("operand", value); }
        }
#nullable restore
#else
        public string Operand {
            get { return BackingStore?.Get<string>("operand"); }
            set { BackingStore?.Set("operand", value); }
        }
#endif
        /// <summary>Operator for rules.</summary>
        public Microsoft.Graph.Beta.Models.Operator? Operator {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Operator?>("operator"); }
            set { BackingStore?.Set("operator", value); }
        }
        /// <summary>Setting name specified in the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SettingName {
            get { return BackingStore?.Get<string?>("settingName"); }
            set { BackingStore?.Set("settingName", value); }
        }
#nullable restore
#else
        public string SettingName {
            get { return BackingStore?.Get<string>("settingName"); }
            set { BackingStore?.Set("settingName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceComplianceScriptRule and sets the default values.
        /// </summary>
        public DeviceComplianceScriptRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceComplianceScriptRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceScriptRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dataType", n => { DataType = n.GetEnumValue<DataType>(); } },
                {"deviceComplianceScriptRulOperator", n => { DeviceComplianceScriptRulOperator = n.GetEnumValue<DeviceComplianceScriptRulOperator>(); } },
                {"deviceComplianceScriptRuleDataType", n => { DeviceComplianceScriptRuleDataType = n.GetEnumValue<DeviceComplianceScriptRuleDataType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operand", n => { Operand = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetEnumValue<Operator>(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DataType>("dataType", DataType);
            writer.WriteEnumValue<DeviceComplianceScriptRuleDataType>("deviceComplianceScriptRuleDataType", DeviceComplianceScriptRuleDataType);
            writer.WriteEnumValue<DeviceComplianceScriptRulOperator>("deviceComplianceScriptRulOperator", DeviceComplianceScriptRulOperator);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operand", Operand);
            writer.WriteEnumValue<Operator>("operator", Operator);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
