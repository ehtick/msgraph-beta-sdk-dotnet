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
    public class TeamsAppInstallationScopeInfo : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The scope property</summary>
        public Microsoft.Graph.Beta.Models.TeamsAppInstallationScopes? Scope
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TeamsAppInstallationScopes?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.TeamsAppInstallationScopeInfo"/> and sets the default values.
        /// </summary>
        public TeamsAppInstallationScopeInfo()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.TeamsAppInstallationScopeInfo"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.TeamsAppInstallationScopeInfo CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.groupChatTeamsAppInstallationScopeInfo" => new Microsoft.Graph.Beta.Models.GroupChatTeamsAppInstallationScopeInfo(),
                "#microsoft.graph.personalTeamsAppInstallationScopeInfo" => new Microsoft.Graph.Beta.Models.PersonalTeamsAppInstallationScopeInfo(),
                "#microsoft.graph.teamTeamsAppInstallationScopeInfo" => new Microsoft.Graph.Beta.Models.TeamTeamsAppInstallationScopeInfo(),
                _ => new Microsoft.Graph.Beta.Models.TeamsAppInstallationScopeInfo(),
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
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "scope", n => { Scope = n.GetEnumValue<Microsoft.Graph.Beta.Models.TeamsAppInstallationScopes>(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.TeamsAppInstallationScopes>("scope", Scope);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
