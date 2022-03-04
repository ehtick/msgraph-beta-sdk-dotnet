using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserAccountInformation : ItemFacet, IParsable {
        /// <summary>Shows the age group of user. Allowed values null, minor, notAdult and adult are generated by the directory and cannot be changed.</summary>
        public string AgeGroup { get; set; }
        /// <summary>Contains the two-character country code associated with the users account.</summary>
        public string CountryCode { get; set; }
        public LocaleInfo PreferredLanguageTag { get; set; }
        /// <summary>The user principal name (UPN) of the user associated with the account.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserAccountInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserAccountInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"ageGroup", (o,n) => { (o as UserAccountInformation).AgeGroup = n.GetStringValue(); } },
                {"countryCode", (o,n) => { (o as UserAccountInformation).CountryCode = n.GetStringValue(); } },
                {"preferredLanguageTag", (o,n) => { (o as UserAccountInformation).PreferredLanguageTag = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"userPrincipalName", (o,n) => { (o as UserAccountInformation).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("ageGroup", AgeGroup);
            writer.WriteStringValue("countryCode", CountryCode);
            writer.WriteObjectValue<LocaleInfo>("preferredLanguageTag", PreferredLanguageTag);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
