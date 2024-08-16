// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class StrongAuthenticationDetail : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The encryptedPinHashHistory property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? EncryptedPinHashHistory
        {
            get { return BackingStore?.Get<byte[]?>("encryptedPinHashHistory"); }
            set { BackingStore?.Set("encryptedPinHashHistory", value); }
        }
#nullable restore
#else
        public byte[] EncryptedPinHashHistory
        {
            get { return BackingStore?.Get<byte[]>("encryptedPinHashHistory"); }
            set { BackingStore?.Set("encryptedPinHashHistory", value); }
        }
#endif
        /// <summary>The proofupTime property</summary>
        public long? ProofupTime
        {
            get { return BackingStore?.Get<long?>("proofupTime"); }
            set { BackingStore?.Set("proofupTime", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.StrongAuthenticationDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.StrongAuthenticationDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.StrongAuthenticationDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "encryptedPinHashHistory", n => { EncryptedPinHashHistory = n.GetByteArrayValue(); } },
                { "proofupTime", n => { ProofupTime = n.GetLongValue(); } },
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
            writer.WriteByteArrayValue("encryptedPinHashHistory", EncryptedPinHashHistory);
            writer.WriteLongValue("proofupTime", ProofupTime);
        }
    }
}
