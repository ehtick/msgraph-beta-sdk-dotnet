// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Drives.Item.Items.Item.Preview {
    #pragma warning disable CS1591
    public class PreviewPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The allowEdit property</summary>
        public bool? AllowEdit {
            get { return BackingStore?.Get<bool?>("allowEdit"); }
            set { BackingStore?.Set("allowEdit", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The chromeless property</summary>
        public bool? Chromeless {
            get { return BackingStore?.Get<bool?>("chromeless"); }
            set { BackingStore?.Set("chromeless", value); }
        }
        /// <summary>The page property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Page {
            get { return BackingStore?.Get<string?>("page"); }
            set { BackingStore?.Set("page", value); }
        }
#nullable restore
#else
        public string Page {
            get { return BackingStore?.Get<string>("page"); }
            set { BackingStore?.Set("page", value); }
        }
#endif
        /// <summary>The viewer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Viewer {
            get { return BackingStore?.Get<string?>("viewer"); }
            set { BackingStore?.Set("viewer", value); }
        }
#nullable restore
#else
        public string Viewer {
            get { return BackingStore?.Get<string>("viewer"); }
            set { BackingStore?.Set("viewer", value); }
        }
#endif
        /// <summary>The zoom property</summary>
        public double? Zoom {
            get { return BackingStore?.Get<double?>("zoom"); }
            set { BackingStore?.Set("zoom", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="PreviewPostRequestBody"/> and sets the default values.
        /// </summary>
        public PreviewPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PreviewPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PreviewPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PreviewPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"allowEdit", n => { AllowEdit = n.GetBoolValue(); } },
                {"chromeless", n => { Chromeless = n.GetBoolValue(); } },
                {"page", n => { Page = n.GetStringValue(); } },
                {"viewer", n => { Viewer = n.GetStringValue(); } },
                {"zoom", n => { Zoom = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowEdit", AllowEdit);
            writer.WriteBoolValue("chromeless", Chromeless);
            writer.WriteStringValue("page", Page);
            writer.WriteStringValue("viewer", Viewer);
            writer.WriteDoubleValue("zoom", Zoom);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
