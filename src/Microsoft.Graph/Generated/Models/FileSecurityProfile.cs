// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class FileSecurityProfile : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The activityGroupNames property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ActivityGroupNames
        {
            get { return BackingStore?.Get<List<string>?>("activityGroupNames"); }
            set { BackingStore?.Set("activityGroupNames", value); }
        }
#nullable restore
#else
        public List<string> ActivityGroupNames
        {
            get { return BackingStore?.Get<List<string>>("activityGroupNames"); }
            set { BackingStore?.Set("activityGroupNames", value); }
        }
#endif
        /// <summary>The azureSubscriptionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureSubscriptionId
        {
            get { return BackingStore?.Get<string?>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
#nullable restore
#else
        public string AzureSubscriptionId
        {
            get { return BackingStore?.Get<string>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
#endif
        /// <summary>The azureTenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureTenantId
        {
            get { return BackingStore?.Get<string?>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#nullable restore
#else
        public string AzureTenantId
        {
            get { return BackingStore?.Get<string>("azureTenantId"); }
            set { BackingStore?.Set("azureTenantId", value); }
        }
#endif
        /// <summary>The certificateThumbprint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateThumbprint
        {
            get { return BackingStore?.Get<string?>("certificateThumbprint"); }
            set { BackingStore?.Set("certificateThumbprint", value); }
        }
#nullable restore
#else
        public string CertificateThumbprint
        {
            get { return BackingStore?.Get<string>("certificateThumbprint"); }
            set { BackingStore?.Set("certificateThumbprint", value); }
        }
#endif
        /// <summary>The extensions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Extensions
        {
            get { return BackingStore?.Get<List<string>?>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#nullable restore
#else
        public List<string> Extensions
        {
            get { return BackingStore?.Get<List<string>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#endif
        /// <summary>The fileType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileType
        {
            get { return BackingStore?.Get<string?>("fileType"); }
            set { BackingStore?.Set("fileType", value); }
        }
#nullable restore
#else
        public string FileType
        {
            get { return BackingStore?.Get<string>("fileType"); }
            set { BackingStore?.Set("fileType", value); }
        }
#endif
        /// <summary>The firstSeenDateTime property</summary>
        public DateTimeOffset? FirstSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("firstSeenDateTime"); }
            set { BackingStore?.Set("firstSeenDateTime", value); }
        }
        /// <summary>The hashes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.FileHash>? Hashes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.FileHash>?>("hashes"); }
            set { BackingStore?.Set("hashes", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.FileHash> Hashes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.FileHash>>("hashes"); }
            set { BackingStore?.Set("hashes", value); }
        }
#endif
        /// <summary>The lastSeenDateTime property</summary>
        public DateTimeOffset? LastSeenDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSeenDateTime"); }
            set { BackingStore?.Set("lastSeenDateTime", value); }
        }
        /// <summary>The malwareStates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.MalwareState>? MalwareStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MalwareState>?>("malwareStates"); }
            set { BackingStore?.Set("malwareStates", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.MalwareState> MalwareStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MalwareState>>("malwareStates"); }
            set { BackingStore?.Set("malwareStates", value); }
        }
#endif
        /// <summary>The names property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Names
        {
            get { return BackingStore?.Get<List<string>?>("names"); }
            set { BackingStore?.Set("names", value); }
        }
#nullable restore
#else
        public List<string> Names
        {
            get { return BackingStore?.Get<List<string>>("names"); }
            set { BackingStore?.Set("names", value); }
        }
#endif
        /// <summary>The riskScore property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RiskScore
        {
            get { return BackingStore?.Get<string?>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
#nullable restore
#else
        public string RiskScore
        {
            get { return BackingStore?.Get<string>("riskScore"); }
            set { BackingStore?.Set("riskScore", value); }
        }
#endif
        /// <summary>The size property</summary>
        public long? Size
        {
            get { return BackingStore?.Get<long?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>The tags property</summary>
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
        /// <summary>The vendorInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SecurityVendorInformation? VendorInformation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SecurityVendorInformation?>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SecurityVendorInformation VendorInformation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SecurityVendorInformation>("vendorInformation"); }
            set { BackingStore?.Set("vendorInformation", value); }
        }
#endif
        /// <summary>The vulnerabilityStates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.VulnerabilityState>? VulnerabilityStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.VulnerabilityState>?>("vulnerabilityStates"); }
            set { BackingStore?.Set("vulnerabilityStates", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.VulnerabilityState> VulnerabilityStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.VulnerabilityState>>("vulnerabilityStates"); }
            set { BackingStore?.Set("vulnerabilityStates", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.FileSecurityProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.FileSecurityProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.FileSecurityProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activityGroupNames", n => { ActivityGroupNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                { "azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                { "certificateThumbprint", n => { CertificateThumbprint = n.GetStringValue(); } },
                { "extensions", n => { Extensions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "fileType", n => { FileType = n.GetStringValue(); } },
                { "firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "hashes", n => { Hashes = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.FileHash>(Microsoft.Graph.Beta.Models.FileHash.CreateFromDiscriminatorValue)?.ToList(); } },
                { "lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "malwareStates", n => { MalwareStates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MalwareState>(Microsoft.Graph.Beta.Models.MalwareState.CreateFromDiscriminatorValue)?.ToList(); } },
                { "names", n => { Names = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "riskScore", n => { RiskScore = n.GetStringValue(); } },
                { "size", n => { Size = n.GetLongValue(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "vendorInformation", n => { VendorInformation = n.GetObjectValue<Microsoft.Graph.Beta.Models.SecurityVendorInformation>(Microsoft.Graph.Beta.Models.SecurityVendorInformation.CreateFromDiscriminatorValue); } },
                { "vulnerabilityStates", n => { VulnerabilityStates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.VulnerabilityState>(Microsoft.Graph.Beta.Models.VulnerabilityState.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("activityGroupNames", ActivityGroupNames);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteStringValue("certificateThumbprint", CertificateThumbprint);
            writer.WriteCollectionOfPrimitiveValues<string>("extensions", Extensions);
            writer.WriteStringValue("fileType", FileType);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.FileHash>("hashes", Hashes);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MalwareState>("malwareStates", MalwareStates);
            writer.WriteCollectionOfPrimitiveValues<string>("names", Names);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteLongValue("size", Size);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SecurityVendorInformation>("vendorInformation", VendorInformation);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.VulnerabilityState>("vulnerabilityStates", VulnerabilityStates);
        }
    }
}
