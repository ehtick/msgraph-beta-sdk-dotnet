// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// A class containing the properties used for mobile app PolicySetItem.
    /// </summary>
    public class MobileAppPolicySetItem : Microsoft.Graph.Beta.Models.PolicySetItem, IParsable
    {
        /// <summary>Possible values for the install intent chosen by the admin.</summary>
        public Microsoft.Graph.Beta.Models.InstallIntent? Intent
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InstallIntent?>("intent"); }
            set { BackingStore?.Set("intent", value); }
        }
        /// <summary>Settings of the MobileAppPolicySetItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings? Settings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings Settings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.MobileAppPolicySetItem"/> and sets the default values.
        /// </summary>
        public MobileAppPolicySetItem() : base()
        {
            OdataType = "#microsoft.graph.mobileAppPolicySetItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MobileAppPolicySetItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MobileAppPolicySetItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MobileAppPolicySetItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "intent", n => { Intent = n.GetEnumValue<Microsoft.Graph.Beta.Models.InstallIntent>(); } },
                { "settings", n => { Settings = n.GetObjectValue<Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings>(Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.InstallIntent>("intent", Intent);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MobileAppAssignmentSettings>("settings", Settings);
        }
    }
}
