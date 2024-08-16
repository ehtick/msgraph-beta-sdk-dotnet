// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class WorkbookChartTitleFormat : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the fill format of an object, which includes background formatting information. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WorkbookChartFill? Fill
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WorkbookChartFill?>("fill"); }
            set { BackingStore?.Set("fill", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WorkbookChartFill Fill
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WorkbookChartFill>("fill"); }
            set { BackingStore?.Set("fill", value); }
        }
#endif
        /// <summary>Represents the font attributes (font name, font size, color, etc.) for the current object. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WorkbookChartFont? Font
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WorkbookChartFont?>("font"); }
            set { BackingStore?.Set("font", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WorkbookChartFont Font
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WorkbookChartFont>("font"); }
            set { BackingStore?.Set("font", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WorkbookChartTitleFormat"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.WorkbookChartTitleFormat CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.WorkbookChartTitleFormat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "fill", n => { Fill = n.GetObjectValue<Microsoft.Graph.Beta.Models.WorkbookChartFill>(Microsoft.Graph.Beta.Models.WorkbookChartFill.CreateFromDiscriminatorValue); } },
                { "font", n => { Font = n.GetObjectValue<Microsoft.Graph.Beta.Models.WorkbookChartFont>(Microsoft.Graph.Beta.Models.WorkbookChartFont.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WorkbookChartFill>("fill", Fill);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WorkbookChartFont>("font", Font);
        }
    }
}
