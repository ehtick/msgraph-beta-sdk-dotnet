---
title: "List partners"
description: "Get a list of all partner configurations within a cross-tenant access policy. You can also use the $expand parameter to list the user synchronization policy for all partner configurations."
author: "jkdouglas"
ms.localizationpriority: medium
ms.prod: "identity-and-sign-in"
doc_type: apiPageType
---

# List partners

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of all partner configurations within a cross-tenant access policy. You can also use the `$expand` parameter to list the user synchronization policy for all partner configurations.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|Policy.Read.All, Policy.ReadWrite.CrossTenantAccess|
|Delegated (personal Microsoft account)|Not applicable|
|Application|Policy.Read.All, Policy.ReadWrite.CrossTenantAccess|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

``` http
GET /policies/crossTenantAccessPolicy/partners
```

## Optional query parameters
This method supports the `$select` and `$expand` OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers

|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body

Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [crossTenantAccessPolicyConfigurationPartner](../resources/crosstenantaccesspolicyconfigurationpartner.md) objects in the response body.

## Examples

### Example 1: List all partner configurations within a cross-tenant access policy

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_crosstenantaccesspolicyconfigurationpartner"
}
-->

``` http
GET https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/partners
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var partners = await graphClient.Policies.CrossTenantAccessPolicy.Partners
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.crossTenantAccessPolicyConfigurationPartner)"
}
-->

``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": [
    {
      "tenantId": "123f4846-ba00-4fd7-ba43-dac1f8f63013",
      "inboundTrust": null,
      "automaticUserConsentSettings":
      {
        "inboundAllowed": null,
        "outboundAllowed": null
      },
      "b2bCollaborationInbound": null,
      "b2bCollaborationOutbound": null,
      "b2bDirectConnectOutbound": null,
      "b2bDirectConnectInbound":
      {
        "usersAndGroups": 
        {
          "accessType": "allowed",
          "targets": [
            {
              "target": "AllUsers",
              "targetType": "user"
            }
          ]
        },
        "applications":
        {
          "accessType": "allowed",
          "targets": [
            {
              "target": "Office365",
              "targetType": "application"
            }
          ]
        }
      }
    }
  ]
}
```

### Example 2: List the user synchronization policy for all partner configurations

#### Request


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_crosstenantidentitysyncpolicypartner"
}
-->
``` http
GET https://graph.microsoft.com/beta/policies/crossTenantAccessPolicy/partners?$select=tenantId&$expand=identitySynchronization
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var partners = await graphClient.Policies.CrossTenantAccessPolicy.Partners
	.Request()
	.Expand("identitySynchronization")
	.Select("tenantId")
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.crossTenantIdentitySyncPolicyPartner)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value":
  [
    {
      "tenantId": "9c5d131d-b1c3-4fc4-9e3f-c6557947d551",
      "identitySynchronization":
      {
        "tenantId": "9c5d131d-b1c3-4fc4-9e3f-c6557947d551",
        "displayName": "Fabrikam",
        "userSyncInbound":
        {
          "isSyncAllowed": true
        }
      }
    }
  ]
}
```
