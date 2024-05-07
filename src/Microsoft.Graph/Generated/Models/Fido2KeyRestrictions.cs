// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    #pragma warning disable CS1591
    public class Fido2KeyRestrictions : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>A collection of Authenticator Attestation GUIDs. AADGUIDs define key types and manufacturers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AaGuids {
            get { return BackingStore?.Get<List<string>?>("aaGuids"); }
            set { BackingStore?.Set("aaGuids", value); }
        }
#nullable restore
#else
        public List<string> AaGuids {
            get { return BackingStore?.Get<List<string>>("aaGuids"); }
            set { BackingStore?.Set("aaGuids", value); }
        }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Enforcement type. Possible values are: allow, block.</summary>
        public Fido2RestrictionEnforcementType? EnforcementType {
            get { return BackingStore?.Get<Fido2RestrictionEnforcementType?>("enforcementType"); }
            set { BackingStore?.Set("enforcementType", value); }
        }
        /// <summary>Determines if the configured key enforcement is enabled.</summary>
        public bool? IsEnforced {
            get { return BackingStore?.Get<bool?>("isEnforced"); }
            set { BackingStore?.Set("isEnforced", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Fido2KeyRestrictions"/> and sets the default values.
        /// </summary>
        public Fido2KeyRestrictions()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Fido2KeyRestrictions"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Fido2KeyRestrictions CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Fido2KeyRestrictions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"aaGuids", n => { AaGuids = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"enforcementType", n => { EnforcementType = n.GetEnumValue<Fido2RestrictionEnforcementType>(); } },
                {"isEnforced", n => { IsEnforced = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("aaGuids", AaGuids);
            writer.WriteEnumValue<Fido2RestrictionEnforcementType>("enforcementType", EnforcementType);
            writer.WriteBoolValue("isEnforced", IsEnforced);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
