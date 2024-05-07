// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class ParticipantInfo : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The ISO 3166-1 Alpha-2 country code of the participant&apos;s best estimated physical location at the start of the call. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode {
            get { return BackingStore?.Get<string?>("countryCode"); }
            set { BackingStore?.Set("countryCode", value); }
        }
#nullable restore
#else
        public string CountryCode {
            get { return BackingStore?.Get<string>("countryCode"); }
            set { BackingStore?.Set("countryCode", value); }
        }
#endif
        /// <summary>The type of endpoint the participant is using. Possible values are: default, voicemail, skypeForBusiness, skypeForBusinessVoipPhone and unknownFutureValue. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.EndpointType? EndpointType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EndpointType?>("endpointType"); }
            set { BackingStore?.Set("endpointType", value); }
        }
        /// <summary>The identity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Identity {
            get { return BackingStore?.Get<IdentitySet?>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#nullable restore
#else
        public IdentitySet Identity {
            get { return BackingStore?.Get<IdentitySet>("identity"); }
            set { BackingStore?.Set("identity", value); }
        }
#endif
        /// <summary>The language culture string. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageId {
            get { return BackingStore?.Get<string?>("languageId"); }
            set { BackingStore?.Set("languageId", value); }
        }
#nullable restore
#else
        public string LanguageId {
            get { return BackingStore?.Get<string>("languageId"); }
            set { BackingStore?.Set("languageId", value); }
        }
#endif
        /// <summary>The nonAnonymizedIdentity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? NonAnonymizedIdentity {
            get { return BackingStore?.Get<IdentitySet?>("nonAnonymizedIdentity"); }
            set { BackingStore?.Set("nonAnonymizedIdentity", value); }
        }
#nullable restore
#else
        public IdentitySet NonAnonymizedIdentity {
            get { return BackingStore?.Get<IdentitySet>("nonAnonymizedIdentity"); }
            set { BackingStore?.Set("nonAnonymizedIdentity", value); }
        }
#endif
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
        /// <summary>The participant ID of the participant. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParticipantId {
            get { return BackingStore?.Get<string?>("participantId"); }
            set { BackingStore?.Set("participantId", value); }
        }
#nullable restore
#else
        public string ParticipantId {
            get { return BackingStore?.Get<string>("participantId"); }
            set { BackingStore?.Set("participantId", value); }
        }
#endif
        /// <summary>The client platform ID of the participant. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlatformId {
            get { return BackingStore?.Get<string?>("platformId"); }
            set { BackingStore?.Set("platformId", value); }
        }
#nullable restore
#else
        public string PlatformId {
            get { return BackingStore?.Get<string>("platformId"); }
            set { BackingStore?.Set("platformId", value); }
        }
#endif
        /// <summary>The home region of the participant, and can be a country, a continent, or a larger geographic region. The region doesn&apos;t change based on the participant&apos;s current physical location, unlike countryCode. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region {
            get { return BackingStore?.Get<string?>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#nullable restore
#else
        public string Region {
            get { return BackingStore?.Get<string>("region"); }
            set { BackingStore?.Set("region", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="ParticipantInfo"/> and sets the default values.
        /// </summary>
        public ParticipantInfo()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ParticipantInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ParticipantInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParticipantInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"countryCode", n => { CountryCode = n.GetStringValue(); } },
                {"endpointType", n => { EndpointType = n.GetEnumValue<EndpointType>(); } },
                {"identity", n => { Identity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"languageId", n => { LanguageId = n.GetStringValue(); } },
                {"nonAnonymizedIdentity", n => { NonAnonymizedIdentity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"participantId", n => { ParticipantId = n.GetStringValue(); } },
                {"platformId", n => { PlatformId = n.GetStringValue(); } },
                {"region", n => { Region = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("countryCode", CountryCode);
            writer.WriteEnumValue<EndpointType>("endpointType", EndpointType);
            writer.WriteObjectValue<IdentitySet>("identity", Identity);
            writer.WriteStringValue("languageId", LanguageId);
            writer.WriteObjectValue<IdentitySet>("nonAnonymizedIdentity", NonAnonymizedIdentity);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("participantId", ParticipantId);
            writer.WriteStringValue("platformId", PlatformId);
            writer.WriteStringValue("region", Region);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
