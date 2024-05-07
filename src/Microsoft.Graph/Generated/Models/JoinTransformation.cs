// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class JoinTransformation : CustomClaimTransformation, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The input2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TransformationAttribute? Input2 {
            get { return BackingStore?.Get<TransformationAttribute?>("input2"); }
            set { BackingStore?.Set("input2", value); }
        }
#nullable restore
#else
        public TransformationAttribute Input2 {
            get { return BackingStore?.Get<TransformationAttribute>("input2"); }
            set { BackingStore?.Set("input2", value); }
        }
#endif
        /// <summary>The separator property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Separator {
            get { return BackingStore?.Get<string?>("separator"); }
            set { BackingStore?.Set("separator", value); }
        }
#nullable restore
#else
        public string Separator {
            get { return BackingStore?.Get<string>("separator"); }
            set { BackingStore?.Set("separator", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="JoinTransformation"/> and sets the default values.
        /// </summary>
        public JoinTransformation() : base()
        {
            OdataType = "#microsoft.graph.joinTransformation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="JoinTransformation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new JoinTransformation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JoinTransformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"input2", n => { Input2 = n.GetObjectValue<TransformationAttribute>(TransformationAttribute.CreateFromDiscriminatorValue); } },
                {"separator", n => { Separator = n.GetStringValue(); } },
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
            writer.WriteObjectValue<TransformationAttribute>("input2", Input2);
            writer.WriteStringValue("separator", Separator);
        }
    }
}
