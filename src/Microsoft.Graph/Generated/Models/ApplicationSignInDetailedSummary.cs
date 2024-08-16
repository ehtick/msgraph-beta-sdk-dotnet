// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class ApplicationSignInDetailedSummary : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? AggregatedEventDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("aggregatedEventDateTime"); }
            set { BackingStore?.Set("aggregatedEventDateTime", value); }
        }
        /// <summary>Name of the application that the user signed in to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName
        {
            get { return BackingStore?.Get<string?>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#nullable restore
#else
        public string AppDisplayName
        {
            get { return BackingStore?.Get<string>("appDisplayName"); }
            set { BackingStore?.Set("appDisplayName", value); }
        }
#endif
        /// <summary>ID of the application that the user signed in to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId
        {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId
        {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>Count of sign-ins made by the application.</summary>
        public long? SignInCount
        {
            get { return BackingStore?.Get<long?>("signInCount"); }
            set { BackingStore?.Set("signInCount", value); }
        }
        /// <summary>Details of the sign-in status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SignInStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SignInStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SignInStatus Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SignInStatus>("status"); }
            set { BackingStore?.Set("status", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.ApplicationSignInDetailedSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "aggregatedEventDateTime", n => { AggregatedEventDateTime = n.GetDateTimeOffsetValue(); } },
                { "appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "signInCount", n => { SignInCount = n.GetLongValue(); } },
                { "status", n => { Status = n.GetObjectValue<Microsoft.Graph.Beta.Models.SignInStatus>(Microsoft.Graph.Beta.Models.SignInStatus.CreateFromDiscriminatorValue); } },
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
            writer.WriteDateTimeOffsetValue("aggregatedEventDateTime", AggregatedEventDateTime);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteLongValue("signInCount", SignInCount);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SignInStatus>("status", Status);
        }
    }
}
