// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class SubstringTransformation : Microsoft.Graph.Beta.Models.CustomClaimTransformation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The start index of the substring operation, where 0 is the first character in the string.</summary>
        public int? Index
        {
            get { return BackingStore?.Get<int?>("index"); }
            set { BackingStore?.Set("index", value); }
        }
        /// <summary>The maximum length of the string, starting from the provided index.</summary>
        public int? Length
        {
            get { return BackingStore?.Get<int?>("length"); }
            set { BackingStore?.Set("length", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.SubstringTransformation"/> and sets the default values.
        /// </summary>
        public SubstringTransformation() : base()
        {
            OdataType = "#microsoft.graph.substringTransformation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.SubstringTransformation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.SubstringTransformation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.SubstringTransformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "index", n => { Index = n.GetIntValue(); } },
                { "length", n => { Length = n.GetIntValue(); } },
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
            writer.WriteIntValue("index", Index);
            writer.WriteIntValue("length", Length);
        }
    }
}
