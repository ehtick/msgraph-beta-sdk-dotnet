// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ILifecycleWorkflowsContainerRequestBuilder.
    /// </summary>
    public partial interface ILifecycleWorkflowsContainerRequestBuilder : Microsoft.Graph.IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ILifecycleWorkflowsContainerRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ILifecycleWorkflowsContainerRequest Request(IEnumerable<Microsoft.Graph.Option> options);
    
        /// <summary>
        /// Gets the request builder for CustomTaskExtensions.
        /// </summary>
        /// <returns>The <see cref="ILifecycleWorkflowsContainerCustomTaskExtensionsCollectionRequestBuilder"/>.</returns>
        ILifecycleWorkflowsContainerCustomTaskExtensionsCollectionRequestBuilder CustomTaskExtensions { get; }

        /// <summary>
        /// Gets the request builder for DeletedItems.
        /// </summary>
        /// <returns>The <see cref="Microsoft.Graph.IDeletedItemContainerRequestBuilder"/>.</returns>
        Microsoft.Graph.IDeletedItemContainerRequestBuilder DeletedItems { get; }

        /// <summary>
        /// Gets the request builder for Settings.
        /// </summary>
        /// <returns>The <see cref="ILifecycleManagementSettingsRequestBuilder"/>.</returns>
        ILifecycleManagementSettingsRequestBuilder Settings { get; }

        /// <summary>
        /// Gets the request builder for TaskDefinitions.
        /// </summary>
        /// <returns>The <see cref="ILifecycleWorkflowsContainerTaskDefinitionsCollectionRequestBuilder"/>.</returns>
        ILifecycleWorkflowsContainerTaskDefinitionsCollectionRequestBuilder TaskDefinitions { get; }

        /// <summary>
        /// Gets the request builder for Workflows.
        /// </summary>
        /// <returns>The <see cref="ILifecycleWorkflowsContainerWorkflowsCollectionRequestBuilder"/>.</returns>
        ILifecycleWorkflowsContainerWorkflowsCollectionRequestBuilder Workflows { get; }

        /// <summary>
        /// Gets the request builder for WorkflowTemplates.
        /// </summary>
        /// <returns>The <see cref="ILifecycleWorkflowsContainerWorkflowTemplatesCollectionRequestBuilder"/>.</returns>
        ILifecycleWorkflowsContainerWorkflowTemplatesCollectionRequestBuilder WorkflowTemplates { get; }
    
    }
}
