---
title: "informationProtectionLabel: extractLabel (deprecated)"
description: "Retrieve informationProtectionContentLabel using metadata from a labeled object. Deprecated."
ms.localizationpriority: medium
author: "tommoser"
ms.prod: "security"
doc_type: "apiPageType"
---

# informationProtectionLabel: extractLabel (deprecated)

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

> [!CAUTION]
> The Information Protection labels API is deprecated and will stop returning data on January 1, 2023. Please use the new [informationProtection](/graph/api/resources/security-informationprotection?view=graph-rest-beta&preserve-view=true), [sensitivityLabel](/graph/api/resources/security-sensitivitylabel?view=graph-rest-beta&preserve-view=true), and associated resources.
Using the metadata that exists on an already-labeled piece of information, resolve the metadata to a specific sensitivity label. The [contentInfo](../resources/contentinfo.md) input is resolved to [informationProtectionContentLabel](../resources/informationprotectioncontentlabel.md).

>[!NOTE]
>The **[informationProtectionContentLabel](../resources/informationprotectioncontentlabel.md)** resource represents a sensitivity label that has been applied to a piece of information. [informationProtectionLabel](../resources/informationprotectionlabel.md) objects are the abstract labels that are part of the organizational labeling policy and can be applied to information.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | InformationProtectionPolicy.Read            |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | InformationProtectionPolicy.Read.All        |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /informationprotection/policy/labels/extractLabel
```

## Request headers

| Name          | Description                                                                                                                                                                       |
| :------------ | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Authorization | Bearer {token}. Required.                                                                                                                                                         |
| Content-type  | Content-type: application/json. Required.                                                                                                                                         |
| User-Agent    | Describes the name and version of the calling application. Details will surface in Azure Information Protection Analytics. Suggested format is ApplicationName/Version. Optional. |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter   | Type                                       | Description                                                                                                                         |
| :---------- | :----------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------- |
| contentInfo | [contentInfo](../resources/contentinfo.md) | Provides details about the content format, content state, and existing [metadata](../resources/keyvaluepair.md) as key/value pairs. |

## Response

If successful, this method returns a `200 OK` response code and a new [informationProtectionContentLabel](../resources/informationprotectioncontentlabel.md) object in the response body.

## Examples

The following is an example of how to call this API.

### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "informationprotectionlabel_extractlabel"
}-->

```http
POST https://graph.microsoft.com/beta/informationProtection/policy/labels/extractLabel
Content-type: application/json
User-agent: ContosoLOBApp/1.0

{
    "contentInfo": {
        "@odata.type": "#microsoft.graph.contentInfo",
        "format@odata.type": "#microsoft.graph.contentFormat",
        "format": "default",
        "identifier": null,
        "state@odata.type": "#microsoft.graph.contentState",
        "state": "rest",
        "metadata@odata.type": "#Collection(microsoft.graph.keyValuePair)",
        "metadata": [
            {
                "@odata.type": "#microsoft.graph.keyValuePair",
                "name": "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Enabled",
                "value": "True"
            },
            {
                "@odata.type": "#microsoft.graph.keyValuePair",
                "name": "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Method",
                "value": "Standard"
            },
            {
                "@odata.type": "#microsoft.graph.keyValuePair",
                "name": "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_SetDate",
                "value": "1/1/0001 12:00:00 AM"
            },
            {
                "@odata.type": "#microsoft.graph.keyValuePair",
                "name": "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_SiteId",
                "value": "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
            },
            {
                "@odata.type": "#microsoft.graph.keyValuePair",
                "name": "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Name",
                "value": "Top Secret"
            },
            {
                "@odata.type": "#microsoft.graph.keyValuePair",
                "name": "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_ContentBits",
                "value": "0"
            },
            {
                "@odata.type": "#microsoft.graph.keyValuePair",
                "name": "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_ActionId",
                "value": "00000000-0000-0000-0000-000000000000"
            }
        ]
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var contentInfo = new ContentInfo
{
	Format = ContentFormat.Default,
	Identifier = null,
	State = ContentState.Rest,
	Metadata = new List<KeyValuePair>()
	{
		new KeyValuePair
		{
			Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Enabled",
			Value = "True"
		},
		new KeyValuePair
		{
			Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Method",
			Value = "Standard"
		},
		new KeyValuePair
		{
			Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_SetDate",
			Value = "1/1/0001 12:00:00 AM"
		},
		new KeyValuePair
		{
			Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_SiteId",
			Value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
		},
		new KeyValuePair
		{
			Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_Name",
			Value = "Top Secret"
		},
		new KeyValuePair
		{
			Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_ContentBits",
			Value = "0"
		},
		new KeyValuePair
		{
			Name = "MSIP_Label_722a5300-ac39-4c9a-88e3-f54c46676417_ActionId",
			Value = "00000000-0000-0000-0000-000000000000"
		}
	},
	AdditionalData = new Dictionary<string, object>()
	{
		{"format@odata.type", "#microsoft.graph.contentFormat"},
		{"state@odata.type", "#microsoft.graph.contentState"},
		{"metadata@odata.type", "#Collection(microsoft.graph.keyValuePair)"}
	}
};

await graphClient.InformationProtection.Policy.Labels
	.ExtractLabel(contentInfo)
	.Request()
	.Header("User-Agent","ContosoLOBApp/1.0")
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

> **Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.informationProtectionContentLabel"
} -->

```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#microsoft.graph.informationProtectionContentLabel",
    "creationDateTime": "1970-01-01T00:00:00Z",
    "assignmentMethod": "standard",
    "label": {
        "id": "722a5300-ac39-4c9a-88e3-f54c46676417",
        "name": "Top Secret",
        "description": "",
        "color": "#000000",
        "sensitivity": 13,
        "tooltip": "This information is top secret.",
        "isActive": true,
        "parent" : null
    }
}
```

<!-- uuid: 16cd6b66-4b1a-43a1-adaf-3a886856ed98
2019-02-04 14:57:30 UTC -->
<!-- {
  "type": "#page.annotation",
  "description": "informationProtectionLabel: extractLabel",
  "keywords": "",
  "section": "documentation",
  "tocPath": ""
}-->


