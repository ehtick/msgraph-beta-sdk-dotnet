// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class ContainerEvidence : Microsoft.Graph.Beta.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list of arguments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Args
        {
            get { return BackingStore?.Get<List<string>?>("args"); }
            set { BackingStore?.Set("args", value); }
        }
#nullable restore
#else
        public List<string> Args
        {
            get { return BackingStore?.Get<List<string>>("args"); }
            set { BackingStore?.Set("args", value); }
        }
#endif
        /// <summary>The list of commands.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Command
        {
            get { return BackingStore?.Get<List<string>?>("command"); }
            set { BackingStore?.Set("command", value); }
        }
#nullable restore
#else
        public List<string> Command
        {
            get { return BackingStore?.Get<List<string>>("command"); }
            set { BackingStore?.Set("command", value); }
        }
#endif
        /// <summary>The container ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContainerId
        {
            get { return BackingStore?.Get<string?>("containerId"); }
            set { BackingStore?.Set("containerId", value); }
        }
#nullable restore
#else
        public string ContainerId
        {
            get { return BackingStore?.Get<string>("containerId"); }
            set { BackingStore?.Set("containerId", value); }
        }
#endif
        /// <summary>The image used to run the container.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.ContainerImageEvidence? Image
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ContainerImageEvidence?>("image"); }
            set { BackingStore?.Set("image", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.ContainerImageEvidence Image
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.ContainerImageEvidence>("image"); }
            set { BackingStore?.Set("image", value); }
        }
#endif
        /// <summary>The privileged status.</summary>
        public bool? IsPrivileged
        {
            get { return BackingStore?.Get<bool?>("isPrivileged"); }
            set { BackingStore?.Set("isPrivileged", value); }
        }
        /// <summary>The container name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The pod that this container belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.KubernetesPodEvidence? Pod
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.KubernetesPodEvidence?>("pod"); }
            set { BackingStore?.Set("pod", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.KubernetesPodEvidence Pod
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.KubernetesPodEvidence>("pod"); }
            set { BackingStore?.Set("pod", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.Security.ContainerEvidence"/> and sets the default values.
        /// </summary>
        public ContainerEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.containerEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.ContainerEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Security.ContainerEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.ContainerEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "args", n => { Args = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "command", n => { Command = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "containerId", n => { ContainerId = n.GetStringValue(); } },
                { "image", n => { Image = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.ContainerImageEvidence>(Microsoft.Graph.Beta.Models.Security.ContainerImageEvidence.CreateFromDiscriminatorValue); } },
                { "isPrivileged", n => { IsPrivileged = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "pod", n => { Pod = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.KubernetesPodEvidence>(Microsoft.Graph.Beta.Models.Security.KubernetesPodEvidence.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("args", Args);
            writer.WriteCollectionOfPrimitiveValues<string>("command", Command);
            writer.WriteStringValue("containerId", ContainerId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.ContainerImageEvidence>("image", Image);
            writer.WriteBoolValue("isPrivileged", IsPrivileged);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.KubernetesPodEvidence>("pod", Pod);
        }
    }
}
