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
    public class ContentCustomization : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Represents the content options of External Identities to be customized throughout the authentication flow for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.KeyValue>? AttributeCollection
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValue>?>("attributeCollection"); }
            set { BackingStore?.Set("attributeCollection", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.KeyValue> AttributeCollection
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValue>>("attributeCollection"); }
            set { BackingStore?.Set("attributeCollection", value); }
        }
#endif
        /// <summary>A relative URL for the content options of External Identities to be customized throughout the authentication flow for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AttributeCollectionRelativeUrl
        {
            get { return BackingStore?.Get<string?>("attributeCollectionRelativeUrl"); }
            set { BackingStore?.Set("attributeCollectionRelativeUrl", value); }
        }
#nullable restore
#else
        public string AttributeCollectionRelativeUrl
        {
            get { return BackingStore?.Get<string>("attributeCollectionRelativeUrl"); }
            set { BackingStore?.Set("attributeCollectionRelativeUrl", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>Represents content options to customize during MFA proofup interruptions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.KeyValue>? RegistrationCampaign
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValue>?>("registrationCampaign"); }
            set { BackingStore?.Set("registrationCampaign", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.KeyValue> RegistrationCampaign
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.KeyValue>>("registrationCampaign"); }
            set { BackingStore?.Set("registrationCampaign", value); }
        }
#endif
        /// <summary>The relative URL of the content options to customize during MFA proofup interruptions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegistrationCampaignRelativeUrl
        {
            get { return BackingStore?.Get<string?>("registrationCampaignRelativeUrl"); }
            set { BackingStore?.Set("registrationCampaignRelativeUrl", value); }
        }
#nullable restore
#else
        public string RegistrationCampaignRelativeUrl
        {
            get { return BackingStore?.Get<string>("registrationCampaignRelativeUrl"); }
            set { BackingStore?.Set("registrationCampaignRelativeUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.ContentCustomization"/> and sets the default values.
        /// </summary>
        public ContentCustomization()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ContentCustomization"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.ContentCustomization CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ContentCustomization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attributeCollection", n => { AttributeCollection = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValue>(Microsoft.Graph.Beta.Models.KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                { "attributeCollectionRelativeUrl", n => { AttributeCollectionRelativeUrl = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "registrationCampaign", n => { RegistrationCampaign = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValue>(Microsoft.Graph.Beta.Models.KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                { "registrationCampaignRelativeUrl", n => { RegistrationCampaignRelativeUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValue>("attributeCollection", AttributeCollection);
            writer.WriteStringValue("attributeCollectionRelativeUrl", AttributeCollectionRelativeUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.KeyValue>("registrationCampaign", RegistrationCampaign);
            writer.WriteStringValue("registrationCampaignRelativeUrl", RegistrationCampaignRelativeUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
