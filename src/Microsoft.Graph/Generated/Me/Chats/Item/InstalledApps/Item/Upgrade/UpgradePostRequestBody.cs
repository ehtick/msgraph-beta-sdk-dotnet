// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Me.Chats.Item.InstalledApps.Item.Upgrade
{
    #pragma warning disable CS1591
    public class UpgradePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The consentedPermissionSet property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamsAppPermissionSet? ConsentedPermissionSet
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppPermissionSet?>("consentedPermissionSet"); }
            set { BackingStore?.Set("consentedPermissionSet", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamsAppPermissionSet ConsentedPermissionSet
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppPermissionSet>("consentedPermissionSet"); }
            set { BackingStore?.Set("consentedPermissionSet", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Me.Chats.Item.InstalledApps.Item.Upgrade.UpgradePostRequestBody"/> and sets the default values.
        /// </summary>
        public UpgradePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Me.Chats.Item.InstalledApps.Item.Upgrade.UpgradePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Me.Chats.Item.InstalledApps.Item.Upgrade.UpgradePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Me.Chats.Item.InstalledApps.Item.Upgrade.UpgradePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "consentedPermissionSet", n => { ConsentedPermissionSet = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamsAppPermissionSet>(Microsoft.Graph.Beta.Models.TeamsAppPermissionSet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamsAppPermissionSet>("consentedPermissionSet", ConsentedPermissionSet);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
