// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates
{
    #pragma warning disable CS1591
    public class AzureADDevice : Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAsset, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Specifies areas of the service in which the device is enrolled. Read-only. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment>? Enrollments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment>?>("enrollments"); }
            set { BackingStore?.Set("enrollments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment> Enrollments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment>>("enrollments"); }
            set { BackingStore?.Set("enrollments", value); }
        }
#endif
        /// <summary>Specifies any errors that prevent the device from being enrolled in update management or receving deployed content. Read-only. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError>? Errors
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError>?>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError> Errors
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError>>("errors"); }
            set { BackingStore?.Set("errors", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.WindowsUpdates.AzureADDevice"/> and sets the default values.
        /// </summary>
        public AzureADDevice() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdates.azureADDevice";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsUpdates.AzureADDevice"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.WindowsUpdates.AzureADDevice CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.WindowsUpdates.AzureADDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "enrollments", n => { Enrollments = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment>(Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "errors", n => { Errors = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError>(Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetEnrollment>("enrollments", Enrollments);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.WindowsUpdates.UpdatableAssetError>("errors", Errors);
        }
    }
}
