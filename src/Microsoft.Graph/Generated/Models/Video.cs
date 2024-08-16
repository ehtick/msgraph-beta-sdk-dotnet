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
    public class Video : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Number of audio bits per sample.</summary>
        public int? AudioBitsPerSample
        {
            get { return BackingStore?.Get<int?>("audioBitsPerSample"); }
            set { BackingStore?.Set("audioBitsPerSample", value); }
        }
        /// <summary>Number of audio channels.</summary>
        public int? AudioChannels
        {
            get { return BackingStore?.Get<int?>("audioChannels"); }
            set { BackingStore?.Set("audioChannels", value); }
        }
        /// <summary>Name of the audio format (AAC, MP3, etc.).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AudioFormat
        {
            get { return BackingStore?.Get<string?>("audioFormat"); }
            set { BackingStore?.Set("audioFormat", value); }
        }
#nullable restore
#else
        public string AudioFormat
        {
            get { return BackingStore?.Get<string>("audioFormat"); }
            set { BackingStore?.Set("audioFormat", value); }
        }
#endif
        /// <summary>Number of audio samples per second.</summary>
        public int? AudioSamplesPerSecond
        {
            get { return BackingStore?.Get<int?>("audioSamplesPerSecond"); }
            set { BackingStore?.Set("audioSamplesPerSecond", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Bit rate of the video in bits per second.</summary>
        public int? Bitrate
        {
            get { return BackingStore?.Get<int?>("bitrate"); }
            set { BackingStore?.Set("bitrate", value); }
        }
        /// <summary>Duration of the file in milliseconds.</summary>
        public long? Duration
        {
            get { return BackingStore?.Get<long?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>&apos;Four character code&apos; name of the video format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FourCC
        {
            get { return BackingStore?.Get<string?>("fourCC"); }
            set { BackingStore?.Set("fourCC", value); }
        }
#nullable restore
#else
        public string FourCC
        {
            get { return BackingStore?.Get<string>("fourCC"); }
            set { BackingStore?.Set("fourCC", value); }
        }
#endif
        /// <summary>The frameRate property</summary>
        public double? FrameRate
        {
            get { return BackingStore?.Get<double?>("frameRate"); }
            set { BackingStore?.Set("frameRate", value); }
        }
        /// <summary>Height of the video, in pixels.</summary>
        public int? Height
        {
            get { return BackingStore?.Get<int?>("height"); }
            set { BackingStore?.Set("height", value); }
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
        /// <summary>Width of the video, in pixels.</summary>
        public int? Width
        {
            get { return BackingStore?.Get<int?>("width"); }
            set { BackingStore?.Set("width", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Video"/> and sets the default values.
        /// </summary>
        public Video()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Video"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.Video CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Video();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "audioBitsPerSample", n => { AudioBitsPerSample = n.GetIntValue(); } },
                { "audioChannels", n => { AudioChannels = n.GetIntValue(); } },
                { "audioFormat", n => { AudioFormat = n.GetStringValue(); } },
                { "audioSamplesPerSecond", n => { AudioSamplesPerSecond = n.GetIntValue(); } },
                { "bitrate", n => { Bitrate = n.GetIntValue(); } },
                { "duration", n => { Duration = n.GetLongValue(); } },
                { "fourCC", n => { FourCC = n.GetStringValue(); } },
                { "frameRate", n => { FrameRate = n.GetDoubleValue(); } },
                { "height", n => { Height = n.GetIntValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "width", n => { Width = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("audioBitsPerSample", AudioBitsPerSample);
            writer.WriteIntValue("audioChannels", AudioChannels);
            writer.WriteStringValue("audioFormat", AudioFormat);
            writer.WriteIntValue("audioSamplesPerSecond", AudioSamplesPerSecond);
            writer.WriteIntValue("bitrate", Bitrate);
            writer.WriteLongValue("duration", Duration);
            writer.WriteStringValue("fourCC", FourCC);
            writer.WriteDoubleValue("frameRate", FrameRate);
            writer.WriteIntValue("height", Height);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("width", Width);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
