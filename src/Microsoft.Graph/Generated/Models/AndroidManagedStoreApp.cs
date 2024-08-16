// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Contains properties and inherited properties for Android Managed Store Apps.
    /// </summary>
    public class AndroidManagedStoreApp : Microsoft.Graph.Beta.Models.MobileApp, IParsable
    {
        /// <summary>The Identity Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppIdentifier
        {
            get { return BackingStore?.Get<string?>("appIdentifier"); }
            set { BackingStore?.Set("appIdentifier", value); }
        }
#nullable restore
#else
        public string AppIdentifier
        {
            get { return BackingStore?.Get<string>("appIdentifier"); }
            set { BackingStore?.Set("appIdentifier", value); }
        }
#endif
        /// <summary>The Play for Work Store app URL. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppStoreUrl
        {
            get { return BackingStore?.Get<string?>("appStoreUrl"); }
            set { BackingStore?.Set("appStoreUrl", value); }
        }
#nullable restore
#else
        public string AppStoreUrl
        {
            get { return BackingStore?.Get<string>("appStoreUrl"); }
            set { BackingStore?.Set("appStoreUrl", value); }
        }
#endif
        /// <summary>The tracks that are visible to this enterprise. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AndroidManagedStoreAppTrack>? AppTracks
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AndroidManagedStoreAppTrack>?>("appTracks"); }
            set { BackingStore?.Set("appTracks", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AndroidManagedStoreAppTrack> AppTracks
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AndroidManagedStoreAppTrack>>("appTracks"); }
            set { BackingStore?.Set("appTracks", value); }
        }
#endif
        /// <summary>Indicates whether the app is only available to a given enterprise&apos;s users. This property is read-only.</summary>
        public bool? IsPrivate
        {
            get { return BackingStore?.Get<bool?>("isPrivate"); }
            set { BackingStore?.Set("isPrivate", value); }
        }
        /// <summary>Indicates whether the app is a preinstalled system app.</summary>
        public bool? IsSystemApp
        {
            get { return BackingStore?.Get<bool?>("isSystemApp"); }
            set { BackingStore?.Set("isSystemApp", value); }
        }
        /// <summary>The package identifier. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PackageId
        {
            get { return BackingStore?.Get<string?>("packageId"); }
            set { BackingStore?.Set("packageId", value); }
        }
#nullable restore
#else
        public string PackageId
        {
            get { return BackingStore?.Get<string>("packageId"); }
            set { BackingStore?.Set("packageId", value); }
        }
#endif
        /// <summary>Whether this app supports OEMConfig policy. This property is read-only.</summary>
        public bool? SupportsOemConfig
        {
            get { return BackingStore?.Get<bool?>("supportsOemConfig"); }
            set { BackingStore?.Set("supportsOemConfig", value); }
        }
        /// <summary>The total number of VPP licenses. This property is read-only.</summary>
        public int? TotalLicenseCount
        {
            get { return BackingStore?.Get<int?>("totalLicenseCount"); }
            set { BackingStore?.Set("totalLicenseCount", value); }
        }
        /// <summary>The number of VPP licenses in use. This property is read-only.</summary>
        public int? UsedLicenseCount
        {
            get { return BackingStore?.Get<int?>("usedLicenseCount"); }
            set { BackingStore?.Set("usedLicenseCount", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.AndroidManagedStoreApp"/> and sets the default values.
        /// </summary>
        public AndroidManagedStoreApp() : base()
        {
            OdataType = "#microsoft.graph.androidManagedStoreApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AndroidManagedStoreApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AndroidManagedStoreApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidManagedStoreWebApp" => new Microsoft.Graph.Beta.Models.AndroidManagedStoreWebApp(),
                _ => new Microsoft.Graph.Beta.Models.AndroidManagedStoreApp(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appIdentifier", n => { AppIdentifier = n.GetStringValue(); } },
                { "appStoreUrl", n => { AppStoreUrl = n.GetStringValue(); } },
                { "appTracks", n => { AppTracks = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AndroidManagedStoreAppTrack>(Microsoft.Graph.Beta.Models.AndroidManagedStoreAppTrack.CreateFromDiscriminatorValue)?.ToList(); } },
                { "isPrivate", n => { IsPrivate = n.GetBoolValue(); } },
                { "isSystemApp", n => { IsSystemApp = n.GetBoolValue(); } },
                { "packageId", n => { PackageId = n.GetStringValue(); } },
                { "supportsOemConfig", n => { SupportsOemConfig = n.GetBoolValue(); } },
                { "totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                { "usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
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
            writer.WriteStringValue("appIdentifier", AppIdentifier);
            writer.WriteBoolValue("isSystemApp", IsSystemApp);
        }
    }
}
