// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class List : Microsoft.Graph.Beta.Models.BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The recent activities that took place within this list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ItemActivityOLD>? Activities
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ItemActivityOLD>?>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ItemActivityOLD> Activities
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ItemActivityOLD>>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#endif
        /// <summary>The collection of field definitions for this list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ColumnDefinition>? Columns
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ColumnDefinition>?>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ColumnDefinition> Columns
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ColumnDefinition>>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#endif
        /// <summary>The collection of content types present in this list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ContentType>? ContentTypes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ContentType>?>("contentTypes"); }
            set { BackingStore?.Set("contentTypes", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ContentType> ContentTypes
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ContentType>>("contentTypes"); }
            set { BackingStore?.Set("contentTypes", value); }
        }
#endif
        /// <summary>The displayable title of the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Allows access to the list as a drive resource with driveItems. Only present on document libraries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.Drive? Drive
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Drive?>("drive"); }
            set { BackingStore?.Set("drive", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.Drive Drive
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Drive>("drive"); }
            set { BackingStore?.Set("drive", value); }
        }
#endif
        /// <summary>All items contained in the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ListItem>? Items
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ListItem>?>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ListItem> Items
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ListItem>>("items"); }
            set { BackingStore?.Set("items", value); }
        }
#endif
        /// <summary>Contains more details about the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.ListInfo? ListProp
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ListInfo?>("list"); }
            set { BackingStore?.Set("list", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.ListInfo ListProp
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ListInfo>("list"); }
            set { BackingStore?.Set("list", value); }
        }
#endif
        /// <summary>The collection of long-running operations on the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.RichLongRunningOperation>? Operations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.RichLongRunningOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.RichLongRunningOperation> Operations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.RichLongRunningOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The permissions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Permission>? Permissions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Permission>?>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Permission> Permissions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Permission>>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SharepointIds? SharepointIds
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharepointIds?>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SharepointIds SharepointIds
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#endif
        /// <summary>The set of subscriptions on the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.Subscription>? Subscriptions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Subscription>?>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.Subscription> Subscriptions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.Subscription>>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
#endif
        /// <summary>If present, indicates that the list is system-managed. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.SystemFacet? System
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SystemFacet?>("system"); }
            set { BackingStore?.Set("system", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.SystemFacet System
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SystemFacet>("system"); }
            set { BackingStore?.Set("system", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.List"/> and sets the default values.
        /// </summary>
        public List() : base()
        {
            OdataType = "#microsoft.graph.list";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.List"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.List CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.List();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activities", n => { Activities = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ItemActivityOLD>(Microsoft.Graph.Beta.Models.ItemActivityOLD.CreateFromDiscriminatorValue)?.ToList(); } },
                { "columns", n => { Columns = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ColumnDefinition>(Microsoft.Graph.Beta.Models.ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                { "contentTypes", n => { ContentTypes = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ContentType>(Microsoft.Graph.Beta.Models.ContentType.CreateFromDiscriminatorValue)?.ToList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "drive", n => { Drive = n.GetObjectValue<Microsoft.Graph.Beta.Models.Drive>(Microsoft.Graph.Beta.Models.Drive.CreateFromDiscriminatorValue); } },
                { "items", n => { Items = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ListItem>(Microsoft.Graph.Beta.Models.ListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                { "list", n => { ListProp = n.GetObjectValue<Microsoft.Graph.Beta.Models.ListInfo>(Microsoft.Graph.Beta.Models.ListInfo.CreateFromDiscriminatorValue); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RichLongRunningOperation>(Microsoft.Graph.Beta.Models.RichLongRunningOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                { "permissions", n => { Permissions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Permission>(Microsoft.Graph.Beta.Models.Permission.CreateFromDiscriminatorValue)?.ToList(); } },
                { "sharepointIds", n => { SharepointIds = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>(Microsoft.Graph.Beta.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                { "subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Subscription>(Microsoft.Graph.Beta.Models.Subscription.CreateFromDiscriminatorValue)?.ToList(); } },
                { "system", n => { System = n.GetObjectValue<Microsoft.Graph.Beta.Models.SystemFacet>(Microsoft.Graph.Beta.Models.SystemFacet.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ItemActivityOLD>("activities", Activities);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ColumnDefinition>("columns", Columns);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ContentType>("contentTypes", ContentTypes);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ListItem>("items", Items);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ListInfo>("list", ListProp);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RichLongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Permission>("permissions", Permissions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.Subscription>("subscriptions", Subscriptions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SystemFacet>("system", System);
        }
    }
}
