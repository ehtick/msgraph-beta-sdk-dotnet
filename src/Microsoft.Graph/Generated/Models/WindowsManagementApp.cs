// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Windows management app entity.
    /// </summary>
    public class WindowsManagementApp : Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>Windows management app available version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvailableVersion
        {
            get { return BackingStore?.Get<string?>("availableVersion"); }
            set { BackingStore?.Set("availableVersion", value); }
        }
#nullable restore
#else
        public string AvailableVersion
        {
            get { return BackingStore?.Get<string>("availableVersion"); }
            set { BackingStore?.Set("availableVersion", value); }
        }
#endif
        /// <summary>The list of health states for installed Windows management app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsManagementAppHealthState>? HealthStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsManagementAppHealthState>?>("healthStates"); }
            set { BackingStore?.Set("healthStates", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsManagementAppHealthState> HealthStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsManagementAppHealthState>>("healthStates"); }
            set { BackingStore?.Set("healthStates", value); }
        }
#endif
        /// <summary>ManagedInstallerStatus</summary>
        public Microsoft.Graph.Beta.Models.ManagedInstallerStatus? ManagedInstaller
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedInstallerStatus?>("managedInstaller"); }
            set { BackingStore?.Set("managedInstaller", value); }
        }
        /// <summary>Managed Installer Configured Date Time</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedInstallerConfiguredDateTime
        {
            get { return BackingStore?.Get<string?>("managedInstallerConfiguredDateTime"); }
            set { BackingStore?.Set("managedInstallerConfiguredDateTime", value); }
        }
#nullable restore
#else
        public string ManagedInstallerConfiguredDateTime
        {
            get { return BackingStore?.Get<string>("managedInstallerConfiguredDateTime"); }
            set { BackingStore?.Set("managedInstallerConfiguredDateTime", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsManagementApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.WindowsManagementApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.WindowsManagementApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "availableVersion", n => { AvailableVersion = n.GetStringValue(); } },
                { "healthStates", n => { HealthStates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsManagementAppHealthState>(Microsoft.Graph.Beta.Models.WindowsManagementAppHealthState.CreateFromDiscriminatorValue)?.ToList(); } },
                { "managedInstaller", n => { ManagedInstaller = n.GetEnumValue<Microsoft.Graph.Beta.Models.ManagedInstallerStatus>(); } },
                { "managedInstallerConfiguredDateTime", n => { ManagedInstallerConfiguredDateTime = n.GetStringValue(); } },
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
            writer.WriteStringValue("availableVersion", AvailableVersion);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsManagementAppHealthState>("healthStates", HealthStates);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ManagedInstallerStatus>("managedInstaller", ManagedInstaller);
            writer.WriteStringValue("managedInstallerConfiguredDateTime", ManagedInstallerConfiguredDateTime);
        }
    }
}
