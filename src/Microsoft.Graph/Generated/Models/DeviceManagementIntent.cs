// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Entity that represents an intent to apply settings to a device
    /// </summary>
    public class DeviceManagementIntent : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Collection of assignments</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DeviceManagementIntentAssignment>? Assignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementIntentAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DeviceManagementIntentAssignment> Assignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementIntentAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>Collection of setting categories within the intent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DeviceManagementIntentSettingCategory>? Categories
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementIntentSettingCategory>?>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DeviceManagementIntentSettingCategory> Categories
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementIntentSettingCategory>>("categories"); }
            set { BackingStore?.Set("categories", value); }
        }
#endif
        /// <summary>The user given description</summary>
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
        /// <summary>Collection of settings and their states and counts of devices that belong to corresponding state for all settings within the intent</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceSettingStateSummary>? DeviceSettingStateSummaries
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceSettingStateSummary>?>("deviceSettingStateSummaries"); }
            set { BackingStore?.Set("deviceSettingStateSummaries", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceSettingStateSummary> DeviceSettingStateSummaries
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceSettingStateSummary>>("deviceSettingStateSummaries"); }
            set { BackingStore?.Set("deviceSettingStateSummaries", value); }
        }
#endif
        /// <summary>Collection of states of all devices that the intent is applied to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceState>? DeviceStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceState>?>("deviceStates"); }
            set { BackingStore?.Set("deviceStates", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceState> DeviceStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceState>>("deviceStates"); }
            set { BackingStore?.Set("deviceStates", value); }
        }
#endif
        /// <summary>A summary of device states and counts of devices that belong to corresponding state for all devices that the intent is applied to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceStateSummary? DeviceStateSummary
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceStateSummary?>("deviceStateSummary"); }
            set { BackingStore?.Set("deviceStateSummary", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceStateSummary DeviceStateSummary
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceStateSummary>("deviceStateSummary"); }
            set { BackingStore?.Set("deviceStateSummary", value); }
        }
#endif
        /// <summary>The user given display name</summary>
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
        /// <summary>Signifies whether or not the intent is assigned to users</summary>
        public bool? IsAssigned
        {
            get { return BackingStore?.Get<bool?>("isAssigned"); }
            set { BackingStore?.Set("isAssigned", value); }
        }
        /// <summary>Signifies whether or not the intent is being migrated to the configurationPolicies endpoint</summary>
        public bool? IsMigratingToConfigurationPolicy
        {
            get { return BackingStore?.Get<bool?>("isMigratingToConfigurationPolicy"); }
            set { BackingStore?.Set("isMigratingToConfigurationPolicy", value); }
        }
        /// <summary>When the intent was last modified</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>List of Scope Tags for this Entity instance.</summary>
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
        /// <summary>Collection of all settings to be applied</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DeviceManagementSettingInstance>? Settings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementSettingInstance>?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DeviceManagementSettingInstance> Settings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementSettingInstance>>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>The ID of the template this intent was created from (if any)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateId
        {
            get { return BackingStore?.Get<string?>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#nullable restore
#else
        public string TemplateId
        {
            get { return BackingStore?.Get<string>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
#endif
        /// <summary>Collection of states of all users that the intent is applied to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DeviceManagementIntentUserState>? UserStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementIntentUserState>?>("userStates"); }
            set { BackingStore?.Set("userStates", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DeviceManagementIntentUserState> UserStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DeviceManagementIntentUserState>>("userStates"); }
            set { BackingStore?.Set("userStates", value); }
        }
#endif
        /// <summary>A summary of user states and counts of users that belong to corresponding state for all users that the intent is applied to</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DeviceManagementIntentUserStateSummary? UserStateSummary
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementIntentUserStateSummary?>("userStateSummary"); }
            set { BackingStore?.Set("userStateSummary", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DeviceManagementIntentUserStateSummary UserStateSummary
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceManagementIntentUserStateSummary>("userStateSummary"); }
            set { BackingStore?.Set("userStateSummary", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.DeviceManagementIntent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.DeviceManagementIntent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.DeviceManagementIntent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntentAssignment>(Microsoft.Graph.Beta.Models.DeviceManagementIntentAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "categories", n => { Categories = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntentSettingCategory>(Microsoft.Graph.Beta.Models.DeviceManagementIntentSettingCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "deviceSettingStateSummaries", n => { DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceSettingStateSummary>(Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceSettingStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                { "deviceStateSummary", n => { DeviceStateSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceStateSummary>(Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceStateSummary.CreateFromDiscriminatorValue); } },
                { "deviceStates", n => { DeviceStates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceState>(Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceState.CreateFromDiscriminatorValue)?.ToList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
                { "isMigratingToConfigurationPolicy", n => { IsMigratingToConfigurationPolicy = n.GetBoolValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "settings", n => { Settings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementSettingInstance>(Microsoft.Graph.Beta.Models.DeviceManagementSettingInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                { "templateId", n => { TemplateId = n.GetStringValue(); } },
                { "userStateSummary", n => { UserStateSummary = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementIntentUserStateSummary>(Microsoft.Graph.Beta.Models.DeviceManagementIntentUserStateSummary.CreateFromDiscriminatorValue); } },
                { "userStates", n => { UserStates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntentUserState>(Microsoft.Graph.Beta.Models.DeviceManagementIntentUserState.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntentAssignment>("assignments", Assignments);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntentSettingCategory>("categories", Categories);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceSettingStateSummary>("deviceSettingStateSummaries", DeviceSettingStateSummaries);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceState>("deviceStates", DeviceStates);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementIntentDeviceStateSummary>("deviceStateSummary", DeviceStateSummary);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isAssigned", IsAssigned);
            writer.WriteBoolValue("isMigratingToConfigurationPolicy", IsMigratingToConfigurationPolicy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementSettingInstance>("settings", Settings);
            writer.WriteStringValue("templateId", TemplateId);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DeviceManagementIntentUserState>("userStates", UserStates);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceManagementIntentUserStateSummary>("userStateSummary", UserStateSummary);
        }
    }
}
