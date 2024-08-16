// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class Training : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The training availability status. Possible values are: unknown, notAvailable, available, archive, delete, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.TrainingAvailabilityStatus? AvailabilityStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TrainingAvailabilityStatus?>("availabilityStatus"); }
            set { BackingStore?.Set("availabilityStatus", value); }
        }
        /// <summary>The identity of the user who created the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.EmailIdentity? CreatedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EmailIdentity?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.EmailIdentity CreatedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EmailIdentity>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The date and time when the training was created. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The training URL</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomUrl
        {
            get { return BackingStore?.Get<string?>("customUrl"); }
            set { BackingStore?.Set("customUrl", value); }
        }
#nullable restore
#else
        public string CustomUrl
        {
            get { return BackingStore?.Get<string>("customUrl"); }
            set { BackingStore?.Set("customUrl", value); }
        }
#endif
        /// <summary>The description for the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name for the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The duration of the training in minutes.</summary>
        public int? DurationInMinutes
        {
            get { return BackingStore?.Get<int?>("durationInMinutes"); }
            set { BackingStore?.Set("durationInMinutes", value); }
        }
        /// <summary>Whether the training has any evaluation.</summary>
        public bool? HasEvaluation
        {
            get { return BackingStore?.Get<bool?>("hasEvaluation"); }
            set { BackingStore?.Set("hasEvaluation", value); }
        }
        /// <summary>Details about the language used in the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.TrainingLanguageDetail>? LanguageDetails
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TrainingLanguageDetail>?>("languageDetails"); }
            set { BackingStore?.Set("languageDetails", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.TrainingLanguageDetail> LanguageDetails
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TrainingLanguageDetail>>("languageDetails"); }
            set { BackingStore?.Set("languageDetails", value); }
        }
#endif
        /// <summary>The identity of the user who last modified the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.EmailIdentity? LastModifiedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EmailIdentity?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.EmailIdentity LastModifiedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EmailIdentity>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The date and time when the training was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The source of the training content. Possible values are: unknown, global, tenant, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.SimulationContentSource? Source
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SimulationContentSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>The supported locales for content for the associated training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedLocales
        {
            get { return BackingStore?.Get<List<string>?>("supportedLocales"); }
            set { BackingStore?.Set("supportedLocales", value); }
        }
#nullable restore
#else
        public List<string> SupportedLocales
        {
            get { return BackingStore?.Get<List<string>>("supportedLocales"); }
            set { BackingStore?.Set("supportedLocales", value); }
        }
#endif
        /// <summary>Training tags.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags
        {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags
        {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>The type of training. Possible values are: unknown, phishing, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.TrainingType? Type
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TrainingType?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Training"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Training CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Training();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "availabilityStatus", n => { AvailabilityStatus = n.GetEnumValue<Microsoft.Graph.Beta.Models.TrainingAvailabilityStatus>(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.EmailIdentity>(Microsoft.Graph.Beta.Models.EmailIdentity.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customUrl", n => { CustomUrl = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "durationInMinutes", n => { DurationInMinutes = n.GetIntValue(); } },
                { "hasEvaluation", n => { HasEvaluation = n.GetBoolValue(); } },
                { "languageDetails", n => { LanguageDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TrainingLanguageDetail>(Microsoft.Graph.Beta.Models.TrainingLanguageDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.EmailIdentity>(Microsoft.Graph.Beta.Models.EmailIdentity.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "source", n => { Source = n.GetEnumValue<Microsoft.Graph.Beta.Models.SimulationContentSource>(); } },
                { "supportedLocales", n => { SupportedLocales = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "type", n => { Type = n.GetEnumValue<Microsoft.Graph.Beta.Models.TrainingType>(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.TrainingAvailabilityStatus>("availabilityStatus", AvailabilityStatus);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.EmailIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("customUrl", CustomUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("durationInMinutes", DurationInMinutes);
            writer.WriteBoolValue("hasEvaluation", HasEvaluation);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TrainingLanguageDetail>("languageDetails", LanguageDetails);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.EmailIdentity>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.SimulationContentSource>("source", Source);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedLocales", SupportedLocales);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.TrainingType>("type", Type);
        }
    }
}
