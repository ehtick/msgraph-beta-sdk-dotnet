// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ApplicationTemplate : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list of categories for the application. Supported values can be: Collaboration, Business Management, Consumer, Content management, CRM, Data services, Developer services, E-commerce, Education, ERP, Finance, Health, Human resources, IT infrastructure, Mail, Management, Marketing, Media, Productivity, Project management, Telecommunications, Tools, Travel, and Web design &amp; hosting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Categories
        {
            get { return BackingStore?.Get<List<string>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<string> Categories
        {
            get { return BackingStore?.Get<List<string>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>A description of the application.</summary>
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
        /// <summary>The name of the application.</summary>
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
        /// <summary>The home page URL of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HomePageUrl
        {
            get { return BackingStore?.Get<string?>("homePageUrl"); }
            set { BackingStore?.Set("homePageUrl", value); }
        }
#nullable restore
#else
        public string HomePageUrl
        {
            get { return BackingStore?.Get<string>("homePageUrl"); }
            set { BackingStore?.Set("homePageUrl", value); }
        }
#endif
        /// <summary>The informationalUrls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.InformationalUrls? InformationalUrls
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InformationalUrls?>("informationalUrls"); }
            set { BackingStore?.Set("informationalUrls", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.InformationalUrls InformationalUrls
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InformationalUrls>("informationalUrls"); }
            set { BackingStore?.Set("informationalUrls", value); }
        }
#endif
        /// <summary>The URL to get the logo for this application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogoUrl
        {
            get { return BackingStore?.Get<string?>("logoUrl"); }
            set { BackingStore?.Set("logoUrl", value); }
        }
#nullable restore
#else
        public string LogoUrl
        {
            get { return BackingStore?.Get<string>("logoUrl"); }
            set { BackingStore?.Set("logoUrl", value); }
        }
#endif
        /// <summary>The name of the publisher for this application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Publisher
        {
            get { return BackingStore?.Get<string?>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#nullable restore
#else
        public string Publisher
        {
            get { return BackingStore?.Get<string>("publisher"); }
            set { BackingStore?.Set("publisher", value); }
        }
#endif
        /// <summary>The supportedClaimConfiguration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SupportedClaimConfiguration? SupportedClaimConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SupportedClaimConfiguration?>("supportedClaimConfiguration"); }
            set { BackingStore?.Set("supportedClaimConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SupportedClaimConfiguration SupportedClaimConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SupportedClaimConfiguration>("supportedClaimConfiguration"); }
            set { BackingStore?.Set("supportedClaimConfiguration", value); }
        }
#endif
        /// <summary>The list of provisioning modes supported by this application. The only valid value is sync.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedProvisioningTypes
        {
            get { return BackingStore?.Get<List<string>?>("supportedProvisioningTypes"); }
            set { BackingStore?.Set("supportedProvisioningTypes", value); }
        }
#nullable restore
#else
        public List<string> SupportedProvisioningTypes
        {
            get { return BackingStore?.Get<List<string>>("supportedProvisioningTypes"); }
            set { BackingStore?.Set("supportedProvisioningTypes", value); }
        }
#endif
        /// <summary>The list of single sign-on modes supported by this application. The supported values are oidc, password, saml, and notSupported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SupportedSingleSignOnModes
        {
            get { return BackingStore?.Get<List<string>?>("supportedSingleSignOnModes"); }
            set { BackingStore?.Set("supportedSingleSignOnModes", value); }
        }
#nullable restore
#else
        public List<string> SupportedSingleSignOnModes
        {
            get { return BackingStore?.Get<List<string>>("supportedSingleSignOnModes"); }
            set { BackingStore?.Set("supportedSingleSignOnModes", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ApplicationTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ApplicationTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ApplicationTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "homePageUrl", n => { HomePageUrl = n.GetStringValue(); } },
                { "informationalUrls", n => { InformationalUrls = n.GetObjectValue<Microsoft.Graph.Beta.Models.InformationalUrls>(Microsoft.Graph.Beta.Models.InformationalUrls.CreateFromDiscriminatorValue); } },
                { "logoUrl", n => { LogoUrl = n.GetStringValue(); } },
                { "publisher", n => { Publisher = n.GetStringValue(); } },
                { "supportedClaimConfiguration", n => { SupportedClaimConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.SupportedClaimConfiguration>(Microsoft.Graph.Beta.Models.SupportedClaimConfiguration.CreateFromDiscriminatorValue); } },
                { "supportedProvisioningTypes", n => { SupportedProvisioningTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "supportedSingleSignOnModes", n => { SupportedSingleSignOnModes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("homePageUrl", HomePageUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.InformationalUrls>("informationalUrls", InformationalUrls);
            writer.WriteStringValue("logoUrl", LogoUrl);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SupportedClaimConfiguration>("supportedClaimConfiguration", SupportedClaimConfiguration);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedProvisioningTypes", SupportedProvisioningTypes);
            writer.WriteCollectionOfPrimitiveValues<string>("supportedSingleSignOnModes", SupportedSingleSignOnModes);
        }
    }
}
