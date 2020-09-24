// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Ios Eas Email Profile Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosEasEmailProfileConfiguration : EasEmailProfileConfigurationBase
    {
    
		///<summary>
		/// The IosEasEmailProfileConfiguration constructor
		///</summary>
        public IosEasEmailProfileConfiguration()
        {
            this.ODataType = "microsoft.graph.iosEasEmailProfileConfiguration";
        }
	
        /// <summary>
        /// Gets or sets account name.
        /// Account name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountName", Required = Newtonsoft.Json.Required.Default)]
        public string AccountName { get; set; }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication method for this Email profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethod", Required = Newtonsoft.Json.Required.Default)]
        public EasAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets block moving messages to other email accounts.
        /// Indicates whether or not to block moving messages to other email accounts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "blockMovingMessagesToOtherEmailAccounts", Required = Newtonsoft.Json.Required.Default)]
        public bool? BlockMovingMessagesToOtherEmailAccounts { get; set; }
    
        /// <summary>
        /// Gets or sets block sending email from third party apps.
        /// Indicates whether or not to block sending email from third party apps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "blockSendingEmailFromThirdPartyApps", Required = Newtonsoft.Json.Required.Default)]
        public bool? BlockSendingEmailFromThirdPartyApps { get; set; }
    
        /// <summary>
        /// Gets or sets block syncing recently used email addresses.
        /// Indicates whether or not to block syncing recently used email addresses, for instance - when composing new email.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "blockSyncingRecentlyUsedEmailAddresses", Required = Newtonsoft.Json.Required.Default)]
        public bool? BlockSyncingRecentlyUsedEmailAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets duration of email to sync.
        /// Duration of time email should be synced back to. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "durationOfEmailToSync", Required = Newtonsoft.Json.Required.Default)]
        public EmailSyncDuration? DurationOfEmailToSync { get; set; }
    
        /// <summary>
        /// Gets or sets eas services.
        /// Exchange data to sync.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "easServices", Required = Newtonsoft.Json.Required.Default)]
        public EasServices? EasServices { get; set; }
    
        /// <summary>
        /// Gets or sets eas services user override enabled.
        /// Allow users to change sync settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "easServicesUserOverrideEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? EasServicesUserOverrideEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets email address source.
        /// Email attribute that is picked from AAD and injected into this profile before installing on the device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "emailAddressSource", Required = Newtonsoft.Json.Required.Default)]
        public UserEmailSource? EmailAddressSource { get; set; }
    
        /// <summary>
        /// Gets or sets encryption certificate type.
        /// Encryption Certificate type for this Email profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptionCertificateType", Required = Newtonsoft.Json.Required.Default)]
        public EmailCertificateType? EncryptionCertificateType { get; set; }
    
        /// <summary>
        /// Gets or sets host name.
        /// Exchange location that (URL) that the native mail app connects to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hostName", Required = Newtonsoft.Json.Required.Default)]
        public string HostName { get; set; }
    
        /// <summary>
        /// Gets or sets per app vpnprofile id.
        /// Profile ID of the Per-App VPN policy to be used to access emails from the native Mail client
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "perAppVPNProfileId", Required = Newtonsoft.Json.Required.Default)]
        public string PerAppVPNProfileId { get; set; }
    
        /// <summary>
        /// Gets or sets require smime.
        /// Indicates whether or not to use S/MIME certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireSmime", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireSmime { get; set; }
    
        /// <summary>
        /// Gets or sets require ssl.
        /// Indicates whether or not to use SSL.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireSsl", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireSsl { get; set; }
    
        /// <summary>
        /// Gets or sets signing certificate type.
        /// Signing Certificate type for this Email profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "signingCertificateType", Required = Newtonsoft.Json.Required.Default)]
        public EmailCertificateType? SigningCertificateType { get; set; }
    
        /// <summary>
        /// Gets or sets smime enable per message switch.
        /// Indicates whether or not to allow unencrypted emails.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smimeEnablePerMessageSwitch", Required = Newtonsoft.Json.Required.Default)]
        public bool? SmimeEnablePerMessageSwitch { get; set; }
    
        /// <summary>
        /// Gets or sets smime encrypt by default enabled.
        /// If set to true S/MIME encryption is enabled by default.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smimeEncryptByDefaultEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SmimeEncryptByDefaultEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets smime encrypt by default user override enabled.
        /// If set to true, the user can toggle the encryption by default setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smimeEncryptByDefaultUserOverrideEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SmimeEncryptByDefaultUserOverrideEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets smime encryption certificate user override enabled.
        /// If set to true the user can select the S/MIME encryption identity. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smimeEncryptionCertificateUserOverrideEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SmimeEncryptionCertificateUserOverrideEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets smime signing certificate user override enabled.
        /// If set to true, the user can select the signing identity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smimeSigningCertificateUserOverrideEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SmimeSigningCertificateUserOverrideEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets smime signing enabled.
        /// If set to true S/MIME signing is enabled for this account
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smimeSigningEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SmimeSigningEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets smime signing user override enabled.
        /// If set to true, the user can toggle S/MIME signing on or off.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smimeSigningUserOverrideEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? SmimeSigningUserOverrideEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets use oauth.
        /// Specifies whether the connection should use OAuth for authentication.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "useOAuth", Required = Newtonsoft.Json.Required.Default)]
        public bool? UseOAuth { get; set; }
    
        /// <summary>
        /// Gets or sets derived credential settings.
        /// Tenant level settings for the Derived Credentials to be used for authentication.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "derivedCredentialSettings", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementDerivedCredentialSettings DerivedCredentialSettings { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// Identity certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityCertificate", Required = Newtonsoft.Json.Required.Default)]
        public IosCertificateProfileBase IdentityCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets smime encryption certificate.
        /// S/MIME encryption certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smimeEncryptionCertificate", Required = Newtonsoft.Json.Required.Default)]
        public IosCertificateProfile SmimeEncryptionCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets smime signing certificate.
        /// S/MIME signing certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "smimeSigningCertificate", Required = Newtonsoft.Json.Required.Default)]
        public IosCertificateProfile SmimeSigningCertificate { get; set; }
    
    }
}

