// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class IntelligenceProfile : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A list of commonly-known aliases for the threat intelligence included in the intelligenceProfile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Aliases
        {
            get { return BackingStore?.Get<List<string>?>("aliases"); }
            set { BackingStore?.Set("aliases", value); }
        }
#nullable restore
#else
        public List<string> Aliases
        {
            get { return BackingStore?.Get<List<string>>("aliases"); }
            set { BackingStore?.Set("aliases", value); }
        }
#endif
        /// <summary>The country/region of origin for the given actor or threat associated with this intelligenceProfile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin>? CountriesOrRegionsOfOrigin
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin>?>("countriesOrRegionsOfOrigin"); }
            set { BackingStore?.Set("countriesOrRegionsOfOrigin", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin> CountriesOrRegionsOfOrigin
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin>>("countriesOrRegionsOfOrigin"); }
            set { BackingStore?.Set("countriesOrRegionsOfOrigin", value); }
        }
#endif
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.FormattedContent? Description
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.FormattedContent?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.FormattedContent Description
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.FormattedContent>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The date and time when this intelligenceProfile was first active.  The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstActiveDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstActiveDateTime"); }
            set { BackingStore?.Set("firstActiveDateTime", value); }
        }
        /// <summary>Includes an assemblage of high-fidelity network indicators of compromise.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator>? Indicators
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator>?>("indicators"); }
            set { BackingStore?.Set("indicators", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator> Indicators
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator>>("indicators"); }
            set { BackingStore?.Set("indicators", value); }
        }
#endif
        /// <summary>The kind property</summary>
        public Microsoft.Graph.Beta.Models.Security.IntelligenceProfileKind? Kind
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileKind?>("kind"); }
            set { BackingStore?.Set("kind", value); }
        }
        /// <summary>The summary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.FormattedContent? Summary
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.FormattedContent?>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.FormattedContent Summary
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.FormattedContent>("summary"); }
            set { BackingStore?.Set("summary", value); }
        }
#endif
        /// <summary>Known targets related to this intelligenceProfile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Targets
        {
            get { return BackingStore?.Get<List<string>?>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#nullable restore
#else
        public List<string> Targets
        {
            get { return BackingStore?.Get<List<string>>("targets"); }
            set { BackingStore?.Set("targets", value); }
        }
#endif
        /// <summary>The title of this intelligenceProfile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title
        {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title
        {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>Formatted information featuring a description of the distinctive tactics, techniques, and procedures (TTP) of the group, followed by a list of all known custom, commodity, and publicly available implants used by the group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.FormattedContent? Tradecraft
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.FormattedContent?>("tradecraft"); }
            set { BackingStore?.Set("tradecraft", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.FormattedContent Tradecraft
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.FormattedContent>("tradecraft"); }
            set { BackingStore?.Set("tradecraft", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.IntelligenceProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Security.IntelligenceProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.IntelligenceProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "aliases", n => { Aliases = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "countriesOrRegionsOfOrigin", n => { CountriesOrRegionsOfOrigin = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin>(Microsoft.Graph.Beta.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin.CreateFromDiscriminatorValue)?.ToList(); } },
                { "description", n => { Description = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.FormattedContent>(Microsoft.Graph.Beta.Models.Security.FormattedContent.CreateFromDiscriminatorValue); } },
                { "firstActiveDateTime", n => { FirstActiveDateTime = n.GetDateTimeOffsetValue(); } },
                { "indicators", n => { Indicators = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator>(Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator.CreateFromDiscriminatorValue)?.ToList(); } },
                { "kind", n => { Kind = n.GetEnumValue<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileKind>(); } },
                { "summary", n => { Summary = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.FormattedContent>(Microsoft.Graph.Beta.Models.Security.FormattedContent.CreateFromDiscriminatorValue); } },
                { "targets", n => { Targets = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "title", n => { Title = n.GetStringValue(); } },
                { "tradecraft", n => { Tradecraft = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.FormattedContent>(Microsoft.Graph.Beta.Models.Security.FormattedContent.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("aliases", Aliases);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileCountryOrRegionOfOrigin>("countriesOrRegionsOfOrigin", CountriesOrRegionsOfOrigin);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.FormattedContent>("description", Description);
            writer.WriteDateTimeOffsetValue("firstActiveDateTime", FirstActiveDateTime);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator>("indicators", Indicators);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileKind>("kind", Kind);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.FormattedContent>("summary", Summary);
            writer.WriteCollectionOfPrimitiveValues<string>("targets", Targets);
            writer.WriteStringValue("title", Title);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.FormattedContent>("tradecraft", Tradecraft);
        }
    }
}
