using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AuditUserIdentity : UserIdentity, IParsable {
        /// <summary>For user sign ins, the identifier of the tenant that the user is a member of.</summary>
        public string HomeTenantId { get; set; }
        /// <summary>For user sign ins, the name of the tenant that the user is a member of. Only populated in cases where the home tenant has provided affirmative consent to Azure AD to show the tenant content.</summary>
        public string HomeTenantName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuditUserIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuditUserIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"homeTenantId", (o,n) => { (o as AuditUserIdentity).HomeTenantId = n.GetStringValue(); } },
                {"homeTenantName", (o,n) => { (o as AuditUserIdentity).HomeTenantName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("homeTenantId", HomeTenantId);
            writer.WriteStringValue("homeTenantName", HomeTenantName);
        }
    }
}
