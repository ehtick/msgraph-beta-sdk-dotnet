// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance
{
    #pragma warning disable CS1591
    public class TaskProcessingResult : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The date time when taskProcessingResult execution ended. Value is null if task execution is still in progress.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? CompletedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("completedDateTime"); }
            set { BackingStore?.Set("completedDateTime", value); }
        }
        /// <summary>The date time when the taskProcessingResult was created.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Describes why the taskProcessingResult has failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FailureReason
        {
            get { return BackingStore?.Get<string?>("failureReason"); }
            set { BackingStore?.Set("failureReason", value); }
        }
#nullable restore
#else
        public string FailureReason
        {
            get { return BackingStore?.Get<string>("failureReason"); }
            set { BackingStore?.Set("failureReason", value); }
        }
#endif
        /// <summary>The processingStatus property</summary>
        public Microsoft.Graph.Beta.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus? ProcessingStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus?>("processingStatus"); }
            set { BackingStore?.Set("processingStatus", value); }
        }
        /// <summary>The date time when taskProcessingResult execution started. Value is null if task execution has not yet started.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? StartedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("startedDateTime"); }
            set { BackingStore?.Set("startedDateTime", value); }
        }
        /// <summary>The subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.User? Subject
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.User?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.User Subject
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.User>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>The task property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject? Task
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject?>("task"); }
            set { BackingStore?.Set("task", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject Task
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>("task"); }
            set { BackingStore?.Set("task", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.IdentityGovernance.TaskProcessingResult"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.IdentityGovernance.TaskProcessingResult CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.IdentityGovernance.TaskProcessingResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "failureReason", n => { FailureReason = n.GetStringValue(); } },
                { "processingStatus", n => { ProcessingStatus = n.GetEnumValue<Microsoft.Graph.Beta.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus>(); } },
                { "startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                { "subject", n => { Subject = n.GetObjectValue<Microsoft.Graph.Beta.Models.User>(Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue); } },
                { "task", n => { Task = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>(Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject.CreateFromDiscriminatorValue); } },
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
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("failureReason", FailureReason);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.IdentityGovernance.LifecycleWorkflowProcessingStatus>("processingStatus", ProcessingStatus);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.User>("subject", Subject);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentityGovernance.TaskObject>("task", Task);
        }
    }
}
