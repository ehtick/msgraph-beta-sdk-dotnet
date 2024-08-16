// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Apple device features configuration profile.
    /// </summary>
    public class EasEmailProfileConfigurationBase : Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>Custom domain name value used while generating an email profile before installing on the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomDomainName
        {
            get { return BackingStore?.Get<string?>("customDomainName"); }
            set { BackingStore?.Set("customDomainName", value); }
        }
#nullable restore
#else
        public string CustomDomainName
        {
            get { return BackingStore?.Get<string>("customDomainName"); }
            set { BackingStore?.Set("customDomainName", value); }
        }
#endif
        /// <summary>UserDomainname attribute that is picked from AAD and injected into this profile before installing on the device. Possible values are: fullDomainName, netBiosDomainName.</summary>
        public Microsoft.Graph.Beta.Models.DomainNameSource? UserDomainNameSource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DomainNameSource?>("userDomainNameSource"); }
            set { BackingStore?.Set("userDomainNameSource", value); }
        }
        /// <summary>Name of the AAD field, that will be used to retrieve UserName for email profile. Possible values are: userPrincipalName, primarySmtpAddress, samAccountName.</summary>
        public Microsoft.Graph.Beta.Models.UsernameSource? UsernameAADSource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UsernameSource?>("usernameAADSource"); }
            set { BackingStore?.Set("usernameAADSource", value); }
        }
        /// <summary>Possible values for username source or email source.</summary>
        public Microsoft.Graph.Beta.Models.UserEmailSource? UsernameSource
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserEmailSource?>("usernameSource"); }
            set { BackingStore?.Set("usernameSource", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.EasEmailProfileConfigurationBase"/> and sets the default values.
        /// </summary>
        public EasEmailProfileConfigurationBase() : base()
        {
            OdataType = "#microsoft.graph.easEmailProfileConfigurationBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.EasEmailProfileConfigurationBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.EasEmailProfileConfigurationBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.iosEasEmailProfileConfiguration" => new Microsoft.Graph.Beta.Models.IosEasEmailProfileConfiguration(),
                "#microsoft.graph.windows10EasEmailProfileConfiguration" => new Microsoft.Graph.Beta.Models.Windows10EasEmailProfileConfiguration(),
                "#microsoft.graph.windowsPhoneEASEmailProfileConfiguration" => new Microsoft.Graph.Beta.Models.WindowsPhoneEASEmailProfileConfiguration(),
                _ => new Microsoft.Graph.Beta.Models.EasEmailProfileConfigurationBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "customDomainName", n => { CustomDomainName = n.GetStringValue(); } },
                { "userDomainNameSource", n => { UserDomainNameSource = n.GetEnumValue<Microsoft.Graph.Beta.Models.DomainNameSource>(); } },
                { "usernameAADSource", n => { UsernameAADSource = n.GetEnumValue<Microsoft.Graph.Beta.Models.UsernameSource>(); } },
                { "usernameSource", n => { UsernameSource = n.GetEnumValue<Microsoft.Graph.Beta.Models.UserEmailSource>(); } },
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
            writer.WriteStringValue("customDomainName", CustomDomainName);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.DomainNameSource>("userDomainNameSource", UserDomainNameSource);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.UsernameSource>("usernameAADSource", UsernameAADSource);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.UserEmailSource>("usernameSource", UsernameSource);
        }
    }
}
