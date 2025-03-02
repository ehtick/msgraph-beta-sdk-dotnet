// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWindowsAutopilotDeviceIdentityRequestBuilder.
    /// </summary>
    public partial interface IWindowsAutopilotDeviceIdentityRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IWindowsAutopilotDeviceIdentityRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IWindowsAutopilotDeviceIdentityRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for DeploymentProfile.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeploymentProfileWithReferenceRequestBuilder"/>.</returns>
        IWindowsAutopilotDeploymentProfileWithReferenceRequestBuilder DeploymentProfile { get; }

        /// <summary>
        /// Gets the request builder for IntendedDeploymentProfile.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeploymentProfileWithReferenceRequestBuilder"/>.</returns>
        IWindowsAutopilotDeploymentProfileWithReferenceRequestBuilder IntendedDeploymentProfile { get; }
    
        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeviceIdentityAssignResourceAccountToDevice.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeviceIdentityAssignResourceAccountToDeviceRequestBuilder"/>.</returns>
        IWindowsAutopilotDeviceIdentityAssignResourceAccountToDeviceRequestBuilder AssignResourceAccountToDevice(
            string userPrincipalName = null,
            string addressableUserName = null,
            string resourceAccountName = null);

        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeviceIdentityAssignUserToDevice.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeviceIdentityAssignUserToDeviceRequestBuilder"/>.</returns>
        IWindowsAutopilotDeviceIdentityAssignUserToDeviceRequestBuilder AssignUserToDevice(
            string userPrincipalName = null,
            string addressableUserName = null);

        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeviceIdentityUnassignResourceAccountFromDevice.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeviceIdentityUnassignResourceAccountFromDeviceRequestBuilder"/>.</returns>
        IWindowsAutopilotDeviceIdentityUnassignResourceAccountFromDeviceRequestBuilder UnassignResourceAccountFromDevice();

        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeviceIdentityUnassignUserFromDevice.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeviceIdentityUnassignUserFromDeviceRequestBuilder"/>.</returns>
        IWindowsAutopilotDeviceIdentityUnassignUserFromDeviceRequestBuilder UnassignUserFromDevice();

        /// <summary>
        /// Gets the request builder for WindowsAutopilotDeviceIdentityUpdateDeviceProperties.
        /// </summary>
        /// <returns>The <see cref="IWindowsAutopilotDeviceIdentityUpdateDevicePropertiesRequestBuilder"/>.</returns>
        IWindowsAutopilotDeviceIdentityUpdateDevicePropertiesRequestBuilder UpdateDeviceProperties(
            string userPrincipalName = null,
            string addressableUserName = null,
            string groupTag = null,
            string displayName = null,
            string deviceAccountUpn = null,
            string deviceAccountPassword = null,
            string deviceFriendlyName = null);
    
    }
}
