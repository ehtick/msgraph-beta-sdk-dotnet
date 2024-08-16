// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.OverrideComplianceState
{
    #pragma warning disable CS1591
    public class OverrideComplianceStatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>Administrator configured device compliance state Enum</summary>
        public Microsoft.Graph.Beta.Models.AdministratorConfiguredDeviceComplianceState? ComplianceState
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AdministratorConfiguredDeviceComplianceState?>("complianceState"); }
            set { BackingStore?.Set("complianceState", value); }
        }
        /// <summary>The remediationUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemediationUrl
        {
            get { return BackingStore?.Get<string?>("remediationUrl"); }
            set { BackingStore?.Set("remediationUrl", value); }
        }
#nullable restore
#else
        public string RemediationUrl
        {
            get { return BackingStore?.Get<string>("remediationUrl"); }
            set { BackingStore?.Set("remediationUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.OverrideComplianceState.OverrideComplianceStatePostRequestBody"/> and sets the default values.
        /// </summary>
        public OverrideComplianceStatePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.OverrideComplianceState.OverrideComplianceStatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.OverrideComplianceState.OverrideComplianceStatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.DeviceManagement.ComanagedDevices.Item.OverrideComplianceState.OverrideComplianceStatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "complianceState", n => { ComplianceState = n.GetEnumValue<Microsoft.Graph.Beta.Models.AdministratorConfiguredDeviceComplianceState>(); } },
                { "remediationUrl", n => { RemediationUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.AdministratorConfiguredDeviceComplianceState>("complianceState", ComplianceState);
            writer.WriteStringValue("remediationUrl", RemediationUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
