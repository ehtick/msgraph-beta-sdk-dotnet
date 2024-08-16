// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class DlpEvaluationInput : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The currentLabel property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.CurrentLabel? CurrentLabel
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CurrentLabel?>("currentLabel"); }
            set { BackingStore?.Set("currentLabel", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.CurrentLabel CurrentLabel
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CurrentLabel>("currentLabel"); }
            set { BackingStore?.Set("currentLabel", value); }
        }
#endif
        /// <summary>The discoveredSensitiveTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DiscoveredSensitiveType>? DiscoveredSensitiveTypes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DiscoveredSensitiveType>?>("discoveredSensitiveTypes"); }
            set { BackingStore?.Set("discoveredSensitiveTypes", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DiscoveredSensitiveType> DiscoveredSensitiveTypes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DiscoveredSensitiveType>>("discoveredSensitiveTypes"); }
            set { BackingStore?.Set("discoveredSensitiveTypes", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.DlpEvaluationInput"/> and sets the default values.
        /// </summary>
        public DlpEvaluationInput()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DlpEvaluationInput"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.DlpEvaluationInput CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.dlpEvaluationWindowsDevicesInput" => new Microsoft.Graph.Beta.Models.DlpEvaluationWindowsDevicesInput(),
                _ => new Microsoft.Graph.Beta.Models.DlpEvaluationInput(),
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
                { "currentLabel", n => { CurrentLabel = n.GetObjectValue<Microsoft.Graph.Beta.Models.CurrentLabel>(Microsoft.Graph.Beta.Models.CurrentLabel.CreateFromDiscriminatorValue); } },
                { "discoveredSensitiveTypes", n => { DiscoveredSensitiveTypes = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DiscoveredSensitiveType>(Microsoft.Graph.Beta.Models.DiscoveredSensitiveType.CreateFromDiscriminatorValue)?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CurrentLabel>("currentLabel", CurrentLabel);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DiscoveredSensitiveType>("discoveredSensitiveTypes", DiscoveredSensitiveTypes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
