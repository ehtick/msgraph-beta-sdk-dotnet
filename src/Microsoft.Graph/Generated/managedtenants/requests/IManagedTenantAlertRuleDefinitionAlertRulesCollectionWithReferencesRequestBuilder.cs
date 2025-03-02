// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IManagedTenantAlertRuleDefinitionAlertRulesCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IManagedTenantAlertRuleDefinitionAlertRulesCollectionWithReferencesRequestBuilder : Microsoft.Graph.IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IManagedTenantAlertRuleDefinitionAlertRulesCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IManagedTenantAlertRuleDefinitionAlertRulesCollectionWithReferencesRequest Request(IEnumerable<Microsoft.Graph.Option> options);

        /// <summary>
        /// Gets an <see cref="IManagedTenantAlertRuleWithReferenceRequestBuilder"/> for the specified ManagedTenantAlertRule.
        /// </summary>
        /// <param name="id">The ID for the ManagedTenantAlertRule.</param>
        /// <returns>The <see cref="IManagedTenantAlertRuleWithReferenceRequestBuilder"/>.</returns>
        IManagedTenantAlertRuleWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IManagedTenantAlertRuleDefinitionAlertRulesCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IManagedTenantAlertRuleDefinitionAlertRulesCollectionReferencesRequestBuilder"/>.</returns>
        IManagedTenantAlertRuleDefinitionAlertRulesCollectionReferencesRequestBuilder References { get; }

    }
}
