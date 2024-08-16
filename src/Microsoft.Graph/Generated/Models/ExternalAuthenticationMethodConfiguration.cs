// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ExternalAuthenticationMethodConfiguration : Microsoft.Graph.Beta.Models.AuthenticationMethodConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>appId for the app registration in Microsoft Entra ID representing the integration with the external provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId
        {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId
        {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>Display name for the external authentication method. This name is shown to users during sign-in.</summary>
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
        /// <summary>A collection of groups that are enabled to use an authentication method as part of an authentication method policy in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AuthenticationMethodTarget>? IncludeTargets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AuthenticationMethodTarget>?>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AuthenticationMethodTarget> IncludeTargets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AuthenticationMethodTarget>>("includeTargets"); }
            set { BackingStore?.Set("includeTargets", value); }
        }
#endif
        /// <summary>The openIdConnectSetting property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.OpenIdConnectSetting? OpenIdConnectSetting
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OpenIdConnectSetting?>("openIdConnectSetting"); }
            set { BackingStore?.Set("openIdConnectSetting", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.OpenIdConnectSetting OpenIdConnectSetting
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OpenIdConnectSetting>("openIdConnectSetting"); }
            set { BackingStore?.Set("openIdConnectSetting", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.ExternalAuthenticationMethodConfiguration"/> and sets the default values.
        /// </summary>
        public ExternalAuthenticationMethodConfiguration() : base()
        {
            OdataType = "#microsoft.graph.externalAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ExternalAuthenticationMethodConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ExternalAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ExternalAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AuthenticationMethodTarget>(Microsoft.Graph.Beta.Models.AuthenticationMethodTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                { "openIdConnectSetting", n => { OpenIdConnectSetting = n.GetObjectValue<Microsoft.Graph.Beta.Models.OpenIdConnectSetting>(Microsoft.Graph.Beta.Models.OpenIdConnectSetting.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AuthenticationMethodTarget>("includeTargets", IncludeTargets);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.OpenIdConnectSetting>("openIdConnectSetting", OpenIdConnectSetting);
        }
    }
}
