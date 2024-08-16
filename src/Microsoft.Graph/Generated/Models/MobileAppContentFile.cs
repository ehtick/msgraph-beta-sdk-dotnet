// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Contains properties for a single installer file that is associated with a given mobileAppContent version.
    /// </summary>
    public class MobileAppContentFile : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Indicates the Azure Storage URI that the file is uploaded to. Created by the service upon receiving a valid mobileAppContentFile. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureStorageUri
        {
            get { return BackingStore?.Get<string?>("azureStorageUri"); }
            set { BackingStore?.Set("azureStorageUri", value); }
        }
#nullable restore
#else
        public string AzureStorageUri
        {
            get { return BackingStore?.Get<string>("azureStorageUri"); }
            set { BackingStore?.Set("azureStorageUri", value); }
        }
#endif
        /// <summary>Indicates the date and time when the Azure storage URI expires, in ISO 8601 format. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Read-only. This property is read-only.</summary>
        public DateTimeOffset? AzureStorageUriExpirationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("azureStorageUriExpirationDateTime"); }
            set { BackingStore?.Set("azureStorageUriExpirationDateTime", value); }
        }
        /// <summary>Indicates created date and time associated with app content file, in ISO 8601 format. For example, midnight UTC on Jan 1, 2014 would look like this: &apos;2014-01-01T00:00:00Z&apos;. Read-only. This property is read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>A value indicating whether the file is committed. A committed app content file has been fully uploaded and validated by the Intune service. TRUE means that app content file is committed, FALSE means that app content file is not committed. Defaults to FALSE. Read-only. This property is read-only.</summary>
        public bool? IsCommitted
        {
            get { return BackingStore?.Get<bool?>("isCommitted"); }
            set { BackingStore?.Set("isCommitted", value); }
        }
        /// <summary>Indicates whether this content file is a dependency for the main content file. TRUE means that the content file is a dependency, FALSE means that the content file is not a dependency and is the main content file. Defaults to FALSE.</summary>
        public bool? IsDependency
        {
            get { return BackingStore?.Get<bool?>("isDependency"); }
            set { BackingStore?.Set("isDependency", value); }
        }
        /// <summary>A value indicating whether the file is a framework file. To be deprecated.</summary>
        public bool? IsFrameworkFile
        {
            get { return BackingStore?.Get<bool?>("isFrameworkFile"); }
            set { BackingStore?.Set("isFrameworkFile", value); }
        }
        /// <summary>Indicates the manifest information, containing file metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Manifest
        {
            get { return BackingStore?.Get<byte[]?>("manifest"); }
            set { BackingStore?.Set("manifest", value); }
        }
#nullable restore
#else
        public byte[] Manifest
        {
            get { return BackingStore?.Get<byte[]>("manifest"); }
            set { BackingStore?.Set("manifest", value); }
        }
#endif
        /// <summary>Indicates the name of the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The size of the file prior to encryption. To be deprecated, please use sizeInBytes property instead.</summary>
        public long? Size
        {
            get { return BackingStore?.Get<long?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>The size of the file after encryption. To be deprecated, please use sizeEncryptedInBytes property instead.</summary>
        public long? SizeEncrypted
        {
            get { return BackingStore?.Get<long?>("sizeEncrypted"); }
            set { BackingStore?.Set("sizeEncrypted", value); }
        }
        /// <summary>Indicates the size of the file after encryption, in bytes. Valid values 0 to 9.22337203685478E+18</summary>
        public long? SizeEncryptedInBytes
        {
            get { return BackingStore?.Get<long?>("sizeEncryptedInBytes"); }
            set { BackingStore?.Set("sizeEncryptedInBytes", value); }
        }
        /// <summary>Indicates the original size of the file, in bytes. Valid values 0 to 9.22337203685478E+18</summary>
        public long? SizeInBytes
        {
            get { return BackingStore?.Get<long?>("sizeInBytes"); }
            set { BackingStore?.Set("sizeInBytes", value); }
        }
        /// <summary>Contains properties for upload request states.</summary>
        public Microsoft.Graph.Beta.Models.MobileAppContentFileUploadState? UploadState
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MobileAppContentFileUploadState?>("uploadState"); }
            set { BackingStore?.Set("uploadState", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MobileAppContentFile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MobileAppContentFile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MobileAppContentFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "azureStorageUri", n => { AzureStorageUri = n.GetStringValue(); } },
                { "azureStorageUriExpirationDateTime", n => { AzureStorageUriExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "isCommitted", n => { IsCommitted = n.GetBoolValue(); } },
                { "isDependency", n => { IsDependency = n.GetBoolValue(); } },
                { "isFrameworkFile", n => { IsFrameworkFile = n.GetBoolValue(); } },
                { "manifest", n => { Manifest = n.GetByteArrayValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "size", n => { Size = n.GetLongValue(); } },
                { "sizeEncrypted", n => { SizeEncrypted = n.GetLongValue(); } },
                { "sizeEncryptedInBytes", n => { SizeEncryptedInBytes = n.GetLongValue(); } },
                { "sizeInBytes", n => { SizeInBytes = n.GetLongValue(); } },
                { "uploadState", n => { UploadState = n.GetEnumValue<Microsoft.Graph.Beta.Models.MobileAppContentFileUploadState>(); } },
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
            writer.WriteBoolValue("isDependency", IsDependency);
            writer.WriteBoolValue("isFrameworkFile", IsFrameworkFile);
            writer.WriteByteArrayValue("manifest", Manifest);
            writer.WriteStringValue("name", Name);
            writer.WriteLongValue("size", Size);
            writer.WriteLongValue("sizeEncrypted", SizeEncrypted);
            writer.WriteLongValue("sizeEncryptedInBytes", SizeEncryptedInBytes);
            writer.WriteLongValue("sizeInBytes", SizeInBytes);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.MobileAppContentFileUploadState>("uploadState", UploadState);
        }
    }
}
