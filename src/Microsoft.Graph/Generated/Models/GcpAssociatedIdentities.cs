// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class GcpAssociatedIdentities : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The all property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GcpIdentity>? All {
            get { return BackingStore?.Get<List<GcpIdentity>?>("all"); }
            set { BackingStore?.Set("all", value); }
        }
#nullable restore
#else
        public List<GcpIdentity> All {
            get { return BackingStore?.Get<List<GcpIdentity>>("all"); }
            set { BackingStore?.Set("all", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The serviceAccounts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GcpServiceAccount>? ServiceAccounts {
            get { return BackingStore?.Get<List<GcpServiceAccount>?>("serviceAccounts"); }
            set { BackingStore?.Set("serviceAccounts", value); }
        }
#nullable restore
#else
        public List<GcpServiceAccount> ServiceAccounts {
            get { return BackingStore?.Get<List<GcpServiceAccount>>("serviceAccounts"); }
            set { BackingStore?.Set("serviceAccounts", value); }
        }
#endif
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GcpUser>? Users {
            get { return BackingStore?.Get<List<GcpUser>?>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#nullable restore
#else
        public List<GcpUser> Users {
            get { return BackingStore?.Get<List<GcpUser>>("users"); }
            set { BackingStore?.Set("users", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="GcpAssociatedIdentities"/> and sets the default values.
        /// </summary>
        public GcpAssociatedIdentities()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="GcpAssociatedIdentities"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GcpAssociatedIdentities CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GcpAssociatedIdentities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"all", n => { All = n.GetCollectionOfObjectValues<GcpIdentity>(GcpIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"serviceAccounts", n => { ServiceAccounts = n.GetCollectionOfObjectValues<GcpServiceAccount>(GcpServiceAccount.CreateFromDiscriminatorValue)?.ToList(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<GcpUser>(GcpUser.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<GcpIdentity>("all", All);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<GcpServiceAccount>("serviceAccounts", ServiceAccounts);
            writer.WriteCollectionOfObjectValues<GcpUser>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
