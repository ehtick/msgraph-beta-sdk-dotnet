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
    public class PreApprovalDetail : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The permissions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.PreApprovedPermissions? Permissions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PreApprovedPermissions?>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.PreApprovedPermissions Permissions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PreApprovedPermissions>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#endif
        /// <summary>The scopeType property</summary>
        public Microsoft.Graph.Beta.Models.ResourceScopeType? ScopeType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ResourceScopeType?>("scopeType"); }
            set { BackingStore?.Set("scopeType", value); }
        }
        /// <summary>The sensitivityLabels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ScopeSensitivityLabels? SensitivityLabels
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ScopeSensitivityLabels?>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ScopeSensitivityLabels SensitivityLabels
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ScopeSensitivityLabels>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.PreApprovalDetail"/> and sets the default values.
        /// </summary>
        public PreApprovalDetail()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.PreApprovalDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.PreApprovalDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.PreApprovalDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "permissions", n => { Permissions = n.GetObjectValue<Microsoft.Graph.Beta.Models.PreApprovedPermissions>(Microsoft.Graph.Beta.Models.PreApprovedPermissions.CreateFromDiscriminatorValue); } },
                { "scopeType", n => { ScopeType = n.GetEnumValue<Microsoft.Graph.Beta.Models.ResourceScopeType>(); } },
                { "sensitivityLabels", n => { SensitivityLabels = n.GetObjectValue<Microsoft.Graph.Beta.Models.ScopeSensitivityLabels>(Microsoft.Graph.Beta.Models.ScopeSensitivityLabels.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PreApprovedPermissions>("permissions", Permissions);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ResourceScopeType>("scopeType", ScopeType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ScopeSensitivityLabels>("sensitivityLabels", SensitivityLabels);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
