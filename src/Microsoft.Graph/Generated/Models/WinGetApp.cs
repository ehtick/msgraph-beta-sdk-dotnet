// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// A MobileApp that is based on a referenced application in a WinGet repository.
    /// </summary>
    public class WinGetApp : Microsoft.Graph.Beta.Models.MobileApp, IParsable
    {
        /// <summary>The install experience settings associated with this application, which are used to ensure the desired install experiences on the target device are taken into account. This includes the account type (System or User) that actions should be run as on target devices. Required at creation time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WinGetAppInstallExperience? InstallExperience
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WinGetAppInstallExperience?>("installExperience"); }
            set { BackingStore?.Set("installExperience", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WinGetAppInstallExperience InstallExperience
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WinGetAppInstallExperience>("installExperience"); }
            set { BackingStore?.Set("installExperience", value); }
        }
#endif
        /// <summary>Hash of package metadata properties used to validate that the application matches the metadata in the source repository.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManifestHash
        {
            get { return BackingStore?.Get<string?>("manifestHash"); }
            set { BackingStore?.Set("manifestHash", value); }
        }
#nullable restore
#else
        public string ManifestHash
        {
            get { return BackingStore?.Get<string>("manifestHash"); }
            set { BackingStore?.Set("manifestHash", value); }
        }
#endif
        /// <summary>The PackageIdentifier from the WinGet source repository REST API. This also maps to the Id when using the WinGet client command line application. Required at creation time, cannot be modified on existing objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageIdentifier
        {
            get { return BackingStore?.Get<string?>("packageIdentifier"); }
            set { BackingStore?.Set("packageIdentifier", value); }
        }
#nullable restore
#else
        public string PackageIdentifier
        {
            get { return BackingStore?.Get<string>("packageIdentifier"); }
            set { BackingStore?.Set("packageIdentifier", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.WinGetApp"/> and sets the default values.
        /// </summary>
        public WinGetApp() : base()
        {
            OdataType = "#microsoft.graph.winGetApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WinGetApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.WinGetApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.WinGetApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "installExperience", n => { InstallExperience = n.GetObjectValue<Microsoft.Graph.Beta.Models.WinGetAppInstallExperience>(Microsoft.Graph.Beta.Models.WinGetAppInstallExperience.CreateFromDiscriminatorValue); } },
                { "manifestHash", n => { ManifestHash = n.GetStringValue(); } },
                { "packageIdentifier", n => { PackageIdentifier = n.GetStringValue(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WinGetAppInstallExperience>("installExperience", InstallExperience);
            writer.WriteStringValue("manifestHash", ManifestHash);
            writer.WriteStringValue("packageIdentifier", PackageIdentifier);
        }
    }
}
