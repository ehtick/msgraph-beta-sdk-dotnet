// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// iOS Device Features Configuration Profile.
    /// </summary>
    public class IosDeviceFeaturesConfiguration : Microsoft.Graph.Beta.Models.AppleDeviceFeaturesConfigurationBase, IParsable
    {
        /// <summary>Asset tag information for the device, displayed on the login window and lock screen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssetTagTemplate
        {
            get { return BackingStore?.Get<string?>("assetTagTemplate"); }
            set { BackingStore?.Set("assetTagTemplate", value); }
        }
#nullable restore
#else
        public string AssetTagTemplate
        {
            get { return BackingStore?.Get<string>("assetTagTemplate"); }
            set { BackingStore?.Set("assetTagTemplate", value); }
        }
#endif
        /// <summary>Gets or sets iOS Web Content Filter settings, supervised mode only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IosWebContentFilterBase? ContentFilterSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosWebContentFilterBase?>("contentFilterSettings"); }
            set { BackingStore?.Set("contentFilterSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IosWebContentFilterBase ContentFilterSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosWebContentFilterBase>("contentFilterSettings"); }
            set { BackingStore?.Set("contentFilterSettings", value); }
        }
#endif
        /// <summary>A list of app and folders to appear on the Home Screen Dock. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IosHomeScreenItem>? HomeScreenDockIcons
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IosHomeScreenItem>?>("homeScreenDockIcons"); }
            set { BackingStore?.Set("homeScreenDockIcons", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IosHomeScreenItem> HomeScreenDockIcons
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IosHomeScreenItem>>("homeScreenDockIcons"); }
            set { BackingStore?.Set("homeScreenDockIcons", value); }
        }
#endif
        /// <summary>Gets or sets the number of rows to render when configuring iOS home screen layout settings. If this value is configured, homeScreenGridWidth must be configured as well.</summary>
        public int? HomeScreenGridHeight
        {
            get { return BackingStore?.Get<int?>("homeScreenGridHeight"); }
            set { BackingStore?.Set("homeScreenGridHeight", value); }
        }
        /// <summary>Gets or sets the number of columns to render when configuring iOS home screen layout settings. If this value is configured, homeScreenGridHeight must be configured as well.</summary>
        public int? HomeScreenGridWidth
        {
            get { return BackingStore?.Get<int?>("homeScreenGridWidth"); }
            set { BackingStore?.Set("homeScreenGridWidth", value); }
        }
        /// <summary>A list of pages on the Home Screen. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IosHomeScreenPage>? HomeScreenPages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IosHomeScreenPage>?>("homeScreenPages"); }
            set { BackingStore?.Set("homeScreenPages", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IosHomeScreenPage> HomeScreenPages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IosHomeScreenPage>>("homeScreenPages"); }
            set { BackingStore?.Set("homeScreenPages", value); }
        }
#endif
        /// <summary>Identity Certificate for the renewal of Kerberos ticket used in single sign-on settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IosCertificateProfileBase? IdentityCertificateForClientAuthentication
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosCertificateProfileBase?>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IosCertificateProfileBase IdentityCertificateForClientAuthentication
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosCertificateProfileBase>("identityCertificateForClientAuthentication"); }
            set { BackingStore?.Set("identityCertificateForClientAuthentication", value); }
        }
#endif
        /// <summary>Gets or sets a single sign-on extension profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IosSingleSignOnExtension? IosSingleSignOnExtension
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosSingleSignOnExtension?>("iosSingleSignOnExtension"); }
            set { BackingStore?.Set("iosSingleSignOnExtension", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IosSingleSignOnExtension IosSingleSignOnExtension
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosSingleSignOnExtension>("iosSingleSignOnExtension"); }
            set { BackingStore?.Set("iosSingleSignOnExtension", value); }
        }
#endif
        /// <summary>A footnote displayed on the login window and lock screen. Available in iOS 9.3.1 and later.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LockScreenFootnote
        {
            get { return BackingStore?.Get<string?>("lockScreenFootnote"); }
            set { BackingStore?.Set("lockScreenFootnote", value); }
        }
#nullable restore
#else
        public string LockScreenFootnote
        {
            get { return BackingStore?.Get<string>("lockScreenFootnote"); }
            set { BackingStore?.Set("lockScreenFootnote", value); }
        }
#endif
        /// <summary>Notification settings for each bundle id. Applicable to devices in supervised mode only (iOS 9.3 and later). This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.IosNotificationSettings>? NotificationSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IosNotificationSettings>?>("notificationSettings"); }
            set { BackingStore?.Set("notificationSettings", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.IosNotificationSettings> NotificationSettings
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.IosNotificationSettings>>("notificationSettings"); }
            set { BackingStore?.Set("notificationSettings", value); }
        }
#endif
        /// <summary>Gets or sets a single sign-on extension profile. Deprecated: use IOSSingleSignOnExtension instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SingleSignOnExtension? SingleSignOnExtension
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SingleSignOnExtension?>("singleSignOnExtension"); }
            set { BackingStore?.Set("singleSignOnExtension", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SingleSignOnExtension SingleSignOnExtension
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SingleSignOnExtension>("singleSignOnExtension"); }
            set { BackingStore?.Set("singleSignOnExtension", value); }
        }
#endif
        /// <summary>PKINIT Certificate for the authentication with single sign-on extension settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IosCertificateProfileBase? SingleSignOnExtensionPkinitCertificate
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosCertificateProfileBase?>("singleSignOnExtensionPkinitCertificate"); }
            set { BackingStore?.Set("singleSignOnExtensionPkinitCertificate", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IosCertificateProfileBase SingleSignOnExtensionPkinitCertificate
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosCertificateProfileBase>("singleSignOnExtensionPkinitCertificate"); }
            set { BackingStore?.Set("singleSignOnExtensionPkinitCertificate", value); }
        }
#endif
        /// <summary>The Kerberos login settings that enable apps on receiving devices to authenticate smoothly.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IosSingleSignOnSettings? SingleSignOnSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosSingleSignOnSettings?>("singleSignOnSettings"); }
            set { BackingStore?.Set("singleSignOnSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IosSingleSignOnSettings SingleSignOnSettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosSingleSignOnSettings>("singleSignOnSettings"); }
            set { BackingStore?.Set("singleSignOnSettings", value); }
        }
#endif
        /// <summary>An enum type for wallpaper display location specifier.</summary>
        public Microsoft.Graph.Beta.Models.IosWallpaperDisplayLocation? WallpaperDisplayLocation
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IosWallpaperDisplayLocation?>("wallpaperDisplayLocation"); }
            set { BackingStore?.Set("wallpaperDisplayLocation", value); }
        }
        /// <summary>A wallpaper image must be in either PNG or JPEG format. It requires a supervised device with iOS 8 or later version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.MimeContent? WallpaperImage
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MimeContent?>("wallpaperImage"); }
            set { BackingStore?.Set("wallpaperImage", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.MimeContent WallpaperImage
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MimeContent>("wallpaperImage"); }
            set { BackingStore?.Set("wallpaperImage", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.IosDeviceFeaturesConfiguration"/> and sets the default values.
        /// </summary>
        public IosDeviceFeaturesConfiguration() : base()
        {
            OdataType = "#microsoft.graph.iosDeviceFeaturesConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.IosDeviceFeaturesConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.IosDeviceFeaturesConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.IosDeviceFeaturesConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assetTagTemplate", n => { AssetTagTemplate = n.GetStringValue(); } },
                { "contentFilterSettings", n => { ContentFilterSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.IosWebContentFilterBase>(Microsoft.Graph.Beta.Models.IosWebContentFilterBase.CreateFromDiscriminatorValue); } },
                { "homeScreenDockIcons", n => { HomeScreenDockIcons = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IosHomeScreenItem>(Microsoft.Graph.Beta.Models.IosHomeScreenItem.CreateFromDiscriminatorValue)?.ToList(); } },
                { "homeScreenGridHeight", n => { HomeScreenGridHeight = n.GetIntValue(); } },
                { "homeScreenGridWidth", n => { HomeScreenGridWidth = n.GetIntValue(); } },
                { "homeScreenPages", n => { HomeScreenPages = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IosHomeScreenPage>(Microsoft.Graph.Beta.Models.IosHomeScreenPage.CreateFromDiscriminatorValue)?.ToList(); } },
                { "identityCertificateForClientAuthentication", n => { IdentityCertificateForClientAuthentication = n.GetObjectValue<Microsoft.Graph.Beta.Models.IosCertificateProfileBase>(Microsoft.Graph.Beta.Models.IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                { "iosSingleSignOnExtension", n => { IosSingleSignOnExtension = n.GetObjectValue<Microsoft.Graph.Beta.Models.IosSingleSignOnExtension>(Microsoft.Graph.Beta.Models.IosSingleSignOnExtension.CreateFromDiscriminatorValue); } },
                { "lockScreenFootnote", n => { LockScreenFootnote = n.GetStringValue(); } },
                { "notificationSettings", n => { NotificationSettings = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IosNotificationSettings>(Microsoft.Graph.Beta.Models.IosNotificationSettings.CreateFromDiscriminatorValue)?.ToList(); } },
                { "singleSignOnExtension", n => { SingleSignOnExtension = n.GetObjectValue<Microsoft.Graph.Beta.Models.SingleSignOnExtension>(Microsoft.Graph.Beta.Models.SingleSignOnExtension.CreateFromDiscriminatorValue); } },
                { "singleSignOnExtensionPkinitCertificate", n => { SingleSignOnExtensionPkinitCertificate = n.GetObjectValue<Microsoft.Graph.Beta.Models.IosCertificateProfileBase>(Microsoft.Graph.Beta.Models.IosCertificateProfileBase.CreateFromDiscriminatorValue); } },
                { "singleSignOnSettings", n => { SingleSignOnSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.IosSingleSignOnSettings>(Microsoft.Graph.Beta.Models.IosSingleSignOnSettings.CreateFromDiscriminatorValue); } },
                { "wallpaperDisplayLocation", n => { WallpaperDisplayLocation = n.GetEnumValue<Microsoft.Graph.Beta.Models.IosWallpaperDisplayLocation>(); } },
                { "wallpaperImage", n => { WallpaperImage = n.GetObjectValue<Microsoft.Graph.Beta.Models.MimeContent>(Microsoft.Graph.Beta.Models.MimeContent.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("assetTagTemplate", AssetTagTemplate);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IosWebContentFilterBase>("contentFilterSettings", ContentFilterSettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IosHomeScreenItem>("homeScreenDockIcons", HomeScreenDockIcons);
            writer.WriteIntValue("homeScreenGridHeight", HomeScreenGridHeight);
            writer.WriteIntValue("homeScreenGridWidth", HomeScreenGridWidth);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IosHomeScreenPage>("homeScreenPages", HomeScreenPages);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IosCertificateProfileBase>("identityCertificateForClientAuthentication", IdentityCertificateForClientAuthentication);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IosSingleSignOnExtension>("iosSingleSignOnExtension", IosSingleSignOnExtension);
            writer.WriteStringValue("lockScreenFootnote", LockScreenFootnote);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.IosNotificationSettings>("notificationSettings", NotificationSettings);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SingleSignOnExtension>("singleSignOnExtension", SingleSignOnExtension);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IosCertificateProfileBase>("singleSignOnExtensionPkinitCertificate", SingleSignOnExtensionPkinitCertificate);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IosSingleSignOnSettings>("singleSignOnSettings", SingleSignOnSettings);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.IosWallpaperDisplayLocation>("wallpaperDisplayLocation", WallpaperDisplayLocation);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MimeContent>("wallpaperImage", WallpaperImage);
        }
    }
}
