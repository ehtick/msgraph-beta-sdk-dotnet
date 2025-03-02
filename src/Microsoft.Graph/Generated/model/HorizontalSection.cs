// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Horizontal Section.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<HorizontalSection>))]
    public partial class HorizontalSection : Entity
    {
    
        /// <summary>
        /// Gets or sets emphasis.
        /// Enumeration value that indicates the emphasis of the section background. The possible values are: none, netural, soft, strong, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("emphasis")]
        public SectionEmphasisType? Emphasis { get; set; }
    
        /// <summary>
        /// Gets or sets layout.
        /// Layout type of the section. The possible values are: none, oneColumn, twoColumns, threeColumns, oneThirdLeftColumn, oneThirdRightColumn, fullWidth, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("layout")]
        public HorizontalSectionLayoutType? Layout { get; set; }
    
        /// <summary>
        /// Gets or sets columns.
        /// The set of vertical columns in this section.
        /// </summary>
        [JsonPropertyName("columns")]
        public IHorizontalSectionColumnsCollectionPage Columns { get; set; }

        /// <summary>
        /// Gets or sets columnsNextLink.
        /// </summary>
        [JsonPropertyName("columns@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ColumnsNextLink { get; set; }
    
    }
}

