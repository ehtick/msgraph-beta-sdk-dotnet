// <auto-generated/>
using Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphApplication;
using Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphDevice;
using Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphGroup;
using Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphOrgContact;
using Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphServicePrincipal;
using Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphUser;
using Microsoft.Graph.Beta.Groups.Item.Members.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Beta.Groups.Item.Members.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \groups\{group-id}\members\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Casts the previous resource to application.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphApplication.GraphApplicationRequestBuilder GraphApplication
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphApplication.GraphApplicationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to device.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphDevice.GraphDeviceRequestBuilder GraphDevice
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphDevice.GraphDeviceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to group.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphGroup.GraphGroupRequestBuilder GraphGroup
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphGroup.GraphGroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to orgContact.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphOrgContact.GraphOrgContactRequestBuilder GraphOrgContact
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphOrgContact.GraphOrgContactRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to servicePrincipal.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphServicePrincipal.GraphServicePrincipalRequestBuilder GraphServicePrincipal
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphServicePrincipal.GraphServicePrincipalRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to user.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphUser.GraphUserRequestBuilder GraphUser
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Members.Item.GraphUser.GraphUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the collection of group entities.</summary>
        public Microsoft.Graph.Beta.Groups.Item.Members.Item.Ref.RefRequestBuilder Ref
        {
            get => new Microsoft.Graph.Beta.Groups.Item.Members.Item.Ref.RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Groups.Item.Members.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/members/{directoryObject%2Did}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Beta.Groups.Item.Members.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/groups/{group%2Did}/members/{directoryObject%2Did}", rawUrl)
        {
        }
    }
}
