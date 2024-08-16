// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class X509CertificateAuthenticationMethodConfiguration : Microsoft.Graph.Beta.Models.AuthenticationMethodConfiguration, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defines strong authentication configurations. This configuration includes the default authentication mode and the different rules for strong authentication bindings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.X509CertificateAuthenticationModeConfiguration? AuthenticationModeConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.X509CertificateAuthenticationModeConfiguration?>("authenticationModeConfiguration"); }
            set { BackingStore?.Set("authenticationModeConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.X509CertificateAuthenticationModeConfiguration AuthenticationModeConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.X509CertificateAuthenticationModeConfiguration>("authenticationModeConfiguration"); }
            set { BackingStore?.Set("authenticationModeConfiguration", value); }
        }
#endif
        /// <summary>Defines fields in the X.509 certificate that map to attributes of the Microsoft Entra user object in order to bind the certificate to the user. The priority of the object determines the order in which the binding is carried out. The first binding that matches will be used and the rest ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.X509CertificateUserBinding>? CertificateUserBindings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.X509CertificateUserBinding>?>("certificateUserBindings"); }
            set { BackingStore?.Set("certificateUserBindings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.X509CertificateUserBinding> CertificateUserBindings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.X509CertificateUserBinding>>("certificateUserBindings"); }
            set { BackingStore?.Set("certificateUserBindings", value); }
        }
#endif
        /// <summary>A collection of groups that are enabled to use the authentication method.</summary>
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
        /// <summary>Determines whether issuer(CA) hints are sent back to the client side to filter the certificates shown in certificate picker.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.X509CertificateIssuerHintsConfiguration? IssuerHintsConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.X509CertificateIssuerHintsConfiguration?>("issuerHintsConfiguration"); }
            set { BackingStore?.Set("issuerHintsConfiguration", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.X509CertificateIssuerHintsConfiguration IssuerHintsConfiguration
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.X509CertificateIssuerHintsConfiguration>("issuerHintsConfiguration"); }
            set { BackingStore?.Set("issuerHintsConfiguration", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.X509CertificateAuthenticationMethodConfiguration"/> and sets the default values.
        /// </summary>
        public X509CertificateAuthenticationMethodConfiguration() : base()
        {
            OdataType = "#microsoft.graph.x509CertificateAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.X509CertificateAuthenticationMethodConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.X509CertificateAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.X509CertificateAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "authenticationModeConfiguration", n => { AuthenticationModeConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.X509CertificateAuthenticationModeConfiguration>(Microsoft.Graph.Beta.Models.X509CertificateAuthenticationModeConfiguration.CreateFromDiscriminatorValue); } },
                { "certificateUserBindings", n => { CertificateUserBindings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.X509CertificateUserBinding>(Microsoft.Graph.Beta.Models.X509CertificateUserBinding.CreateFromDiscriminatorValue)?.ToList(); } },
                { "includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AuthenticationMethodTarget>(Microsoft.Graph.Beta.Models.AuthenticationMethodTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                { "issuerHintsConfiguration", n => { IssuerHintsConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.X509CertificateIssuerHintsConfiguration>(Microsoft.Graph.Beta.Models.X509CertificateIssuerHintsConfiguration.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.X509CertificateAuthenticationModeConfiguration>("authenticationModeConfiguration", AuthenticationModeConfiguration);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.X509CertificateUserBinding>("certificateUserBindings", CertificateUserBindings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AuthenticationMethodTarget>("includeTargets", IncludeTargets);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.X509CertificateIssuerHintsConfiguration>("issuerHintsConfiguration", IssuerHintsConfiguration);
        }
    }
}
