// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.IdentityGovernanceNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type TimeBasedAttributeTrigger.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<TimeBasedAttributeTrigger>))]
    public partial class TimeBasedAttributeTrigger : WorkflowExecutionTrigger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeBasedAttributeTrigger"/> class.
        /// </summary>
        public TimeBasedAttributeTrigger()
        {
            this.ODataType = "microsoft.graph.identityGovernance.timeBasedAttributeTrigger";
        }

        /// <summary>
        /// Gets or sets offsetInDays.
        /// How many days before or after the time-based attribute specified the workflow should trigger. For example, if the attribute is employeeHireDate and offsetInDays is -1, then the workflow should trigger one day before the employee hire date. The value can range between -60 and 60 days.
        /// </summary>
        [JsonPropertyName("offsetInDays")]
        public Int32? OffsetInDays { get; set; }
    
        /// <summary>
        /// Gets or sets timeBasedAttribute.
        /// Determines which time-based identity property to reference. The possible values are: employeeHireDate, employeeLeaveDateTime, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("timeBasedAttribute")]
        public WorkflowTriggerTimeBasedAttribute? TimeBasedAttribute { get; set; }
    
    }
}
