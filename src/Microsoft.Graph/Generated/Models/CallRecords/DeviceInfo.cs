// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.CallRecords {
    #pragma warning disable CS1591
    public class DeviceInfo : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Name of the capture device driver used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CaptureDeviceDriver {
            get { return BackingStore?.Get<string?>("captureDeviceDriver"); }
            set { BackingStore?.Set("captureDeviceDriver", value); }
        }
#nullable restore
#else
        public string CaptureDeviceDriver {
            get { return BackingStore?.Get<string>("captureDeviceDriver"); }
            set { BackingStore?.Set("captureDeviceDriver", value); }
        }
#endif
        /// <summary>Name of the capture device used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CaptureDeviceName {
            get { return BackingStore?.Get<string?>("captureDeviceName"); }
            set { BackingStore?.Set("captureDeviceName", value); }
        }
#nullable restore
#else
        public string CaptureDeviceName {
            get { return BackingStore?.Get<string>("captureDeviceName"); }
            set { BackingStore?.Set("captureDeviceName", value); }
        }
#endif
        /// <summary>Fraction of the call that the media endpoint detected the capture device was not working properly.</summary>
        public float? CaptureNotFunctioningEventRatio {
            get { return BackingStore?.Get<float?>("captureNotFunctioningEventRatio"); }
            set { BackingStore?.Set("captureNotFunctioningEventRatio", value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected the CPU resources available were insufficient and caused poor quality of the audio sent and received.</summary>
        public float? CpuInsufficentEventRatio {
            get { return BackingStore?.Get<float?>("cpuInsufficentEventRatio"); }
            set { BackingStore?.Set("cpuInsufficentEventRatio", value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected clipping in the captured audio that caused poor quality of the audio being sent.</summary>
        public float? DeviceClippingEventRatio {
            get { return BackingStore?.Get<float?>("deviceClippingEventRatio"); }
            set { BackingStore?.Set("deviceClippingEventRatio", value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected glitches or gaps in the audio played or captured that caused poor quality of the audio being sent or received.</summary>
        public float? DeviceGlitchEventRatio {
            get { return BackingStore?.Get<float?>("deviceGlitchEventRatio"); }
            set { BackingStore?.Set("deviceGlitchEventRatio", value); }
        }
        /// <summary>Number of times during the call that the media endpoint detected howling or screeching audio.</summary>
        public int? HowlingEventCount {
            get { return BackingStore?.Get<int?>("howlingEventCount"); }
            set { BackingStore?.Set("howlingEventCount", value); }
        }
        /// <summary>The root mean square (RMS) of the incoming signal of up to the first 30 seconds of the call.</summary>
        public float? InitialSignalLevelRootMeanSquare {
            get { return BackingStore?.Get<float?>("initialSignalLevelRootMeanSquare"); }
            set { BackingStore?.Set("initialSignalLevelRootMeanSquare", value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected low speech level that caused poor quality of the audio being sent.</summary>
        public float? LowSpeechLevelEventRatio {
            get { return BackingStore?.Get<float?>("lowSpeechLevelEventRatio"); }
            set { BackingStore?.Set("lowSpeechLevelEventRatio", value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected low speech to noise level that caused poor quality of the audio being sent.</summary>
        public float? LowSpeechToNoiseEventRatio {
            get { return BackingStore?.Get<float?>("lowSpeechToNoiseEventRatio"); }
            set { BackingStore?.Set("lowSpeechToNoiseEventRatio", value); }
        }
        /// <summary>Glitches per 5 minute interval for the media endpoint&apos;s microphone.</summary>
        public float? MicGlitchRate {
            get { return BackingStore?.Get<float?>("micGlitchRate"); }
            set { BackingStore?.Set("micGlitchRate", value); }
        }
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
        /// <summary>Average energy level of received audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.</summary>
        public int? ReceivedNoiseLevel {
            get { return BackingStore?.Get<int?>("receivedNoiseLevel"); }
            set { BackingStore?.Set("receivedNoiseLevel", value); }
        }
        /// <summary>Average energy level of received audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.</summary>
        public int? ReceivedSignalLevel {
            get { return BackingStore?.Get<int?>("receivedSignalLevel"); }
            set { BackingStore?.Set("receivedSignalLevel", value); }
        }
        /// <summary>Name of the render device driver used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RenderDeviceDriver {
            get { return BackingStore?.Get<string?>("renderDeviceDriver"); }
            set { BackingStore?.Set("renderDeviceDriver", value); }
        }
#nullable restore
#else
        public string RenderDeviceDriver {
            get { return BackingStore?.Get<string>("renderDeviceDriver"); }
            set { BackingStore?.Set("renderDeviceDriver", value); }
        }
#endif
        /// <summary>Name of the render device used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RenderDeviceName {
            get { return BackingStore?.Get<string?>("renderDeviceName"); }
            set { BackingStore?.Set("renderDeviceName", value); }
        }
#nullable restore
#else
        public string RenderDeviceName {
            get { return BackingStore?.Get<string>("renderDeviceName"); }
            set { BackingStore?.Set("renderDeviceName", value); }
        }
#endif
        /// <summary>Fraction of the call that media endpoint detected device render is muted.</summary>
        public float? RenderMuteEventRatio {
            get { return BackingStore?.Get<float?>("renderMuteEventRatio"); }
            set { BackingStore?.Set("renderMuteEventRatio", value); }
        }
        /// <summary>Fraction of the call that the media endpoint detected the render device was not working properly.</summary>
        public float? RenderNotFunctioningEventRatio {
            get { return BackingStore?.Get<float?>("renderNotFunctioningEventRatio"); }
            set { BackingStore?.Set("renderNotFunctioningEventRatio", value); }
        }
        /// <summary>Fraction of the call that media endpoint detected device render volume is set to 0.</summary>
        public float? RenderZeroVolumeEventRatio {
            get { return BackingStore?.Get<float?>("renderZeroVolumeEventRatio"); }
            set { BackingStore?.Set("renderZeroVolumeEventRatio", value); }
        }
        /// <summary>Average energy level of sent audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.</summary>
        public int? SentNoiseLevel {
            get { return BackingStore?.Get<int?>("sentNoiseLevel"); }
            set { BackingStore?.Set("sentNoiseLevel", value); }
        }
        /// <summary>Average energy level of sent audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.</summary>
        public int? SentSignalLevel {
            get { return BackingStore?.Get<int?>("sentSignalLevel"); }
            set { BackingStore?.Set("sentSignalLevel", value); }
        }
        /// <summary>Glitches per 5 minute internal for the media endpoint&apos;s loudspeaker.</summary>
        public float? SpeakerGlitchRate {
            get { return BackingStore?.Get<float?>("speakerGlitchRate"); }
            set { BackingStore?.Set("speakerGlitchRate", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="DeviceInfo"/> and sets the default values.
        /// </summary>
        public DeviceInfo()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="DeviceInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"captureDeviceDriver", n => { CaptureDeviceDriver = n.GetStringValue(); } },
                {"captureDeviceName", n => { CaptureDeviceName = n.GetStringValue(); } },
                {"captureNotFunctioningEventRatio", n => { CaptureNotFunctioningEventRatio = n.GetFloatValue(); } },
                {"cpuInsufficentEventRatio", n => { CpuInsufficentEventRatio = n.GetFloatValue(); } },
                {"deviceClippingEventRatio", n => { DeviceClippingEventRatio = n.GetFloatValue(); } },
                {"deviceGlitchEventRatio", n => { DeviceGlitchEventRatio = n.GetFloatValue(); } },
                {"howlingEventCount", n => { HowlingEventCount = n.GetIntValue(); } },
                {"initialSignalLevelRootMeanSquare", n => { InitialSignalLevelRootMeanSquare = n.GetFloatValue(); } },
                {"lowSpeechLevelEventRatio", n => { LowSpeechLevelEventRatio = n.GetFloatValue(); } },
                {"lowSpeechToNoiseEventRatio", n => { LowSpeechToNoiseEventRatio = n.GetFloatValue(); } },
                {"micGlitchRate", n => { MicGlitchRate = n.GetFloatValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"receivedNoiseLevel", n => { ReceivedNoiseLevel = n.GetIntValue(); } },
                {"receivedSignalLevel", n => { ReceivedSignalLevel = n.GetIntValue(); } },
                {"renderDeviceDriver", n => { RenderDeviceDriver = n.GetStringValue(); } },
                {"renderDeviceName", n => { RenderDeviceName = n.GetStringValue(); } },
                {"renderMuteEventRatio", n => { RenderMuteEventRatio = n.GetFloatValue(); } },
                {"renderNotFunctioningEventRatio", n => { RenderNotFunctioningEventRatio = n.GetFloatValue(); } },
                {"renderZeroVolumeEventRatio", n => { RenderZeroVolumeEventRatio = n.GetFloatValue(); } },
                {"sentNoiseLevel", n => { SentNoiseLevel = n.GetIntValue(); } },
                {"sentSignalLevel", n => { SentSignalLevel = n.GetIntValue(); } },
                {"speakerGlitchRate", n => { SpeakerGlitchRate = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("captureDeviceDriver", CaptureDeviceDriver);
            writer.WriteStringValue("captureDeviceName", CaptureDeviceName);
            writer.WriteFloatValue("captureNotFunctioningEventRatio", CaptureNotFunctioningEventRatio);
            writer.WriteFloatValue("cpuInsufficentEventRatio", CpuInsufficentEventRatio);
            writer.WriteFloatValue("deviceClippingEventRatio", DeviceClippingEventRatio);
            writer.WriteFloatValue("deviceGlitchEventRatio", DeviceGlitchEventRatio);
            writer.WriteIntValue("howlingEventCount", HowlingEventCount);
            writer.WriteFloatValue("initialSignalLevelRootMeanSquare", InitialSignalLevelRootMeanSquare);
            writer.WriteFloatValue("lowSpeechLevelEventRatio", LowSpeechLevelEventRatio);
            writer.WriteFloatValue("lowSpeechToNoiseEventRatio", LowSpeechToNoiseEventRatio);
            writer.WriteFloatValue("micGlitchRate", MicGlitchRate);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("receivedNoiseLevel", ReceivedNoiseLevel);
            writer.WriteIntValue("receivedSignalLevel", ReceivedSignalLevel);
            writer.WriteStringValue("renderDeviceDriver", RenderDeviceDriver);
            writer.WriteStringValue("renderDeviceName", RenderDeviceName);
            writer.WriteFloatValue("renderMuteEventRatio", RenderMuteEventRatio);
            writer.WriteFloatValue("renderNotFunctioningEventRatio", RenderNotFunctioningEventRatio);
            writer.WriteFloatValue("renderZeroVolumeEventRatio", RenderZeroVolumeEventRatio);
            writer.WriteIntValue("sentNoiseLevel", SentNoiseLevel);
            writer.WriteIntValue("sentSignalLevel", SentSignalLevel);
            writer.WriteFloatValue("speakerGlitchRate", SpeakerGlitchRate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
