---
title: "List authenticationStrengthPolicies"
description: "Get a list of the authenticationStrengthPolicy objects and their properties."
author: "mmcla"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# List authenticationStrengthPolicies
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [authenticationStrengthPolicy](../resources/authenticationstrengthpolicy.md) objects and their properties. This API returns both built-in and custom policies.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.Read.All, Policy.ReadWrite.ConditionalAccess, Policy.ReadWrite.AuthenticationMethod|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Policy.Read.All, Policy.ReadWrite.ConditionalAccess, Policy.ReadWrite.AuthenticationMethod|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /policies/authenticationStrengthPolicies
```

## Optional query parameters
This method supports the `filter` OData query parameter on the `policyType` and `policyName` properties to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [authenticationStrengthPolicy](../resources/authenticationstrengthpolicy.md) objects in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_authenticationstrengthpolicy"
}
-->
``` http
GET https://graph.microsoft.com/beta/policies/authenticationStrengthPolicies
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var authenticationStrengthPolicies = await graphClient.Policies.AuthenticationStrengthPolicies
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.authenticationStrengthPolicy)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": [
    {
      "@odata.type" : "authenticationStrengthPolicy",
      "id": "7d718ef4-5493-4313-a52c-7401b7df3a9c",
      "createdDateTime": "2022-09-30T10:59:01Z",
      "modifiedDateTime": "2022-09-30T10:59:01Z",
      "displayName": "Contoso authentication level",
      "description": "The only authentication level allowed to access our secret apps",
      "policyType": "custom",
      "requirementsSatisfied": "mfa",
      "allowedCombinations": [
        "x509CertificateSingleFactor, fido2",
        "fido2"
      ],
      "combinationConfigurations": [
        {
          "@odata.type" : "fido2CombinationConfiguration",
          "id": "675ff4e1-7c6d-4a7f-9803-ad084d1b45b3",
          "allowedAAGUIDs": [
            "2ac80ddb-17bd-4575-b41c-0dc37ae3290d"
          ],
          "appliesToCombinations": ["fido2"]
        }
      ]
    },
    {
      "@odata.type" : "authenticationStrengthPolicy",
      "id": "00000000-0000-0000-0000-000000000002",
      "createdDateTime": "2022-09-30T10:59:01Z",
      "modifiedDateTime": "2022-09-30T10:59:01Z",
      "displayName": "Multi-factor authentication",
      "description": "Combinations of methods that satisfy strong authentication, such as a password + SMS",
      "policyType": "builtIn",
      "requirementsSatisfied": "mfa",
      "allowedCombinations": [
        "windowsHelloForBusiness",
        "fido2",
        "x509CertificateMultiFactor",
        "deviceBasedPush",
        "temporaryAccessPassOneTime",
        "temporaryAccessPassMultiUse",
        "password, microsoftAuthenticatorPush",
        "password, softwareOath",
        "password, hardwareOath",
        "password, sms",
        "password, voice",
        "federatedMultiFactor",
        "federatedSingleFactor, microsoftAuthenticatorPush",
        "federatedSingleFactor, softwareOath",
        "federatedSingleFactor, hardwareOath",
        "federatedSingleFactor, sms",
        "federatedSingleFactor, voice"
      ],
      "combinationConfigurations": []
    },
    {
      "@odata.type" : "authenticationStrengthPolicy",
      "id": "00000000-0000-0000-0000-000000000003",
      "createdDateTime": "2022-09-30T10:59:01Z",
      "modifiedDateTime": "2022-09-30T10:59:01Z",
      "displayName": "Passwordless MFA",
      "description": "Passwordless methods that satisfy strong authentication, such as Passwordless sign-in with the Microsoft Authenticator",
      "policyType": "builtIn",
      "requirementsSatisfied": "mfa",
      "allowedCombinations": [
        "windowsHelloForBusiness",
        "fido2",
        "x509CertificateMultiFactor",
        "deviceBasedPush"
      ],
      "combinationConfigurations": []
    },
    {
      "@odata.type" : "authenticationStrengthPolicy",
      "id": "00000000-0000-0000-0000-000000000004",
      "createdDateTime": "2022-09-30T10:59:01Z",
      "modifiedDateTime": "2022-09-30T10:59:01Z",
      "displayName": "Phishing resistant MFA",
      "description": "Phishing-resistant, Passwordless methods for the strongest authentication, such as a FIDO2 security key",
      "policyType": "builtIn",
      "requirementsSatisfied": "mfa",
      "allowedCombinations": [
        "windowsHelloForBusiness",
        "fido2",
        "x509CertificateMultiFactor"
      ],
      "combinationConfigurations": []
    }
  ]
}
```

