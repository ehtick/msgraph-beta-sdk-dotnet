// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class MfaCompletionMetric : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The ID of the Microsoft Entra application. Supports $filter (eq).</summary>
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
        /// <summary>Number of users who attempted to sign up. Supports $filter (eq).</summary>
        public long? AttemptsCount
        {
            get { return BackingStore?.Get<long?>("attemptsCount"); }
            set { BackingStore?.Set("attemptsCount", value); }
        }
        /// <summary>The country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country
        {
            get { return BackingStore?.Get<string?>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#nullable restore
#else
        public string Country
        {
            get { return BackingStore?.Get<string>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#endif
        /// <summary>The date of the user insight.</summary>
        public Date? FactDate
        {
            get { return BackingStore?.Get<Date?>("factDate"); }
            set { BackingStore?.Set("factDate", value); }
        }
        /// <summary>The identityProvider property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityProvider
        {
            get { return BackingStore?.Get<string?>("identityProvider"); }
            set { BackingStore?.Set("identityProvider", value); }
        }
#nullable restore
#else
        public string IdentityProvider
        {
            get { return BackingStore?.Get<string>("identityProvider"); }
            set { BackingStore?.Set("identityProvider", value); }
        }
#endif
        /// <summary>The language property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language
        {
            get { return BackingStore?.Get<string?>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#nullable restore
#else
        public string Language
        {
            get { return BackingStore?.Get<string>("language"); }
            set { BackingStore?.Set("language", value); }
        }
#endif
        /// <summary>The mfaFailures property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.MfaFailure>? MfaFailures
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MfaFailure>?>("mfaFailures"); }
            set { BackingStore?.Set("mfaFailures", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.MfaFailure> MfaFailures
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MfaFailure>>("mfaFailures"); }
            set { BackingStore?.Set("mfaFailures", value); }
        }
#endif
        /// <summary>The MFA authentication method used by the customers. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MfaMethod
        {
            get { return BackingStore?.Get<string?>("mfaMethod"); }
            set { BackingStore?.Set("mfaMethod", value); }
        }
#nullable restore
#else
        public string MfaMethod
        {
            get { return BackingStore?.Get<string>("mfaMethod"); }
            set { BackingStore?.Set("mfaMethod", value); }
        }
#endif
        /// <summary>The platform of the device that the customers used. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Os
        {
            get { return BackingStore?.Get<string?>("os"); }
            set { BackingStore?.Set("os", value); }
        }
#nullable restore
#else
        public string Os
        {
            get { return BackingStore?.Get<string>("os"); }
            set { BackingStore?.Set("os", value); }
        }
#endif
        /// <summary>Number of users who signed up successfully. Supports $filter (eq).</summary>
        public long? SuccessCount
        {
            get { return BackingStore?.Get<long?>("successCount"); }
            set { BackingStore?.Set("successCount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MfaCompletionMetric"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MfaCompletionMetric CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MfaCompletionMetric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "attemptsCount", n => { AttemptsCount = n.GetLongValue(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "factDate", n => { FactDate = n.GetDateValue(); } },
                { "identityProvider", n => { IdentityProvider = n.GetStringValue(); } },
                { "language", n => { Language = n.GetStringValue(); } },
                { "mfaFailures", n => { MfaFailures = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MfaFailure>(Microsoft.Graph.Beta.Models.MfaFailure.CreateFromDiscriminatorValue)?.ToList(); } },
                { "mfaMethod", n => { MfaMethod = n.GetStringValue(); } },
                { "os", n => { Os = n.GetStringValue(); } },
                { "successCount", n => { SuccessCount = n.GetLongValue(); } },
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
            writer.WriteStringValue("appId", AppId);
            writer.WriteLongValue("attemptsCount", AttemptsCount);
            writer.WriteStringValue("country", Country);
            writer.WriteDateValue("factDate", FactDate);
            writer.WriteStringValue("identityProvider", IdentityProvider);
            writer.WriteStringValue("language", Language);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MfaFailure>("mfaFailures", MfaFailures);
            writer.WriteStringValue("mfaMethod", MfaMethod);
            writer.WriteStringValue("os", Os);
            writer.WriteLongValue("successCount", SuccessCount);
        }
    }
}
