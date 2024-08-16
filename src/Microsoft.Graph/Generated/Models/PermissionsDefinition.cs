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
    public class PermissionsDefinition : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The authorizationSystemInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystem? AuthorizationSystemInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystem?>("authorizationSystemInfo"); }
            set { BackingStore?.Set("authorizationSystemInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystem AuthorizationSystemInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystem>("authorizationSystemInfo"); }
            set { BackingStore?.Set("authorizationSystemInfo", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The identityInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystemIdentity? IdentityInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystemIdentity?>("identityInfo"); }
            set { BackingStore?.Set("identityInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystemIdentity IdentityInfo
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystemIdentity>("identityInfo"); }
            set { BackingStore?.Set("identityInfo", value); }
        }
#endif
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
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.PermissionsDefinition"/> and sets the default values.
        /// </summary>
        public PermissionsDefinition()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.PermissionsDefinition"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.PermissionsDefinition CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.awsPermissionsDefinition" => new Microsoft.Graph.Beta.Models.AwsPermissionsDefinition(),
                "#microsoft.graph.singleResourceAzurePermissionsDefinition" => new Microsoft.Graph.Beta.Models.SingleResourceAzurePermissionsDefinition(),
                "#microsoft.graph.singleResourceGcpPermissionsDefinition" => new Microsoft.Graph.Beta.Models.SingleResourceGcpPermissionsDefinition(),
                _ => new Microsoft.Graph.Beta.Models.PermissionsDefinition(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "authorizationSystemInfo", n => { AuthorizationSystemInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystem>(Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystem.CreateFromDiscriminatorValue); } },
                { "identityInfo", n => { IdentityInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystemIdentity>(Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystemIdentity.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystem>("authorizationSystemInfo", AuthorizationSystemInfo);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PermissionsDefinitionAuthorizationSystemIdentity>("identityInfo", IdentityInfo);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
