// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AppManagementPolicy : Microsoft.Graph.Beta.Models.PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Collection of application and service principals to which a policy is applied.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.DirectoryObject>? AppliesTo
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DirectoryObject>?>("appliesTo"); }
            set { BackingStore?.Set("appliesTo", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.DirectoryObject> AppliesTo
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.DirectoryObject>>("appliesTo"); }
            set { BackingStore?.Set("appliesTo", value); }
        }
#endif
        /// <summary>Denotes whether the policy is enabled.</summary>
        public bool? IsEnabled
        {
            get { return BackingStore?.Get<bool?>("isEnabled"); }
            set { BackingStore?.Set("isEnabled", value); }
        }
        /// <summary>Restrictions that apply to an application or service principal object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AppManagementConfiguration? Restrictions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AppManagementConfiguration?>("restrictions"); }
            set { BackingStore?.Set("restrictions", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AppManagementConfiguration Restrictions
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AppManagementConfiguration>("restrictions"); }
            set { BackingStore?.Set("restrictions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.AppManagementPolicy"/> and sets the default values.
        /// </summary>
        public AppManagementPolicy() : base()
        {
            OdataType = "#microsoft.graph.appManagementPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AppManagementPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.AppManagementPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AppManagementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appliesTo", n => { AppliesTo = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DirectoryObject>(Microsoft.Graph.Beta.Models.DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "restrictions", n => { Restrictions = n.GetObjectValue<Microsoft.Graph.Beta.Models.AppManagementConfiguration>(Microsoft.Graph.Beta.Models.AppManagementConfiguration.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.DirectoryObject>("appliesTo", AppliesTo);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AppManagementConfiguration>("restrictions", Restrictions);
        }
    }
}
