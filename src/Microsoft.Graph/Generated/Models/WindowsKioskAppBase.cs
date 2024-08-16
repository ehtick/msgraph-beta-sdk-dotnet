// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The base class for a type of apps
    /// </summary>
    public class WindowsKioskAppBase : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The type of Windows kiosk app.</summary>
        public Microsoft.Graph.Beta.Models.WindowsKioskAppType? AppType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsKioskAppType?>("appType"); }
            set { BackingStore?.Set("appType", value); }
        }
        /// <summary>Allow the app to be auto-launched in multi-app kiosk mode</summary>
        public bool? AutoLaunch
        {
            get { return BackingStore?.Get<bool?>("autoLaunch"); }
            set { BackingStore?.Set("autoLaunch", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Represents the friendly name of an app</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The tile size of Windows app in the start layout.</summary>
        public Microsoft.Graph.Beta.Models.WindowsAppStartLayoutTileSize? StartLayoutTileSize
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsAppStartLayoutTileSize?>("startLayoutTileSize"); }
            set { BackingStore?.Set("startLayoutTileSize", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.WindowsKioskAppBase"/> and sets the default values.
        /// </summary>
        public WindowsKioskAppBase()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsKioskAppBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.WindowsKioskAppBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.windowsKioskDesktopApp" => new Microsoft.Graph.Beta.Models.WindowsKioskDesktopApp(),
                "#microsoft.graph.windowsKioskUWPApp" => new Microsoft.Graph.Beta.Models.WindowsKioskUWPApp(),
                "#microsoft.graph.windowsKioskWin32App" => new Microsoft.Graph.Beta.Models.WindowsKioskWin32App(),
                _ => new Microsoft.Graph.Beta.Models.WindowsKioskAppBase(),
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
                { "appType", n => { AppType = n.GetEnumValue<Microsoft.Graph.Beta.Models.WindowsKioskAppType>(); } },
                { "autoLaunch", n => { AutoLaunch = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "startLayoutTileSize", n => { StartLayoutTileSize = n.GetEnumValue<Microsoft.Graph.Beta.Models.WindowsAppStartLayoutTileSize>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.WindowsKioskAppType>("appType", AppType);
            writer.WriteBoolValue("autoLaunch", AutoLaunch);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.WindowsAppStartLayoutTileSize>("startLayoutTileSize", StartLayoutTileSize);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
