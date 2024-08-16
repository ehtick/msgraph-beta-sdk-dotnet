// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    #pragma warning disable CS1591
    public class InformationProtection : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read the Microsoft Purview Information Protection policy settings for the user or organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Security.InformationProtectionPolicySetting? LabelPolicySettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.InformationProtectionPolicySetting?>("labelPolicySettings"); }
            set { BackingStore?.Set("labelPolicySettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Security.InformationProtectionPolicySetting LabelPolicySettings
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.InformationProtectionPolicySetting>("labelPolicySettings"); }
            set { BackingStore?.Set("labelPolicySettings", value); }
        }
#endif
        /// <summary>Read the Microsoft Purview Information Protection labels for the user or organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Security.SensitivityLabel>? SensitivityLabels
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.SensitivityLabel>?>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Security.SensitivityLabel> SensitivityLabels
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Security.SensitivityLabel>>("sensitivityLabels"); }
            set { BackingStore?.Set("sensitivityLabels", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.Security.InformationProtection"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.Security.InformationProtection CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.Security.InformationProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "labelPolicySettings", n => { LabelPolicySettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.InformationProtectionPolicySetting>(Microsoft.Graph.Beta.Models.Security.InformationProtectionPolicySetting.CreateFromDiscriminatorValue); } },
                { "sensitivityLabels", n => { SensitivityLabels = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.SensitivityLabel>(Microsoft.Graph.Beta.Models.Security.SensitivityLabel.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.InformationProtectionPolicySetting>("labelPolicySettings", LabelPolicySettings);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Security.SensitivityLabel>("sensitivityLabels", SensitivityLabels);
        }
    }
}
