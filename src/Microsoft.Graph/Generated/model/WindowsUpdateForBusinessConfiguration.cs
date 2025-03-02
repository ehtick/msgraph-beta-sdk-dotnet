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
    /// The type Windows Update For Business Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsUpdateForBusinessConfiguration>))]
    public partial class WindowsUpdateForBusinessConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The WindowsUpdateForBusinessConfiguration constructor
        ///</summary>
        public WindowsUpdateForBusinessConfiguration()
        {
            this.ODataType = "microsoft.graph.windowsUpdateForBusinessConfiguration";
        }

        /// <summary>
        /// Gets or sets allow windows11upgrade.
        /// When TRUE, allows eligible Windows 10 devices to upgrade to Windows 11. When FALSE, implies the device stays on the existing operating system. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("allowWindows11Upgrade")]
        public bool? AllowWindows11Upgrade { get; set; }
    
        /// <summary>
        /// Gets or sets automatic update mode.
        /// The Automatic Update Mode. Possible values are: UserDefined, NotifyDownload, AutoInstallAtMaintenanceTime, AutoInstallAndRebootAtMaintenanceTime, AutoInstallAndRebootAtScheduledTime, AutoInstallAndRebootWithoutEndUserControl, WindowsDefault. UserDefined is the default value, no intent. Returned by default. Query parameters are not supported. Possible values are: userDefined, notifyDownload, autoInstallAtMaintenanceTime, autoInstallAndRebootAtMaintenanceTime, autoInstallAndRebootAtScheduledTime, autoInstallAndRebootWithoutEndUserControl, windowsDefault.
        /// </summary>
        [JsonPropertyName("automaticUpdateMode")]
        public AutomaticUpdateMode? AutomaticUpdateMode { get; set; }
    
        /// <summary>
        /// Gets or sets auto restart notification dismissal.
        /// Specify the method by which the auto-restart required notification is dismissed. Possible values are: NotConfigured, Automatic, User. Returned by default. Query parameters are not supported. Possible values are: notConfigured, automatic, user, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("autoRestartNotificationDismissal")]
        public AutoRestartNotificationDismissalMethod? AutoRestartNotificationDismissal { get; set; }
    
        /// <summary>
        /// Gets or sets business ready updates only.
        /// Determines which branch devices will receive their updates from. Possible values are: UserDefined, All, BusinessReadyOnly, WindowsInsiderBuildFast, WindowsInsiderBuildSlow, WindowsInsiderBuildRelease. Returned by default. Query parameters are not supported. Possible values are: userDefined, all, businessReadyOnly, windowsInsiderBuildFast, windowsInsiderBuildSlow, windowsInsiderBuildRelease.
        /// </summary>
        [JsonPropertyName("businessReadyUpdatesOnly")]
        public WindowsUpdateType? BusinessReadyUpdatesOnly { get; set; }
    
        /// <summary>
        /// Gets or sets deadline for feature updates in days.
        /// Number of days before feature updates are installed automatically with valid range from 0 to 30 days. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("deadlineForFeatureUpdatesInDays")]
        public Int32? DeadlineForFeatureUpdatesInDays { get; set; }
    
        /// <summary>
        /// Gets or sets deadline for quality updates in days.
        /// Number of days before quality updates are installed automatically with valid range from 0 to 30 days. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("deadlineForQualityUpdatesInDays")]
        public Int32? DeadlineForQualityUpdatesInDays { get; set; }
    
        /// <summary>
        /// Gets or sets deadline grace period in days.
        /// Number of days after deadline until restarts occur automatically with valid range from 0 to 7 days. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("deadlineGracePeriodInDays")]
        public Int32? DeadlineGracePeriodInDays { get; set; }
    
        /// <summary>
        /// Gets or sets delivery optimization mode.
        /// The Delivery Optimization Mode. Possible values are: UserDefined, HttpOnly, HttpWithPeeringNat, HttpWithPeeringPrivateGroup, HttpWithInternetPeering, SimpleDownload, BypassMode. UserDefined allows the user to set. Returned by default. Query parameters are not supported. Possible values are: userDefined, httpOnly, httpWithPeeringNat, httpWithPeeringPrivateGroup, httpWithInternetPeering, simpleDownload, bypassMode.
        /// </summary>
        [JsonPropertyName("deliveryOptimizationMode")]
        public WindowsDeliveryOptimizationMode? DeliveryOptimizationMode { get; set; }
    
        /// <summary>
        /// Gets or sets drivers excluded.
        /// When TRUE, excludes Windows update Drivers. When FALSE, does not exclude Windows update Drivers. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("driversExcluded")]
        public bool? DriversExcluded { get; set; }
    
        /// <summary>
        /// Gets or sets engaged restart deadline in days.
        /// Deadline in days before automatically scheduling and executing a pending restart outside of active hours, with valid range from 2 to 30 days. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("engagedRestartDeadlineInDays")]
        public Int32? EngagedRestartDeadlineInDays { get; set; }
    
        /// <summary>
        /// Gets or sets engaged restart snooze schedule in days.
        /// Number of days a user can snooze Engaged Restart reminder notifications with valid range from 1 to 3 days. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("engagedRestartSnoozeScheduleInDays")]
        public Int32? EngagedRestartSnoozeScheduleInDays { get; set; }
    
        /// <summary>
        /// Gets or sets engaged restart transition schedule in days.
        /// Number of days before transitioning from Auto Restarts scheduled outside of active hours to Engaged Restart, which requires the user to schedule, with valid range from 0 to 30 days. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("engagedRestartTransitionScheduleInDays")]
        public Int32? EngagedRestartTransitionScheduleInDays { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates deferral period in days.
        /// Defer Feature Updates by these many days with valid range from 0 to 30 days. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("featureUpdatesDeferralPeriodInDays")]
        public Int32? FeatureUpdatesDeferralPeriodInDays { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates paused.
        /// When TRUE, assigned devices are paused from receiving feature updates for up to 35 days from the time you pause the ring. When FALSE, does not pause Feature Updates. Returned by default. Query parameters are not supported.s
        /// </summary>
        [JsonPropertyName("featureUpdatesPaused")]
        public bool? FeatureUpdatesPaused { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates pause expiry date time.
        /// The Feature Updates Pause Expiry datetime. This value is 35 days from the time admin paused or extended the pause for the ring. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("featureUpdatesPauseExpiryDateTime")]
        public DateTimeOffset? FeatureUpdatesPauseExpiryDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates pause start date.
        /// The Feature Updates Pause start date. This value is the time when the admin paused or extended the pause for the ring. Returned by default. Query parameters are not supported. This property is read-only.
        /// </summary>
        [JsonPropertyName("featureUpdatesPauseStartDate")]
        public Date FeatureUpdatesPauseStartDate { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates rollback start date time.
        /// The Feature Updates Rollback Start datetime.This value is the time when the admin rolled back the Feature update for the ring.Returned by default.Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("featureUpdatesRollbackStartDateTime")]
        public DateTimeOffset? FeatureUpdatesRollbackStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates rollback window in days.
        /// The number of days after a Feature Update for which a rollback is valid with valid range from 2 to 60 days. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("featureUpdatesRollbackWindowInDays")]
        public Int32? FeatureUpdatesRollbackWindowInDays { get; set; }
    
        /// <summary>
        /// Gets or sets feature updates will be rolled back.
        /// When TRUE, rollback Feature Updates on the next device check in. When FALSE, do not rollback Feature Updates on the next device check in. Returned by default.Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("featureUpdatesWillBeRolledBack")]
        public bool? FeatureUpdatesWillBeRolledBack { get; set; }
    
        /// <summary>
        /// Gets or sets installation schedule.
        /// The Installation Schedule. Possible values are: ActiveHoursStart, ActiveHoursEnd, ScheduledInstallDay, ScheduledInstallTime. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("installationSchedule")]
        public WindowsUpdateInstallScheduleType InstallationSchedule { get; set; }
    
        /// <summary>
        /// Gets or sets microsoft update service allowed.
        /// When TRUE, allows Microsoft Update Service. When FALSE, does not allow Microsoft Update Service. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("microsoftUpdateServiceAllowed")]
        public bool? MicrosoftUpdateServiceAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets postpone reboot until after deadline.
        /// When TRUE the device should wait until deadline for rebooting outside of active hours. When FALSE the device should not wait until deadline for rebooting outside of active hours. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("postponeRebootUntilAfterDeadline")]
        public bool? PostponeRebootUntilAfterDeadline { get; set; }
    
        /// <summary>
        /// Gets or sets prerelease features.
        /// The Pre-Release Features. Possible values are: UserDefined, SettingsOnly, SettingsAndExperimentations, NotAllowed. UserDefined is the default value, no intent. Returned by default. Query parameters are not supported. Possible values are: userDefined, settingsOnly, settingsAndExperimentations, notAllowed.
        /// </summary>
        [JsonPropertyName("prereleaseFeatures")]
        public PrereleaseFeatures? PrereleaseFeatures { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates deferral period in days.
        /// Defer Quality Updates by these many days with valid range from 0 to 30 days. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("qualityUpdatesDeferralPeriodInDays")]
        public Int32? QualityUpdatesDeferralPeriodInDays { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates paused.
        /// When TRUE, assigned devices are paused from receiving quality updates for up to 35 days from the time you pause the ring. When FALSE, does not pause Quality Updates. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("qualityUpdatesPaused")]
        public bool? QualityUpdatesPaused { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates pause expiry date time.
        /// The Quality Updates Pause Expiry datetime. This value is 35 days from the time admin paused or extended the pause for the ring. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("qualityUpdatesPauseExpiryDateTime")]
        public DateTimeOffset? QualityUpdatesPauseExpiryDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates pause start date.
        /// The Quality Updates Pause start date. This value is the time when the admin paused or extended the pause for the ring. Returned by default. Query parameters are not supported. This property is read-only.
        /// </summary>
        [JsonPropertyName("qualityUpdatesPauseStartDate")]
        public Date QualityUpdatesPauseStartDate { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates rollback start date time.
        /// The Quality Updates Rollback Start datetime. This value is the time when the admin rolled back the Quality update for the ring. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("qualityUpdatesRollbackStartDateTime")]
        public DateTimeOffset? QualityUpdatesRollbackStartDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets quality updates will be rolled back.
        /// When TRUE, rollback Quality Updates on the next device check in. When FALSE, do not rollback Quality Updates on the next device check in. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("qualityUpdatesWillBeRolledBack")]
        public bool? QualityUpdatesWillBeRolledBack { get; set; }
    
        /// <summary>
        /// Gets or sets schedule imminent restart warning in minutes.
        /// Specify the period for auto-restart imminent warning notifications. Supported values: 15, 30 or 60 (minutes). Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("scheduleImminentRestartWarningInMinutes")]
        public Int32? ScheduleImminentRestartWarningInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets schedule restart warning in hours.
        /// Specify the period for auto-restart warning reminder notifications. Supported values: 2, 4, 8, 12 or 24 (hours). Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("scheduleRestartWarningInHours")]
        public Int32? ScheduleRestartWarningInHours { get; set; }
    
        /// <summary>
        /// Gets or sets skip checks before restart.
        /// When TRUE, skips all checks before restart: Battery level = 40%, User presence, Display Needed, Presentation mode, Full screen mode, phone call state, game mode etc. When FALSE, does not skip all checks before restart. Returned by default. Query parameters are not supported.
        /// </summary>
        [JsonPropertyName("skipChecksBeforeRestart")]
        public bool? SkipChecksBeforeRestart { get; set; }
    
        /// <summary>
        /// Gets or sets update notification level.
        /// Specifies what Windows Update notifications users see. Possible values are: NotConfigured, DefaultNotifications, RestartWarningsOnly, DisableAllNotifications. Returned by default. Query parameters are not supported. Possible values are: notConfigured, defaultNotifications, restartWarningsOnly, disableAllNotifications, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("updateNotificationLevel")]
        public WindowsUpdateNotificationDisplayOption? UpdateNotificationLevel { get; set; }
    
        /// <summary>
        /// Gets or sets update weeks.
        /// Schedule the update installation on the weeks of the month. Possible values are: UserDefined, FirstWeek, SecondWeek, ThirdWeek, FourthWeek, EveryWeek. Returned by default. Query parameters are not supported. Possible values are: userDefined, firstWeek, secondWeek, thirdWeek, fourthWeek, everyWeek, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("updateWeeks")]
        public WindowsUpdateForBusinessUpdateWeeks? UpdateWeeks { get; set; }
    
        /// <summary>
        /// Gets or sets user pause access.
        /// Specifies whether to enable end user’s access to pause software updates. Possible values are: NotConfigured, Enabled, Disabled. Returned by default. Query parameters are not supported. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("userPauseAccess")]
        public Enablement? UserPauseAccess { get; set; }
    
        /// <summary>
        /// Gets or sets user windows update scan access.
        /// Specifies whether to disable user’s access to scan Windows Update. Possible values are: NotConfigured, Enabled, Disabled. Returned by default. Query parameters are not supported. Possible values are: notConfigured, enabled, disabled.
        /// </summary>
        [JsonPropertyName("userWindowsUpdateScanAccess")]
        public Enablement? UserWindowsUpdateScanAccess { get; set; }
    
        /// <summary>
        /// Gets or sets device update states.
        /// Windows update for business configuration device states. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("deviceUpdateStates")]
        public IWindowsUpdateForBusinessConfigurationDeviceUpdateStatesCollectionPage DeviceUpdateStates { get; set; }

        /// <summary>
        /// Gets or sets deviceUpdateStatesNextLink.
        /// </summary>
        [JsonPropertyName("deviceUpdateStates@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DeviceUpdateStatesNextLink { get; set; }
    
    }
}

