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
    public class CloudPcDeviceImage : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The display name of the associated device image. The device image display name and the version are used to uniquely identify the Cloud PC device image. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The error code of the status of the image that indicates why the upload failed, if applicable. Possible values are: internalServerError, sourceImageNotFound, osVersionNotSupported, sourceImageInvalid, sourceImageNotGeneralized, unknownFutureValue, vmAlreadyAzureAdJoined, paidSourceImageNotSupport, sourceImageNotSupportCustomizeVMName, sourceImageSizeExceedsLimitation. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: vmAlreadyAzureAdJoined, paidSourceImageNotSupport, sourceImageNotSupportCustomizeVMName, sourceImageSizeExceedsLimitation. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.CloudPcDeviceImageErrorCode? ErrorCode
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CloudPcDeviceImageErrorCode?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
        /// <summary>The date when the image became unavailable. Read-only.</summary>
        public Date? ExpirationDate
        {
            get { return BackingStore?.Get<Date?>("expirationDate"); }
            set { BackingStore?.Set("expirationDate", value); }
        }
        /// <summary>The data and time when the image was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The operating system of the image. For example, Windows 10 Enterprise. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem
        {
            get { return BackingStore?.Get<string?>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#nullable restore
#else
        public string OperatingSystem
        {
            get { return BackingStore?.Get<string>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#endif
        /// <summary>The OS build version of the image. For example, 1909. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsBuildNumber
        {
            get { return BackingStore?.Get<string?>("osBuildNumber"); }
            set { BackingStore?.Set("osBuildNumber", value); }
        }
#nullable restore
#else
        public string OsBuildNumber
        {
            get { return BackingStore?.Get<string>("osBuildNumber"); }
            set { BackingStore?.Set("osBuildNumber", value); }
        }
#endif
        /// <summary>The OS status of this image. Possible values are: supported, supportedWithWarning, unknown, unknownFutureValue. The default value is unknown. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.CloudPcDeviceImageOsStatus? OsStatus
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CloudPcDeviceImageOsStatus?>("osStatus"); }
            set { BackingStore?.Set("osStatus", value); }
        }
        /// <summary>The scopeIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ScopeIds
        {
            get { return BackingStore?.Get<List<string>?>("scopeIds"); }
            set { BackingStore?.Set("scopeIds", value); }
        }
#nullable restore
#else
        public List<string> ScopeIds
        {
            get { return BackingStore?.Get<List<string>>("scopeIds"); }
            set { BackingStore?.Set("scopeIds", value); }
        }
#endif
        /// <summary>The unique identifier (ID) of the source image resource on Azure. The required ID format is: &apos;/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}&apos;. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceImageResourceId
        {
            get { return BackingStore?.Get<string?>("sourceImageResourceId"); }
            set { BackingStore?.Set("sourceImageResourceId", value); }
        }
#nullable restore
#else
        public string SourceImageResourceId
        {
            get { return BackingStore?.Get<string>("sourceImageResourceId"); }
            set { BackingStore?.Set("sourceImageResourceId", value); }
        }
#endif
        /// <summary>The status of the image on the Cloud PC. Possible values are: pending, ready, failed, unknownFutureValue. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.CloudPcDeviceImageStatus? Status
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CloudPcDeviceImageStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The details of the status of the image that indicates why the upload failed, if applicable. Possible values are: internalServerError, sourceImageNotFound, osVersionNotSupported, sourceImageInvalid, sourceImageNotGeneralized, unknownFutureValue, vmAlreadyAzureAdJoined, paidSourceImageNotSupport, sourceImageNotSupportCustomizeVMName, sourceImageSizeExceedsLimitation. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: vmAlreadyAzureAdJoined, paidSourceImageNotSupport, sourceImageNotSupportCustomizeVMName, sourceImageSizeExceedsLimitation. Read-only. The statusDetails property is deprecated and will stop returning data on January 31, 2024. Going forward, use the errorCode property.</summary>
        public Microsoft.Graph.Beta.Models.CloudPcDeviceImageStatusDetails? StatusDetails
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CloudPcDeviceImageStatusDetails?>("statusDetails"); }
            set { BackingStore?.Set("statusDetails", value); }
        }
        /// <summary>The image version. For example, 0.0.1 and 1.5.13. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version
        {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version
        {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.CloudPcDeviceImage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.CloudPcDeviceImage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.CloudPcDeviceImage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "errorCode", n => { ErrorCode = n.GetEnumValue<Microsoft.Graph.Beta.Models.CloudPcDeviceImageErrorCode>(); } },
                { "expirationDate", n => { ExpirationDate = n.GetDateValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                { "osBuildNumber", n => { OsBuildNumber = n.GetStringValue(); } },
                { "osStatus", n => { OsStatus = n.GetEnumValue<Microsoft.Graph.Beta.Models.CloudPcDeviceImageOsStatus>(); } },
                { "scopeIds", n => { ScopeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "sourceImageResourceId", n => { SourceImageResourceId = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<Microsoft.Graph.Beta.Models.CloudPcDeviceImageStatus>(); } },
                { "statusDetails", n => { StatusDetails = n.GetEnumValue<Microsoft.Graph.Beta.Models.CloudPcDeviceImageStatusDetails>(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.CloudPcDeviceImageErrorCode>("errorCode", ErrorCode);
            writer.WriteDateValue("expirationDate", ExpirationDate);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.CloudPcDeviceImageOsStatus>("osStatus", OsStatus);
            writer.WriteCollectionOfPrimitiveValues<string>("scopeIds", ScopeIds);
            writer.WriteStringValue("sourceImageResourceId", SourceImageResourceId);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.CloudPcDeviceImageStatus>("status", Status);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.CloudPcDeviceImageStatusDetails>("statusDetails", StatusDetails);
            writer.WriteStringValue("version", Version);
        }
    }
}
