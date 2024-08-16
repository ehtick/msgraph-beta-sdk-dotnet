// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Indicates whether tenant has a valid Intune Endpoint Privilege Management license. Possible value are : 0 - notPaid, 1 - paid, 2 - trial. See LicenseType enum for more details. Default notPaid .</summary>
    public enum LicenseType
    {
        /// <summary>Indicates the tenant has neither trial or paid license.</summary>
        [EnumMember(Value = "notPaid")]
        NotPaid,
        /// <summary>Indicates the tenant has paid Endpoint Privilege Management license.</summary>
        [EnumMember(Value = "paid")]
        Paid,
        /// <summary>Indicates the tenant has trial Endpoint Privilege Management license.</summary>
        [EnumMember(Value = "trial")]
        Trial,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
