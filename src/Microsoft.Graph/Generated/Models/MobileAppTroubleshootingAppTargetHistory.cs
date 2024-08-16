// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// History Item contained in the Mobile App Troubleshooting Event.
    /// </summary>
    public class MobileAppTroubleshootingAppTargetHistory : Microsoft.Graph.Beta.Models.MobileAppTroubleshootingHistoryItem, IParsable
    {
        /// <summary>Error code for the failure, empty if no failure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorCode
        {
            get { return BackingStore?.Get<string?>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
#nullable restore
#else
        public string ErrorCode
        {
            get { return BackingStore?.Get<string>("errorCode"); }
            set { BackingStore?.Set("errorCode", value); }
        }
#endif
        /// <summary>Indicates the type of execution status of the device management script.</summary>
        public Microsoft.Graph.Beta.Models.RunState? RunState
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RunState?>("runState"); }
            set { BackingStore?.Set("runState", value); }
        }
        /// <summary>AAD security group id to which it was targeted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecurityGroupId
        {
            get { return BackingStore?.Get<string?>("securityGroupId"); }
            set { BackingStore?.Set("securityGroupId", value); }
        }
#nullable restore
#else
        public string SecurityGroupId
        {
            get { return BackingStore?.Get<string>("securityGroupId"); }
            set { BackingStore?.Set("securityGroupId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.MobileAppTroubleshootingAppTargetHistory"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.MobileAppTroubleshootingAppTargetHistory CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.MobileAppTroubleshootingAppTargetHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "errorCode", n => { ErrorCode = n.GetStringValue(); } },
                { "runState", n => { RunState = n.GetEnumValue<Microsoft.Graph.Beta.Models.RunState>(); } },
                { "securityGroupId", n => { SecurityGroupId = n.GetStringValue(); } },
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
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.RunState>("runState", RunState);
            writer.WriteStringValue("securityGroupId", SecurityGroupId);
        }
    }
}
