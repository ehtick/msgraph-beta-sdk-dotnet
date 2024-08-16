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
    public class UserTrainingEventInfo : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Display name of the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Latest status of the training assigned to the user. Possible values are: unknown, assigned, inProgress, completed, overdue, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.TrainingStatus? LatestTrainingStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TrainingStatus?>("latestTrainingStatus"); }
            set { BackingStore?.Set("latestTrainingStatus", value); }
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
        /// <summary>Event details of the training when it was assigned to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo? TrainingAssignedProperties
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo?>("trainingAssignedProperties"); }
            set { BackingStore?.Set("trainingAssignedProperties", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo TrainingAssignedProperties
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo>("trainingAssignedProperties"); }
            set { BackingStore?.Set("trainingAssignedProperties", value); }
        }
#endif
        /// <summary>Event details of the training when it was completed by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo? TrainingCompletedProperties
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo?>("trainingCompletedProperties"); }
            set { BackingStore?.Set("trainingCompletedProperties", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo TrainingCompletedProperties
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo>("trainingCompletedProperties"); }
            set { BackingStore?.Set("trainingCompletedProperties", value); }
        }
#endif
        /// <summary>Event details of the training when it was updated/in-progress by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo? TrainingUpdatedProperties
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo?>("trainingUpdatedProperties"); }
            set { BackingStore?.Set("trainingUpdatedProperties", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo TrainingUpdatedProperties
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo>("trainingUpdatedProperties"); }
            set { BackingStore?.Set("trainingUpdatedProperties", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.UserTrainingEventInfo"/> and sets the default values.
        /// </summary>
        public UserTrainingEventInfo()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UserTrainingEventInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.UserTrainingEventInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.UserTrainingEventInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "latestTrainingStatus", n => { LatestTrainingStatus = n.GetEnumValue<Microsoft.Graph.Beta.Models.TrainingStatus>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "trainingAssignedProperties", n => { TrainingAssignedProperties = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo>(Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
                { "trainingCompletedProperties", n => { TrainingCompletedProperties = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo>(Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
                { "trainingUpdatedProperties", n => { TrainingUpdatedProperties = n.GetObjectValue<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo>(Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.TrainingStatus>("latestTrainingStatus", LatestTrainingStatus);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo>("trainingAssignedProperties", TrainingAssignedProperties);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo>("trainingCompletedProperties", TrainingCompletedProperties);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.UserTrainingContentEventInfo>("trainingUpdatedProperties", TrainingUpdatedProperties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
