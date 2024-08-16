// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AuthorizationPolicy : Microsoft.Graph.Beta.Models.PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether users can sign up for email based subscriptions.</summary>
        public bool? AllowedToSignUpEmailBasedSubscriptions
        {
            get { return BackingStore?.Get<bool?>("allowedToSignUpEmailBasedSubscriptions"); }
            set { BackingStore?.Set("allowedToSignUpEmailBasedSubscriptions", value); }
        }
        /// <summary>Indicates whether administrators of the tenant can use the Self-Service Password Reset (SSPR). For more information, see Self-service password reset for administrators.</summary>
        public bool? AllowedToUseSSPR
        {
            get { return BackingStore?.Get<bool?>("allowedToUseSSPR"); }
            set { BackingStore?.Set("allowedToUseSSPR", value); }
        }
        /// <summary>Indicates whether a user can join the tenant by email validation.</summary>
        public bool? AllowEmailVerifiedUsersToJoinOrganization
        {
            get { return BackingStore?.Get<bool?>("allowEmailVerifiedUsersToJoinOrganization"); }
            set { BackingStore?.Set("allowEmailVerifiedUsersToJoinOrganization", value); }
        }
        /// <summary>Indicates who can invite guests to the organization. Possible values are: none, adminsAndGuestInviters, adminsGuestInvitersAndAllMembers, everyone. everyone is the default setting for all cloud environments except US Government. For more information, see allowInvitesFrom values.</summary>
        public Microsoft.Graph.Beta.Models.AllowInvitesFrom? AllowInvitesFrom
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AllowInvitesFrom?>("allowInvitesFrom"); }
            set { BackingStore?.Set("allowInvitesFrom", value); }
        }
        /// <summary>Indicates whether user consent for risky apps is allowed. Default value is false. We recommend that you keep the value set to false.</summary>
        public bool? AllowUserConsentForRiskyApps
        {
            get { return BackingStore?.Get<bool?>("allowUserConsentForRiskyApps"); }
            set { BackingStore?.Set("allowUserConsentForRiskyApps", value); }
        }
        /// <summary>To disable the use of the MSOnline PowerShell module set this property to true. This also disables user-based access to the legacy service endpoint used by the MSOnline PowerShell module. This doesn&apos;t affect Microsoft Entra Connect or Microsoft Graph.</summary>
        public bool? BlockMsolPowerShell
        {
            get { return BackingStore?.Get<bool?>("blockMsolPowerShell"); }
            set { BackingStore?.Set("blockMsolPowerShell", value); }
        }
        /// <summary>The defaultUserRoleOverrides property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DefaultUserRoleOverride>? DefaultUserRoleOverrides
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DefaultUserRoleOverride>?>("defaultUserRoleOverrides"); }
            set { BackingStore?.Set("defaultUserRoleOverrides", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DefaultUserRoleOverride> DefaultUserRoleOverrides
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DefaultUserRoleOverride>>("defaultUserRoleOverrides"); }
            set { BackingStore?.Set("defaultUserRoleOverrides", value); }
        }
#endif
        /// <summary>The defaultUserRolePermissions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.DefaultUserRolePermissions? DefaultUserRolePermissions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefaultUserRolePermissions?>("defaultUserRolePermissions"); }
            set { BackingStore?.Set("defaultUserRolePermissions", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.DefaultUserRolePermissions DefaultUserRolePermissions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DefaultUserRolePermissions>("defaultUserRolePermissions"); }
            set { BackingStore?.Set("defaultUserRolePermissions", value); }
        }
#endif
        /// <summary>List of features enabled for private preview on the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnabledPreviewFeatures
        {
            get { return BackingStore?.Get<List<string>?>("enabledPreviewFeatures"); }
            set { BackingStore?.Set("enabledPreviewFeatures", value); }
        }
#nullable restore
#else
        public List<string> EnabledPreviewFeatures
        {
            get { return BackingStore?.Get<List<string>>("enabledPreviewFeatures"); }
            set { BackingStore?.Set("enabledPreviewFeatures", value); }
        }
#endif
        /// <summary>Represents role templateId for the role that should be granted to guests. Refer to List unifiedRoleDefinitions to find the list of available role templates. Currently following roles are supported:  User (a0b1b346-4d3e-4e8b-98f8-753987be4970), Guest User (10dae51f-b6af-4016-8d66-8c2a99b929b3), and Restricted Guest User (2af84b1e-32c8-42b7-82bc-daa82404023b).</summary>
        public Guid? GuestUserRoleId
        {
            get { return BackingStore?.Get<Guid?>("guestUserRoleId"); }
            set { BackingStore?.Set("guestUserRoleId", value); }
        }
        /// <summary>Indicates if user consent to apps is allowed, and if it is, the app consent policy that governs the permission for users to grant consent. Values should be in the format managePermissionGrantsForSelf.{id} for user consent policies or managePermissionGrantsForOwnedResource.{id} for resource-specific consent policies, where {id} is the id of a built-in or custom app consent policy. An empty list indicates user consent to apps is disabled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? PermissionGrantPolicyIdsAssignedToDefaultUserRole
        {
            get { return BackingStore?.Get<List<string>?>("permissionGrantPolicyIdsAssignedToDefaultUserRole"); }
            set { BackingStore?.Set("permissionGrantPolicyIdsAssignedToDefaultUserRole", value); }
        }
#nullable restore
#else
        public List<string> PermissionGrantPolicyIdsAssignedToDefaultUserRole
        {
            get { return BackingStore?.Get<List<string>>("permissionGrantPolicyIdsAssignedToDefaultUserRole"); }
            set { BackingStore?.Set("permissionGrantPolicyIdsAssignedToDefaultUserRole", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.AuthorizationPolicy"/> and sets the default values.
        /// </summary>
        public AuthorizationPolicy() : base()
        {
            OdataType = "#microsoft.graph.authorizationPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AuthorizationPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AuthorizationPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AuthorizationPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowEmailVerifiedUsersToJoinOrganization", n => { AllowEmailVerifiedUsersToJoinOrganization = n.GetBoolValue(); } },
                { "allowInvitesFrom", n => { AllowInvitesFrom = n.GetEnumValue<Microsoft.Graph.Beta.Models.AllowInvitesFrom>(); } },
                { "allowUserConsentForRiskyApps", n => { AllowUserConsentForRiskyApps = n.GetBoolValue(); } },
                { "allowedToSignUpEmailBasedSubscriptions", n => { AllowedToSignUpEmailBasedSubscriptions = n.GetBoolValue(); } },
                { "allowedToUseSSPR", n => { AllowedToUseSSPR = n.GetBoolValue(); } },
                { "blockMsolPowerShell", n => { BlockMsolPowerShell = n.GetBoolValue(); } },
                { "defaultUserRoleOverrides", n => { DefaultUserRoleOverrides = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DefaultUserRoleOverride>(Microsoft.Graph.Beta.Models.DefaultUserRoleOverride.CreateFromDiscriminatorValue)?.ToList(); } },
                { "defaultUserRolePermissions", n => { DefaultUserRolePermissions = n.GetObjectValue<Microsoft.Graph.Beta.Models.DefaultUserRolePermissions>(Microsoft.Graph.Beta.Models.DefaultUserRolePermissions.CreateFromDiscriminatorValue); } },
                { "enabledPreviewFeatures", n => { EnabledPreviewFeatures = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "guestUserRoleId", n => { GuestUserRoleId = n.GetGuidValue(); } },
                { "permissionGrantPolicyIdsAssignedToDefaultUserRole", n => { PermissionGrantPolicyIdsAssignedToDefaultUserRole = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteBoolValue("allowedToSignUpEmailBasedSubscriptions", AllowedToSignUpEmailBasedSubscriptions);
            writer.WriteBoolValue("allowedToUseSSPR", AllowedToUseSSPR);
            writer.WriteBoolValue("allowEmailVerifiedUsersToJoinOrganization", AllowEmailVerifiedUsersToJoinOrganization);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.AllowInvitesFrom>("allowInvitesFrom", AllowInvitesFrom);
            writer.WriteBoolValue("allowUserConsentForRiskyApps", AllowUserConsentForRiskyApps);
            writer.WriteBoolValue("blockMsolPowerShell", BlockMsolPowerShell);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DefaultUserRoleOverride>("defaultUserRoleOverrides", DefaultUserRoleOverrides);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DefaultUserRolePermissions>("defaultUserRolePermissions", DefaultUserRolePermissions);
            writer.WriteCollectionOfPrimitiveValues<string>("enabledPreviewFeatures", EnabledPreviewFeatures);
            writer.WriteGuidValue("guestUserRoleId", GuestUserRoleId);
            writer.WriteCollectionOfPrimitiveValues<string>("permissionGrantPolicyIdsAssignedToDefaultUserRole", PermissionGrantPolicyIdsAssignedToDefaultUserRole);
        }
    }
}
