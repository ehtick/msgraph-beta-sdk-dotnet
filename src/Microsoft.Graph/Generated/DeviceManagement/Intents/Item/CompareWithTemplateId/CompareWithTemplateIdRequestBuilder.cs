using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Beta.DeviceManagement.Intents.Item.CompareWithTemplateId {
    /// <summary>Provides operations to call the compare method.</summary>
    public class CompareWithTemplateIdRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new CompareWithTemplateIdRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="templateId">Usage: templateId=&apos;{templateId}&apos;</param>
        /// </summary>
        public CompareWithTemplateIdRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string templateId = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/intents/{deviceManagementIntent%2Did}/microsoft.graph.compare(templateId='{templateId}')";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("templateId", templateId);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new CompareWithTemplateIdRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public CompareWithTemplateIdRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/deviceManagement/intents/{deviceManagementIntent%2Did}/microsoft.graph.compare(templateId='{templateId}')";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function compare
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<CompareWithTemplateIdRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new CompareWithTemplateIdRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Invoke function compare
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<CompareWithTemplateIdResponse> GetAsync(Action<CompareWithTemplateIdRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<CompareWithTemplateIdResponse>(requestInfo, CompareWithTemplateIdResponse.CreateFromDiscriminatorValue, responseHandler, default, cancellationToken);
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class CompareWithTemplateIdRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new compareWithTemplateIdRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public CompareWithTemplateIdRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
