// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum DeviceComplianceScriptRulOperator.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeviceComplianceScriptRulOperator
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// And
        /// </summary>
        And = 1,
	
        /// <summary>
        /// Or
        /// </summary>
        Or = 2,
	
        /// <summary>
        /// Is Equals
        /// </summary>
        IsEquals = 3,
	
        /// <summary>
        /// Not Equals
        /// </summary>
        NotEquals = 4,
	
        /// <summary>
        /// Greater Than
        /// </summary>
        GreaterThan = 5,
	
        /// <summary>
        /// Less Than
        /// </summary>
        LessThan = 6,
	
        /// <summary>
        /// Between
        /// </summary>
        Between = 7,
	
        /// <summary>
        /// Not Between
        /// </summary>
        NotBetween = 8,
	
        /// <summary>
        /// Greater Equals
        /// </summary>
        GreaterEquals = 9,
	
        /// <summary>
        /// Less Equals
        /// </summary>
        LessEquals = 10,
	
        /// <summary>
        /// Day Time Between
        /// </summary>
        DayTimeBetween = 11,
	
        /// <summary>
        /// Begins With
        /// </summary>
        BeginsWith = 12,
	
        /// <summary>
        /// Not Begins With
        /// </summary>
        NotBeginsWith = 13,
	
        /// <summary>
        /// Ends With
        /// </summary>
        EndsWith = 14,
	
        /// <summary>
        /// Not Ends With
        /// </summary>
        NotEndsWith = 15,
	
        /// <summary>
        /// Contains
        /// </summary>
        Contains = 16,
	
        /// <summary>
        /// Not Contains
        /// </summary>
        NotContains = 17,
	
        /// <summary>
        /// All Of
        /// </summary>
        AllOf = 18,
	
        /// <summary>
        /// One Of
        /// </summary>
        OneOf = 19,
	
        /// <summary>
        /// None Of
        /// </summary>
        NoneOf = 20,
	
        /// <summary>
        /// Set Equals
        /// </summary>
        SetEquals = 21,
	
        /// <summary>
        /// Ordered Set Equals
        /// </summary>
        OrderedSetEquals = 22,
	
        /// <summary>
        /// Subset Of
        /// </summary>
        SubsetOf = 23,
	
        /// <summary>
        /// Excludes All
        /// </summary>
        ExcludesAll = 24,
	
    }
}
