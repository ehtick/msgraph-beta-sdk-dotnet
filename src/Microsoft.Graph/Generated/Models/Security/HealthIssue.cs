// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class HealthIssue : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Contains additional information about the issue, such as a list of items to fix.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AdditionalInformation
        {
            get { return BackingStore?.Get<List<string>?>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#nullable restore
#else
        public List<string> AdditionalInformation
        {
            get { return BackingStore?.Get<List<string>>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#endif
        /// <summary>The date and time of when the health issue was generated.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Contains more detailed information about the health issue.</summary>
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
        /// <summary>The display name of the health issue.</summary>
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
        /// <summary>A list of the fully qualified domain names of the domains or the sensors the health issue is related to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DomainNames
        {
            get { return BackingStore?.Get<List<string>?>("domainNames"); }
            set { BackingStore?.Set("domainNames", value); }
        }
#nullable restore
#else
        public List<string> DomainNames
        {
            get { return BackingStore?.Get<List<string>>("domainNames"); }
            set { BackingStore?.Set("domainNames", value); }
        }
#endif
        /// <summary>The type of the health issue. The possible values are: sensor, global, unknownFutureValue. For a list of all health issues and their identifiers, see Microsoft Defender for Identity health issues.</summary>
        public Microsoft.Graph.Beta.Models.Security.HealthIssueType? HealthIssueType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.HealthIssueType?>("healthIssueType"); }
            set { BackingStore?.Set("healthIssueType", value); }
        }
        /// <summary>The type identifier of the health issue. For a list of all health issues and their identifiers, see Microsoft Defender for Identity health issues.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueTypeId
        {
            get { return BackingStore?.Get<string?>("issueTypeId"); }
            set { BackingStore?.Set("issueTypeId", value); }
        }
#nullable restore
#else
        public string IssueTypeId
        {
            get { return BackingStore?.Get<string>("issueTypeId"); }
            set { BackingStore?.Set("issueTypeId", value); }
        }
#endif
        /// <summary>The date and time of when the health issue was last updated.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>This field contains a list of recommended actions that can be taken to resolve the issue effectively and efficiently. These actions might include how to investigate the issue further. Not limited to prewritten responses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Recommendations
        {
            get { return BackingStore?.Get<List<string>?>("recommendations"); }
            set { BackingStore?.Set("recommendations", value); }
        }
#nullable restore
#else
        public List<string> Recommendations
        {
            get { return BackingStore?.Get<List<string>>("recommendations"); }
            set { BackingStore?.Set("recommendations", value); }
        }
#endif
        /// <summary>Contains a list of commands from the product&apos;s PowerShell module that can be used to resolve the issue, if available. If there aren&apos;t any commands that can be used to solve the issue, this field is empty. The commands, if present, provide a quick and efficient way to address the issue. The commands run in order for the single recommended fix.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RecommendedActionCommands
        {
            get { return BackingStore?.Get<List<string>?>("recommendedActionCommands"); }
            set { BackingStore?.Set("recommendedActionCommands", value); }
        }
#nullable restore
#else
        public List<string> RecommendedActionCommands
        {
            get { return BackingStore?.Get<List<string>>("recommendedActionCommands"); }
            set { BackingStore?.Set("recommendedActionCommands", value); }
        }
#endif
        /// <summary>A list of the dns names of the sensors the health issue is related to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SensorDNSNames
        {
            get { return BackingStore?.Get<List<string>?>("sensorDNSNames"); }
            set { BackingStore?.Set("sensorDNSNames", value); }
        }
#nullable restore
#else
        public List<string> SensorDNSNames
        {
            get { return BackingStore?.Get<List<string>>("sensorDNSNames"); }
            set { BackingStore?.Set("sensorDNSNames", value); }
        }
#endif
        /// <summary>The severity of the health issue. The possible values are: low, medium, high, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.HealthIssueSeverity? Severity
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.HealthIssueSeverity?>("severity"); }
            set { BackingStore?.Set("severity", value); }
        }
        /// <summary>The status of the health issue. The possible values are: open, closed, suppressed, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.Security.HealthIssueStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.HealthIssueStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.HealthIssue"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Security.HealthIssue CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.HealthIssue();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "additionalInformation", n => { AdditionalInformation = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "domainNames", n => { DomainNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "healthIssueType", n => { HealthIssueType = n.GetEnumValue<Microsoft.Graph.Beta.Models.Security.HealthIssueType>(); } },
                { "issueTypeId", n => { IssueTypeId = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "recommendations", n => { Recommendations = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "recommendedActionCommands", n => { RecommendedActionCommands = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "sensorDNSNames", n => { SensorDNSNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "severity", n => { Severity = n.GetEnumValue<Microsoft.Graph.Beta.Models.Security.HealthIssueSeverity>(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Beta.Models.Security.HealthIssueStatus>(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("additionalInformation", AdditionalInformation);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("domainNames", DomainNames);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Security.HealthIssueType>("healthIssueType", HealthIssueType);
            writer.WriteStringValue("issueTypeId", IssueTypeId);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("recommendations", Recommendations);
            writer.WriteCollectionOfPrimitiveValues<string>("recommendedActionCommands", RecommendedActionCommands);
            writer.WriteCollectionOfPrimitiveValues<string>("sensorDNSNames", SensorDNSNames);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Security.HealthIssueSeverity>("severity", Severity);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.Security.HealthIssueStatus>("status", Status);
        }
    }
}
