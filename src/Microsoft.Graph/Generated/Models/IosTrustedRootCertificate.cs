// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// iOS Trusted Root Certificate configuration profile.
    /// </summary>
    public class IosTrustedRootCertificate : Microsoft.Graph.Beta.Models.DeviceConfiguration, IParsable
    {
        /// <summary>File name to display in UI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertFileName
        {
            get { return BackingStore?.Get<string?>("certFileName"); }
            set { BackingStore?.Set("certFileName", value); }
        }
#nullable restore
#else
        public string CertFileName
        {
            get { return BackingStore?.Get<string>("certFileName"); }
            set { BackingStore?.Set("certFileName", value); }
        }
#endif
        /// <summary>Trusted Root Certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? TrustedRootCertificate
        {
            get { return BackingStore?.Get<byte[]?>("trustedRootCertificate"); }
            set { BackingStore?.Set("trustedRootCertificate", value); }
        }
#nullable restore
#else
        public byte[] TrustedRootCertificate
        {
            get { return BackingStore?.Get<byte[]>("trustedRootCertificate"); }
            set { BackingStore?.Set("trustedRootCertificate", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.IosTrustedRootCertificate"/> and sets the default values.
        /// </summary>
        public IosTrustedRootCertificate() : base()
        {
            OdataType = "#microsoft.graph.iosTrustedRootCertificate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.IosTrustedRootCertificate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.IosTrustedRootCertificate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.IosTrustedRootCertificate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "certFileName", n => { CertFileName = n.GetStringValue(); } },
                { "trustedRootCertificate", n => { TrustedRootCertificate = n.GetByteArrayValue(); } },
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
            writer.WriteStringValue("certFileName", CertFileName);
            writer.WriteByteArrayValue("trustedRootCertificate", TrustedRootCertificate);
        }
    }
}
