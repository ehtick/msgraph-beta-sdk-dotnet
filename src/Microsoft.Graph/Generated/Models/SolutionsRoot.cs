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
    public class SolutionsRoot : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The backupRestore property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.BackupRestoreRoot? BackupRestore
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BackupRestoreRoot?>("backupRestore"); }
            set { BackingStore?.Set("backupRestore", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.BackupRestoreRoot BackupRestore
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BackupRestoreRoot>("backupRestore"); }
            set { BackingStore?.Set("backupRestore", value); }
        }
#endif
        /// <summary>The bookingBusinesses property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.BookingBusiness>? BookingBusinesses
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.BookingBusiness>?>("bookingBusinesses"); }
            set { BackingStore?.Set("bookingBusinesses", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.BookingBusiness> BookingBusinesses
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.BookingBusiness>>("bookingBusinesses"); }
            set { BackingStore?.Set("bookingBusinesses", value); }
        }
#endif
        /// <summary>The bookingCurrencies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.BookingCurrency>? BookingCurrencies
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.BookingCurrency>?>("bookingCurrencies"); }
            set { BackingStore?.Set("bookingCurrencies", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.BookingCurrency> BookingCurrencies
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.BookingCurrency>>("bookingCurrencies"); }
            set { BackingStore?.Set("bookingCurrencies", value); }
        }
#endif
        /// <summary>The businessScenarios property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.BusinessScenario>? BusinessScenarios
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.BusinessScenario>?>("businessScenarios"); }
            set { BackingStore?.Set("businessScenarios", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.BusinessScenario> BusinessScenarios
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.BusinessScenario>>("businessScenarios"); }
            set { BackingStore?.Set("businessScenarios", value); }
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
        /// <summary>The virtualEvents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.VirtualEventsRoot? VirtualEvents
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VirtualEventsRoot?>("virtualEvents"); }
            set { BackingStore?.Set("virtualEvents", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.VirtualEventsRoot VirtualEvents
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VirtualEventsRoot>("virtualEvents"); }
            set { BackingStore?.Set("virtualEvents", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.SolutionsRoot"/> and sets the default values.
        /// </summary>
        public SolutionsRoot()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.SolutionsRoot"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.SolutionsRoot CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.SolutionsRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "backupRestore", n => { BackupRestore = n.GetObjectValue<Microsoft.Graph.Beta.Models.BackupRestoreRoot>(Microsoft.Graph.Beta.Models.BackupRestoreRoot.CreateFromDiscriminatorValue); } },
                { "bookingBusinesses", n => { BookingBusinesses = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.BookingBusiness>(Microsoft.Graph.Beta.Models.BookingBusiness.CreateFromDiscriminatorValue)?.ToList(); } },
                { "bookingCurrencies", n => { BookingCurrencies = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.BookingCurrency>(Microsoft.Graph.Beta.Models.BookingCurrency.CreateFromDiscriminatorValue)?.ToList(); } },
                { "businessScenarios", n => { BusinessScenarios = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.BusinessScenario>(Microsoft.Graph.Beta.Models.BusinessScenario.CreateFromDiscriminatorValue)?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "virtualEvents", n => { VirtualEvents = n.GetObjectValue<Microsoft.Graph.Beta.Models.VirtualEventsRoot>(Microsoft.Graph.Beta.Models.VirtualEventsRoot.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.BackupRestoreRoot>("backupRestore", BackupRestore);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.BookingBusiness>("bookingBusinesses", BookingBusinesses);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.BookingCurrency>("bookingCurrencies", BookingCurrencies);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.BusinessScenario>("businessScenarios", BusinessScenarios);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.VirtualEventsRoot>("virtualEvents", VirtualEvents);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
