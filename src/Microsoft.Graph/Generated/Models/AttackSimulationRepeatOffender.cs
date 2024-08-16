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
    public class AttackSimulationRepeatOffender : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The user in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AttackSimulationUser? AttackSimulationUser
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AttackSimulationUser?>("attackSimulationUser"); }
            set { BackingStore?.Set("attackSimulationUser", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AttackSimulationUser AttackSimulationUser
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AttackSimulationUser>("attackSimulationUser"); }
            set { BackingStore?.Set("attackSimulationUser", value); }
        }
#endif
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
        /// <summary>Number of repeat offences of the user in attack simulation and training campaigns.</summary>
        public int? RepeatOffenceCount
        {
            get { return BackingStore?.Get<int?>("repeatOffenceCount"); }
            set { BackingStore?.Set("repeatOffenceCount", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.AttackSimulationRepeatOffender"/> and sets the default values.
        /// </summary>
        public AttackSimulationRepeatOffender()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AttackSimulationRepeatOffender"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.AttackSimulationRepeatOffender CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AttackSimulationRepeatOffender();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attackSimulationUser", n => { AttackSimulationUser = n.GetObjectValue<Microsoft.Graph.Beta.Models.AttackSimulationUser>(Microsoft.Graph.Beta.Models.AttackSimulationUser.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "repeatOffenceCount", n => { RepeatOffenceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AttackSimulationUser>("attackSimulationUser", AttackSimulationUser);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("repeatOffenceCount", RepeatOffenceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
