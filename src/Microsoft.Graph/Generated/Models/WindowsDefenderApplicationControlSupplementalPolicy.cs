// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class WindowsDefenderApplicationControlSupplementalPolicy : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The associated group assignments for the Windows Defender Application Control Supplemental Policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyAssignment>? Assignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyAssignment> Assignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Indicates the content of the Windows Defender Application Control Supplemental Policy in byte array format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Content
        {
            get { return BackingStore?.Get<byte[]?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public byte[] Content
        {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>Indicates the file name associated with the content of the Windows Defender Application Control Supplemental Policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentFileName
        {
            get { return BackingStore?.Get<string?>("contentFileName"); }
            set { BackingStore?.Set("contentFileName", value); }
        }
#nullable restore
#else
        public string ContentFileName
        {
            get { return BackingStore?.Get<string>("contentFileName"); }
            set { BackingStore?.Set("contentFileName", value); }
        }
#endif
        /// <summary>Indicates the created date and time when the Windows Defender Application Control Supplemental Policy was uploaded.</summary>
        public DateTimeOffset? CreationDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("creationDateTime"); }
            set { BackingStore?.Set("creationDateTime", value); }
        }
        /// <summary>WindowsDefenderApplicationControl supplemental policy deployment summary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary? DeploySummary
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary?>("deploySummary"); }
            set { BackingStore?.Set("deploySummary", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary DeploySummary
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>("deploySummary"); }
            set { BackingStore?.Set("deploySummary", value); }
        }
#endif
        /// <summary>The description of the Windows Defender Application Control Supplemental Policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>The list of device deployment states for this WindowsDefenderApplicationControl supplemental policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>? DeviceStatuses
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>?>("deviceStatuses"); }
            set { BackingStore?.Set("deviceStatuses", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus> DeviceStatuses
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>>("deviceStatuses"); }
            set { BackingStore?.Set("deviceStatuses", value); }
        }
#endif
        /// <summary>The display name of the Windows Defender Application Control Supplemental Policy.</summary>
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
        /// <summary>Indicates the last modified date and time of the Windows Defender Application Control Supplemental Policy.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>List of Scope Tags for the Windows Defender Application Control Supplemental Policy entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>?>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#nullable restore
#else
        public List<string> RoleScopeTagIds
        {
            get { return BackingStore?.Get<List<string>>("roleScopeTagIds"); }
            set { BackingStore?.Set("roleScopeTagIds", value); }
        }
#endif
        /// <summary>Indicates the Windows Defender Application Control Supplemental Policy&apos;s version.</summary>
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyAssignment>(Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "content", n => { Content = n.GetByteArrayValue(); } },
                { "contentFileName", n => { ContentFileName = n.GetStringValue(); } },
                { "creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                { "deploySummary", n => { DeploySummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>(Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>(Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyAssignment>("assignments", Assignments);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("contentFileName", ContentFileName);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary>("deploySummary", DeploySummary);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsDefenderApplicationControlSupplementalPolicyDeploymentStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteStringValue("version", Version);
        }
    }
}
