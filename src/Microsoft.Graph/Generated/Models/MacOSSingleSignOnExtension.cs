// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// An abstract base class for all macOS-specific single sign-on extension types.
    /// </summary>
    public class MacOSSingleSignOnExtension : Microsoft.Graph.Beta.Models.SingleSignOnExtension, IParsable
    {
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension"/> and sets the default values.
        /// </summary>
        public MacOSSingleSignOnExtension() : base()
        {
            OdataType = "#microsoft.graph.macOSSingleSignOnExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.macOSAzureAdSingleSignOnExtension" => new Microsoft.Graph.Beta.Models.MacOSAzureAdSingleSignOnExtension(),
                "#microsoft.graph.macOSCredentialSingleSignOnExtension" => new Microsoft.Graph.Beta.Models.MacOSCredentialSingleSignOnExtension(),
                "#microsoft.graph.macOSKerberosSingleSignOnExtension" => new Microsoft.Graph.Beta.Models.MacOSKerberosSingleSignOnExtension(),
                "#microsoft.graph.macOSRedirectSingleSignOnExtension" => new Microsoft.Graph.Beta.Models.MacOSRedirectSingleSignOnExtension(),
                _ => new Microsoft.Graph.Beta.Models.MacOSSingleSignOnExtension(),
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
        }
    }
}
