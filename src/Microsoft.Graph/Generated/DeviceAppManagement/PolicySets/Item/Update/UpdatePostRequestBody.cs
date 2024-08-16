// <auto-generated/>
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.DeviceAppManagement.PolicySets.Item.Update
{
    #pragma warning disable CS1591
    public class UpdatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The addedPolicySetItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PolicySetItem>? AddedPolicySetItems
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PolicySetItem>?>("addedPolicySetItems"); }
            set { BackingStore?.Set("addedPolicySetItems", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PolicySetItem> AddedPolicySetItems
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PolicySetItem>>("addedPolicySetItems"); }
            set { BackingStore?.Set("addedPolicySetItems", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The assignments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PolicySetAssignment>? Assignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PolicySetAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PolicySetAssignment> Assignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PolicySetAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deletedPolicySetItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DeletedPolicySetItems
        {
            get { return BackingStore?.Get<List<string>?>("deletedPolicySetItems"); }
            set { BackingStore?.Set("deletedPolicySetItems", value); }
        }
#nullable restore
#else
        public List<string> DeletedPolicySetItems
        {
            get { return BackingStore?.Get<List<string>>("deletedPolicySetItems"); }
            set { BackingStore?.Set("deletedPolicySetItems", value); }
        }
#endif
        /// <summary>The updatedPolicySetItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PolicySetItem>? UpdatedPolicySetItems
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PolicySetItem>?>("updatedPolicySetItems"); }
            set { BackingStore?.Set("updatedPolicySetItems", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PolicySetItem> UpdatedPolicySetItems
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PolicySetItem>>("updatedPolicySetItems"); }
            set { BackingStore?.Set("updatedPolicySetItems", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceAppManagement.PolicySets.Item.Update.UpdatePostRequestBody"/> and sets the default values.
        /// </summary>
        public UpdatePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceAppManagement.PolicySets.Item.Update.UpdatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.DeviceAppManagement.PolicySets.Item.Update.UpdatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.DeviceAppManagement.PolicySets.Item.Update.UpdatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "addedPolicySetItems", n => { AddedPolicySetItems = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PolicySetItem>(Microsoft.Graph.Beta.Models.PolicySetItem.CreateFromDiscriminatorValue)?.ToList(); } },
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PolicySetAssignment>(Microsoft.Graph.Beta.Models.PolicySetAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "deletedPolicySetItems", n => { DeletedPolicySetItems = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "updatedPolicySetItems", n => { UpdatedPolicySetItems = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PolicySetItem>(Microsoft.Graph.Beta.Models.PolicySetItem.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PolicySetItem>("addedPolicySetItems", AddedPolicySetItems);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PolicySetAssignment>("assignments", Assignments);
            writer.WriteCollectionOfPrimitiveValues<string>("deletedPolicySetItems", DeletedPolicySetItems);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PolicySetItem>("updatedPolicySetItems", UpdatedPolicySetItems);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
