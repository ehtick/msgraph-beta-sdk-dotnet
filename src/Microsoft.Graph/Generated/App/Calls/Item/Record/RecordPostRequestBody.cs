// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.App.Calls.Item.Record
{
    #pragma warning disable CS1591
    public class RecordPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The bargeInAllowed property</summary>
        public bool? BargeInAllowed
        {
            get { return BackingStore?.Get<bool?>("bargeInAllowed"); }
            set { BackingStore?.Set("bargeInAllowed", value); }
        }
        /// <summary>The clientContext property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientContext
        {
            get { return BackingStore?.Get<string?>("clientContext"); }
            set { BackingStore?.Set("clientContext", value); }
        }
#nullable restore
#else
        public string ClientContext
        {
            get { return BackingStore?.Get<string>("clientContext"); }
            set { BackingStore?.Set("clientContext", value); }
        }
#endif
        /// <summary>The initialSilenceTimeoutInSeconds property</summary>
        public int? InitialSilenceTimeoutInSeconds
        {
            get { return BackingStore?.Get<int?>("initialSilenceTimeoutInSeconds"); }
            set { BackingStore?.Set("initialSilenceTimeoutInSeconds", value); }
        }
        /// <summary>The maxRecordDurationInSeconds property</summary>
        public int? MaxRecordDurationInSeconds
        {
            get { return BackingStore?.Get<int?>("maxRecordDurationInSeconds"); }
            set { BackingStore?.Set("maxRecordDurationInSeconds", value); }
        }
        /// <summary>The maxSilenceTimeoutInSeconds property</summary>
        public int? MaxSilenceTimeoutInSeconds
        {
            get { return BackingStore?.Get<int?>("maxSilenceTimeoutInSeconds"); }
            set { BackingStore?.Set("maxSilenceTimeoutInSeconds", value); }
        }
        /// <summary>The playBeep property</summary>
        public bool? PlayBeep
        {
            get { return BackingStore?.Get<bool?>("playBeep"); }
            set { BackingStore?.Set("playBeep", value); }
        }
        /// <summary>The prompts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Prompt>? Prompts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Prompt>?>("prompts"); }
            set { BackingStore?.Set("prompts", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Prompt> Prompts
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Prompt>>("prompts"); }
            set { BackingStore?.Set("prompts", value); }
        }
#endif
        /// <summary>The stopTones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? StopTones
        {
            get { return BackingStore?.Get<List<string>?>("stopTones"); }
            set { BackingStore?.Set("stopTones", value); }
        }
#nullable restore
#else
        public List<string> StopTones
        {
            get { return BackingStore?.Get<List<string>>("stopTones"); }
            set { BackingStore?.Set("stopTones", value); }
        }
#endif
        /// <summary>The streamWhileRecording property</summary>
        public bool? StreamWhileRecording
        {
            get { return BackingStore?.Get<bool?>("streamWhileRecording"); }
            set { BackingStore?.Set("streamWhileRecording", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.App.Calls.Item.Record.RecordPostRequestBody"/> and sets the default values.
        /// </summary>
        public RecordPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.App.Calls.Item.Record.RecordPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.App.Calls.Item.Record.RecordPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.App.Calls.Item.Record.RecordPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bargeInAllowed", n => { BargeInAllowed = n.GetBoolValue(); } },
                { "clientContext", n => { ClientContext = n.GetStringValue(); } },
                { "initialSilenceTimeoutInSeconds", n => { InitialSilenceTimeoutInSeconds = n.GetIntValue(); } },
                { "maxRecordDurationInSeconds", n => { MaxRecordDurationInSeconds = n.GetIntValue(); } },
                { "maxSilenceTimeoutInSeconds", n => { MaxSilenceTimeoutInSeconds = n.GetIntValue(); } },
                { "playBeep", n => { PlayBeep = n.GetBoolValue(); } },
                { "prompts", n => { Prompts = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Prompt>(Microsoft.Graph.Beta.Models.Prompt.CreateFromDiscriminatorValue)?.ToList(); } },
                { "stopTones", n => { StopTones = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "streamWhileRecording", n => { StreamWhileRecording = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("bargeInAllowed", BargeInAllowed);
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteIntValue("initialSilenceTimeoutInSeconds", InitialSilenceTimeoutInSeconds);
            writer.WriteIntValue("maxRecordDurationInSeconds", MaxRecordDurationInSeconds);
            writer.WriteIntValue("maxSilenceTimeoutInSeconds", MaxSilenceTimeoutInSeconds);
            writer.WriteBoolValue("playBeep", PlayBeep);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Prompt>("prompts", Prompts);
            writer.WriteCollectionOfPrimitiveValues<string>("stopTones", StopTones);
            writer.WriteBoolValue("streamWhileRecording", StreamWhileRecording);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
