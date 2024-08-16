// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Device Configuration.
    /// </summary>
    public class Windows81CertificateProfileBase : Microsoft.Graph.Beta.Models.WindowsCertificateProfileBase, IParsable
    {
        /// <summary>Custom Subject Alternative Name Settings. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>? CustomSubjectAlternativeNames
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>?>("customSubjectAlternativeNames"); }
            set { BackingStore?.Set("customSubjectAlternativeNames", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName> CustomSubjectAlternativeNames
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>>("customSubjectAlternativeNames"); }
            set { BackingStore?.Set("customSubjectAlternativeNames", value); }
        }
#endif
        /// <summary>Extended Key Usage (EKU) settings. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ExtendedKeyUsage>? ExtendedKeyUsages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ExtendedKeyUsage>?>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ExtendedKeyUsage> ExtendedKeyUsages
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ExtendedKeyUsage>>("extendedKeyUsages"); }
            set { BackingStore?.Set("extendedKeyUsages", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Windows81CertificateProfileBase"/> and sets the default values.
        /// </summary>
        public Windows81CertificateProfileBase() : base()
        {
            OdataType = "#microsoft.graph.windows81CertificateProfileBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Windows81CertificateProfileBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Windows81CertificateProfileBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.windows81SCEPCertificateProfile" => new Microsoft.Graph.Beta.Models.Windows81SCEPCertificateProfile(),
                _ => new Microsoft.Graph.Beta.Models.Windows81CertificateProfileBase(),
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
                { "customSubjectAlternativeNames", n => { CustomSubjectAlternativeNames = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>(Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName.CreateFromDiscriminatorValue)?.ToList(); } },
                { "extendedKeyUsages", n => { ExtendedKeyUsages = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ExtendedKeyUsage>(Microsoft.Graph.Beta.Models.ExtendedKeyUsage.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.CustomSubjectAlternativeName>("customSubjectAlternativeNames", CustomSubjectAlternativeNames);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ExtendedKeyUsage>("extendedKeyUsages", ExtendedKeyUsages);
        }
    }
}
