using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// ServiceNow properties including the ServiceNow instanceUrl, connection credentials and other metadata.
    /// </summary>
    public class ServiceNowConnection : Entity, IParsable {
        /// <summary>Indicates the method used by Intune to authenticate with ServiceNow. Currently supports only web authentication with ServiceNow using the specified app id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ServiceNowAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<ServiceNowAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
#nullable restore
#else
        public ServiceNowAuthenticationMethod AuthenticationMethod {
            get { return BackingStore?.Get<ServiceNowAuthenticationMethod>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
#endif
        /// <summary>Date Time when connection properties were created. The value cannot be modified and is automatically populated when the connection properties were entered.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Indicates the ServiceNow incident API URL that Intune will use the fetch incidents. Saved in the format of /api/now/table/incident</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncidentApiUrl {
            get { return BackingStore?.Get<string?>("incidentApiUrl"); }
            set { BackingStore?.Set("incidentApiUrl", value); }
        }
#nullable restore
#else
        public string IncidentApiUrl {
            get { return BackingStore?.Get<string>("incidentApiUrl"); }
            set { BackingStore?.Set("incidentApiUrl", value); }
        }
#endif
        /// <summary>Indicates the ServiceNow instance URL that Intune will connect to. Saved in the format of https://&lt;instance&gt;.service-now.com</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InstanceUrl {
            get { return BackingStore?.Get<string?>("instanceUrl"); }
            set { BackingStore?.Set("instanceUrl", value); }
        }
#nullable restore
#else
        public string InstanceUrl {
            get { return BackingStore?.Get<string>("instanceUrl"); }
            set { BackingStore?.Set("instanceUrl", value); }
        }
#endif
        /// <summary>Date Time when connection properties were last updated. The value cannot be modified and is automatically populated when the connection properties were updated.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Date Time when incidents from ServiceNow were last queried</summary>
        public DateTimeOffset? LastQueriedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastQueriedDateTime"); }
            set { BackingStore?.Set("lastQueriedDateTime", value); }
        }
        /// <summary>Status of ServiceNow Connection</summary>
        public Microsoft.Graph.Beta.Models.ServiceNowConnectionStatus? ServiceNowConnectionStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ServiceNowConnectionStatus?>("serviceNowConnectionStatus"); }
            set { BackingStore?.Set("serviceNowConnectionStatus", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServiceNowConnection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceNowConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetObjectValue<ServiceNowAuthenticationMethod>(ServiceNowAuthenticationMethod.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"incidentApiUrl", n => { IncidentApiUrl = n.GetStringValue(); } },
                {"instanceUrl", n => { InstanceUrl = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastQueriedDateTime", n => { LastQueriedDateTime = n.GetDateTimeOffsetValue(); } },
                {"serviceNowConnectionStatus", n => { ServiceNowConnectionStatus = n.GetEnumValue<ServiceNowConnectionStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ServiceNowAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("incidentApiUrl", IncidentApiUrl);
            writer.WriteStringValue("instanceUrl", InstanceUrl);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastQueriedDateTime", LastQueriedDateTime);
            writer.WriteEnumValue<ServiceNowConnectionStatus>("serviceNowConnectionStatus", ServiceNowConnectionStatus);
        }
    }
}
