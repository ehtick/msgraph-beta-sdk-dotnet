---
title: "List siteSources"
description: "Get the siteSource resources from the siteSources navigation property."
author: "SeunginLyu"
ms.localizationpriority: medium
ms.prod: "ediscovery"
doc_type: apiPageType
---

# List siteSources
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Get a list of the [siteSource](../resources/security-sitesource.md) objects associated with an [ediscoveryCustodian](../resources/security-ediscoverycustodian.md).

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|eDiscovery.Read.All, eDiscovery.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|Not supported.|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
GET /security/cases/ediscoveryCases/{ediscoveryCaseId}/custodians/{custodianId}/siteSources
```

## Optional query parameters
This method supports some of the OData query parameters to help customize the response. For general information, see [OData query parameters](/graph/query-parameters).

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|

## Request body
Do not supply a request body for this method.

## Response

If successful, this method returns a `200 OK` response code and a collection of [microsoft.graph.security.siteSource](../resources/security-sitesource.md) objects in the response body.

## Examples

### Request
The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "list_sitesource_for_custodian"
}
-->
``` http
GET https://graph.microsoft.com/beta/security/cases/ediscoveryCases/b0073e4e-4184-41c6-9eb7-8c8cc3e2288b/custodians/0053a61a3b6c42738f7606791716a22a/siteSources
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var siteSources = await graphClient.Security.Cases.EdiscoveryCases["{security.ediscoveryCase-id}"].Custodians["{security.ediscoveryCustodian-id}"].SiteSources
	.Request()
	.GetAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "Collection(microsoft.graph.security.siteSource)"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#security/cases/ediscoveryCases('b0073e4e-4184-41c6-9eb7-8c8cc3e2288b')/custodians('0053a61a3b6c42738f7606791716a22a')/siteSources",
    "value": [
        {
            "@odata.id": "https://graph.microsoft.com/v1.0/sites/169718e3-a8df-449d-bef4-ee09fe1ddc5d",
            "displayName": "U.S. Sales",
            "createdDateTime": "2022-05-23T02:35:42.926309Z",
            "holdStatus": "applied",
            "id": "169718e3-a8df-449d-bef4-ee09fe1ddc5d",
            "createdBy": {
                "application": null,
                "user": {
                    "id": "c25c3914-f9f7-43ee-9cba-a25377e0cec6",
                    "displayName": null
                }
            },
            "site": {
                "webUrl": "https://m365x809305.sharepoint.com/sites/USSales",
                "id": "169718e3-a8df-449d-bef4-ee09fe1ddc5d",
                "createdDateTime": "2022-05-23T02:35:42.926309Z"
            }
        }
    ]
}
```
