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
    public class CloudPcDisasterRecoveryCapability : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The capabilityType property</summary>
        public Microsoft.Graph.Beta.Models.CloudPcDisasterRecoveryCapabilityType? CapabilityType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CloudPcDisasterRecoveryCapabilityType?>("capabilityType"); }
            set { BackingStore?.Set("capabilityType", value); }
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
        /// <summary>The primaryRegion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryRegion
        {
            get { return BackingStore?.Get<string?>("primaryRegion"); }
            set { BackingStore?.Set("primaryRegion", value); }
        }
#nullable restore
#else
        public string PrimaryRegion
        {
            get { return BackingStore?.Get<string>("primaryRegion"); }
            set { BackingStore?.Set("primaryRegion", value); }
        }
#endif
        /// <summary>The secondaryRegion property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecondaryRegion
        {
            get { return BackingStore?.Get<string?>("secondaryRegion"); }
            set { BackingStore?.Set("secondaryRegion", value); }
        }
#nullable restore
#else
        public string SecondaryRegion
        {
            get { return BackingStore?.Get<string>("secondaryRegion"); }
            set { BackingStore?.Set("secondaryRegion", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.CloudPcDisasterRecoveryCapability"/> and sets the default values.
        /// </summary>
        public CloudPcDisasterRecoveryCapability()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CloudPcDisasterRecoveryCapability"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.CloudPcDisasterRecoveryCapability CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.CloudPcDisasterRecoveryCapability();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "capabilityType", n => { CapabilityType = n.GetEnumValue<Microsoft.Graph.Beta.Models.CloudPcDisasterRecoveryCapabilityType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "primaryRegion", n => { PrimaryRegion = n.GetStringValue(); } },
                { "secondaryRegion", n => { SecondaryRegion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.CloudPcDisasterRecoveryCapabilityType>("capabilityType", CapabilityType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("primaryRegion", PrimaryRegion);
            writer.WriteStringValue("secondaryRegion", SecondaryRegion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
