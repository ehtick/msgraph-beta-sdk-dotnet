// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Groups.Item.Calendar.Events.Item.Instances.Item.ExceptionOccurrences.Delta
{
    #pragma warning disable CS1591
    public class DeltaGetResponse : Microsoft.Graph.Beta.Models.BaseDeltaFunctionResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The value property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Event>? Value
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Event>?>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Event> Value
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Event>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Groups.Item.Calendar.Events.Item.Instances.Item.ExceptionOccurrences.Delta.DeltaGetResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Groups.Item.Calendar.Events.Item.Instances.Item.ExceptionOccurrences.Delta.DeltaGetResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Groups.Item.Calendar.Events.Item.Instances.Item.ExceptionOccurrences.Delta.DeltaGetResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "value", n => { Value = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Event>(Microsoft.Graph.Beta.Models.Event.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Event>("value", Value);
        }
    }
}
