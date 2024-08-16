// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AwsPermissionsDefinition : Microsoft.Graph.Beta.Models.PermissionsDefinition, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The actionInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AwsPermissionsDefinitionAction? ActionInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AwsPermissionsDefinitionAction?>("actionInfo"); }
            set { BackingStore?.Set("actionInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AwsPermissionsDefinitionAction ActionInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AwsPermissionsDefinitionAction>("actionInfo"); }
            set { BackingStore?.Set("actionInfo", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.AwsPermissionsDefinition"/> and sets the default values.
        /// </summary>
        public AwsPermissionsDefinition() : base()
        {
            OdataType = "#microsoft.graph.awsPermissionsDefinition";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AwsPermissionsDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AwsPermissionsDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AwsPermissionsDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionInfo", n => { ActionInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.AwsPermissionsDefinitionAction>(Microsoft.Graph.Beta.Models.AwsPermissionsDefinitionAction.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AwsPermissionsDefinitionAction>("actionInfo", ActionInfo);
        }
    }
}
