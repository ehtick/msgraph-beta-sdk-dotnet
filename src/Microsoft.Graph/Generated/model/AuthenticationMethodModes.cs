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
    /// The enum AuthenticationMethodModes.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
	[System.Flags]
    public enum AuthenticationMethodModes
    {
    
        /// <summary>
        /// Password
        /// </summary>
        Password = 1,
	
        /// <summary>
        /// Voice
        /// </summary>
        Voice = 2,
	
        /// <summary>
        /// Hardware Oath
        /// </summary>
        HardwareOath = 4,
	
        /// <summary>
        /// Software Oath
        /// </summary>
        SoftwareOath = 8,
	
        /// <summary>
        /// Sms
        /// </summary>
        Sms = 16,
	
        /// <summary>
        /// Fido2
        /// </summary>
        Fido2 = 32,
	
        /// <summary>
        /// Windows Hello For Business
        /// </summary>
        WindowsHelloForBusiness = 64,
	
        /// <summary>
        /// Microsoft Authenticator Push
        /// </summary>
        MicrosoftAuthenticatorPush = 128,
	
        /// <summary>
        /// Device Based Push
        /// </summary>
        DeviceBasedPush = 256,
	
        /// <summary>
        /// Temporary Access Pass One Time
        /// </summary>
        TemporaryAccessPassOneTime = 512,
	
        /// <summary>
        /// Temporary Access Pass Multi Use
        /// </summary>
        TemporaryAccessPassMultiUse = 1024,
	
        /// <summary>
        /// Email
        /// </summary>
        Email = 2048,
	
        /// <summary>
        /// X509Certificate Single Factor
        /// </summary>
        X509CertificateSingleFactor = 4096,
	
        /// <summary>
        /// X509Certificate Multi Factor
        /// </summary>
        X509CertificateMultiFactor = 8192,
	
        /// <summary>
        /// Federated Single Factor
        /// </summary>
        FederatedSingleFactor = 16384,
	
        /// <summary>
        /// Federated Multi Factor
        /// </summary>
        FederatedMultiFactor = 32768,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 65536,
	
    }
}
