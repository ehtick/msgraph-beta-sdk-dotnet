using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class BitlockerRecoveryKey : Entity, IParsable {
        /// <summary>The date and time when the key was originally backed up to Azure Active Directory.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>ID of the device the BitLocker key is originally backed up from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DeviceId {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#else
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The BitLocker recovery key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Key {
            get { return BackingStore?.Get<string?>("key"); }
            set { BackingStore?.Set("key", value); }
        }
#else
        public string Key {
            get { return BackingStore?.Get<string>("key"); }
            set { BackingStore?.Set("key", value); }
        }
#endif
        /// <summary>Indicates the type of volume the BitLocker key is associated with. Possible values are: operatingSystemVolume, fixedDataVolume, removableDataVolume, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.VolumeType? VolumeType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VolumeType?>("volumeType"); }
            set { BackingStore?.Set("volumeType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BitlockerRecoveryKey CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BitlockerRecoveryKey();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"key", n => { Key = n.GetStringValue(); } },
                {"volumeType", n => { VolumeType = n.GetEnumValue<VolumeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("key", Key);
            writer.WriteEnumValue<VolumeType>("volumeType", VolumeType);
        }
    }
}
