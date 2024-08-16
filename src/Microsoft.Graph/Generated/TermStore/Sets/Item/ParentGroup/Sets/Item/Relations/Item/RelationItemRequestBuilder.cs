// <auto-generated/>
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models.TermStore;
using Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.FromTerm;
using Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.Set;
using Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.ToTerm;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item
{
    /// <summary>
    /// Provides operations to manage the relations property of the microsoft.graph.termStore.set entity.
    /// </summary>
    public class RelationItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the fromTerm property of the microsoft.graph.termStore.relation entity.</summary>
        public Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.FromTerm.FromTermRequestBuilder FromTerm
        {
            get => new Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.FromTerm.FromTermRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the set property of the microsoft.graph.termStore.relation entity.</summary>
        public Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.Set.SetRequestBuilder Set
        {
            get => new Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.Set.SetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the toTerm property of the microsoft.graph.termStore.relation entity.</summary>
        public Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.ToTerm.ToTermRequestBuilder ToTerm
        {
            get => new Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.ToTerm.ToTermRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.RelationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/termStore/sets/{set%2Did}/parentGroup/sets/{set%2Did1}/relations/{relation%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.RelationItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RelationItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/termStore/sets/{set%2Did}/parentGroup/sets/{set%2Did1}/relations/{relation%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property relations for termStore
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Indicates which terms have been pinned or reused directly under the set.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.TermStore.Relation"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.TermStore.Relation?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.RelationItemRequestBuilder.RelationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.TermStore.Relation> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.RelationItemRequestBuilder.RelationItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.TermStore.Relation>(requestInfo, Microsoft.Graph.Beta.Models.TermStore.Relation.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property relations in termStore
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.TermStore.Relation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.TermStore.Relation?> PatchAsync(Microsoft.Graph.Beta.Models.TermStore.Relation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.TermStore.Relation> PatchAsync(Microsoft.Graph.Beta.Models.TermStore.Relation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.TermStore.Relation>(requestInfo, Microsoft.Graph.Beta.Models.TermStore.Relation.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property relations for termStore
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Indicates which terms have been pinned or reused directly under the set.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.RelationItemRequestBuilder.RelationItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.RelationItemRequestBuilder.RelationItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property relations in termStore
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.TermStore.Relation body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.TermStore.Relation body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.RelationItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.RelationItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.RelationItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RelationItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// Indicates which terms have been pinned or reused directly under the set.
        /// </summary>
        public class RelationItemRequestBuilderGetQueryParameters 
        {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RelationItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.TermStore.Sets.Item.ParentGroup.Sets.Item.Relations.Item.RelationItemRequestBuilder.RelationItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class RelationItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
