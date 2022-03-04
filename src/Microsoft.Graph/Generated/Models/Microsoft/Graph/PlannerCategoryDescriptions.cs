using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PlannerCategoryDescriptions : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The label associated with Category 1</summary>
        public string Category1 { get; set; }
        /// <summary>The label associated with Category 10</summary>
        public string Category10 { get; set; }
        /// <summary>The label associated with Category 11</summary>
        public string Category11 { get; set; }
        /// <summary>The label associated with Category 12</summary>
        public string Category12 { get; set; }
        /// <summary>The label associated with Category 13</summary>
        public string Category13 { get; set; }
        /// <summary>The label associated with Category 14</summary>
        public string Category14 { get; set; }
        /// <summary>The label associated with Category 15</summary>
        public string Category15 { get; set; }
        /// <summary>The label associated with Category 16</summary>
        public string Category16 { get; set; }
        /// <summary>The label associated with Category 17</summary>
        public string Category17 { get; set; }
        /// <summary>The label associated with Category 18</summary>
        public string Category18 { get; set; }
        /// <summary>The label associated with Category 19</summary>
        public string Category19 { get; set; }
        /// <summary>The label associated with Category 2</summary>
        public string Category2 { get; set; }
        /// <summary>The label associated with Category 20</summary>
        public string Category20 { get; set; }
        /// <summary>The label associated with Category 21</summary>
        public string Category21 { get; set; }
        /// <summary>The label associated with Category 22</summary>
        public string Category22 { get; set; }
        /// <summary>The label associated with Category 23</summary>
        public string Category23 { get; set; }
        /// <summary>The label associated with Category 24</summary>
        public string Category24 { get; set; }
        /// <summary>The label associated with Category 25</summary>
        public string Category25 { get; set; }
        /// <summary>The label associated with Category 3</summary>
        public string Category3 { get; set; }
        /// <summary>The label associated with Category 4</summary>
        public string Category4 { get; set; }
        /// <summary>The label associated with Category 5</summary>
        public string Category5 { get; set; }
        /// <summary>The label associated with Category 6</summary>
        public string Category6 { get; set; }
        /// <summary>The label associated with Category 7</summary>
        public string Category7 { get; set; }
        /// <summary>The label associated with Category 8</summary>
        public string Category8 { get; set; }
        /// <summary>The label associated with Category 9</summary>
        public string Category9 { get; set; }
        /// <summary>
        /// Instantiates a new plannerCategoryDescriptions and sets the default values.
        /// </summary>
        public PlannerCategoryDescriptions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PlannerCategoryDescriptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerCategoryDescriptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"category1", (o,n) => { (o as PlannerCategoryDescriptions).Category1 = n.GetStringValue(); } },
                {"category10", (o,n) => { (o as PlannerCategoryDescriptions).Category10 = n.GetStringValue(); } },
                {"category11", (o,n) => { (o as PlannerCategoryDescriptions).Category11 = n.GetStringValue(); } },
                {"category12", (o,n) => { (o as PlannerCategoryDescriptions).Category12 = n.GetStringValue(); } },
                {"category13", (o,n) => { (o as PlannerCategoryDescriptions).Category13 = n.GetStringValue(); } },
                {"category14", (o,n) => { (o as PlannerCategoryDescriptions).Category14 = n.GetStringValue(); } },
                {"category15", (o,n) => { (o as PlannerCategoryDescriptions).Category15 = n.GetStringValue(); } },
                {"category16", (o,n) => { (o as PlannerCategoryDescriptions).Category16 = n.GetStringValue(); } },
                {"category17", (o,n) => { (o as PlannerCategoryDescriptions).Category17 = n.GetStringValue(); } },
                {"category18", (o,n) => { (o as PlannerCategoryDescriptions).Category18 = n.GetStringValue(); } },
                {"category19", (o,n) => { (o as PlannerCategoryDescriptions).Category19 = n.GetStringValue(); } },
                {"category2", (o,n) => { (o as PlannerCategoryDescriptions).Category2 = n.GetStringValue(); } },
                {"category20", (o,n) => { (o as PlannerCategoryDescriptions).Category20 = n.GetStringValue(); } },
                {"category21", (o,n) => { (o as PlannerCategoryDescriptions).Category21 = n.GetStringValue(); } },
                {"category22", (o,n) => { (o as PlannerCategoryDescriptions).Category22 = n.GetStringValue(); } },
                {"category23", (o,n) => { (o as PlannerCategoryDescriptions).Category23 = n.GetStringValue(); } },
                {"category24", (o,n) => { (o as PlannerCategoryDescriptions).Category24 = n.GetStringValue(); } },
                {"category25", (o,n) => { (o as PlannerCategoryDescriptions).Category25 = n.GetStringValue(); } },
                {"category3", (o,n) => { (o as PlannerCategoryDescriptions).Category3 = n.GetStringValue(); } },
                {"category4", (o,n) => { (o as PlannerCategoryDescriptions).Category4 = n.GetStringValue(); } },
                {"category5", (o,n) => { (o as PlannerCategoryDescriptions).Category5 = n.GetStringValue(); } },
                {"category6", (o,n) => { (o as PlannerCategoryDescriptions).Category6 = n.GetStringValue(); } },
                {"category7", (o,n) => { (o as PlannerCategoryDescriptions).Category7 = n.GetStringValue(); } },
                {"category8", (o,n) => { (o as PlannerCategoryDescriptions).Category8 = n.GetStringValue(); } },
                {"category9", (o,n) => { (o as PlannerCategoryDescriptions).Category9 = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("category1", Category1);
            writer.WriteStringValue("category10", Category10);
            writer.WriteStringValue("category11", Category11);
            writer.WriteStringValue("category12", Category12);
            writer.WriteStringValue("category13", Category13);
            writer.WriteStringValue("category14", Category14);
            writer.WriteStringValue("category15", Category15);
            writer.WriteStringValue("category16", Category16);
            writer.WriteStringValue("category17", Category17);
            writer.WriteStringValue("category18", Category18);
            writer.WriteStringValue("category19", Category19);
            writer.WriteStringValue("category2", Category2);
            writer.WriteStringValue("category20", Category20);
            writer.WriteStringValue("category21", Category21);
            writer.WriteStringValue("category22", Category22);
            writer.WriteStringValue("category23", Category23);
            writer.WriteStringValue("category24", Category24);
            writer.WriteStringValue("category25", Category25);
            writer.WriteStringValue("category3", Category3);
            writer.WriteStringValue("category4", Category4);
            writer.WriteStringValue("category5", Category5);
            writer.WriteStringValue("category6", Category6);
            writer.WriteStringValue("category7", Category7);
            writer.WriteStringValue("category8", Category8);
            writer.WriteStringValue("category9", Category9);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
