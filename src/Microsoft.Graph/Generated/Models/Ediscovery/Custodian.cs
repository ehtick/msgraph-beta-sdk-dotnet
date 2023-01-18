using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public class Custodian : DataSourceContainer, IParsable {
        /// <summary>Date and time the custodian acknowledged a hold notification.</summary>
        public DateTimeOffset? AcknowledgedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("acknowledgedDateTime"); }
            set { BackingStore?.Set("acknowledgedDateTime", value); }
        }
        /// <summary>Identifies whether a custodian&apos;s sources were placed on hold during creation.</summary>
        public bool? ApplyHoldToSources {
            get { return BackingStore?.Get<bool?>("applyHoldToSources"); }
            set { BackingStore?.Set("applyHoldToSources", value); }
        }
        /// <summary>Email address of the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Email {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#else
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>Data source entity for SharePoint sites associated with the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<SiteSource>? SiteSources {
            get { return BackingStore?.Get<List<SiteSource>?>("siteSources"); }
            set { BackingStore?.Set("siteSources", value); }
        }
#else
        public List<SiteSource> SiteSources {
            get { return BackingStore?.Get<List<SiteSource>>("siteSources"); }
            set { BackingStore?.Set("siteSources", value); }
        }
#endif
        /// <summary>Data source entity for groups associated with the custodian.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<UnifiedGroupSource>? UnifiedGroupSources {
            get { return BackingStore?.Get<List<UnifiedGroupSource>?>("unifiedGroupSources"); }
            set { BackingStore?.Set("unifiedGroupSources", value); }
        }
#else
        public List<UnifiedGroupSource> UnifiedGroupSources {
            get { return BackingStore?.Get<List<UnifiedGroupSource>>("unifiedGroupSources"); }
            set { BackingStore?.Set("unifiedGroupSources", value); }
        }
#endif
        /// <summary>Data source entity for a the custodian. This is the container for a custodian&apos;s mailbox and OneDrive for Business site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<UserSource>? UserSources {
            get { return BackingStore?.Get<List<UserSource>?>("userSources"); }
            set { BackingStore?.Set("userSources", value); }
        }
#else
        public List<UserSource> UserSources {
            get { return BackingStore?.Get<List<UserSource>>("userSources"); }
            set { BackingStore?.Set("userSources", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Custodian and sets the default values.
        /// </summary>
        public Custodian() : base() {
            OdataType = "#microsoft.graph.ediscovery.custodian";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Custodian CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Custodian();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acknowledgedDateTime", n => { AcknowledgedDateTime = n.GetDateTimeOffsetValue(); } },
                {"applyHoldToSources", n => { ApplyHoldToSources = n.GetBoolValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"siteSources", n => { SiteSources = n.GetCollectionOfObjectValues<SiteSource>(SiteSource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"unifiedGroupSources", n => { UnifiedGroupSources = n.GetCollectionOfObjectValues<UnifiedGroupSource>(UnifiedGroupSource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userSources", n => { UserSources = n.GetCollectionOfObjectValues<UserSource>(UserSource.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("acknowledgedDateTime", AcknowledgedDateTime);
            writer.WriteBoolValue("applyHoldToSources", ApplyHoldToSources);
            writer.WriteStringValue("email", Email);
            writer.WriteCollectionOfObjectValues<SiteSource>("siteSources", SiteSources);
            writer.WriteCollectionOfObjectValues<UnifiedGroupSource>("unifiedGroupSources", UnifiedGroupSources);
            writer.WriteCollectionOfObjectValues<UserSource>("userSources", UserSources);
        }
    }
}
