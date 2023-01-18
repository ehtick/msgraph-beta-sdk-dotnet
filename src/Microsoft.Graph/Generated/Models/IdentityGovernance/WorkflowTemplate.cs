using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class WorkflowTemplate : Entity, IParsable {
        /// <summary>The category property</summary>
        public LifecycleWorkflowCategory? Category {
            get { return BackingStore?.Get<LifecycleWorkflowCategory?>("category"); }
            set { BackingStore?.Set("category", value); }
        }
        /// <summary>The description of the workflowTemplate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The display name of the workflowTemplate.Supports $filter(eq, ne) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Conditions describing when to execute the workflow and the criteria to identify in-scope subject set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public WorkflowExecutionConditions? ExecutionConditions {
            get { return BackingStore?.Get<WorkflowExecutionConditions?>("executionConditions"); }
            set { BackingStore?.Set("executionConditions", value); }
        }
#else
        public WorkflowExecutionConditions ExecutionConditions {
            get { return BackingStore?.Get<WorkflowExecutionConditions>("executionConditions"); }
            set { BackingStore?.Set("executionConditions", value); }
        }
#endif
        /// <summary>Represents the configured tasks to execute and their execution sequence within a workflow. This relationship is expanded by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<TaskObject>? Tasks {
            get { return BackingStore?.Get<List<TaskObject>?>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#else
        public List<TaskObject> Tasks {
            get { return BackingStore?.Get<List<TaskObject>>("tasks"); }
            set { BackingStore?.Set("tasks", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkflowTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"category", n => { Category = n.GetEnumValue<LifecycleWorkflowCategory>(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"executionConditions", n => { ExecutionConditions = n.GetObjectValue<WorkflowExecutionConditions>(WorkflowExecutionConditions.CreateFromDiscriminatorValue); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<TaskObject>(TaskObject.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<LifecycleWorkflowCategory>("category", Category);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<WorkflowExecutionConditions>("executionConditions", ExecutionConditions);
            writer.WriteCollectionOfObjectValues<TaskObject>("tasks", Tasks);
        }
    }
}
