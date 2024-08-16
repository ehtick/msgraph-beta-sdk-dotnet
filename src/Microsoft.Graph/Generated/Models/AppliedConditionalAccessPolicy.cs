// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models
{
    #pragma warning disable CS1591
    public class AppliedConditionalAccessPolicy : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The custom authentication strength enforced in a Conditional Access policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.AuthenticationStrength? AuthenticationStrength
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthenticationStrength?>("authenticationStrength"); }
            set { BackingStore?.Set("authenticationStrength", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.AuthenticationStrength AuthenticationStrength
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AuthenticationStrength>("authenticationStrength"); }
            set { BackingStore?.Set("authenticationStrength", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Refers to the conditional access policy conditions that aren&apos;t satisfied. The possible values are: none, application, users, devicePlatform, location, clientType, signInRisk, userRisk, time, deviceState, client,ipAddressSeenByAzureAD,ipAddressSeenByResourceProvider,unknownFutureValue,servicePrincipals,servicePrincipalRisk, authenticationFlows, insiderRisk . You must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: servicePrincipals,servicePrincipalRisk, authenticationFlows, insiderRisk. conditionalAccessConditions is a multi-valued enumeration and the property can contain multiple values in a comma-separated list.</summary>
        public Microsoft.Graph.Beta.Models.ConditionalAccessConditions? ConditionsNotSatisfied
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConditionalAccessConditions?>("conditionsNotSatisfied"); }
            set { BackingStore?.Set("conditionsNotSatisfied", value); }
        }
        /// <summary>Refers to the conditional access policy conditions that are satisfied. The possible values are: none, application, users, devicePlatform, location, clientType, signInRisk, userRisk, time, deviceState, client,ipAddressSeenByAzureAD,ipAddressSeenByResourceProvider,unknownFutureValue,servicePrincipals,servicePrincipalRisk, authenticationFlows, insiderRisk. You must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: servicePrincipals,servicePrincipalRisk, authenticationFlows, insiderRisk. conditionalAccessConditions is a multi-valued enumeration and the property can contain multiple values in a comma-separated list.</summary>
        public Microsoft.Graph.Beta.Models.ConditionalAccessConditions? ConditionsSatisfied
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConditionalAccessConditions?>("conditionsSatisfied"); }
            set { BackingStore?.Set("conditionsSatisfied", value); }
        }
        /// <summary>Name of the conditional access policy.</summary>
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
        /// <summary>Refers to the grant controls enforced by the conditional access policy (example: &apos;Require multi-factor authentication&apos;).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnforcedGrantControls
        {
            get { return BackingStore?.Get<List<string>?>("enforcedGrantControls"); }
            set { BackingStore?.Set("enforcedGrantControls", value); }
        }
#nullable restore
#else
        public List<string> EnforcedGrantControls
        {
            get { return BackingStore?.Get<List<string>>("enforcedGrantControls"); }
            set { BackingStore?.Set("enforcedGrantControls", value); }
        }
#endif
        /// <summary>Refers to the session controls enforced by the conditional access policy (example: &apos;Require app enforced controls&apos;).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnforcedSessionControls
        {
            get { return BackingStore?.Get<List<string>?>("enforcedSessionControls"); }
            set { BackingStore?.Set("enforcedSessionControls", value); }
        }
#nullable restore
#else
        public List<string> EnforcedSessionControls
        {
            get { return BackingStore?.Get<List<string>>("enforcedSessionControls"); }
            set { BackingStore?.Set("enforcedSessionControls", value); }
        }
#endif
        /// <summary>List of key-value pairs containing each matched exclude condition in the conditional access policy. Example: [{&apos;devicePlatform&apos; : &apos;DevicePlatform&apos;}] means the policy didn&apos;t apply, because the DevicePlatform condition was a match.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied>? ExcludeRulesSatisfied
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied>?>("excludeRulesSatisfied"); }
            set { BackingStore?.Set("excludeRulesSatisfied", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied> ExcludeRulesSatisfied
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied>>("excludeRulesSatisfied"); }
            set { BackingStore?.Set("excludeRulesSatisfied", value); }
        }
#endif
        /// <summary>Identifier of the conditional access policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id
        {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id
        {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
        /// <summary>List of key-value pairs containing each matched include condition in the conditional access policy. Example: [{ &apos;application&apos; : &apos;AllApps&apos;}, {&apos;users&apos;: &apos;Group&apos;}], meaning Application condition was a match because AllApps are included and Users condition was a match because the user was part of the included Group rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied>? IncludeRulesSatisfied
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied>?>("includeRulesSatisfied"); }
            set { BackingStore?.Set("includeRulesSatisfied", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied> IncludeRulesSatisfied
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied>>("includeRulesSatisfied"); }
            set { BackingStore?.Set("includeRulesSatisfied", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Indicates the result of the CA policy that was triggered. Possible values are: success, failure, notApplied (policy isn&apos;t applied because policy conditions weren&apos;t met), notEnabled (this is due to the policy in a disabled state), unknown, unknownFutureValue, reportOnlySuccess, reportOnlyFailure, reportOnlyNotApplied, reportOnlyInterrupted. You must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: reportOnlySuccess, reportOnlyFailure, reportOnlyNotApplied, reportOnlyInterrupted.</summary>
        public Microsoft.Graph.Beta.Models.AppliedConditionalAccessPolicyResult? Result
        {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AppliedConditionalAccessPolicyResult?>("result"); }
            set { BackingStore?.Set("result", value); }
        }
        /// <summary>Refers to the session controls that a sign-in activity didn&apos;t satisfy. (Example: Application enforced Restrictions).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SessionControlsNotSatisfied
        {
            get { return BackingStore?.Get<List<string>?>("sessionControlsNotSatisfied"); }
            set { BackingStore?.Set("sessionControlsNotSatisfied", value); }
        }
#nullable restore
#else
        public List<string> SessionControlsNotSatisfied
        {
            get { return BackingStore?.Get<List<string>>("sessionControlsNotSatisfied"); }
            set { BackingStore?.Set("sessionControlsNotSatisfied", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Models.AppliedConditionalAccessPolicy"/> and sets the default values.
        /// </summary>
        public AppliedConditionalAccessPolicy()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.AppliedConditionalAccessPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Beta.Models.AppliedConditionalAccessPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Beta.Models.AppliedConditionalAccessPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "authenticationStrength", n => { AuthenticationStrength = n.GetObjectValue<Microsoft.Graph.Beta.Models.AuthenticationStrength>(Microsoft.Graph.Beta.Models.AuthenticationStrength.CreateFromDiscriminatorValue); } },
                { "conditionsNotSatisfied", n => { ConditionsNotSatisfied = n.GetEnumValue<Microsoft.Graph.Beta.Models.ConditionalAccessConditions>(); } },
                { "conditionsSatisfied", n => { ConditionsSatisfied = n.GetEnumValue<Microsoft.Graph.Beta.Models.ConditionalAccessConditions>(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "enforcedGrantControls", n => { EnforcedGrantControls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "enforcedSessionControls", n => { EnforcedSessionControls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                { "excludeRulesSatisfied", n => { ExcludeRulesSatisfied = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied>(Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied.CreateFromDiscriminatorValue)?.ToList(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "includeRulesSatisfied", n => { IncludeRulesSatisfied = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied>(Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied.CreateFromDiscriminatorValue)?.ToList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "result", n => { Result = n.GetEnumValue<Microsoft.Graph.Beta.Models.AppliedConditionalAccessPolicyResult>(); } },
                { "sessionControlsNotSatisfied", n => { SessionControlsNotSatisfied = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AuthenticationStrength>("authenticationStrength", AuthenticationStrength);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ConditionalAccessConditions>("conditionsNotSatisfied", ConditionsNotSatisfied);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.ConditionalAccessConditions>("conditionsSatisfied", ConditionsSatisfied);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedGrantControls", EnforcedGrantControls);
            writer.WriteCollectionOfPrimitiveValues<string>("enforcedSessionControls", EnforcedSessionControls);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied>("excludeRulesSatisfied", ExcludeRulesSatisfied);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.ConditionalAccessRuleSatisfied>("includeRulesSatisfied", IncludeRulesSatisfied);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<Microsoft.Graph.Beta.Models.AppliedConditionalAccessPolicyResult>("result", Result);
            writer.WriteCollectionOfPrimitiveValues<string>("sessionControlsNotSatisfied", SessionControlsNotSatisfied);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
