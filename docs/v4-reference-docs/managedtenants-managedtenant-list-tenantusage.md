---
title: "List tenantUsage"
description: "Get a list of the tenantUsage objects and their properties."
author: "kylewirpel"
ms.localizationpriority: medium
ms.prod: "multi-tenant-management"
doc_type: apiPageType
---

# List tenantUsage
Namespace: microsoft.graph.managedTenants

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Gets the [monthly usage data for each service](../resources/managedtenants-tenantusage.md) in a [managed tenant](../resources/managedtenants-managedtenant.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|ManagedTenants.Read.All, ManagedTenants.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /tenantRelationships/managedTenants/tenantUsage
```

## Optional query parameters
This method supports the `$filter` and `$top` [OData query parameters](/graph/query-parameters) to help customize the response.

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [tenantUsage](../resources/managedtenants-tenantusage.md) objects in the response body.

## Examples

### Request

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_tenantusage"
}
-->
``` http
GET https://graph.microsoft.com/beta/tenantRelationships/managedTenants/tenantUsage
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var tenantUsage = await graphClient.TenantRelationships.ManagedTenants.TenantUsage
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.managedTenants.tenantUsage)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "value": [
        {
            "tenantId": "fab47685-ce50-424c-5215-ae28419c9db6",
            "reportingDate": "2021-09-01T00:00:00Z",
            "monthlyActiveUsers": 100,
            "serviceUsages": [
                { "serviceName": "Excel", "monthlyActiveUsers": 100 },
                { "serviceName": "Exchange", "monthlyActiveUsers": 100 },
                { "serviceName": "Intune", "monthlyActiveUsers": 100 },
                { "serviceName": "Teams", "monthlyActiveUsers": 100 },
                { "serviceName": "Word", "monthlyActiveUsers": 100 }
            ]
        }
  ]
}
```
