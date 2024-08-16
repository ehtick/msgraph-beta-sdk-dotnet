// <auto-generated/>
using Microsoft.Graph.Beta.Models.ManagedTenants;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class TenantRelationship : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The customer who has a delegated admin relationship with a Microsoft partner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DelegatedAdminCustomer>? DelegatedAdminCustomers
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DelegatedAdminCustomer>?>("delegatedAdminCustomers"); }
            set { BackingStore?.Set("delegatedAdminCustomers", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DelegatedAdminCustomer> DelegatedAdminCustomers
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DelegatedAdminCustomer>>("delegatedAdminCustomers"); }
            set { BackingStore?.Set("delegatedAdminCustomers", value); }
        }
#endif
        /// <summary>The details of the delegated administrative privileges that a Microsoft partner has in a customer tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DelegatedAdminRelationship>? DelegatedAdminRelationships
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DelegatedAdminRelationship>?>("delegatedAdminRelationships"); }
            set { BackingStore?.Set("delegatedAdminRelationships", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DelegatedAdminRelationship> DelegatedAdminRelationships
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DelegatedAdminRelationship>>("delegatedAdminRelationships"); }
            set { BackingStore?.Set("delegatedAdminRelationships", value); }
        }
#endif
        /// <summary>The operations available to interact with the multi-tenant management platform.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ManagedTenants.ManagedTenant? ManagedTenants
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedTenants.ManagedTenant?>("managedTenants"); }
            set { BackingStore?.Set("managedTenants", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ManagedTenants.ManagedTenant ManagedTenants
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedTenants.ManagedTenant>("managedTenants"); }
            set { BackingStore?.Set("managedTenants", value); }
        }
#endif
        /// <summary>Defines an organization with more than one instance of Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.MultiTenantOrganization? MultiTenantOrganization
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MultiTenantOrganization?>("multiTenantOrganization"); }
            set { BackingStore?.Set("multiTenantOrganization", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.MultiTenantOrganization MultiTenantOrganization
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MultiTenantOrganization>("multiTenantOrganization"); }
            set { BackingStore?.Set("multiTenantOrganization", value); }
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
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.TenantRelationship"/> and sets the default values.
        /// </summary>
        public TenantRelationship()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.TenantRelationship"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.TenantRelationship CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.TenantRelationship();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "delegatedAdminCustomers", n => { DelegatedAdminCustomers = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DelegatedAdminCustomer>(Microsoft.Graph.Beta.Models.DelegatedAdminCustomer.CreateFromDiscriminatorValue)?.ToList(); } },
                { "delegatedAdminRelationships", n => { DelegatedAdminRelationships = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DelegatedAdminRelationship>(Microsoft.Graph.Beta.Models.DelegatedAdminRelationship.CreateFromDiscriminatorValue)?.ToList(); } },
                { "managedTenants", n => { ManagedTenants = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedTenants.ManagedTenant>(Microsoft.Graph.Beta.Models.ManagedTenants.ManagedTenant.CreateFromDiscriminatorValue); } },
                { "multiTenantOrganization", n => { MultiTenantOrganization = n.GetObjectValue<Microsoft.Graph.Beta.Models.MultiTenantOrganization>(Microsoft.Graph.Beta.Models.MultiTenantOrganization.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DelegatedAdminCustomer>("delegatedAdminCustomers", DelegatedAdminCustomers);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DelegatedAdminRelationship>("delegatedAdminRelationships", DelegatedAdminRelationships);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedTenants.ManagedTenant>("managedTenants", ManagedTenants);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MultiTenantOrganization>("multiTenantOrganization", MultiTenantOrganization);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
