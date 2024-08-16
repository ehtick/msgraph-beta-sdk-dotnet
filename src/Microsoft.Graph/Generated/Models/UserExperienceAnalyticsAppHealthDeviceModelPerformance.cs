// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The user experience analytics device model performance entity contains device model performance details.
    /// </summary>
    public class UserExperienceAnalyticsAppHealthDeviceModelPerformance : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The number of active devices for the model. Valid values 0 to 2147483647. Supports: $filter, $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? ActiveDeviceCount
        {
            get { return BackingStore?.Get<int?>("activeDeviceCount"); }
            set { BackingStore?.Set("activeDeviceCount", value); }
        }
        /// <summary>The manufacturer name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceManufacturer
        {
            get { return BackingStore?.Get<string?>("deviceManufacturer"); }
            set { BackingStore?.Set("deviceManufacturer", value); }
        }
#nullable restore
#else
        public string DeviceManufacturer
        {
            get { return BackingStore?.Get<string>("deviceManufacturer"); }
            set { BackingStore?.Set("deviceManufacturer", value); }
        }
#endif
        /// <summary>The model name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceModel
        {
            get { return BackingStore?.Get<string?>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#nullable restore
#else
        public string DeviceModel
        {
            get { return BackingStore?.Get<string>("deviceModel"); }
            set { BackingStore?.Set("deviceModel", value); }
        }
#endif
        /// <summary>The healthStatus property</summary>
        public Microsoft.Graph.Beta.Models.UserExperienceAnalyticsHealthState? HealthStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsHealthState?>("healthStatus"); }
            set { BackingStore?.Set("healthStatus", value); }
        }
        /// <summary>The mean time to failure for the application in minutes. Valid values 0 to 2147483647. Supports: $filter, $select, $OrderBy. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? MeanTimeToFailureInMinutes
        {
            get { return BackingStore?.Get<int?>("meanTimeToFailureInMinutes"); }
            set { BackingStore?.Set("meanTimeToFailureInMinutes", value); }
        }
        /// <summary>The application health score of the device model. Valid values 0 to 100. Supports: $filter, $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ModelAppHealthScore
        {
            get { return BackingStore?.Get<double?>("modelAppHealthScore"); }
            set { BackingStore?.Set("modelAppHealthScore", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeDeviceCount", n => { ActiveDeviceCount = n.GetIntValue(); } },
                { "deviceManufacturer", n => { DeviceManufacturer = n.GetStringValue(); } },
                { "deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                { "healthStatus", n => { HealthStatus = n.GetEnumValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsHealthState>(); } },
                { "meanTimeToFailureInMinutes", n => { MeanTimeToFailureInMinutes = n.GetIntValue(); } },
                { "modelAppHealthScore", n => { ModelAppHealthScore = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("activeDeviceCount", ActiveDeviceCount);
            writer.WriteStringValue("deviceManufacturer", DeviceManufacturer);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteIntValue("meanTimeToFailureInMinutes", MeanTimeToFailureInMinutes);
            writer.WriteDoubleValue("modelAppHealthScore", ModelAppHealthScore);
        }
    }
}
