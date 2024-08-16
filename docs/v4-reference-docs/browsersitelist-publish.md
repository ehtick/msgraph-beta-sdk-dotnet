---
title: "browserSiteList: publish"
description: "Publish the specified browserSiteList for devices to download."
author: "edward-day-vii"
ms.localizationpriority: medium
ms.prod: "browser-management"
doc_type: apiPageType
---

# browserSiteList: publish
Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Publish the specified [browserSiteList](../resources/browsersitelist.md) for devices to download.

## Permissions
One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type|Permissions (from least to most privileged)|
|:---|:---|
|Delegated (work or school account)|BrowserSiteLists.ReadWrite.All|
|Delegated (personal Microsoft account)|Not supported.|
|Application|BrowserSiteLists.ReadWrite.All|

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->
``` http
POST /admin/edge/internetExplorerMode/siteLists/{browserSiteListId}/publish
```

## Request headers
|Name|Description|
|:---|:---|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|


## Request body

In the request body, omit both sites and share cookies to publish the entire site list. Optionally, you can publish specific sites and shared cookies by specifying a collection of IDs.


|Property|Type|Description|
|:---|:---|:---|
|revision|String|The revision of the site list to publish. Required.|
|sharedCookies|[browserSharedCookie](../resources/browsersharedcookie.md) collection|The collection of shared cookies to publish. Optional. Only requires the shared cookie ID. All other fields are ignored.|
|sites|[browserSite](../resources/browsersite.md) collection|The collection of sites to publish. Optional. Only requires the site ID. All other fields are ignored.|


## Response

If successful, this action returns a `200 OK` response code and a [browserSiteList](../resources/browsersitelist.md) in the response body.

## Examples

### Example 1: Publish all sites and shared cookies

#### Request

The following is an example of a request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "browsersitelist_publish",
  "sampleKeys": ["36ba61eb-c492-4283-a38b-963a1dbb2f69"]
}
-->
``` http
POST https://graph.microsoft.com/beta/admin/edge/internetExplorerMode/siteLists/36ba61eb-c492-4283-a38b-963a1dbb2f69/publish
Content-Type: application/json

{
    "revision": "1.0"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var revision = "1.0";

var sites = new List<BrowserSite>()
{
	new BrowserSite
	{
		Id = "53e5f971-fc7b-4cd3-a1bf-34d7c0416882"
	},
	new BrowserSite
	{
		Id = "2e27cc86-3662-447e-b751-274fb9f869ea"
	}
};

var sharedCookies = new List<BrowserSharedCookie>()
{
	new BrowserSharedCookie
	{
		Id = "7f639835-23ab-4793-b1e6-1a06fad127a2"
	}
};

await graphClient.Admin.Edge.InternetExplorerMode.SiteLists["{browserSiteList-id}"]
	.Publish(revision,sites,sharedCookies)
	.Request()
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response
The following is an example of the response.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.browserSiteList"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.browserSiteList",
    "id": "36ba61eb-c492-4283-a38b-963a1dbb2f69",
    "revision": "1.0",
    "displayName": "Product Site List A",
    "description": "A production site list for team A",
    "lastModifiedDateTime": "2022-06-28T19:29:52.8752365Z",
    "publishedDateTime": "2022-06-28T19:29:52.8752365Z",
    "status": "published",
    "lastModifiedBy": {
        "user": {
            "id": "f6ff107e-bc40-4918-a432-8d7b60030a7c",
            "displayName": "Joe Smith"
        },
        "application": null
    },
    "publishedBy": {
        "user": {
            "id": "f6ff107e-bc40-4918-a432-8d7b60030a7c",
            "displayName": "Joe Smith"
        },
        "application": null
    }
}
```

### Example 2: Publish specific sites and shared cookies

#### Request

The following is an example of a request.
<!-- {
  "blockType": "request",
  "name": "browsersitelist_publish",
  "sampleKeys": ["36ba61eb-c492-4283-a38b-963a1dbb2f69"]
}
-->
``` http
POST https://graph.microsoft.com/beta/admin/edge/internetExplorerMode/siteLists/36ba61eb-c492-4283-a38b-963a1dbb2f69/publish
Content-Type: application/json

{
    "revision": "1.0",
    "sites": [
        {
            "id": "53e5f971-fc7b-4cd3-a1bf-34d7c0416882"
        },
        {
            "id": "2e27cc86-3662-447e-b751-274fb9f869ea"
        }
    ],
    "sharedCookies": [
        {
            "id": "7f639835-23ab-4793-b1e6-1a06fad127a2"
        }
    ]
}
```


#### Response
The following is an example of the response. The **status** will show `pending` if the request contains sites or shared cookies that you have not published yet.
>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.browserSiteList"
}
-->
``` http
HTTP/1.1 200 OK
Content-Type: application/json

{
    "@odata.type": "#microsoft.graph.browserSiteList",
    "id": "36ba61eb-c492-4283-a38b-963a1dbb2f69",
    "revision": "1.0",
    "displayName": "Product Site List A",
    "description": "A production site list for team A",
    "lastModifiedDateTime": "2022-06-28T19:29:52.8752365Z",
    "publishedDateTime": "2022-06-28T19:29:52.8752365Z",
    "status": "pending",
    "lastModifiedBy": {
        "user": {
            "id": "f6ff107e-bc40-4918-a432-8d7b60030a7c",
            "displayName": "Joe Smith"
        },
        "application": null
    },
    "publishedBy": {
        "user": {
            "id": "f6ff107e-bc40-4918-a432-8d7b60030a7c",
            "displayName": "Joe Smith"
        },
        "application": null
    }
}
```
