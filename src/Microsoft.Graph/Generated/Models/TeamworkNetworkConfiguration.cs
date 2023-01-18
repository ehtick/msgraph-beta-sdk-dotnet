using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkNetworkConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The default gateway is the path used to pass information when the destination is unknown to the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DefaultGateway {
            get { return BackingStore?.Get<string?>("defaultGateway"); }
            set { BackingStore?.Set("defaultGateway", value); }
        }
#else
        public string DefaultGateway {
            get { return BackingStore?.Get<string>("defaultGateway"); }
            set { BackingStore?.Set("defaultGateway", value); }
        }
#endif
        /// <summary>The network domain of the device, for example, contoso.com.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DomainName {
            get { return BackingStore?.Get<string?>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
#else
        public string DomainName {
            get { return BackingStore?.Get<string>("domainName"); }
            set { BackingStore?.Set("domainName", value); }
        }
#endif
        /// <summary>The device name on a network.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? HostName {
            get { return BackingStore?.Get<string?>("hostName"); }
            set { BackingStore?.Set("hostName", value); }
        }
#else
        public string HostName {
            get { return BackingStore?.Get<string>("hostName"); }
            set { BackingStore?.Set("hostName", value); }
        }
#endif
        /// <summary>The IP address is a numerical label that uniquely identifies every device connected to the internet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? IpAddress {
            get { return BackingStore?.Get<string?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#else
        public string IpAddress {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#endif
        /// <summary>True if DHCP is enabled.</summary>
        public bool? IsDhcpEnabled {
            get { return BackingStore?.Get<bool?>("isDhcpEnabled"); }
            set { BackingStore?.Set("isDhcpEnabled", value); }
        }
        /// <summary>True if the PC port is enabled.</summary>
        public bool? IsPCPortEnabled {
            get { return BackingStore?.Get<bool?>("isPCPortEnabled"); }
            set { BackingStore?.Set("isPCPortEnabled", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>A primary DNS is the first point of contact for a device that translates the hostname into an IP address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? PrimaryDns {
            get { return BackingStore?.Get<string?>("primaryDns"); }
            set { BackingStore?.Set("primaryDns", value); }
        }
#else
        public string PrimaryDns {
            get { return BackingStore?.Get<string>("primaryDns"); }
            set { BackingStore?.Set("primaryDns", value); }
        }
#endif
        /// <summary>A secondary DNS is used when the primary DNS is not available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SecondaryDns {
            get { return BackingStore?.Get<string?>("secondaryDns"); }
            set { BackingStore?.Set("secondaryDns", value); }
        }
#else
        public string SecondaryDns {
            get { return BackingStore?.Get<string>("secondaryDns"); }
            set { BackingStore?.Set("secondaryDns", value); }
        }
#endif
        /// <summary>A subnet mask is a number that distinguishes the network address and the host address within an IP address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? SubnetMask {
            get { return BackingStore?.Get<string?>("subnetMask"); }
            set { BackingStore?.Set("subnetMask", value); }
        }
#else
        public string SubnetMask {
            get { return BackingStore?.Get<string>("subnetMask"); }
            set { BackingStore?.Set("subnetMask", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new teamworkNetworkConfiguration and sets the default values.
        /// </summary>
        public TeamworkNetworkConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamworkNetworkConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkNetworkConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultGateway", n => { DefaultGateway = n.GetStringValue(); } },
                {"domainName", n => { DomainName = n.GetStringValue(); } },
                {"hostName", n => { HostName = n.GetStringValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"isDhcpEnabled", n => { IsDhcpEnabled = n.GetBoolValue(); } },
                {"isPCPortEnabled", n => { IsPCPortEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"primaryDns", n => { PrimaryDns = n.GetStringValue(); } },
                {"secondaryDns", n => { SecondaryDns = n.GetStringValue(); } },
                {"subnetMask", n => { SubnetMask = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultGateway", DefaultGateway);
            writer.WriteStringValue("domainName", DomainName);
            writer.WriteStringValue("hostName", HostName);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteBoolValue("isDhcpEnabled", IsDhcpEnabled);
            writer.WriteBoolValue("isPCPortEnabled", IsPCPortEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("primaryDns", PrimaryDns);
            writer.WriteStringValue("secondaryDns", SecondaryDns);
            writer.WriteStringValue("subnetMask", SubnetMask);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
