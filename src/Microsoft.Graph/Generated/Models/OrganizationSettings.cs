// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class OrganizationSettings : Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Contains the properties that are configured by an administrator as a tenant-level privacy control whether to identify duplicate contacts among a user&apos;s contacts list and suggest the user to merge those contacts to have a cleaner contacts list. List contactInsights returns the settings to display or return contact insights in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.InsightsSettings? ContactInsights
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InsightsSettings?>("contactInsights"); }
            set { BackingStore?.Set("contactInsights", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.InsightsSettings ContactInsights
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InsightsSettings>("contactInsights"); }
            set { BackingStore?.Set("contactInsights", value); }
        }
#endif
        /// <summary>Contains the properties that are configured by an administrator for the visibility of Microsoft Graph-derived insights, between a user and other items in Microsoft 365, such as documents or sites. List itemInsights returns the settings to display or return item insights in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.InsightsSettings? ItemInsights
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InsightsSettings?>("itemInsights"); }
            set { BackingStore?.Set("itemInsights", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.InsightsSettings ItemInsights
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InsightsSettings>("itemInsights"); }
            set { BackingStore?.Set("itemInsights", value); }
        }
#endif
        /// <summary>The microsoftApplicationDataAccess property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.MicrosoftApplicationDataAccessSettings? MicrosoftApplicationDataAccess
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MicrosoftApplicationDataAccessSettings?>("microsoftApplicationDataAccess"); }
            set { BackingStore?.Set("microsoftApplicationDataAccess", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.MicrosoftApplicationDataAccessSettings MicrosoftApplicationDataAccess
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MicrosoftApplicationDataAccessSettings>("microsoftApplicationDataAccess"); }
            set { BackingStore?.Set("microsoftApplicationDataAccess", value); }
        }
#endif
        /// <summary>Contains the properties that are configured by an administrator for the visibility of a list of people relevant and working with a user in Microsoft 365. List peopleInsights returns the settings to display or return people insights in an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.InsightsSettings? PeopleInsights
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InsightsSettings?>("peopleInsights"); }
            set { BackingStore?.Set("peopleInsights", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.InsightsSettings PeopleInsights
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.InsightsSettings>("peopleInsights"); }
            set { BackingStore?.Set("peopleInsights", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.OrganizationSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.OrganizationSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.OrganizationSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "contactInsights", n => { ContactInsights = n.GetObjectValue<Microsoft.Graph.Beta.Models.InsightsSettings>(Microsoft.Graph.Beta.Models.InsightsSettings.CreateFromDiscriminatorValue); } },
                { "itemInsights", n => { ItemInsights = n.GetObjectValue<Microsoft.Graph.Beta.Models.InsightsSettings>(Microsoft.Graph.Beta.Models.InsightsSettings.CreateFromDiscriminatorValue); } },
                { "microsoftApplicationDataAccess", n => { MicrosoftApplicationDataAccess = n.GetObjectValue<Microsoft.Graph.Beta.Models.MicrosoftApplicationDataAccessSettings>(Microsoft.Graph.Beta.Models.MicrosoftApplicationDataAccessSettings.CreateFromDiscriminatorValue); } },
                { "peopleInsights", n => { PeopleInsights = n.GetObjectValue<Microsoft.Graph.Beta.Models.InsightsSettings>(Microsoft.Graph.Beta.Models.InsightsSettings.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.InsightsSettings>("contactInsights", ContactInsights);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.InsightsSettings>("itemInsights", ItemInsights);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MicrosoftApplicationDataAccessSettings>("microsoftApplicationDataAccess", MicrosoftApplicationDataAccess);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.InsightsSettings>("peopleInsights", PeopleInsights);
        }
    }
}
