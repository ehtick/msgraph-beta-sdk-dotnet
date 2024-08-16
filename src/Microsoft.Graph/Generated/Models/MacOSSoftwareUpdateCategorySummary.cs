// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// MacOS software update category summary report for a device and user
    /// </summary>
    public class MacOSSoftwareUpdateCategorySummary : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The device ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId
        {
            get { return BackingStore?.Get<string?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#nullable restore
#else
        public string DeviceId
        {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
#endif
        /// <summary>The name of the report</summary>
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
        /// <summary>Number of failed updates on the device</summary>
        public int? FailedUpdateCount
        {
            get { return BackingStore?.Get<int?>("failedUpdateCount"); }
            set { BackingStore?.Set("failedUpdateCount", value); }
        }
        /// <summary>Last date time the report for this device was updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>Number of successful updates on the device</summary>
        public int? SuccessfulUpdateCount
        {
            get { return BackingStore?.Get<int?>("successfulUpdateCount"); }
            set { BackingStore?.Set("successfulUpdateCount", value); }
        }
        /// <summary>Number of total updates on the device</summary>
        public int? TotalUpdateCount
        {
            get { return BackingStore?.Get<int?>("totalUpdateCount"); }
            set { BackingStore?.Set("totalUpdateCount", value); }
        }
        /// <summary>MacOS Software Update Category</summary>
        public Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateCategory? UpdateCategory
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateCategory?>("updateCategory"); }
            set { BackingStore?.Set("updateCategory", value); }
        }
        /// <summary>Summary of the update states.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateStateSummary>? UpdateStateSummaries
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateStateSummary>?>("updateStateSummaries"); }
            set { BackingStore?.Set("updateStateSummaries", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateStateSummary> UpdateStateSummaries
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateStateSummary>>("updateStateSummaries"); }
            set { BackingStore?.Set("updateStateSummaries", value); }
        }
#endif
        /// <summary>The user ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId
        {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId
        {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateCategorySummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateCategorySummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateCategorySummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deviceId", n => { DeviceId = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "failedUpdateCount", n => { FailedUpdateCount = n.GetIntValue(); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "successfulUpdateCount", n => { SuccessfulUpdateCount = n.GetIntValue(); } },
                { "totalUpdateCount", n => { TotalUpdateCount = n.GetIntValue(); } },
                { "updateCategory", n => { UpdateCategory = n.GetEnumValue<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateCategory>(); } },
                { "updateStateSummaries", n => { UpdateStateSummaries = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateStateSummary>(Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
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
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("failedUpdateCount", FailedUpdateCount);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteIntValue("successfulUpdateCount", SuccessfulUpdateCount);
            writer.WriteIntValue("totalUpdateCount", TotalUpdateCount);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateCategory>("updateCategory", UpdateCategory);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MacOSSoftwareUpdateStateSummary>("updateStateSummaries", UpdateStateSummaries);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
