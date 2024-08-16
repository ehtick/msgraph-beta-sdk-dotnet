// <auto-generated/>
using Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.AllowNextEnrollment;
using Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.AssignResourceAccountToDevice;
using Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.AssignUserToDevice;
using Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.DeploymentProfile;
using Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.IntendedDeploymentProfile;
using Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UnassignResourceAccountFromDevice;
using Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UnassignUserFromDevice;
using Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UpdateDeviceProperties;
using Microsoft.Graph.Beta.Models.ODataErrors;
using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item
{
    /// <summary>
    /// Provides operations to manage the windowsAutopilotDeviceIdentities property of the microsoft.graph.deviceManagement entity.
    /// </summary>
    public class WindowsAutopilotDeviceIdentityItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to call the allowNextEnrollment method.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.AllowNextEnrollment.AllowNextEnrollmentRequestBuilder AllowNextEnrollment
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.AllowNextEnrollment.AllowNextEnrollmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the assignResourceAccountToDevice method.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.AssignResourceAccountToDevice.AssignResourceAccountToDeviceRequestBuilder AssignResourceAccountToDevice
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.AssignResourceAccountToDevice.AssignResourceAccountToDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the assignUserToDevice method.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.AssignUserToDevice.AssignUserToDeviceRequestBuilder AssignUserToDevice
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.AssignUserToDevice.AssignUserToDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the deploymentProfile property of the microsoft.graph.windowsAutopilotDeviceIdentity entity.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.DeploymentProfile.DeploymentProfileRequestBuilder DeploymentProfile
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.DeploymentProfile.DeploymentProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the intendedDeploymentProfile property of the microsoft.graph.windowsAutopilotDeviceIdentity entity.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.IntendedDeploymentProfile.IntendedDeploymentProfileRequestBuilder IntendedDeploymentProfile
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.IntendedDeploymentProfile.IntendedDeploymentProfileRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unassignResourceAccountFromDevice method.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UnassignResourceAccountFromDevice.UnassignResourceAccountFromDeviceRequestBuilder UnassignResourceAccountFromDevice
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UnassignResourceAccountFromDevice.UnassignResourceAccountFromDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the unassignUserFromDevice method.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UnassignUserFromDevice.UnassignUserFromDeviceRequestBuilder UnassignUserFromDevice
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UnassignUserFromDevice.UnassignUserFromDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the updateDeviceProperties method.</summary>
        public Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UpdateDeviceProperties.UpdateDevicePropertiesRequestBuilder UpdateDeviceProperties
        {
            get => new Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.UpdateDeviceProperties.UpdateDevicePropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.WindowsAutopilotDeviceIdentityItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WindowsAutopilotDeviceIdentityItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/windowsAutopilotDeviceIdentities/{windowsAutopilotDeviceIdentity%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.WindowsAutopilotDeviceIdentityItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WindowsAutopilotDeviceIdentityItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/deviceManagement/windowsAutopilotDeviceIdentities/{windowsAutopilotDeviceIdentity%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// Delete navigation property windowsAutopilotDeviceIdentities for deviceManagement
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
        /// The Windows autopilot device identities contained collection.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.WindowsAutopilotDeviceIdentityItemRequestBuilder.WindowsAutopilotDeviceIdentityItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.WindowsAutopilotDeviceIdentityItemRequestBuilder.WindowsAutopilotDeviceIdentityItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity>(requestInfo, Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the navigation property windowsAutopilotDeviceIdentities in deviceManagement
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Beta.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity?> PatchAsync(Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity> PatchAsync(Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Beta.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity>(requestInfo, Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Delete navigation property windowsAutopilotDeviceIdentities for deviceManagement
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
        /// The Windows autopilot device identities contained collection.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.WindowsAutopilotDeviceIdentityItemRequestBuilder.WindowsAutopilotDeviceIdentityItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.WindowsAutopilotDeviceIdentityItemRequestBuilder.WindowsAutopilotDeviceIdentityItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property windowsAutopilotDeviceIdentities in deviceManagement
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Microsoft.Graph.Beta.Models.WindowsAutopilotDeviceIdentity body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.WindowsAutopilotDeviceIdentityItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.WindowsAutopilotDeviceIdentityItemRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.WindowsAutopilotDeviceIdentityItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WindowsAutopilotDeviceIdentityItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
        /// <summary>
        /// The Windows autopilot device identities contained collection.
        /// </summary>
        public class WindowsAutopilotDeviceIdentityItemRequestBuilderGetQueryParameters 
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
        public class WindowsAutopilotDeviceIdentityItemRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Beta.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.WindowsAutopilotDeviceIdentityItemRequestBuilder.WindowsAutopilotDeviceIdentityItemRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WindowsAutopilotDeviceIdentityItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
