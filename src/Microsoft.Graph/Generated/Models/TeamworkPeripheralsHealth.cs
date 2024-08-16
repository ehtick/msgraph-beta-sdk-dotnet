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
    public class TeamworkPeripheralsHealth : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The health details about the communication speaker.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth? CommunicationSpeakerHealth
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth?>("communicationSpeakerHealth"); }
            set { BackingStore?.Set("communicationSpeakerHealth", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth CommunicationSpeakerHealth
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>("communicationSpeakerHealth"); }
            set { BackingStore?.Set("communicationSpeakerHealth", value); }
        }
#endif
        /// <summary>The health details about the content camera.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth? ContentCameraHealth
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth?>("contentCameraHealth"); }
            set { BackingStore?.Set("contentCameraHealth", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth ContentCameraHealth
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>("contentCameraHealth"); }
            set { BackingStore?.Set("contentCameraHealth", value); }
        }
#endif
        /// <summary>The health details about displays.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>? DisplayHealthCollection
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>?>("displayHealthCollection"); }
            set { BackingStore?.Set("displayHealthCollection", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth> DisplayHealthCollection
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>>("displayHealthCollection"); }
            set { BackingStore?.Set("displayHealthCollection", value); }
        }
#endif
        /// <summary>The health details about the microphone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth? MicrophoneHealth
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth?>("microphoneHealth"); }
            set { BackingStore?.Set("microphoneHealth", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth MicrophoneHealth
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>("microphoneHealth"); }
            set { BackingStore?.Set("microphoneHealth", value); }
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
        /// <summary>The health details about the room camera.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth? RoomCameraHealth
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth?>("roomCameraHealth"); }
            set { BackingStore?.Set("roomCameraHealth", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth RoomCameraHealth
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>("roomCameraHealth"); }
            set { BackingStore?.Set("roomCameraHealth", value); }
        }
#endif
        /// <summary>The health details about the speaker.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth? SpeakerHealth
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth?>("speakerHealth"); }
            set { BackingStore?.Set("speakerHealth", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth SpeakerHealth
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>("speakerHealth"); }
            set { BackingStore?.Set("speakerHealth", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.TeamworkPeripheralsHealth"/> and sets the default values.
        /// </summary>
        public TeamworkPeripheralsHealth()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.TeamworkPeripheralsHealth"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.TeamworkPeripheralsHealth CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.TeamworkPeripheralsHealth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "communicationSpeakerHealth", n => { CommunicationSpeakerHealth = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>(Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
                { "contentCameraHealth", n => { ContentCameraHealth = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>(Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
                { "displayHealthCollection", n => { DisplayHealthCollection = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>(Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth.CreateFromDiscriminatorValue)?.ToList(); } },
                { "microphoneHealth", n => { MicrophoneHealth = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>(Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "roomCameraHealth", n => { RoomCameraHealth = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>(Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
                { "speakerHealth", n => { SpeakerHealth = n.GetObjectValue<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>(Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>("communicationSpeakerHealth", CommunicationSpeakerHealth);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>("contentCameraHealth", ContentCameraHealth);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>("displayHealthCollection", DisplayHealthCollection);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>("microphoneHealth", MicrophoneHealth);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>("roomCameraHealth", RoomCameraHealth);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TeamworkPeripheralHealth>("speakerHealth", SpeakerHealth);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
