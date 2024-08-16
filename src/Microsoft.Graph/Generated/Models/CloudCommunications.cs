// <auto-generated/>
using Microsoft.Graph.Beta.Models.CallRecords;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class CloudCommunications : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The callRecords property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.CallRecords.CallRecord>? CallRecords
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CallRecords.CallRecord>?>("callRecords"); }
            set { BackingStore?.Set("callRecords", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.CallRecords.CallRecord> CallRecords
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CallRecords.CallRecord>>("callRecords"); }
            set { BackingStore?.Set("callRecords", value); }
        }
#endif
        /// <summary>The calls property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Call>? Calls
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Call>?>("calls"); }
            set { BackingStore?.Set("calls", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Call> Calls
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Call>>("calls"); }
            set { BackingStore?.Set("calls", value); }
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
        /// <summary>The onlineMeetings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.OnlineMeeting>? OnlineMeetings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OnlineMeeting>?>("onlineMeetings"); }
            set { BackingStore?.Set("onlineMeetings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.OnlineMeeting> OnlineMeetings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.OnlineMeeting>>("onlineMeetings"); }
            set { BackingStore?.Set("onlineMeetings", value); }
        }
#endif
        /// <summary>The presences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Presence>? Presences
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Presence>?>("presences"); }
            set { BackingStore?.Set("presences", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Presence> Presences
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Presence>>("presences"); }
            set { BackingStore?.Set("presences", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.CloudCommunications"/> and sets the default values.
        /// </summary>
        public CloudCommunications()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CloudCommunications"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.CloudCommunications CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.CloudCommunications();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "callRecords", n => { CallRecords = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CallRecords.CallRecord>(Microsoft.Graph.Beta.Models.CallRecords.CallRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                { "calls", n => { Calls = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Call>(Microsoft.Graph.Beta.Models.Call.CreateFromDiscriminatorValue)?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "onlineMeetings", n => { OnlineMeetings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OnlineMeeting>(Microsoft.Graph.Beta.Models.OnlineMeeting.CreateFromDiscriminatorValue)?.ToList(); } },
                { "presences", n => { Presences = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Presence>(Microsoft.Graph.Beta.Models.Presence.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CallRecords.CallRecord>("callRecords", CallRecords);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Call>("calls", Calls);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.OnlineMeeting>("onlineMeetings", OnlineMeetings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Presence>("presences", Presences);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
