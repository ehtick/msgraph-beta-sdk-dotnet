// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    #pragma warning disable CS1591
    public class TenantAllowOrBlockListAction : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Specifies whether the tenant allow-or-block list is an allow or block. The possible values are: allow, block, and unkownFutureValue.</summary>
        public TenantAllowBlockListAction? Action {
            get { return BackingStore?.Get<TenantAllowBlockListAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Specifies when the tenant allow-block-list expires in date time.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Specifies the note added to the tenant allow-or-block list entry in the format of string.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Note {
            get { return BackingStore?.Get<string?>("note"); }
            set { BackingStore?.Set("note", value); }
        }
#nullable restore
#else
        public string Note {
            get { return BackingStore?.Get<string>("note"); }
            set { BackingStore?.Set("note", value); }
        }
#endif
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
        /// <summary>Contains the result of the submission that lead to the tenant allow-block-list entry creation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TenantAllowBlockListEntryResult>? Results {
            get { return BackingStore?.Get<List<TenantAllowBlockListEntryResult>?>("results"); }
            set { BackingStore?.Set("results", value); }
        }
#nullable restore
#else
        public List<TenantAllowBlockListEntryResult> Results {
            get { return BackingStore?.Get<List<TenantAllowBlockListEntryResult>>("results"); }
            set { BackingStore?.Set("results", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="TenantAllowOrBlockListAction"/> and sets the default values.
        /// </summary>
        public TenantAllowOrBlockListAction()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="TenantAllowOrBlockListAction"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TenantAllowOrBlockListAction CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantAllowOrBlockListAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"action", n => { Action = n.GetEnumValue<TenantAllowBlockListAction>(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"note", n => { Note = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"results", n => { Results = n.GetCollectionOfObjectValues<TenantAllowBlockListEntryResult>(TenantAllowBlockListEntryResult.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<TenantAllowBlockListAction>("action", Action);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("note", Note);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<TenantAllowBlockListEntryResult>("results", Results);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
