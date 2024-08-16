// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class UserLastSignInRecommendationInsightSetting : Microsoft.Graph.Beta.Models.AccessReviewRecommendationInsightSetting, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Optional. Indicates the time period of inactivity (with respect to the start date of the review instance) that recommendations will be configured from. The recommendation will be to deny if the user is inactive during the look-back duration. For reviews of groups and Microsoft Entra roles, any duration is accepted. For reviews of applications, 30 days is the maximum duration. If not specified, the duration is 30 days.</summary>
        public TimeSpan? RecommendationLookBackDuration
        {
            get { return BackingStore?.Get<TimeSpan?>("recommendationLookBackDuration"); }
            set { BackingStore?.Set("recommendationLookBackDuration", value); }
        }
        /// <summary>Indicates whether inactivity is calculated based on the user&apos;s inactivity in the tenant or in the application. The possible values are tenant, application, unknownFutureValue. application is only relevant when the access review is a review of an assignment to an application.</summary>
        public Microsoft.Graph.Beta.Models.UserSignInRecommendationScope? SignInScope
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.UserSignInRecommendationScope?>("signInScope"); }
            set { BackingStore?.Set("signInScope", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.UserLastSignInRecommendationInsightSetting"/> and sets the default values.
        /// </summary>
        public UserLastSignInRecommendationInsightSetting() : base()
        {
            OdataType = "#microsoft.graph.userLastSignInRecommendationInsightSetting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.UserLastSignInRecommendationInsightSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Beta.Models.UserLastSignInRecommendationInsightSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.UserLastSignInRecommendationInsightSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "recommendationLookBackDuration", n => { RecommendationLookBackDuration = n.GetTimeSpanValue(); } },
                { "signInScope", n => { SignInScope = n.GetEnumValue<Microsoft.Graph.Beta.Models.UserSignInRecommendationScope>(); } },
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
            writer.WriteTimeSpanValue("recommendationLookBackDuration", RecommendationLookBackDuration);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.UserSignInRecommendationScope>("signInScope", SignInScope);
        }
    }
}
