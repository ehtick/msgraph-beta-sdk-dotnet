// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AccessPackageResourceRequest : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessPackageResource property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessPackageResource? AccessPackageResource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResource?>("accessPackageResource"); }
            set { BackingStore?.Set("accessPackageResource", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessPackageResource AccessPackageResource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResource"); }
            set { BackingStore?.Set("accessPackageResource", value); }
        }
#endif
        /// <summary>The unique ID of the access package catalog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CatalogId
        {
            get { return BackingStore?.Get<string?>("catalogId"); }
            set { BackingStore?.Set("catalogId", value); }
        }
#nullable restore
#else
        public string CatalogId
        {
            get { return BackingStore?.Get<string>("catalogId"); }
            set { BackingStore?.Set("catalogId", value); }
        }
#endif
        /// <summary>The executeImmediately property</summary>
        public bool? ExecuteImmediately
        {
            get { return BackingStore?.Get<bool?>("executeImmediately"); }
            set { BackingStore?.Set("executeImmediately", value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ExpirationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>If set, doesn&apos;t add the resource.</summary>
        public bool? IsValidationOnly
        {
            get { return BackingStore?.Get<bool?>("isValidationOnly"); }
            set { BackingStore?.Set("isValidationOnly", value); }
        }
        /// <summary>The requestor&apos;s justification for adding or removing the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification
        {
            get { return BackingStore?.Get<string?>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#nullable restore
#else
        public string Justification
        {
            get { return BackingStore?.Get<string>("justification"); }
            set { BackingStore?.Set("justification", value); }
        }
#endif
        /// <summary>Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AccessPackageSubject? Requestor
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageSubject?>("requestor"); }
            set { BackingStore?.Set("requestor", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AccessPackageSubject Requestor
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AccessPackageSubject>("requestor"); }
            set { BackingStore?.Set("requestor", value); }
        }
#endif
        /// <summary>The outcome of whether the service was able to add the resource to the catalog. The value is Delivered if the resource was added or removed. Read-Only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestState
        {
            get { return BackingStore?.Get<string?>("requestState"); }
            set { BackingStore?.Set("requestState", value); }
        }
#nullable restore
#else
        public string RequestState
        {
            get { return BackingStore?.Get<string>("requestState"); }
            set { BackingStore?.Set("requestState", value); }
        }
#endif
        /// <summary>The requestStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestStatus
        {
            get { return BackingStore?.Get<string?>("requestStatus"); }
            set { BackingStore?.Set("requestStatus", value); }
        }
#nullable restore
#else
        public string RequestStatus
        {
            get { return BackingStore?.Get<string>("requestStatus"); }
            set { BackingStore?.Set("requestStatus", value); }
        }
#endif
        /// <summary>Use AdminAdd to add a resource, if the caller is an administrator or resource owner, AdminUpdate to update a resource, or AdminRemove to remove a resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RequestType
        {
            get { return BackingStore?.Get<string?>("requestType"); }
            set { BackingStore?.Set("requestType", value); }
        }
#nullable restore
#else
        public string RequestType
        {
            get { return BackingStore?.Get<string>("requestType"); }
            set { BackingStore?.Set("requestType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AccessPackageResourceRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AccessPackageResourceRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AccessPackageResourceRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackageResource", n => { AccessPackageResource = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>(Microsoft.Graph.Beta.Models.AccessPackageResource.CreateFromDiscriminatorValue); } },
                { "catalogId", n => { CatalogId = n.GetStringValue(); } },
                { "executeImmediately", n => { ExecuteImmediately = n.GetBoolValue(); } },
                { "expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "isValidationOnly", n => { IsValidationOnly = n.GetBoolValue(); } },
                { "justification", n => { Justification = n.GetStringValue(); } },
                { "requestState", n => { RequestState = n.GetStringValue(); } },
                { "requestStatus", n => { RequestStatus = n.GetStringValue(); } },
                { "requestType", n => { RequestType = n.GetStringValue(); } },
                { "requestor", n => { Requestor = n.GetObjectValue<Microsoft.Graph.Beta.Models.AccessPackageSubject>(Microsoft.Graph.Beta.Models.AccessPackageSubject.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageResource>("accessPackageResource", AccessPackageResource);
            writer.WriteStringValue("catalogId", CatalogId);
            writer.WriteBoolValue("executeImmediately", ExecuteImmediately);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AccessPackageSubject>("requestor", Requestor);
            writer.WriteStringValue("requestState", RequestState);
            writer.WriteStringValue("requestStatus", RequestStatus);
            writer.WriteStringValue("requestType", RequestType);
        }
    }
}
