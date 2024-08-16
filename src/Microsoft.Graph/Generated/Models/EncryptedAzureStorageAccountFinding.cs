// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class EncryptedAzureStorageAccountFinding : Microsoft.Graph.Beta.Models.Finding, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The encryptionManagedBy property</summary>
        public Microsoft.Graph.Beta.Models.AzureEncryption? EncryptionManagedBy
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AzureEncryption?>("encryptionManagedBy"); }
            set { BackingStore?.Set("encryptionManagedBy", value); }
        }
        /// <summary>The storageAccount property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AuthorizationSystemResource? StorageAccount
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthorizationSystemResource?>("storageAccount"); }
            set { BackingStore?.Set("storageAccount", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AuthorizationSystemResource StorageAccount
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthorizationSystemResource>("storageAccount"); }
            set { BackingStore?.Set("storageAccount", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.EncryptedAzureStorageAccountFinding"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.EncryptedAzureStorageAccountFinding CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.EncryptedAzureStorageAccountFinding();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "encryptionManagedBy", n => { EncryptionManagedBy = n.GetEnumValue<Microsoft.Graph.Beta.Models.AzureEncryption>(); } },
                { "storageAccount", n => { StorageAccount = n.GetObjectValue<Microsoft.Graph.Beta.Models.AuthorizationSystemResource>(Microsoft.Graph.Beta.Models.AuthorizationSystemResource.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.AzureEncryption>("encryptionManagedBy", EncryptionManagedBy);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AuthorizationSystemResource>("storageAccount", StorageAccount);
        }
    }
}
