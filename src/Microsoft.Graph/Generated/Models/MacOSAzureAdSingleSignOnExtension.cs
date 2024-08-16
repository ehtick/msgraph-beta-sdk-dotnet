// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Represents an Azure AD-type Single Sign-On extension profile for macOS devices.
    /// </summary>
    public class MacOSAzureAdSingleSignOnExtension : Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension, IParsable
    {
        /// <summary>An optional list of additional bundle IDs allowed to use the AAD extension for single sign-on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BundleIdAccessControlList
        {
            get { return BackingStore?.Get<List<string>?>("bundleIdAccessControlList"); }
            set { BackingStore?.Set("bundleIdAccessControlList", value); }
        }
#nullable restore
#else
        public List<string> BundleIdAccessControlList
        {
            get { return BackingStore?.Get<List<string>>("bundleIdAccessControlList"); }
            set { BackingStore?.Set("bundleIdAccessControlList", value); }
        }
#endif
        /// <summary>Gets or sets a list of typed key-value pairs used to configure Credential-type profiles. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.KeyTypedValuePair>? Configurations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyTypedValuePair>?>("configurations"); }
            set { BackingStore?.Set("configurations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.KeyTypedValuePair> Configurations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyTypedValuePair>>("configurations"); }
            set { BackingStore?.Set("configurations", value); }
        }
#endif
        /// <summary>Enables or disables shared device mode.</summary>
        public bool? EnableSharedDeviceMode
        {
            get { return BackingStore?.Get<bool?>("enableSharedDeviceMode"); }
            set { BackingStore?.Set("enableSharedDeviceMode", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.MacOSAzureAdSingleSignOnExtension"/> and sets the default values.
        /// </summary>
        public MacOSAzureAdSingleSignOnExtension() : base()
        {
            OdataType = "#microsoft.graph.macOSAzureAdSingleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MacOSAzureAdSingleSignOnExtension"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MacOSAzureAdSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MacOSAzureAdSingleSignOnExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "bundleIdAccessControlList", n => { BundleIdAccessControlList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "configurations", n => { Configurations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyTypedValuePair>(Microsoft.Graph.Beta.Models.KeyTypedValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                { "enableSharedDeviceMode", n => { EnableSharedDeviceMode = n.GetBoolValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("bundleIdAccessControlList", BundleIdAccessControlList);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyTypedValuePair>("configurations", Configurations);
            writer.WriteBoolValue("enableSharedDeviceMode", EnableSharedDeviceMode);
        }
    }
}
