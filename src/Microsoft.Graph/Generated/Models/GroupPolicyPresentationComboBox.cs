using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyPresentationComboBox : GroupPolicyUploadedPresentation, IParsable {
        /// <summary>Localized default string displayed in the combo box. The default value is empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DefaultValue {
            get { return BackingStore?.Get<string?>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#else
        public string DefaultValue {
            get { return BackingStore?.Get<string>("defaultValue"); }
            set { BackingStore?.Set("defaultValue", value); }
        }
#endif
        /// <summary>An unsigned integer that specifies the maximum number of text characters for the parameter. The default value is 1023.</summary>
        public long? MaxLength {
            get { return BackingStore?.Get<long?>("maxLength"); }
            set { BackingStore?.Set("maxLength", value); }
        }
        /// <summary>Specifies whether a value must be specified for the parameter. The default value is false.</summary>
        public bool? Required {
            get { return BackingStore?.Get<bool?>("required"); }
            set { BackingStore?.Set("required", value); }
        }
        /// <summary>Localized strings listed in the drop-down list of the combo box. The default value is empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? Suggestions {
            get { return BackingStore?.Get<List<string>?>("suggestions"); }
            set { BackingStore?.Set("suggestions", value); }
        }
#else
        public List<string> Suggestions {
            get { return BackingStore?.Get<List<string>>("suggestions"); }
            set { BackingStore?.Set("suggestions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new GroupPolicyPresentationComboBox and sets the default values.
        /// </summary>
        public GroupPolicyPresentationComboBox() : base() {
            OdataType = "#microsoft.graph.groupPolicyPresentationComboBox";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyPresentationComboBox CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyPresentationComboBox();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultValue", n => { DefaultValue = n.GetStringValue(); } },
                {"maxLength", n => { MaxLength = n.GetLongValue(); } },
                {"required", n => { Required = n.GetBoolValue(); } },
                {"suggestions", n => { Suggestions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("defaultValue", DefaultValue);
            writer.WriteLongValue("maxLength", MaxLength);
            writer.WriteBoolValue("required", Required);
            writer.WriteCollectionOfPrimitiveValues<string>("suggestions", Suggestions);
        }
    }
}
