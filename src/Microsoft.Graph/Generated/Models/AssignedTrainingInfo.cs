// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class AssignedTrainingInfo : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Number of users who were assigned the training in an attack simulation and training campaign.</summary>
        public int? AssignedUserCount {
            get { return BackingStore?.Get<int?>("assignedUserCount"); }
            set { BackingStore?.Set("assignedUserCount", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Number of users who completed the training in an attack simulation and training campaign.</summary>
        public int? CompletedUserCount {
            get { return BackingStore?.Get<int?>("completedUserCount"); }
            set { BackingStore?.Set("completedUserCount", value); }
        }
        /// <summary>Display name of the training in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
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
        /// <summary>
        /// Instantiates a new <see cref="AssignedTrainingInfo"/> and sets the default values.
        /// </summary>
        public AssignedTrainingInfo()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="AssignedTrainingInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignedTrainingInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignedTrainingInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"assignedUserCount", n => { AssignedUserCount = n.GetIntValue(); } },
                {"completedUserCount", n => { CompletedUserCount = n.GetIntValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
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
            writer.WriteIntValue("assignedUserCount", AssignedUserCount);
            writer.WriteIntValue("completedUserCount", CompletedUserCount);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
