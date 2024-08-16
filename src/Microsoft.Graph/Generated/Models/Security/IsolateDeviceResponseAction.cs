// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class IsolateDeviceResponseAction : Microsoft.Graph.Beta.Models.Security.ResponseAction, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identifier property</summary>
        public Microsoft.Graph.Beta.Models.Security.DeviceIdEntityIdentifier? Identifier
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DeviceIdEntityIdentifier?>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
        /// <summary>The isolationType property</summary>
        public Microsoft.Graph.Beta.Models.Security.IsolationType? IsolationType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.IsolationType?>("isolationType"); }
            set { BackingStore?.Set("isolationType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Security.IsolateDeviceResponseAction"/> and sets the default values.
        /// </summary>
        public IsolateDeviceResponseAction() : base()
        {
            OdataType = "#microsoft.graph.security.isolateDeviceResponseAction";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.IsolateDeviceResponseAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Security.IsolateDeviceResponseAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.IsolateDeviceResponseAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "identifier", n => { Identifier = n.GetEnumValue<Microsoft.Graph.Beta.Models.Security.DeviceIdEntityIdentifier>(); } },
                { "isolationType", n => { IsolationType = n.GetEnumValue<Microsoft.Graph.Beta.Models.Security.IsolationType>(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Security.DeviceIdEntityIdentifier>("identifier", Identifier);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Security.IsolationType>("isolationType", IsolationType);
        }
    }
}
