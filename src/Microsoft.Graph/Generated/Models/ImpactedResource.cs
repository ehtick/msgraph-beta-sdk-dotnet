// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ImpactedResource : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The date and time when the impactedResource object was initially associated with the recommendation.</summary>
        public DateTimeOffset? AddedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("addedDateTime"); }
            set { BackingStore?.Set("addedDateTime", value); }
        }
        /// <summary>Additional information unique to the impactedResource to help contextualize the recommendation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.KeyValue>? AdditionalDetails
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValue>?>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.KeyValue> AdditionalDetails
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValue>>("additionalDetails"); }
            set { BackingStore?.Set("additionalDetails", value); }
        }
#endif
        /// <summary>The URL link to the corresponding Microsoft Entra resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApiUrl
        {
            get { return BackingStore?.Get<string?>("apiUrl"); }
            set { BackingStore?.Set("apiUrl", value); }
        }
#nullable restore
#else
        public string ApiUrl
        {
            get { return BackingStore?.Get<string>("apiUrl"); }
            set { BackingStore?.Set("apiUrl", value); }
        }
#endif
        /// <summary>Friendly name of the Microsoft Entra resource.</summary>
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
        /// <summary>Name of the user or service that last updated the status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedBy
        {
            get { return BackingStore?.Get<string?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public string LastModifiedBy
        {
            get { return BackingStore?.Get<string>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The date and time when the status was last updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedDateTime
        {
            get { return BackingStore?.Get<string?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
#nullable restore
#else
        public string LastModifiedDateTime
        {
            get { return BackingStore?.Get<string>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
#endif
        /// <summary>The user responsible for maintaining the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner
        {
            get { return BackingStore?.Get<string?>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#nullable restore
#else
        public string Owner
        {
            get { return BackingStore?.Get<string>("owner"); }
            set { BackingStore?.Set("owner", value); }
        }
#endif
        /// <summary>The URL link to the corresponding Microsoft Entra admin center page of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PortalUrl
        {
            get { return BackingStore?.Get<string?>("portalUrl"); }
            set { BackingStore?.Set("portalUrl", value); }
        }
#nullable restore
#else
        public string PortalUrl
        {
            get { return BackingStore?.Get<string>("portalUrl"); }
            set { BackingStore?.Set("portalUrl", value); }
        }
#endif
        /// <summary>The future date and time when the status of a postponed impactedResource will be active again.</summary>
        public DateTimeOffset? PostponeUntilDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("postponeUntilDateTime"); }
            set { BackingStore?.Set("postponeUntilDateTime", value); }
        }
        /// <summary>Indicates the importance of the resource. A resource with a rank equal to 1 is of the highest importance.</summary>
        public int? Rank
        {
            get { return BackingStore?.Get<int?>("rank"); }
            set { BackingStore?.Set("rank", value); }
        }
        /// <summary>The unique identifier of the recommendation that the resource is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecommendationId
        {
            get { return BackingStore?.Get<string?>("recommendationId"); }
            set { BackingStore?.Set("recommendationId", value); }
        }
#nullable restore
#else
        public string RecommendationId
        {
            get { return BackingStore?.Get<string>("recommendationId"); }
            set { BackingStore?.Set("recommendationId", value); }
        }
#endif
        /// <summary>Indicates the type of Microsoft Entra resource. Examples include user, application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceType
        {
            get { return BackingStore?.Get<string?>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
#nullable restore
#else
        public string ResourceType
        {
            get { return BackingStore?.Get<string>("resourceType"); }
            set { BackingStore?.Set("resourceType", value); }
        }
#endif
        /// <summary>The status property</summary>
        public Microsoft.Graph.Beta.Models.RecommendationStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RecommendationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The related unique identifier, depending on the resourceType. For example, this property is set to the applicationId if the resourceType is an application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubjectId
        {
            get { return BackingStore?.Get<string?>("subjectId"); }
            set { BackingStore?.Set("subjectId", value); }
        }
#nullable restore
#else
        public string SubjectId
        {
            get { return BackingStore?.Get<string>("subjectId"); }
            set { BackingStore?.Set("subjectId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ImpactedResource"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ImpactedResource CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ImpactedResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addedDateTime", n => { AddedDateTime = n.GetDateTimeOffsetValue(); } },
                { "additionalDetails", n => { AdditionalDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValue>(Microsoft.Graph.Beta.Models.KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                { "apiUrl", n => { ApiUrl = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetStringValue(); } },
                { "owner", n => { Owner = n.GetStringValue(); } },
                { "portalUrl", n => { PortalUrl = n.GetStringValue(); } },
                { "postponeUntilDateTime", n => { PostponeUntilDateTime = n.GetDateTimeOffsetValue(); } },
                { "rank", n => { Rank = n.GetIntValue(); } },
                { "recommendationId", n => { RecommendationId = n.GetStringValue(); } },
                { "resourceType", n => { ResourceType = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Beta.Models.RecommendationStatus>(); } },
                { "subjectId", n => { SubjectId = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("addedDateTime", AddedDateTime);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValue>("additionalDetails", AdditionalDetails);
            writer.WriteStringValue("apiUrl", ApiUrl);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("lastModifiedBy", LastModifiedBy);
            writer.WriteStringValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("owner", Owner);
            writer.WriteStringValue("portalUrl", PortalUrl);
            writer.WriteDateTimeOffsetValue("postponeUntilDateTime", PostponeUntilDateTime);
            writer.WriteIntValue("rank", Rank);
            writer.WriteStringValue("recommendationId", RecommendationId);
            writer.WriteStringValue("resourceType", ResourceType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.RecommendationStatus>("status", Status);
            writer.WriteStringValue("subjectId", SubjectId);
        }
    }
}
