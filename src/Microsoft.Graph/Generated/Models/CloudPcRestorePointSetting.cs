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
    public class CloudPcRestorePointSetting : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The time interval in hours to take snapshots (restore points) of a Cloud PC automatically. Possible values are 4, 6, 12, 16, and 24. The default frequency is 12 hours. The frequencyInHours property is deprecated and will stop returning data on January 31, 2024. Going forward, use the frequencyType property.</summary>
        public int? FrequencyInHours
        {
            get { return BackingStore?.Get<int?>("frequencyInHours"); }
            set { BackingStore?.Set("frequencyInHours", value); }
        }
        /// <summary>The time interval in hours to take snapshots (restore points) of a Cloud PC automatically. Possible values are: default, fourHours, sixHours, twelveHours, sixteenHours, twentyFourHours, unknownFutureValue. The default value is default that indicates that the time interval for automatic capturing of restore point snapshots is set to 12 hours.</summary>
        public Microsoft.Graph.Beta.Models.CloudPcRestorePointFrequencyType? FrequencyType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CloudPcRestorePointFrequencyType?>("frequencyType"); }
            set { BackingStore?.Set("frequencyType", value); }
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
        /// <summary>If true, the user has the ability to use snapshots to restore Cloud PCs. If false, non-admin users can&apos;t use snapshots to restore the Cloud PC.</summary>
        public bool? UserRestoreEnabled
        {
            get { return BackingStore?.Get<bool?>("userRestoreEnabled"); }
            set { BackingStore?.Set("userRestoreEnabled", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.CloudPcRestorePointSetting"/> and sets the default values.
        /// </summary>
        public CloudPcRestorePointSetting()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CloudPcRestorePointSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.CloudPcRestorePointSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.CloudPcRestorePointSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "frequencyInHours", n => { FrequencyInHours = n.GetIntValue(); } },
                { "frequencyType", n => { FrequencyType = n.GetEnumValue<Microsoft.Graph.Beta.Models.CloudPcRestorePointFrequencyType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "userRestoreEnabled", n => { UserRestoreEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("frequencyInHours", FrequencyInHours);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.CloudPcRestorePointFrequencyType>("frequencyType", FrequencyType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("userRestoreEnabled", UserRestoreEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
