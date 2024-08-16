// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class ThreatIntelligence : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Refers to indicators of threat or compromise highlighted in an article.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.ArticleIndicator>? ArticleIndicators
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.ArticleIndicator>?>("articleIndicators"); }
            set { BackingStore?.Set("articleIndicators", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.ArticleIndicator> ArticleIndicators
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.ArticleIndicator>>("articleIndicators"); }
            set { BackingStore?.Set("articleIndicators", value); }
        }
#endif
        /// <summary>A list of article objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.Article>? Articles
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.Article>?>("articles"); }
            set { BackingStore?.Set("articles", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.Article> Articles
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.Article>>("articles"); }
            set { BackingStore?.Set("articles", value); }
        }
#endif
        /// <summary>Retrieve details about hostComponent objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.HostComponent>? HostComponents
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostComponent>?>("hostComponents"); }
            set { BackingStore?.Set("hostComponents", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.HostComponent> HostComponents
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostComponent>>("hostComponents"); }
            set { BackingStore?.Set("hostComponents", value); }
        }
#endif
        /// <summary>Retrieve details about hostCookie objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.HostCookie>? HostCookies
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostCookie>?>("hostCookies"); }
            set { BackingStore?.Set("hostCookies", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.HostCookie> HostCookies
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostCookie>>("hostCookies"); }
            set { BackingStore?.Set("hostCookies", value); }
        }
#endif
        /// <summary>Retrieve details about hostTracker objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.HostPair>? HostPairs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostPair>?>("hostPairs"); }
            set { BackingStore?.Set("hostPairs", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.HostPair> HostPairs
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostPair>>("hostPairs"); }
            set { BackingStore?.Set("hostPairs", value); }
        }
#endif
        /// <summary>Retrieve details about hostPort objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.HostPort>? HostPorts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostPort>?>("hostPorts"); }
            set { BackingStore?.Set("hostPorts", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.HostPort> HostPorts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostPort>>("hostPorts"); }
            set { BackingStore?.Set("hostPorts", value); }
        }
#endif
        /// <summary>Refers to host objects that Microsoft Threat Intelligence has observed.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.Host>? Hosts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.Host>?>("hosts"); }
            set { BackingStore?.Set("hosts", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.Host> Hosts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.Host>>("hosts"); }
            set { BackingStore?.Set("hosts", value); }
        }
#endif
        /// <summary>Retrieve details about hostSslCertificate objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.HostSslCertificate>? HostSslCertificates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostSslCertificate>?>("hostSslCertificates"); }
            set { BackingStore?.Set("hostSslCertificates", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.HostSslCertificate> HostSslCertificates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostSslCertificate>>("hostSslCertificates"); }
            set { BackingStore?.Set("hostSslCertificates", value); }
        }
#endif
        /// <summary>Retrieve details about hostTracker objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.HostTracker>? HostTrackers
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostTracker>?>("hostTrackers"); }
            set { BackingStore?.Set("hostTrackers", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.HostTracker> HostTrackers
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.HostTracker>>("hostTrackers"); }
            set { BackingStore?.Set("hostTrackers", value); }
        }
#endif
        /// <summary>The intelligenceProfileIndicators property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator>? IntelligenceProfileIndicators
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator>?>("intelligenceProfileIndicators"); }
            set { BackingStore?.Set("intelligenceProfileIndicators", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator> IntelligenceProfileIndicators
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator>>("intelligenceProfileIndicators"); }
            set { BackingStore?.Set("intelligenceProfileIndicators", value); }
        }
#endif
        /// <summary>A list of intelligenceProfile objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfile>? IntelProfiles
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfile>?>("intelProfiles"); }
            set { BackingStore?.Set("intelProfiles", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfile> IntelProfiles
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.IntelligenceProfile>>("intelProfiles"); }
            set { BackingStore?.Set("intelProfiles", value); }
        }
#endif
        /// <summary>Retrieve details about passiveDnsRecord objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>? PassiveDnsRecords
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>?>("passiveDnsRecords"); }
            set { BackingStore?.Set("passiveDnsRecords", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord> PassiveDnsRecords
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>>("passiveDnsRecords"); }
            set { BackingStore?.Set("passiveDnsRecords", value); }
        }
#endif
        /// <summary>Retrieve details about sslCertificate objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.SslCertificate>? SslCertificates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.SslCertificate>?>("sslCertificates"); }
            set { BackingStore?.Set("sslCertificates", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.SslCertificate> SslCertificates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.SslCertificate>>("sslCertificates"); }
            set { BackingStore?.Set("sslCertificates", value); }
        }
#endif
        /// <summary>Retrieve details about the subdomain.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.Subdomain>? Subdomains
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.Subdomain>?>("subdomains"); }
            set { BackingStore?.Set("subdomains", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.Subdomain> Subdomains
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.Subdomain>>("subdomains"); }
            set { BackingStore?.Set("subdomains", value); }
        }
#endif
        /// <summary>Retrieve details about vulnerabilities.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.Vulnerability>? Vulnerabilities
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.Vulnerability>?>("vulnerabilities"); }
            set { BackingStore?.Set("vulnerabilities", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.Vulnerability> Vulnerabilities
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.Vulnerability>>("vulnerabilities"); }
            set { BackingStore?.Set("vulnerabilities", value); }
        }
#endif
        /// <summary>Retrieve details about whoisHistoryRecord objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.WhoisHistoryRecord>? WhoisHistoryRecords
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.WhoisHistoryRecord>?>("whoisHistoryRecords"); }
            set { BackingStore?.Set("whoisHistoryRecords", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.WhoisHistoryRecord> WhoisHistoryRecords
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.WhoisHistoryRecord>>("whoisHistoryRecords"); }
            set { BackingStore?.Set("whoisHistoryRecords", value); }
        }
#endif
        /// <summary>A list of whoisRecord objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.WhoisRecord>? WhoisRecords
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.WhoisRecord>?>("whoisRecords"); }
            set { BackingStore?.Set("whoisRecords", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.WhoisRecord> WhoisRecords
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.WhoisRecord>>("whoisRecords"); }
            set { BackingStore?.Set("whoisRecords", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.ThreatIntelligence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Security.ThreatIntelligence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.ThreatIntelligence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "articleIndicators", n => { ArticleIndicators = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.ArticleIndicator>(Microsoft.Graph.Beta.Models.Security.ArticleIndicator.CreateFromDiscriminatorValue)?.ToList(); } },
                { "articles", n => { Articles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.Article>(Microsoft.Graph.Beta.Models.Security.Article.CreateFromDiscriminatorValue)?.ToList(); } },
                { "hostComponents", n => { HostComponents = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostComponent>(Microsoft.Graph.Beta.Models.Security.HostComponent.CreateFromDiscriminatorValue)?.ToList(); } },
                { "hostCookies", n => { HostCookies = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostCookie>(Microsoft.Graph.Beta.Models.Security.HostCookie.CreateFromDiscriminatorValue)?.ToList(); } },
                { "hostPairs", n => { HostPairs = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostPair>(Microsoft.Graph.Beta.Models.Security.HostPair.CreateFromDiscriminatorValue)?.ToList(); } },
                { "hostPorts", n => { HostPorts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostPort>(Microsoft.Graph.Beta.Models.Security.HostPort.CreateFromDiscriminatorValue)?.ToList(); } },
                { "hostSslCertificates", n => { HostSslCertificates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostSslCertificate>(Microsoft.Graph.Beta.Models.Security.HostSslCertificate.CreateFromDiscriminatorValue)?.ToList(); } },
                { "hostTrackers", n => { HostTrackers = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostTracker>(Microsoft.Graph.Beta.Models.Security.HostTracker.CreateFromDiscriminatorValue)?.ToList(); } },
                { "hosts", n => { Hosts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.Host>(Microsoft.Graph.Beta.Models.Security.Host.CreateFromDiscriminatorValue)?.ToList(); } },
                { "intelProfiles", n => { IntelProfiles = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.IntelligenceProfile>(Microsoft.Graph.Beta.Models.Security.IntelligenceProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                { "intelligenceProfileIndicators", n => { IntelligenceProfileIndicators = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator>(Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator.CreateFromDiscriminatorValue)?.ToList(); } },
                { "passiveDnsRecords", n => { PassiveDnsRecords = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>(Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                { "sslCertificates", n => { SslCertificates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.SslCertificate>(Microsoft.Graph.Beta.Models.Security.SslCertificate.CreateFromDiscriminatorValue)?.ToList(); } },
                { "subdomains", n => { Subdomains = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.Subdomain>(Microsoft.Graph.Beta.Models.Security.Subdomain.CreateFromDiscriminatorValue)?.ToList(); } },
                { "vulnerabilities", n => { Vulnerabilities = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.Vulnerability>(Microsoft.Graph.Beta.Models.Security.Vulnerability.CreateFromDiscriminatorValue)?.ToList(); } },
                { "whoisHistoryRecords", n => { WhoisHistoryRecords = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.WhoisHistoryRecord>(Microsoft.Graph.Beta.Models.Security.WhoisHistoryRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                { "whoisRecords", n => { WhoisRecords = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.WhoisRecord>(Microsoft.Graph.Beta.Models.Security.WhoisRecord.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.ArticleIndicator>("articleIndicators", ArticleIndicators);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.Article>("articles", Articles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostComponent>("hostComponents", HostComponents);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostCookie>("hostCookies", HostCookies);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostPair>("hostPairs", HostPairs);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostPort>("hostPorts", HostPorts);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.Host>("hosts", Hosts);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostSslCertificate>("hostSslCertificates", HostSslCertificates);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.HostTracker>("hostTrackers", HostTrackers);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.IntelligenceProfileIndicator>("intelligenceProfileIndicators", IntelligenceProfileIndicators);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.IntelligenceProfile>("intelProfiles", IntelProfiles);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.PassiveDnsRecord>("passiveDnsRecords", PassiveDnsRecords);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.SslCertificate>("sslCertificates", SslCertificates);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.Subdomain>("subdomains", Subdomains);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.Vulnerability>("vulnerabilities", Vulnerabilities);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.WhoisHistoryRecord>("whoisHistoryRecords", WhoisHistoryRecords);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.WhoisRecord>("whoisRecords", WhoisRecords);
        }
    }
}
