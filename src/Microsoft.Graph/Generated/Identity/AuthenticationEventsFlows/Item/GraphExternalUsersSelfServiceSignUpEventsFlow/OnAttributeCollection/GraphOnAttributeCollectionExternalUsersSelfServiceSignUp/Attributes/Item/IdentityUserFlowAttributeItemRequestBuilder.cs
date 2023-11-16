// <auto-generated/>
using Microsoft.Graph.Beta.Identity.AuthenticationEventsFlows.Item.GraphExternalUsersSelfServiceSignUpEventsFlow.OnAttributeCollection.GraphOnAttributeCollectionExternalUsersSelfServiceSignUp.Attributes.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Beta.Identity.AuthenticationEventsFlows.Item.GraphExternalUsersSelfServiceSignUpEventsFlow.OnAttributeCollection.GraphOnAttributeCollectionExternalUsersSelfServiceSignUp.Attributes.Item {
    /// <summary>
    /// Builds and executes requests for operations under \identity\authenticationEventsFlows\{authenticationEventsFlow-id}\graph.externalUsersSelfServiceSignUpEventsFlow\onAttributeCollection\graph.onAttributeCollectionExternalUsersSelfServiceSignUp\attributes\{identityUserFlowAttribute-id}
    /// </summary>
    public class IdentityUserFlowAttributeItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the collection of identityContainer entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new IdentityUserFlowAttributeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityUserFlowAttributeItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/authenticationEventsFlows/{authenticationEventsFlow%2Did}/graph.externalUsersSelfServiceSignUpEventsFlow/onAttributeCollection/graph.onAttributeCollectionExternalUsersSelfServiceSignUp/attributes/{identityUserFlowAttribute%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new IdentityUserFlowAttributeItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IdentityUserFlowAttributeItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/authenticationEventsFlows/{authenticationEventsFlow%2Did}/graph.externalUsersSelfServiceSignUpEventsFlow/onAttributeCollection/graph.onAttributeCollectionExternalUsersSelfServiceSignUp/attributes/{identityUserFlowAttribute%2Did}", rawUrl) {
        }
    }
}
