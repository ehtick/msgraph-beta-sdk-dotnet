// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ServiceHealthIssue : Microsoft.Graph.Beta.Models.ServiceAnnouncementBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The classification property</summary>
        public Microsoft.Graph.Beta.Models.ServiceHealthClassificationType? Classification
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceHealthClassificationType?>("classification"); }
            set { BackingStore?.Set("classification", value); }
        }
        /// <summary>The feature name of the service issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Feature
        {
            get { return BackingStore?.Get<string?>("feature"); }
            set { BackingStore?.Set("feature", value); }
        }
#nullable restore
#else
        public string Feature
        {
            get { return BackingStore?.Get<string>("feature"); }
            set { BackingStore?.Set("feature", value); }
        }
#endif
        /// <summary>The feature group name of the service issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FeatureGroup
        {
            get { return BackingStore?.Get<string?>("featureGroup"); }
            set { BackingStore?.Set("featureGroup", value); }
        }
#nullable restore
#else
        public string FeatureGroup
        {
            get { return BackingStore?.Get<string>("featureGroup"); }
            set { BackingStore?.Set("featureGroup", value); }
        }
#endif
        /// <summary>The description of the service issue impact.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImpactDescription
        {
            get { return BackingStore?.Get<string?>("impactDescription"); }
            set { BackingStore?.Set("impactDescription", value); }
        }
#nullable restore
#else
        public string ImpactDescription
        {
            get { return BackingStore?.Get<string>("impactDescription"); }
            set { BackingStore?.Set("impactDescription", value); }
        }
#endif
        /// <summary>Indicates whether the issue is resolved.</summary>
        public bool? IsResolved
        {
            get { return BackingStore?.Get<bool?>("isResolved"); }
            set { BackingStore?.Set("isResolved", value); }
        }
        /// <summary>The origin property</summary>
        public Microsoft.Graph.Beta.Models.ServiceHealthOrigin? Origin
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceHealthOrigin?>("origin"); }
            set { BackingStore?.Set("origin", value); }
        }
        /// <summary>Collection of historical posts for the service issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ServiceHealthIssuePost>? Posts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ServiceHealthIssuePost>?>("posts"); }
            set { BackingStore?.Set("posts", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ServiceHealthIssuePost> Posts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ServiceHealthIssuePost>>("posts"); }
            set { BackingStore?.Set("posts", value); }
        }
#endif
        /// <summary>Indicates the service affected by the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Service
        {
            get { return BackingStore?.Get<string?>("service"); }
            set { BackingStore?.Set("service", value); }
        }
#nullable restore
#else
        public string Service
        {
            get { return BackingStore?.Get<string>("service"); }
            set { BackingStore?.Set("service", value); }
        }
#endif
        /// <summary>The status property</summary>
        public Microsoft.Graph.Beta.Models.ServiceHealthStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceHealthStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.ServiceHealthIssue"/> and sets the default values.
        /// </summary>
        public ServiceHealthIssue() : base()
        {
            OdataType = "#microsoft.graph.serviceHealthIssue";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ServiceHealthIssue"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ServiceHealthIssue CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ServiceHealthIssue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "classification", n => { Classification = n.GetEnumValue<Microsoft.Graph.Beta.Models.ServiceHealthClassificationType>(); } },
                { "feature", n => { Feature = n.GetStringValue(); } },
                { "featureGroup", n => { FeatureGroup = n.GetStringValue(); } },
                { "impactDescription", n => { ImpactDescription = n.GetStringValue(); } },
                { "isResolved", n => { IsResolved = n.GetBoolValue(); } },
                { "origin", n => { Origin = n.GetEnumValue<Microsoft.Graph.Beta.Models.ServiceHealthOrigin>(); } },
                { "posts", n => { Posts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ServiceHealthIssuePost>(Microsoft.Graph.Beta.Models.ServiceHealthIssuePost.CreateFromDiscriminatorValue)?.ToList(); } },
                { "service", n => { Service = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Beta.Models.ServiceHealthStatus>(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ServiceHealthClassificationType>("classification", Classification);
            writer.WriteStringValue("feature", Feature);
            writer.WriteStringValue("featureGroup", FeatureGroup);
            writer.WriteStringValue("impactDescription", ImpactDescription);
            writer.WriteBoolValue("isResolved", IsResolved);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ServiceHealthOrigin>("origin", Origin);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ServiceHealthIssuePost>("posts", Posts);
            writer.WriteStringValue("service", Service);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ServiceHealthStatus>("status", Status);
        }
    }
}
