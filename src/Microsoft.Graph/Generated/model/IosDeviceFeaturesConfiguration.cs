// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Ios Device Features Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<IosDeviceFeaturesConfiguration>))]
    public partial class IosDeviceFeaturesConfiguration : AppleDeviceFeaturesConfigurationBase
    {
    
        ///<summary>
        /// The IosDeviceFeaturesConfiguration constructor
        ///</summary>
        public IosDeviceFeaturesConfiguration()
        {
            this.ODataType = "microsoft.graph.iosDeviceFeaturesConfiguration";
        }

        /// <summary>
        /// Gets or sets asset tag template.
        /// Asset tag information for the device, displayed on the login window and lock screen.
        /// </summary>
        [JsonPropertyName("assetTagTemplate")]
        public string AssetTagTemplate { get; set; }
    
        /// <summary>
        /// Gets or sets content filter settings.
        /// Gets or sets iOS Web Content Filter settings, supervised mode only
        /// </summary>
        [JsonPropertyName("contentFilterSettings")]
        public IosWebContentFilterBase ContentFilterSettings { get; set; }
    
        /// <summary>
        /// Gets or sets home screen dock icons.
        /// A list of app and folders to appear on the Home Screen Dock. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("homeScreenDockIcons")]
        public IEnumerable<IosHomeScreenItem> HomeScreenDockIcons { get; set; }
    
        /// <summary>
        /// Gets or sets home screen grid height.
        /// Gets or sets the number of rows to render when configuring iOS home screen layout settings. If this value is configured, homeScreenGridWidth must be configured as well.
        /// </summary>
        [JsonPropertyName("homeScreenGridHeight")]
        public Int32? HomeScreenGridHeight { get; set; }
    
        /// <summary>
        /// Gets or sets home screen grid width.
        /// Gets or sets the number of columns to render when configuring iOS home screen layout settings. If this value is configured, homeScreenGridHeight must be configured as well.
        /// </summary>
        [JsonPropertyName("homeScreenGridWidth")]
        public Int32? HomeScreenGridWidth { get; set; }
    
        /// <summary>
        /// Gets or sets home screen pages.
        /// A list of pages on the Home Screen. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("homeScreenPages")]
        public IEnumerable<IosHomeScreenPage> HomeScreenPages { get; set; }
    
        /// <summary>
        /// Gets or sets ios single sign on extension.
        /// Gets or sets a single sign-on extension profile.
        /// </summary>
        [JsonPropertyName("iosSingleSignOnExtension")]
        public IosSingleSignOnExtension IosSingleSignOnExtension { get; set; }
    
        /// <summary>
        /// Gets or sets lock screen footnote.
        /// A footnote displayed on the login window and lock screen. Available in iOS 9.3.1 and later.
        /// </summary>
        [JsonPropertyName("lockScreenFootnote")]
        public string LockScreenFootnote { get; set; }
    
        /// <summary>
        /// Gets or sets notification settings.
        /// Notification settings for each bundle id. Applicable to devices in supervised mode only (iOS 9.3 and later). This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("notificationSettings")]
        public IEnumerable<IosNotificationSettings> NotificationSettings { get; set; }
    
        /// <summary>
        /// Gets or sets single sign on extension.
        /// Gets or sets a single sign-on extension profile. Deprecated: use IOSSingleSignOnExtension instead.
        /// </summary>
        [JsonPropertyName("singleSignOnExtension")]
        public SingleSignOnExtension SingleSignOnExtension { get; set; }
    
        /// <summary>
        /// Gets or sets single sign on settings.
        /// The Kerberos login settings that enable apps on receiving devices to authenticate smoothly.
        /// </summary>
        [JsonPropertyName("singleSignOnSettings")]
        public IosSingleSignOnSettings SingleSignOnSettings { get; set; }
    
        /// <summary>
        /// Gets or sets wallpaper display location.
        /// A wallpaper display location specifier. Possible values are: notConfigured, lockScreen, homeScreen, lockAndHomeScreens.
        /// </summary>
        [JsonPropertyName("wallpaperDisplayLocation")]
        public IosWallpaperDisplayLocation? WallpaperDisplayLocation { get; set; }
    
        /// <summary>
        /// Gets or sets wallpaper image.
        /// A wallpaper image must be in either PNG or JPEG format. It requires a supervised device with iOS 8 or later version.
        /// </summary>
        [JsonPropertyName("wallpaperImage")]
        public MimeContent WallpaperImage { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate for client authentication.
        /// Identity Certificate for the renewal of Kerberos ticket used in single sign-on settings.
        /// </summary>
        [JsonPropertyName("identityCertificateForClientAuthentication")]
        public IosCertificateProfileBase IdentityCertificateForClientAuthentication { get; set; }
    
        /// <summary>
        /// Gets or sets single sign on extension pkinit certificate.
        /// PKINIT Certificate for the authentication with single sign-on extension settings.
        /// </summary>
        [JsonPropertyName("singleSignOnExtensionPkinitCertificate")]
        public IosCertificateProfileBase SingleSignOnExtensionPkinitCertificate { get; set; }
    
    }
}

