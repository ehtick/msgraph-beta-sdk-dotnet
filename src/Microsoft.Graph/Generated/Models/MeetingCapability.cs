// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class MeetingCapability : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Indicates whether anonymous users dialout is allowed in a meeting.</summary>
        public bool? AllowAnonymousUsersToDialOut {
            get { return BackingStore?.Get<bool?>("allowAnonymousUsersToDialOut"); }
            set { BackingStore?.Set("allowAnonymousUsersToDialOut", value); }
        }
        /// <summary>Indicates whether anonymous users are allowed to start a meeting.</summary>
        public bool? AllowAnonymousUsersToStartMeeting {
            get { return BackingStore?.Get<bool?>("allowAnonymousUsersToStartMeeting"); }
            set { BackingStore?.Set("allowAnonymousUsersToStartMeeting", value); }
        }
        /// <summary>The autoAdmittedUsers property</summary>
        public AutoAdmittedUsersType? AutoAdmittedUsers {
            get { return BackingStore?.Get<AutoAdmittedUsersType?>("autoAdmittedUsers"); }
            set { BackingStore?.Set("autoAdmittedUsers", value); }
        }
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
        /// <summary>
        /// Instantiates a new <see cref="MeetingCapability"/> and sets the default values.
        /// </summary>
        public MeetingCapability()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MeetingCapability"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MeetingCapability CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingCapability();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"allowAnonymousUsersToDialOut", n => { AllowAnonymousUsersToDialOut = n.GetBoolValue(); } },
                {"allowAnonymousUsersToStartMeeting", n => { AllowAnonymousUsersToStartMeeting = n.GetBoolValue(); } },
                {"autoAdmittedUsers", n => { AutoAdmittedUsers = n.GetEnumValue<AutoAdmittedUsersType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowAnonymousUsersToDialOut", AllowAnonymousUsersToDialOut);
            writer.WriteBoolValue("allowAnonymousUsersToStartMeeting", AllowAnonymousUsersToStartMeeting);
            writer.WriteEnumValue<AutoAdmittedUsersType>("autoAdmittedUsers", AutoAdmittedUsers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
