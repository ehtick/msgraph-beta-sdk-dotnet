using Microsoft.Graph.Beta.Models;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.Item.ServicePrincipal.AddTokenSigningCertificate;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.Item.ServicePrincipal.CheckMemberGroups;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.Item.ServicePrincipal.CheckMemberObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.Item.ServicePrincipal.CreatePasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.Item.ServicePrincipal.DeletePasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.Item.ServicePrincipal.GetMemberGroups;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.Item.ServicePrincipal.GetMemberObjects;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.Item.ServicePrincipal.GetPasswordSingleSignOnCredentials;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.Item.ServicePrincipal.Restore;
using Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.Item.ServicePrincipal.UpdatePasswordSingleSignOnCredentials;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.ServicePrincipals.Item.MemberOf.Item.ServicePrincipal {
    /// <summary>Casts the previous resource to servicePrincipal.</summary>
    public class ServicePrincipalRequestBuilder {
        /// <summary>The addTokenSigningCertificate property</summary>
        public AddTokenSigningCertificateRequestBuilder AddTokenSigningCertificate { get =>
            new AddTokenSigningCertificateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkMemberGroups property</summary>
        public CheckMemberGroupsRequestBuilder CheckMemberGroups { get =>
            new CheckMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The checkMemberObjects property</summary>
        public CheckMemberObjectsRequestBuilder CheckMemberObjects { get =>
            new CheckMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The createPasswordSingleSignOnCredentials property</summary>
        public CreatePasswordSingleSignOnCredentialsRequestBuilder CreatePasswordSingleSignOnCredentials { get =>
            new CreatePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deletePasswordSingleSignOnCredentials property</summary>
        public DeletePasswordSingleSignOnCredentialsRequestBuilder DeletePasswordSingleSignOnCredentials { get =>
            new DeletePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getMemberGroups property</summary>
        public GetMemberGroupsRequestBuilder GetMemberGroups { get =>
            new GetMemberGroupsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getMemberObjects property</summary>
        public GetMemberObjectsRequestBuilder GetMemberObjects { get =>
            new GetMemberObjectsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getPasswordSingleSignOnCredentials property</summary>
        public GetPasswordSingleSignOnCredentialsRequestBuilder GetPasswordSingleSignOnCredentials { get =>
            new GetPasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The restore property</summary>
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The updatePasswordSingleSignOnCredentials property</summary>
        public UpdatePasswordSingleSignOnCredentialsRequestBuilder UpdatePasswordSingleSignOnCredentials { get =>
            new UpdatePasswordSingleSignOnCredentialsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new ServicePrincipalRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ServicePrincipalRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/memberOf/{directoryObject%2Did}/microsoft.graph.servicePrincipal{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ServicePrincipalRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public ServicePrincipalRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/memberOf/{directoryObject%2Did}/microsoft.graph.servicePrincipal{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<ServicePrincipalRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ServicePrincipalRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<Microsoft.Graph.Beta.Models.ServicePrincipal> GetAsync(Action<ServicePrincipalRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.ServicePrincipal>(requestInfo, Microsoft.Graph.Beta.Models.ServicePrincipal.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Get the item of type microsoft.graph.directoryObject as microsoft.graph.servicePrincipal</summary>
        public class ServicePrincipalRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class ServicePrincipalRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ServicePrincipalRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ServicePrincipalRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new servicePrincipalRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ServicePrincipalRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
