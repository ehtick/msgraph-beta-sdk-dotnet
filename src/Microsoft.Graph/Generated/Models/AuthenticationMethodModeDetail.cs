using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AuthenticationMethodModeDetail : Entity, IParsable {
        /// <summary>The authenticationMethod property</summary>
        public BaseAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<BaseAuthenticationMethod?>("authenticationMethod"); }
            set { BackingStore?.Set("authenticationMethod", value); }
        }
        /// <summary>The display name of this mode</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuthenticationMethodModeDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationMethodModeDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<BaseAuthenticationMethod>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<BaseAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
