// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// Android PFX Import certificate profile
    /// </summary>
    public class AndroidImportedPFXCertificateProfile : Microsoft.Graph.Beta.Models.AndroidCertificateProfileBase, IParsable
    {
        /// <summary>PFX Import Options.</summary>
        public Microsoft.Graph.Beta.Models.IntendedPurpose? IntendedPurpose
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IntendedPurpose?>("intendedPurpose"); }
            set { BackingStore?.Set("intendedPurpose", value); }
        }
        /// <summary>Certificate state for devices. This collection can contain a maximum of 2147483647 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>? ManagedDeviceCertificateStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>?>("managedDeviceCertificateStates"); }
            set { BackingStore?.Set("managedDeviceCertificateStates", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState> ManagedDeviceCertificateStates
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>>("managedDeviceCertificateStates"); }
            set { BackingStore?.Set("managedDeviceCertificateStates", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.AndroidImportedPFXCertificateProfile"/> and sets the default values.
        /// </summary>
        public AndroidImportedPFXCertificateProfile() : base()
        {
            OdataType = "#microsoft.graph.androidImportedPFXCertificateProfile";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AndroidImportedPFXCertificateProfile"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AndroidImportedPFXCertificateProfile CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AndroidImportedPFXCertificateProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "intendedPurpose", n => { IntendedPurpose = n.GetEnumValue<Microsoft.Graph.Beta.Models.IntendedPurpose>(); } },
                { "managedDeviceCertificateStates", n => { ManagedDeviceCertificateStates = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>(Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.IntendedPurpose>("intendedPurpose", IntendedPurpose);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ManagedDeviceCertificateState>("managedDeviceCertificateStates", ManagedDeviceCertificateStates);
        }
    }
}
