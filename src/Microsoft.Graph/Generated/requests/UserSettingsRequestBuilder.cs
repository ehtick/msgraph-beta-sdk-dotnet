// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type UserSettingsRequestBuilder.
    /// </summary>
    public partial class UserSettingsRequestBuilder : EntityRequestBuilder, IUserSettingsRequestBuilder
    {

        /// <summary>
        /// Constructs a new UserSettingsRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserSettingsRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IUserSettingsRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IUserSettingsRequest Request(IEnumerable<Option> options)
        {
            return new UserSettingsRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for ItemInsights.
        /// </summary>
        /// <returns>The <see cref="IUserInsightsSettingsRequestBuilder"/>.</returns>
        public IUserInsightsSettingsRequestBuilder ItemInsights
        {
            get
            {
                return new UserInsightsSettingsRequestBuilder(this.AppendSegmentToRequestUrl("itemInsights"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ContactMergeSuggestions.
        /// </summary>
        /// <returns>The <see cref="IContactMergeSuggestionsRequestBuilder"/>.</returns>
        public IContactMergeSuggestionsRequestBuilder ContactMergeSuggestions
        {
            get
            {
                return new ContactMergeSuggestionsRequestBuilder(this.AppendSegmentToRequestUrl("contactMergeSuggestions"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for RegionalAndLanguageSettings.
        /// </summary>
        /// <returns>The <see cref="IRegionalAndLanguageSettingsRequestBuilder"/>.</returns>
        public IRegionalAndLanguageSettingsRequestBuilder RegionalAndLanguageSettings
        {
            get
            {
                return new RegionalAndLanguageSettingsRequestBuilder(this.AppendSegmentToRequestUrl("regionalAndLanguageSettings"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ShiftPreferences.
        /// </summary>
        /// <returns>The <see cref="IShiftPreferencesRequestBuilder"/>.</returns>
        public IShiftPreferencesRequestBuilder ShiftPreferences
        {
            get
            {
                return new ShiftPreferencesRequestBuilder(this.AppendSegmentToRequestUrl("shiftPreferences"), this.Client);
            }
        }
    
    }
}
