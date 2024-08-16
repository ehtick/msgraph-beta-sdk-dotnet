// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class Authentication : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the email addresses registered to a user for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.EmailAuthenticationMethod>? EmailMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.EmailAuthenticationMethod>?>("emailMethods"); }
            set { BackingStore?.Set("emailMethods", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.EmailAuthenticationMethod> EmailMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.EmailAuthenticationMethod>>("emailMethods"); }
            set { BackingStore?.Set("emailMethods", value); }
        }
#endif
        /// <summary>Represents the FIDO2 security keys registered to a user for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Fido2AuthenticationMethod>? Fido2Methods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Fido2AuthenticationMethod>?>("fido2Methods"); }
            set { BackingStore?.Set("fido2Methods", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Fido2AuthenticationMethod> Fido2Methods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Fido2AuthenticationMethod>>("fido2Methods"); }
            set { BackingStore?.Set("fido2Methods", value); }
        }
#endif
        /// <summary>Represents all authentication methods registered to a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.AuthenticationMethod>? Methods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AuthenticationMethod>?>("methods"); }
            set { BackingStore?.Set("methods", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.AuthenticationMethod> Methods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AuthenticationMethod>>("methods"); }
            set { BackingStore?.Set("methods", value); }
        }
#endif
        /// <summary>The details of the Microsoft Authenticator app registered to a user for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethod>? MicrosoftAuthenticatorMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethod>?>("microsoftAuthenticatorMethods"); }
            set { BackingStore?.Set("microsoftAuthenticatorMethods", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethod> MicrosoftAuthenticatorMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethod>>("microsoftAuthenticatorMethods"); }
            set { BackingStore?.Set("microsoftAuthenticatorMethods", value); }
        }
#endif
        /// <summary>The operations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.LongRunningOperation>? Operations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.LongRunningOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.LongRunningOperation> Operations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.LongRunningOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>Represents the Microsoft Authenticator Passwordless Phone Sign-in methods registered to a user for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PasswordlessMicrosoftAuthenticatorAuthenticationMethod>? PasswordlessMicrosoftAuthenticatorMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PasswordlessMicrosoftAuthenticatorAuthenticationMethod>?>("passwordlessMicrosoftAuthenticatorMethods"); }
            set { BackingStore?.Set("passwordlessMicrosoftAuthenticatorMethods", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PasswordlessMicrosoftAuthenticatorAuthenticationMethod> PasswordlessMicrosoftAuthenticatorMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PasswordlessMicrosoftAuthenticatorAuthenticationMethod>>("passwordlessMicrosoftAuthenticatorMethods"); }
            set { BackingStore?.Set("passwordlessMicrosoftAuthenticatorMethods", value); }
        }
#endif
        /// <summary>Represents the details of the password authentication method registered to a user for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PasswordAuthenticationMethod>? PasswordMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PasswordAuthenticationMethod>?>("passwordMethods"); }
            set { BackingStore?.Set("passwordMethods", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PasswordAuthenticationMethod> PasswordMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PasswordAuthenticationMethod>>("passwordMethods"); }
            set { BackingStore?.Set("passwordMethods", value); }
        }
#endif
        /// <summary>Represents the phone registered to a user for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PhoneAuthenticationMethod>? PhoneMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PhoneAuthenticationMethod>?>("phoneMethods"); }
            set { BackingStore?.Set("phoneMethods", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PhoneAuthenticationMethod> PhoneMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PhoneAuthenticationMethod>>("phoneMethods"); }
            set { BackingStore?.Set("phoneMethods", value); }
        }
#endif
        /// <summary>The platformCredentialMethods property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.PlatformCredentialAuthenticationMethod>? PlatformCredentialMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlatformCredentialAuthenticationMethod>?>("platformCredentialMethods"); }
            set { BackingStore?.Set("platformCredentialMethods", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.PlatformCredentialAuthenticationMethod> PlatformCredentialMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.PlatformCredentialAuthenticationMethod>>("platformCredentialMethods"); }
            set { BackingStore?.Set("platformCredentialMethods", value); }
        }
#endif
        /// <summary>The settings and preferences for the sign-in experience of a user. Use this property to configure the user&apos;s default multifactor authentication (MFA) method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SignInPreferences? SignInPreferences
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SignInPreferences?>("signInPreferences"); }
            set { BackingStore?.Set("signInPreferences", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SignInPreferences SignInPreferences
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SignInPreferences>("signInPreferences"); }
            set { BackingStore?.Set("signInPreferences", value); }
        }
#endif
        /// <summary>The software OATH time-based one-time password (TOTP) applications registered to a user for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.SoftwareOathAuthenticationMethod>? SoftwareOathMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.SoftwareOathAuthenticationMethod>?>("softwareOathMethods"); }
            set { BackingStore?.Set("softwareOathMethods", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.SoftwareOathAuthenticationMethod> SoftwareOathMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.SoftwareOathAuthenticationMethod>>("softwareOathMethods"); }
            set { BackingStore?.Set("softwareOathMethods", value); }
        }
#endif
        /// <summary>Represents a Temporary Access Pass registered to a user for authentication through time-limited passcodes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod>? TemporaryAccessPassMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod>?>("temporaryAccessPassMethods"); }
            set { BackingStore?.Set("temporaryAccessPassMethods", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod> TemporaryAccessPassMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod>>("temporaryAccessPassMethods"); }
            set { BackingStore?.Set("temporaryAccessPassMethods", value); }
        }
#endif
        /// <summary>Represents the Windows Hello for Business authentication method registered to a user for authentication.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsHelloForBusinessAuthenticationMethod>? WindowsHelloForBusinessMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsHelloForBusinessAuthenticationMethod>?>("windowsHelloForBusinessMethods"); }
            set { BackingStore?.Set("windowsHelloForBusinessMethods", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsHelloForBusinessAuthenticationMethod> WindowsHelloForBusinessMethods
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsHelloForBusinessAuthenticationMethod>>("windowsHelloForBusinessMethods"); }
            set { BackingStore?.Set("windowsHelloForBusinessMethods", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Authentication"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Authentication CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Authentication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "emailMethods", n => { EmailMethods = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.EmailAuthenticationMethod>(Microsoft.Graph.Beta.Models.EmailAuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                { "fido2Methods", n => { Fido2Methods = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Fido2AuthenticationMethod>(Microsoft.Graph.Beta.Models.Fido2AuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                { "methods", n => { Methods = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AuthenticationMethod>(Microsoft.Graph.Beta.Models.AuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                { "microsoftAuthenticatorMethods", n => { MicrosoftAuthenticatorMethods = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethod>(Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.LongRunningOperation>(Microsoft.Graph.Beta.Models.LongRunningOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                { "passwordMethods", n => { PasswordMethods = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PasswordAuthenticationMethod>(Microsoft.Graph.Beta.Models.PasswordAuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                { "passwordlessMicrosoftAuthenticatorMethods", n => { PasswordlessMicrosoftAuthenticatorMethods = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PasswordlessMicrosoftAuthenticatorAuthenticationMethod>(Microsoft.Graph.Beta.Models.PasswordlessMicrosoftAuthenticatorAuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                { "phoneMethods", n => { PhoneMethods = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PhoneAuthenticationMethod>(Microsoft.Graph.Beta.Models.PhoneAuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                { "platformCredentialMethods", n => { PlatformCredentialMethods = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlatformCredentialAuthenticationMethod>(Microsoft.Graph.Beta.Models.PlatformCredentialAuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                { "signInPreferences", n => { SignInPreferences = n.GetObjectValue<Microsoft.Graph.Beta.Models.SignInPreferences>(Microsoft.Graph.Beta.Models.SignInPreferences.CreateFromDiscriminatorValue); } },
                { "softwareOathMethods", n => { SoftwareOathMethods = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.SoftwareOathAuthenticationMethod>(Microsoft.Graph.Beta.Models.SoftwareOathAuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                { "temporaryAccessPassMethods", n => { TemporaryAccessPassMethods = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod>(Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
                { "windowsHelloForBusinessMethods", n => { WindowsHelloForBusinessMethods = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsHelloForBusinessAuthenticationMethod>(Microsoft.Graph.Beta.Models.WindowsHelloForBusinessAuthenticationMethod.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.EmailAuthenticationMethod>("emailMethods", EmailMethods);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Fido2AuthenticationMethod>("fido2Methods", Fido2Methods);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AuthenticationMethod>("methods", Methods);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.MicrosoftAuthenticatorAuthenticationMethod>("microsoftAuthenticatorMethods", MicrosoftAuthenticatorMethods);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.LongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PasswordlessMicrosoftAuthenticatorAuthenticationMethod>("passwordlessMicrosoftAuthenticatorMethods", PasswordlessMicrosoftAuthenticatorMethods);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PasswordAuthenticationMethod>("passwordMethods", PasswordMethods);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PhoneAuthenticationMethod>("phoneMethods", PhoneMethods);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.PlatformCredentialAuthenticationMethod>("platformCredentialMethods", PlatformCredentialMethods);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SignInPreferences>("signInPreferences", SignInPreferences);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.SoftwareOathAuthenticationMethod>("softwareOathMethods", SoftwareOathMethods);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.TemporaryAccessPassAuthenticationMethod>("temporaryAccessPassMethods", TemporaryAccessPassMethods);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsHelloForBusinessAuthenticationMethod>("windowsHelloForBusinessMethods", WindowsHelloForBusinessMethods);
        }
    }
}
