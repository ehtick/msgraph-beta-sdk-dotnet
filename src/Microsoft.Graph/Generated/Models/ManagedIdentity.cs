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
    public class ManagedIdentity : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The ARM resource ID of the Azure resource associated with the managed identity used for sign in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssociatedResourceId
        {
            get { return BackingStore?.Get<string?>("associatedResourceId"); }
            set { BackingStore?.Set("associatedResourceId", value); }
        }
#nullable restore
#else
        public string AssociatedResourceId
        {
            get { return BackingStore?.Get<string>("associatedResourceId"); }
            set { BackingStore?.Set("associatedResourceId", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The unique ID of the federated token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FederatedTokenId
        {
            get { return BackingStore?.Get<string?>("federatedTokenId"); }
            set { BackingStore?.Set("federatedTokenId", value); }
        }
#nullable restore
#else
        public string FederatedTokenId
        {
            get { return BackingStore?.Get<string>("federatedTokenId"); }
            set { BackingStore?.Set("federatedTokenId", value); }
        }
#endif
        /// <summary>The issuer of the federated token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FederatedTokenIssuer
        {
            get { return BackingStore?.Get<string?>("federatedTokenIssuer"); }
            set { BackingStore?.Set("federatedTokenIssuer", value); }
        }
#nullable restore
#else
        public string FederatedTokenIssuer
        {
            get { return BackingStore?.Get<string>("federatedTokenIssuer"); }
            set { BackingStore?.Set("federatedTokenIssuer", value); }
        }
#endif
        /// <summary>The possible values are: none, userAssigned, systemAssigned, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.MsiType? MsiType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MsiType?>("msiType"); }
            set { BackingStore?.Set("msiType", value); }
        }
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
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.ManagedIdentity"/> and sets the default values.
        /// </summary>
        public ManagedIdentity()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ManagedIdentity"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.ManagedIdentity CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ManagedIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "associatedResourceId", n => { AssociatedResourceId = n.GetStringValue(); } },
                { "federatedTokenId", n => { FederatedTokenId = n.GetStringValue(); } },
                { "federatedTokenIssuer", n => { FederatedTokenIssuer = n.GetStringValue(); } },
                { "msiType", n => { MsiType = n.GetEnumValue<Microsoft.Graph.Beta.Models.MsiType>(); } },
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
            writer.WriteStringValue("associatedResourceId", AssociatedResourceId);
            writer.WriteStringValue("federatedTokenId", FederatedTokenId);
            writer.WriteStringValue("federatedTokenIssuer", FederatedTokenIssuer);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.MsiType>("msiType", MsiType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
