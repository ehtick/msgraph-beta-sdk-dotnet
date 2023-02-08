using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class DeploymentSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Settings for governing whether content is applicable to a device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContentApplicabilitySettings? ContentApplicability {
            get { return BackingStore?.Get<ContentApplicabilitySettings?>("contentApplicability"); }
            set { BackingStore?.Set("contentApplicability", value); }
        }
#nullable restore
#else
        public ContentApplicabilitySettings ContentApplicability {
            get { return BackingStore?.Get<ContentApplicabilitySettings>("contentApplicability"); }
            set { BackingStore?.Set("contentApplicability", value); }
        }
#endif
        /// <summary>Settings for governing whether updates should be expedited.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ExpediteSettings? Expedite {
            get { return BackingStore?.Get<ExpediteSettings?>("expedite"); }
            set { BackingStore?.Set("expedite", value); }
        }
#nullable restore
#else
        public ExpediteSettings Expedite {
            get { return BackingStore?.Get<ExpediteSettings>("expedite"); }
            set { BackingStore?.Set("expedite", value); }
        }
#endif
        /// <summary>Settings for governing conditions to monitor and automated actions to take.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MonitoringSettings? Monitoring {
            get { return BackingStore?.Get<MonitoringSettings?>("monitoring"); }
            set { BackingStore?.Set("monitoring", value); }
        }
#nullable restore
#else
        public MonitoringSettings Monitoring {
            get { return BackingStore?.Get<MonitoringSettings>("monitoring"); }
            set { BackingStore?.Set("monitoring", value); }
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
        /// <summary>Settings for governing how and when the content is rolled out.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ScheduleSettings? Schedule {
            get { return BackingStore?.Get<ScheduleSettings?>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#nullable restore
#else
        public ScheduleSettings Schedule {
            get { return BackingStore?.Get<ScheduleSettings>("schedule"); }
            set { BackingStore?.Set("schedule", value); }
        }
#endif
        /// <summary>Settings for governing end user update experience.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceSettings? UserExperience {
            get { return BackingStore?.Get<UserExperienceSettings?>("userExperience"); }
            set { BackingStore?.Set("userExperience", value); }
        }
#nullable restore
#else
        public UserExperienceSettings UserExperience {
            get { return BackingStore?.Get<UserExperienceSettings>("userExperience"); }
            set { BackingStore?.Set("userExperience", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deploymentSettings and sets the default values.
        /// </summary>
        public DeploymentSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeploymentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeploymentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contentApplicability", n => { ContentApplicability = n.GetObjectValue<ContentApplicabilitySettings>(ContentApplicabilitySettings.CreateFromDiscriminatorValue); } },
                {"expedite", n => { Expedite = n.GetObjectValue<ExpediteSettings>(ExpediteSettings.CreateFromDiscriminatorValue); } },
                {"monitoring", n => { Monitoring = n.GetObjectValue<MonitoringSettings>(MonitoringSettings.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"schedule", n => { Schedule = n.GetObjectValue<ScheduleSettings>(ScheduleSettings.CreateFromDiscriminatorValue); } },
                {"userExperience", n => { UserExperience = n.GetObjectValue<UserExperienceSettings>(UserExperienceSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ContentApplicabilitySettings>("contentApplicability", ContentApplicability);
            writer.WriteObjectValue<ExpediteSettings>("expedite", Expedite);
            writer.WriteObjectValue<MonitoringSettings>("monitoring", Monitoring);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ScheduleSettings>("schedule", Schedule);
            writer.WriteObjectValue<UserExperienceSettings>("userExperience", UserExperience);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
