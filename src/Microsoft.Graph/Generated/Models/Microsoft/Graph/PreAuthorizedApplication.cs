using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PreAuthorizedApplication : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier for the application.</summary>
        public string AppId { get; set; }
        /// <summary>The unique identifier for the oauth2PermissionScopes the application requires.</summary>
        public List<string> PermissionIds { get; set; }
        /// <summary>
        /// Instantiates a new preAuthorizedApplication and sets the default values.
        /// </summary>
        public PreAuthorizedApplication() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PreAuthorizedApplication CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PreAuthorizedApplication();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"appId", (o,n) => { (o as PreAuthorizedApplication).AppId = n.GetStringValue(); } },
                {"permissionIds", (o,n) => { (o as PreAuthorizedApplication).PermissionIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appId", AppId);
            writer.WriteCollectionOfPrimitiveValues<string>("permissionIds", PermissionIds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
