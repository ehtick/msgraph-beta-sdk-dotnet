// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Me.InformationProtection.EncryptBuffer
{
    #pragma warning disable CS1591
    public class EncryptBufferPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The buffer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Buffer
        {
            get { return BackingStore?.Get<byte[]?>("buffer"); }
            set { BackingStore?.Set("buffer", value); }
        }
#nullable restore
#else
        public byte[] Buffer
        {
            get { return BackingStore?.Get<byte[]>("buffer"); }
            set { BackingStore?.Set("buffer", value); }
        }
#endif
        /// <summary>The labelId property</summary>
        public Guid? LabelId
        {
            get { return BackingStore?.Get<Guid?>("labelId"); }
            set { BackingStore?.Set("labelId", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Me.InformationProtection.EncryptBuffer.EncryptBufferPostRequestBody"/> and sets the default values.
        /// </summary>
        public EncryptBufferPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Me.InformationProtection.EncryptBuffer.EncryptBufferPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Me.InformationProtection.EncryptBuffer.EncryptBufferPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Me.InformationProtection.EncryptBuffer.EncryptBufferPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "buffer", n => { Buffer = n.GetByteArrayValue(); } },
                { "labelId", n => { LabelId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("buffer", Buffer);
            writer.WriteGuidValue("labelId", LabelId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
