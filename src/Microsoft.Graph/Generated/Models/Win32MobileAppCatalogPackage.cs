// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// win32MobileAppCatalogPackage extends mobileAppCatalogPackage by providing information necessary for the creation of a win32CatalogApp instance.
    /// </summary>
    public class Win32MobileAppCatalogPackage : Microsoft.Graph.Beta.Models.MobileAppCatalogPackage, IParsable
    {
        /// <summary>Contains properties for Windows architecture.</summary>
        public Microsoft.Graph.Beta.Models.WindowsArchitecture? ApplicableArchitectures
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsArchitecture?>("applicableArchitectures"); }
            set { BackingStore?.Set("applicableArchitectures", value); }
        }
        /// <summary>The product branch name, which is a specific subset of product functionality as defined by the publisher (example: &quot;Fabrikam for Business (x64)&quot;). A specific product will have one or more branchDisplayNames. Read-only. Supports $filter, $search, $select. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BranchDisplayName
        {
            get { return BackingStore?.Get<string?>("branchDisplayName"); }
            set { BackingStore?.Set("branchDisplayName", value); }
        }
#nullable restore
#else
        public string BranchDisplayName
        {
            get { return BackingStore?.Get<string>("branchDisplayName"); }
            set { BackingStore?.Set("branchDisplayName", value); }
        }
#endif
        /// <summary>One or more locale(s) supported by the branch. Value is a two-letter ISO 639 language tags with optional two-letter subtags (example: en-US, ko, de, de-DE), or mul to indicate multi-language. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Locales
        {
            get { return BackingStore?.Get<List<string>?>("locales"); }
            set { BackingStore?.Set("locales", value); }
        }
#nullable restore
#else
        public List<string> Locales
        {
            get { return BackingStore?.Get<List<string>>("locales"); }
            set { BackingStore?.Set("locales", value); }
        }
#endif
        /// <summary>Indicates whether the package is capable to auto-update to latest when software/application updates are available. When TRUE, it indicates it is an auto-updating application. When FALSE, it indicates that it is not an auto-updating application. This property is read-only.</summary>
        public bool? PackageAutoUpdateCapable
        {
            get { return BackingStore?.Get<bool?>("packageAutoUpdateCapable"); }
            set { BackingStore?.Set("packageAutoUpdateCapable", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Win32MobileAppCatalogPackage"/> and sets the default values.
        /// </summary>
        public Win32MobileAppCatalogPackage() : base()
        {
            OdataType = "#microsoft.graph.win32MobileAppCatalogPackage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Win32MobileAppCatalogPackage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Win32MobileAppCatalogPackage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Win32MobileAppCatalogPackage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "applicableArchitectures", n => { ApplicableArchitectures = n.GetEnumValue<Microsoft.Graph.Beta.Models.WindowsArchitecture>(); } },
                { "branchDisplayName", n => { BranchDisplayName = n.GetStringValue(); } },
                { "locales", n => { Locales = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "packageAutoUpdateCapable", n => { PackageAutoUpdateCapable = n.GetBoolValue(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.WindowsArchitecture>("applicableArchitectures", ApplicableArchitectures);
        }
    }
}
