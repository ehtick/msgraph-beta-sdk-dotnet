// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class UnifiedStorageQuota : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The deleted property</summary>
        public long? Deleted
        {
            get { return BackingStore?.Get<long?>("deleted"); }
            set { BackingStore?.Set("deleted", value); }
        }
        /// <summary>A URL that can be used in a browser to manage the breakdown. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManageWebUrl
        {
            get { return BackingStore?.Get<string?>("manageWebUrl"); }
            set { BackingStore?.Set("manageWebUrl", value); }
        }
#nullable restore
#else
        public string ManageWebUrl
        {
            get { return BackingStore?.Get<string>("manageWebUrl"); }
            set { BackingStore?.Set("manageWebUrl", value); }
        }
#endif
        /// <summary>Total space remaining before reaching the quota limit in bytes.</summary>
        public long? Remaining
        {
            get { return BackingStore?.Get<long?>("remaining"); }
            set { BackingStore?.Set("remaining", value); }
        }
        /// <summary>The breakdown of services contributing to the user&apos;s quota usage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ServiceStorageQuotaBreakdown>? Services
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ServiceStorageQuotaBreakdown>?>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ServiceStorageQuotaBreakdown> Services
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ServiceStorageQuotaBreakdown>>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#endif
        /// <summary>Indicates the state of the storage space. The possible values are: normal, nearing, critical, full, and overLimit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State
        {
            get { return BackingStore?.Get<string?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#nullable restore
#else
        public string State
        {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#endif
        /// <summary>Total allowed storage space in bytes.</summary>
        public long? Total
        {
            get { return BackingStore?.Get<long?>("total"); }
            set { BackingStore?.Set("total", value); }
        }
        /// <summary>Total space used in bytes.</summary>
        public long? Used
        {
            get { return BackingStore?.Get<long?>("used"); }
            set { BackingStore?.Set("used", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UnifiedStorageQuota"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.UnifiedStorageQuota CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.UnifiedStorageQuota();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deleted", n => { Deleted = n.GetLongValue(); } },
                { "manageWebUrl", n => { ManageWebUrl = n.GetStringValue(); } },
                { "remaining", n => { Remaining = n.GetLongValue(); } },
                { "services", n => { Services = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ServiceStorageQuotaBreakdown>(Microsoft.Graph.Beta.Models.ServiceStorageQuotaBreakdown.CreateFromDiscriminatorValue)?.ToList(); } },
                { "state", n => { State = n.GetStringValue(); } },
                { "total", n => { Total = n.GetLongValue(); } },
                { "used", n => { Used = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("deleted", Deleted);
            writer.WriteStringValue("manageWebUrl", ManageWebUrl);
            writer.WriteLongValue("remaining", Remaining);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ServiceStorageQuotaBreakdown>("services", Services);
            writer.WriteStringValue("state", State);
            writer.WriteLongValue("total", Total);
            writer.WriteLongValue("used", Used);
        }
    }
}
