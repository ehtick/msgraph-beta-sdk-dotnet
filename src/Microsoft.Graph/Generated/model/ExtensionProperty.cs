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
    /// The type Extension Property.
    /// </summary>
    public partial class ExtensionProperty : DirectoryObject
    {
    
        ///<summary>
        /// The ExtensionProperty constructor
        ///</summary>
        public ExtensionProperty()
        {
            this.ODataType = "microsoft.graph.extensionProperty";
        }

        /// <summary>
        /// Gets or sets app display name.
        /// Display name of the application object on which this extension property is defined. Read-only.
        /// </summary>
        [JsonPropertyName("appDisplayName")]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets data type.
        /// Specifies the data type of the value the extension property can hold. Following values are supported. Not nullable. Binary - 256 bytes maximumBooleanDateTime - Must be specified in ISO 8601 format. Will be stored in UTC.Integer - 32-bit value.LargeInteger - 64-bit value.String - 256 characters maximum
        /// </summary>
        [JsonPropertyName("dataType")]
        public string DataType { get; set; }
    
        /// <summary>
        /// Gets or sets is synced from on premises.
        /// Indicates if this extension property was synced from on-premises active directory using Azure AD Connect. Read-only.
        /// </summary>
        [JsonPropertyName("isSyncedFromOnPremises")]
        public bool? IsSyncedFromOnPremises { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Name of the extension property. Not nullable.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets target objects.
        /// Following values are supported. Not nullable. UserGroupAdministrativeUnitApplicationDeviceOrganization
        /// </summary>
        [JsonPropertyName("targetObjects")]
        public IEnumerable<string> TargetObjects { get; set; }
    
    }
}

