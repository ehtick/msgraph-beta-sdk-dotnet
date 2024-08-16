// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.PrivilegedApproval.Item.RoleInfo.SelfActivate
{
    #pragma warning disable CS1591
    public class SelfActivatePostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
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
        /// <summary>The duration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Duration
        {
            get { return BackingStore?.Get<string?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
#nullable restore
#else
        public string Duration
        {
            get { return BackingStore?.Get<string>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
#endif
        /// <summary>The reason property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason
        {
            get { return BackingStore?.Get<string?>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#nullable restore
#else
        public string Reason
        {
            get { return BackingStore?.Get<string>("reason"); }
            set { BackingStore?.Set("reason", value); }
        }
#endif
        /// <summary>The ticketNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TicketNumber
        {
            get { return BackingStore?.Get<string?>("ticketNumber"); }
            set { BackingStore?.Set("ticketNumber", value); }
        }
#nullable restore
#else
        public string TicketNumber
        {
            get { return BackingStore?.Get<string>("ticketNumber"); }
            set { BackingStore?.Set("ticketNumber", value); }
        }
#endif
        /// <summary>The ticketSystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TicketSystem
        {
            get { return BackingStore?.Get<string?>("ticketSystem"); }
            set { BackingStore?.Set("ticketSystem", value); }
        }
#nullable restore
#else
        public string TicketSystem
        {
            get { return BackingStore?.Get<string>("ticketSystem"); }
            set { BackingStore?.Set("ticketSystem", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.PrivilegedApproval.Item.RoleInfo.SelfActivate.SelfActivatePostRequestBody"/> and sets the default values.
        /// </summary>
        public SelfActivatePostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.PrivilegedApproval.Item.RoleInfo.SelfActivate.SelfActivatePostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.PrivilegedApproval.Item.RoleInfo.SelfActivate.SelfActivatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.PrivilegedApproval.Item.RoleInfo.SelfActivate.SelfActivatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "duration", n => { Duration = n.GetStringValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "ticketNumber", n => { TicketNumber = n.GetStringValue(); } },
                { "ticketSystem", n => { TicketSystem = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("duration", Duration);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("ticketNumber", TicketNumber);
            writer.WriteStringValue("ticketSystem", TicketSystem);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
