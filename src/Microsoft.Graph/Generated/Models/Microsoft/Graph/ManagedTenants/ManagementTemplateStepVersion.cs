using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class ManagementTemplateStepVersion : Entity, IParsable {
        public ManagementTemplateStep AcceptedFor { get; set; }
        public string ContentMarkdown { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTimeOffset? CreatedDateTime { get; set; }
        public List<ManagementTemplateStepDeployment> Deployments { get; set; }
        public string LastActionByUserId { get; set; }
        public DateTimeOffset? LastActionDateTime { get; set; }
        public string Name { get; set; }
        public ManagementTemplateStep TemplateStep { get; set; }
        public int? Version { get; set; }
        public string VersionInformation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagementTemplateStepVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagementTemplateStepVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"acceptedFor", (o,n) => { (o as ManagementTemplateStepVersion).AcceptedFor = n.GetObjectValue<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue); } },
                {"contentMarkdown", (o,n) => { (o as ManagementTemplateStepVersion).ContentMarkdown = n.GetStringValue(); } },
                {"createdByUserId", (o,n) => { (o as ManagementTemplateStepVersion).CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as ManagementTemplateStepVersion).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deployments", (o,n) => { (o as ManagementTemplateStepVersion).Deployments = n.GetCollectionOfObjectValues<ManagementTemplateStepDeployment>(ManagementTemplateStepDeployment.CreateFromDiscriminatorValue).ToList(); } },
                {"lastActionByUserId", (o,n) => { (o as ManagementTemplateStepVersion).LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", (o,n) => { (o as ManagementTemplateStepVersion).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", (o,n) => { (o as ManagementTemplateStepVersion).Name = n.GetStringValue(); } },
                {"templateStep", (o,n) => { (o as ManagementTemplateStepVersion).TemplateStep = n.GetObjectValue<ManagementTemplateStep>(ManagementTemplateStep.CreateFromDiscriminatorValue); } },
                {"version", (o,n) => { (o as ManagementTemplateStepVersion).Version = n.GetIntValue(); } },
                {"versionInformation", (o,n) => { (o as ManagementTemplateStepVersion).VersionInformation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ManagementTemplateStep>("acceptedFor", AcceptedFor);
            writer.WriteStringValue("contentMarkdown", ContentMarkdown);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<ManagementTemplateStepDeployment>("deployments", Deployments);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ManagementTemplateStep>("templateStep", TemplateStep);
            writer.WriteIntValue("version", Version);
            writer.WriteStringValue("versionInformation", VersionInformation);
        }
    }
}
