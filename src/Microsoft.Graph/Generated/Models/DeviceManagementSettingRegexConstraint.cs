// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Constraint enforcing the setting matches against a given RegEx pattern
    /// </summary>
    public class DeviceManagementSettingRegexConstraint : Microsoft.Graph.Beta.Models.DeviceManagementConstraint, IParsable
    {
        /// <summary>The RegEx pattern to match against</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Regex
        {
            get { return BackingStore?.Get<string?>("regex"); }
            set { BackingStore?.Set("regex", value); }
        }
#nullable restore
#else
        public string Regex
        {
            get { return BackingStore?.Get<string>("regex"); }
            set { BackingStore?.Set("regex", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.DeviceManagementSettingRegexConstraint"/> and sets the default values.
        /// </summary>
        public DeviceManagementSettingRegexConstraint() : base()
        {
            OdataType = "#microsoft.graph.deviceManagementSettingRegexConstraint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceManagementSettingRegexConstraint"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DeviceManagementSettingRegexConstraint CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.DeviceManagementSettingRegexConstraint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "regex", n => { Regex = n.GetStringValue(); } },
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
            writer.WriteStringValue("regex", Regex);
        }
    }
}
