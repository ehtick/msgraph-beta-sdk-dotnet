using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The enrollmentProfile resource represents a collection of configurations which must be provided pre-enrollment to enable enrolling certain devices whose identities have been pre-staged. Pre-staged device identities are assigned to this type of profile to apply the profile&apos;s configurations at enrollment of the corresponding device.
    /// </summary>
    public class EnrollmentProfile : Entity, IParsable {
        /// <summary>Configuration endpoint url to use for Enrollment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ConfigurationEndpointUrl {
            get { return BackingStore?.Get<string?>("configurationEndpointUrl"); }
            set { BackingStore?.Set("configurationEndpointUrl", value); }
        }
#else
        public string ConfigurationEndpointUrl {
            get { return BackingStore?.Get<string>("configurationEndpointUrl"); }
            set { BackingStore?.Set("configurationEndpointUrl", value); }
        }
#endif
        /// <summary>Description of the profile</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Name of the profile</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Indicates to authenticate with Apple Setup Assistant instead of Company Portal.</summary>
        public bool? EnableAuthenticationViaCompanyPortal {
            get { return BackingStore?.Get<bool?>("enableAuthenticationViaCompanyPortal"); }
            set { BackingStore?.Set("enableAuthenticationViaCompanyPortal", value); }
        }
        /// <summary>Indicates that Company Portal is required on setup assistant enrolled devices</summary>
        public bool? RequireCompanyPortalOnSetupAssistantEnrolledDevices {
            get { return BackingStore?.Get<bool?>("requireCompanyPortalOnSetupAssistantEnrolledDevices"); }
            set { BackingStore?.Set("requireCompanyPortalOnSetupAssistantEnrolledDevices", value); }
        }
        /// <summary>Indicates if the profile requires user authentication</summary>
        public bool? RequiresUserAuthentication {
            get { return BackingStore?.Get<bool?>("requiresUserAuthentication"); }
            set { BackingStore?.Set("requiresUserAuthentication", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EnrollmentProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.depEnrollmentBaseProfile" => new DepEnrollmentBaseProfile(),
                "#microsoft.graph.depEnrollmentProfile" => new DepEnrollmentProfile(),
                "#microsoft.graph.depIOSEnrollmentProfile" => new DepIOSEnrollmentProfile(),
                "#microsoft.graph.depMacOSEnrollmentProfile" => new DepMacOSEnrollmentProfile(),
                _ => new EnrollmentProfile(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurationEndpointUrl", n => { ConfigurationEndpointUrl = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enableAuthenticationViaCompanyPortal", n => { EnableAuthenticationViaCompanyPortal = n.GetBoolValue(); } },
                {"requireCompanyPortalOnSetupAssistantEnrolledDevices", n => { RequireCompanyPortalOnSetupAssistantEnrolledDevices = n.GetBoolValue(); } },
                {"requiresUserAuthentication", n => { RequiresUserAuthentication = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("configurationEndpointUrl", ConfigurationEndpointUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enableAuthenticationViaCompanyPortal", EnableAuthenticationViaCompanyPortal);
            writer.WriteBoolValue("requireCompanyPortalOnSetupAssistantEnrolledDevices", RequireCompanyPortalOnSetupAssistantEnrolledDevices);
            writer.WriteBoolValue("requiresUserAuthentication", RequiresUserAuthentication);
        }
    }
}
