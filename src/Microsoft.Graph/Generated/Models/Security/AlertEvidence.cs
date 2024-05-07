// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    #pragma warning disable CS1591
    public class AlertEvidence : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The date and time when the evidence was created and added to the alert. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Detailed description of the entity role/s in an alert. Values are free-form.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DetailedRoles {
            get { return BackingStore?.Get<List<string>?>("detailedRoles"); }
            set { BackingStore?.Set("detailedRoles", value); }
        }
#nullable restore
#else
        public List<string> DetailedRoles {
            get { return BackingStore?.Get<List<string>>("detailedRoles"); }
            set { BackingStore?.Set("detailedRoles", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The remediationStatus property</summary>
        public EvidenceRemediationStatus? RemediationStatus {
            get { return BackingStore?.Get<EvidenceRemediationStatus?>("remediationStatus"); }
            set { BackingStore?.Set("remediationStatus", value); }
        }
        /// <summary>Details about the remediation status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemediationStatusDetails {
            get { return BackingStore?.Get<string?>("remediationStatusDetails"); }
            set { BackingStore?.Set("remediationStatusDetails", value); }
        }
#nullable restore
#else
        public string RemediationStatusDetails {
            get { return BackingStore?.Get<string>("remediationStatusDetails"); }
            set { BackingStore?.Set("remediationStatusDetails", value); }
        }
#endif
        /// <summary>The role/s that an evidence entity represents in an alert, for example, an IP address that is associated with an attacker has the evidence role Attacker.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EvidenceRole?>? Roles {
            get { return BackingStore?.Get<List<EvidenceRole?>?>("roles"); }
            set { BackingStore?.Set("roles", value); }
        }
#nullable restore
#else
        public List<EvidenceRole?> Roles {
            get { return BackingStore?.Get<List<EvidenceRole?>>("roles"); }
            set { BackingStore?.Set("roles", value); }
        }
#endif
        /// <summary>Array of custom tags associated with an evidence instance, for example, to denote a group of devices, high-value assets, etc.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags {
            get { return BackingStore?.Get<List<string>?>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#nullable restore
#else
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
#endif
        /// <summary>The verdict property</summary>
        public EvidenceVerdict? Verdict {
            get { return BackingStore?.Get<EvidenceVerdict?>("verdict"); }
            set { BackingStore?.Set("verdict", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="AlertEvidence"/> and sets the default values.
        /// </summary>
        public AlertEvidence()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AlertEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AlertEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.security.amazonResourceEvidence" => new AmazonResourceEvidence(),
                "#microsoft.graph.security.analyzedMessageEvidence" => new AnalyzedMessageEvidence(),
                "#microsoft.graph.security.azureResourceEvidence" => new AzureResourceEvidence(),
                "#microsoft.graph.security.blobContainerEvidence" => new BlobContainerEvidence(),
                "#microsoft.graph.security.blobEvidence" => new BlobEvidence(),
                "#microsoft.graph.security.cloudApplicationEvidence" => new CloudApplicationEvidence(),
                "#microsoft.graph.security.containerEvidence" => new ContainerEvidence(),
                "#microsoft.graph.security.containerImageEvidence" => new ContainerImageEvidence(),
                "#microsoft.graph.security.containerRegistryEvidence" => new ContainerRegistryEvidence(),
                "#microsoft.graph.security.deviceEvidence" => new DeviceEvidence(),
                "#microsoft.graph.security.dnsEvidence" => new DnsEvidence(),
                "#microsoft.graph.security.fileEvidence" => new FileEvidence(),
                "#microsoft.graph.security.fileHashEvidence" => new FileHashEvidence(),
                "#microsoft.graph.security.gitHubOrganizationEvidence" => new GitHubOrganizationEvidence(),
                "#microsoft.graph.security.gitHubRepoEvidence" => new GitHubRepoEvidence(),
                "#microsoft.graph.security.gitHubUserEvidence" => new GitHubUserEvidence(),
                "#microsoft.graph.security.googleCloudResourceEvidence" => new GoogleCloudResourceEvidence(),
                "#microsoft.graph.security.hostLogonSessionEvidence" => new HostLogonSessionEvidence(),
                "#microsoft.graph.security.ioTDeviceEvidence" => new IoTDeviceEvidence(),
                "#microsoft.graph.security.ipEvidence" => new IpEvidence(),
                "#microsoft.graph.security.kubernetesClusterEvidence" => new KubernetesClusterEvidence(),
                "#microsoft.graph.security.kubernetesControllerEvidence" => new KubernetesControllerEvidence(),
                "#microsoft.graph.security.kubernetesNamespaceEvidence" => new KubernetesNamespaceEvidence(),
                "#microsoft.graph.security.kubernetesPodEvidence" => new KubernetesPodEvidence(),
                "#microsoft.graph.security.kubernetesSecretEvidence" => new KubernetesSecretEvidence(),
                "#microsoft.graph.security.kubernetesServiceAccountEvidence" => new KubernetesServiceAccountEvidence(),
                "#microsoft.graph.security.kubernetesServiceEvidence" => new KubernetesServiceEvidence(),
                "#microsoft.graph.security.mailboxConfigurationEvidence" => new MailboxConfigurationEvidence(),
                "#microsoft.graph.security.mailboxEvidence" => new MailboxEvidence(),
                "#microsoft.graph.security.mailClusterEvidence" => new MailClusterEvidence(),
                "#microsoft.graph.security.malwareEvidence" => new MalwareEvidence(),
                "#microsoft.graph.security.networkConnectionEvidence" => new NetworkConnectionEvidence(),
                "#microsoft.graph.security.nicEvidence" => new NicEvidence(),
                "#microsoft.graph.security.oauthApplicationEvidence" => new OauthApplicationEvidence(),
                "#microsoft.graph.security.processEvidence" => new ProcessEvidence(),
                "#microsoft.graph.security.registryKeyEvidence" => new RegistryKeyEvidence(),
                "#microsoft.graph.security.registryValueEvidence" => new RegistryValueEvidence(),
                "#microsoft.graph.security.sasTokenEvidence" => new SasTokenEvidence(),
                "#microsoft.graph.security.securityGroupEvidence" => new SecurityGroupEvidence(),
                "#microsoft.graph.security.servicePrincipalEvidence" => new ServicePrincipalEvidence(),
                "#microsoft.graph.security.submissionMailEvidence" => new SubmissionMailEvidence(),
                "#microsoft.graph.security.urlEvidence" => new UrlEvidence(),
                "#microsoft.graph.security.userEvidence" => new UserEvidence(),
                _ => new AlertEvidence(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"detailedRoles", n => { DetailedRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"remediationStatus", n => { RemediationStatus = n.GetEnumValue<EvidenceRemediationStatus>(); } },
                {"remediationStatusDetails", n => { RemediationStatusDetails = n.GetStringValue(); } },
                {"roles", n => { Roles = n.GetCollectionOfEnumValues<EvidenceRole>()?.ToList(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"verdict", n => { Verdict = n.GetEnumValue<EvidenceVerdict>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("detailedRoles", DetailedRoles);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<EvidenceRemediationStatus>("remediationStatus", RemediationStatus);
            writer.WriteStringValue("remediationStatusDetails", RemediationStatusDetails);
            writer.WriteCollectionOfEnumValues<EvidenceRole>("roles", Roles);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteEnumValue<EvidenceVerdict>("verdict", Verdict);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
