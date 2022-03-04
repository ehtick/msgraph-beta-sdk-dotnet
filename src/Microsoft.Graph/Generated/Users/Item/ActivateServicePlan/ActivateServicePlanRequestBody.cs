using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Users.Item.ActivateServicePlan {
    public class ActivateServicePlanRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string ServicePlanId { get; set; }
        public string SkuId { get; set; }
        /// <summary>
        /// Instantiates a new activateServicePlanRequestBody and sets the default values.
        /// </summary>
        public ActivateServicePlanRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ActivateServicePlanRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActivateServicePlanRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"servicePlanId", (o,n) => { (o as ActivateServicePlanRequestBody).ServicePlanId = n.GetStringValue(); } },
                {"skuId", (o,n) => { (o as ActivateServicePlanRequestBody).SkuId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("servicePlanId", ServicePlanId);
            writer.WriteStringValue("skuId", SkuId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
