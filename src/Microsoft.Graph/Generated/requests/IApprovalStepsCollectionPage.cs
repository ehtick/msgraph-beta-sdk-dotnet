// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The interface IApprovalStepsCollectionPage.
    /// </summary>
    [InterfaceConverter(typeof(InterfaceConverter<ApprovalStepsCollectionPage>))]
    public interface IApprovalStepsCollectionPage : ICollectionPage<ApprovalStep>
    {
        /// <summary>
        /// Gets the next page <see cref="IApprovalStepsCollectionRequest"/> instance.
        /// </summary>
        IApprovalStepsCollectionRequest NextPageRequest { get; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString);
    }
}
