// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Contains properties for the health summary of the Windows management app.
    /// </summary>
    public class WindowsManagementAppHealthSummary : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Healthy device count.</summary>
        public int? HealthyDeviceCount
        {
            get { return BackingStore?.Get<int?>("healthyDeviceCount"); }
            set { BackingStore?.Set("healthyDeviceCount", value); }
        }
        /// <summary>Unhealthy device count.</summary>
        public int? UnhealthyDeviceCount
        {
            get { return BackingStore?.Get<int?>("unhealthyDeviceCount"); }
            set { BackingStore?.Set("unhealthyDeviceCount", value); }
        }
        /// <summary>Unknown device count.</summary>
        public int? UnknownDeviceCount
        {
            get { return BackingStore?.Get<int?>("unknownDeviceCount"); }
            set { BackingStore?.Set("unknownDeviceCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsManagementAppHealthSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.WindowsManagementAppHealthSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.WindowsManagementAppHealthSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "healthyDeviceCount", n => { HealthyDeviceCount = n.GetIntValue(); } },
                { "unhealthyDeviceCount", n => { UnhealthyDeviceCount = n.GetIntValue(); } },
                { "unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
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
            writer.WriteIntValue("healthyDeviceCount", HealthyDeviceCount);
            writer.WriteIntValue("unhealthyDeviceCount", UnhealthyDeviceCount);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
