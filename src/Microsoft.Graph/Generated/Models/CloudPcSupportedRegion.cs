// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class CloudPcSupportedRegion : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name for the supported region. Read-only.</summary>
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
        /// <summary>The regionGroup property</summary>
        public Microsoft.Graph.Beta.Models.CloudPcRegionGroup? RegionGroup
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CloudPcRegionGroup?>("regionGroup"); }
            set { BackingStore?.Set("regionGroup", value); }
        }
        /// <summary>The status of the supported region. Possible values are: available, restricted, unavailable, unknownFutureValue. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.CloudPcSupportedRegionStatus? RegionStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CloudPcSupportedRegionStatus?>("regionStatus"); }
            set { BackingStore?.Set("regionStatus", value); }
        }
        /// <summary>The supportedSolution property</summary>
        public Microsoft.Graph.Beta.Models.CloudPcManagementService? SupportedSolution
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CloudPcManagementService?>("supportedSolution"); }
            set { BackingStore?.Set("supportedSolution", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CloudPcSupportedRegion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.CloudPcSupportedRegion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.CloudPcSupportedRegion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "regionGroup", n => { RegionGroup = n.GetEnumValue<Microsoft.Graph.Beta.Models.CloudPcRegionGroup>(); } },
                { "regionStatus", n => { RegionStatus = n.GetEnumValue<Microsoft.Graph.Beta.Models.CloudPcSupportedRegionStatus>(); } },
                { "supportedSolution", n => { SupportedSolution = n.GetEnumValue<Microsoft.Graph.Beta.Models.CloudPcManagementService>(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.CloudPcRegionGroup>("regionGroup", RegionGroup);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.CloudPcSupportedRegionStatus>("regionStatus", RegionStatus);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.CloudPcManagementService>("supportedSolution", SupportedSolution);
        }
    }
}
