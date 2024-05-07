// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    #pragma warning disable CS1591
    public class Sensor : Microsoft.Graph.Beta.Models.Entity, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The deploymentStatus property</summary>
        public Microsoft.Graph.Beta.Models.Security.DeploymentStatus? DeploymentStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.DeploymentStatus?>("deploymentStatus"); }
            set { BackingStore?.Set("deploymentStatus", value); }
        }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The domainName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DomainName {
            get { return BackingStore?.Get<string?>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
#nullable restore
#else
        public string DomainName {
            get { return BackingStore?.Get<string>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
#endif
        /// <summary>The healthIssues property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HealthIssue>? HealthIssues {
            get { return BackingStore?.Get<List<HealthIssue>?>("healthIssues"); }
            set { BackingStore?.Set("healthIssues", value); }
        }
#nullable restore
#else
        public List<HealthIssue> HealthIssues {
            get { return BackingStore?.Get<List<HealthIssue>>("healthIssues"); }
            set { BackingStore?.Set("healthIssues", value); }
        }
#endif
        /// <summary>The healthStatus property</summary>
        public SensorHealthStatus? HealthStatus {
            get { return BackingStore?.Get<SensorHealthStatus?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>The openHealthIssuesCount property</summary>
        public long? OpenHealthIssuesCount {
            get { return BackingStore?.Get<long?>("openHealthIssuesCount"); }
            set { BackingStore?.Set("openHealthIssuesCount", value); }
        }
        /// <summary>The sensorType property</summary>
        public Microsoft.Graph.Beta.Models.Security.SensorType? SensorType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.SensorType?>("sensorType"); }
            set { BackingStore?.Set("sensorType", value); }
        }
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SensorSettings? Settings {
            get { return BackingStore?.Get<SensorSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public SensorSettings Settings {
            get { return BackingStore?.Get<SensorSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>The version property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Sensor"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Sensor CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Sensor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deploymentStatus", n => { DeploymentStatus = n.GetEnumValue<DeploymentStatus>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"domainName", n => { DomainName = n.GetStringValue(); } },
                {"healthIssues", n => { HealthIssues = n.GetCollectionOfObjectValues<HealthIssue>(HealthIssue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<SensorHealthStatus>(); } },
                {"openHealthIssuesCount", n => { OpenHealthIssuesCount = n.GetLongValue(); } },
                {"sensorType", n => { SensorType = n.GetEnumValue<SensorType>(); } },
                {"settings", n => { Settings = n.GetObjectValue<SensorSettings>(SensorSettings.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<DeploymentStatus>("deploymentStatus", DeploymentStatus);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteCollectionOfObjectValues<HealthIssue>("healthIssues", HealthIssues);
            writer.WriteEnumValue<SensorHealthStatus>("healthStatus", HealthStatus);
            writer.WriteLongValue("openHealthIssuesCount", OpenHealthIssuesCount);
            writer.WriteEnumValue<SensorType>("sensorType", SensorType);
            writer.WriteObjectValue<SensorSettings>("settings", Settings);
            writer.WriteStringValue("version", Version);
        }
    }
}
