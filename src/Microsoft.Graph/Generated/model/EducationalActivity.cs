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
    /// The type Educational Activity.
    /// </summary>
    public partial class EducationalActivity : ItemFacet
    {
    
        ///<summary>
        /// The EducationalActivity constructor
        ///</summary>
        public EducationalActivity()
        {
            this.ODataType = "microsoft.graph.educationalActivity";
        }

        /// <summary>
        /// Gets or sets completion month year.
        /// The month and year the user graduated or completed the activity.
        /// </summary>
        [JsonPropertyName("completionMonthYear")]
        public Date CompletionMonthYear { get; set; }
    
        /// <summary>
        /// Gets or sets end month year.
        /// The month and year the user completed the educational activity referenced.
        /// </summary>
        [JsonPropertyName("endMonthYear")]
        public Date EndMonthYear { get; set; }
    
        /// <summary>
        /// Gets or sets institution.
        /// Contains details of the institution studied at.
        /// </summary>
        [JsonPropertyName("institution")]
        public InstitutionData Institution { get; set; }
    
        /// <summary>
        /// Gets or sets program.
        /// Contains extended information about the program or course.
        /// </summary>
        [JsonPropertyName("program")]
        public EducationalActivityDetail Program { get; set; }
    
        /// <summary>
        /// Gets or sets start month year.
        /// The month and year the user commenced the activity referenced.
        /// </summary>
        [JsonPropertyName("startMonthYear")]
        public Date StartMonthYear { get; set; }
    
    }
}

