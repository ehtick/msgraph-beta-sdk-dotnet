// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AccessReviewStage : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Each user reviewed in an accessReviewStage has a decision item representing if they were approved, denied, or not yet reviewed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItem>? Decisions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItem>?>("decisions"); }
            set { BackingStore?.Set("decisions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItem> Decisions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItem>>("decisions"); }
            set { BackingStore?.Set("decisions", value); }
        }
#endif
        /// <summary>DateTime when review stage is scheduled to end. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. This property is the cumulative total of the durationInDays for all stages. Read-only.</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>This collection of reviewer scopes is used to define the list of fallback reviewers. These fallback reviewers are notified to take action if no users are found from the list of reviewers specified. This can occur when either the group owner is specified as the reviewer but the group owner does not exist, or manager is specified as reviewer but a user&apos;s manager does not exist.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope>? FallbackReviewers
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope>?>("fallbackReviewers"); }
            set { BackingStore?.Set("fallbackReviewers", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope> FallbackReviewers
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope>>("fallbackReviewers"); }
            set { BackingStore?.Set("fallbackReviewers", value); }
        }
#endif
        /// <summary>This collection of access review scopes is used to define who the reviewers are. For examples of options for assigning reviewers, see Assign reviewers to your access review definition using the Microsoft Graph API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope>? Reviewers
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope>?>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope> Reviewers
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope>>("reviewers"); }
            set { BackingStore?.Set("reviewers", value); }
        }
#endif
        /// <summary>DateTime when review stage is scheduled to start. May be in the future. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? StartDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>Specifies the status of an accessReviewStage. Possible values: Initializing, NotStarted, Starting, InProgress, Completing, Completed, AutoReviewing, and AutoReviewed. Supports $orderby, and $filter (eq only). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status
        {
            get { return BackingStore?.Get<string?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public string Status
        {
            get { return BackingStore?.Get<string>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AccessReviewStage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AccessReviewStage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AccessReviewStage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "decisions", n => { Decisions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItem>(Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItem.CreateFromDiscriminatorValue)?.ToList(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "fallbackReviewers", n => { FallbackReviewers = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope>(Microsoft.Graph.Beta.Models.AccessReviewReviewerScope.CreateFromDiscriminatorValue)?.ToList(); } },
                { "reviewers", n => { Reviewers = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope>(Microsoft.Graph.Beta.Models.AccessReviewReviewerScope.CreateFromDiscriminatorValue)?.ToList(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "status", n => { Status = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessReviewInstanceDecisionItem>("decisions", Decisions);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope>("fallbackReviewers", FallbackReviewers);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AccessReviewReviewerScope>("reviewers", Reviewers);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("status", Status);
        }
    }
}
