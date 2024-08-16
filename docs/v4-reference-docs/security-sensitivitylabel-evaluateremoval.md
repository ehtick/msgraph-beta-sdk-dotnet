---
title: "sensitivityLabel: evaluateRemoval"
description: "Evaluate which label to remove and how to remove it based on an existing content information."
author: "tommoser"
ms.localizationpriority: medium
ms.prod: "security"
doc_type: apiPageType
---

# sensitivityLabel: evaluateRemoval
Namespace: microsoft.graph.security

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Indicate to the consuming application what actions it should take to remove the label information.

Given [contentInfo](../resources/contentinfo.md) as an input, which includes existing content metadata [key-value pairs](../resources/security-keyvaluepair.md), the API returns an [informationProtectionAction](../resources/security-informationprotectionaction.md) that contains some combination of one or more of the following: 

* [justifyAction](../resources/security-justifyaction.md)
* [metadataAction](../resources/security-metadataaction.md)
* [removeContentFooterAction](../resources/security-removecontentfooteraction.md)
* [removeContentHeaderAction](../resources/security-removecontentheaderaction.md)
* [removeProtectionAction](../resources/security-removeprotectionaction.md)
* [removeWatermarkAction](../resources/security-removewatermarkaction.md)

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type                        | Permissions (from least to most privileged) |
| :------------------------------------- | :------------------------------------------ |
| Delegated (work or school account)     | InformationProtectionPolicy.Read            |
| Delegated (personal Microsoft account) | Not supported.                              |
| Application                            | InformationProtectionPolicy.Read.All        |

## HTTP request

<!-- {
  "blockType": "ignored"
}
-->

To evaluate removal as the signed-in user (delegated permission) or a specified user (application permission):

``` http
POST /users/{usersId}/security/informationProtection/sensitivityLabels/evaluateRemoval
POST /users/me/security/informationProtection/sensitivityLabels/evaluateRemoval
```

To evaluate removal as a service principal (application permission):

``` http
POST /users/security/informationProtection/sensitivityLabels/evaluateRemoval
```

## Request headers

| Name          | Description                                                                                                                                                                       |
| :------------ | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Authorization | Bearer {token}. Required.                                                                                                                                                         |
| Content-type  | application/json. Required.                                                                                                                                                       |
| User-Agent    | Describes the name and version of the calling application. Details will surface in Azure Information Protection Analytics. Suggested format is `ApplicationName/Version`. Optional. |

## Request body

In the request body, supply a JSON representation of the parameters.

The following table shows the parameters that can be used with this action.

| Parameter              | Type                                                                      | Description                                                                                                                         |
| :--------------------- | :------------------------------------------------------------------------ | :---------------------------------------------------------------------------------------------------------------------------------- |
| contentInfo            | [contentInfo](../resources/security-contentinfo.md)                       | Provides details about the content format, content state, and existing [metadata](../resources/security-keyvaluepair.md) as key-value pairs. |
| downgradeJustification | [downgradeJustification](../resources/security-downgradejustification.md) | Justification that must be provided by the user or application logic.                                                               |

## Response

If successful, this action returns a `200 OK` response code and an [informationProtectionAction](../resources/security-informationprotectionaction.md) collection in the response body. The [informationProtectionAction](../resources/security-informationprotectionaction.md) object will contain a [metadataAction](../resources/security-metadataaction.md) object that informs the application which metadata to remove.

## Examples

### Request

The following is an example of a request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "sensitivitylabelthis.evaluateremoval",
  "sampleKeys": ["bob@contoso.com"]
}
-->
```http
POST https://graph.microsoft.com/beta/users/bob@contoso.com/security/informationProtection/sensitivityLabels/evaluateRemoval
Content-type: application/json
User-agent: ContosoLOBApp/1.0

{
    "contentInfo": {
        "@odata.type": "#microsoft.graph.security.contentInfo",
        "identifier": null,
        "state": "rest",
        "metadata": [
            {
                "name": "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Enabled",
                "value": "True"
            },
            {
                "name": "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Method",
                "value": "Standard"
            },
            {
                "name": "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SetDate",
                "value": "1/1/0001 12:00:00 AM"
            },
            {
                "@odata.type": "#microsoft.graph.security.keyValuePair",
                "name": "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SiteId",
                "value": "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
            },
            {
                "@odata.type": "#microsoft.graph.security.keyValuePair",
                "name": "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Name",
                "value": "LabelScopedToBob_Tests"
            },
            {
                "@odata.type": "#microsoft.graph.security.keyValuePair",
                "name": "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ContentBits",
                "value": "0"
            },
            {
                "@odata.type": "#microsoft.graph.security.keyValuePair",
                "name": "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ActionId",
                "value": "00000000-0000-0000-0000-000000000000"
            }
        ]
    },
    "downgradeJustification": {
        "justificationMessage": "The information has been declassified.",
        "isDowngradeJustified": true
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var contentInfo = new Microsoft.Graph.Security.ContentInfo
{
	Identifier = null,
	State = Microsoft.Graph.Security.ContentState.Rest,
	Metadata = new List<Microsoft.Graph.Security.KeyValuePair>()
	{
		new Microsoft.Graph.Security.KeyValuePair
		{
			Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Enabled",
			Value = "True"
		},
		new Microsoft.Graph.Security.KeyValuePair
		{
			Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Method",
			Value = "Standard"
		},
		new Microsoft.Graph.Security.KeyValuePair
		{
			Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SetDate",
			Value = "1/1/0001 12:00:00 AM"
		},
		new Microsoft.Graph.Security.KeyValuePair
		{
			Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SiteId",
			Value = "cfa4cf1d-a337-4481-aa99-19d8f3d63f7c"
		},
		new Microsoft.Graph.Security.KeyValuePair
		{
			Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Name",
			Value = "LabelScopedToBob_Tests"
		},
		new Microsoft.Graph.Security.KeyValuePair
		{
			Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ContentBits",
			Value = "0"
		},
		new Microsoft.Graph.Security.KeyValuePair
		{
			Name = "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ActionId",
			Value = "00000000-0000-0000-0000-000000000000"
		}
	}
};

var downgradeJustification = new Microsoft.Graph.Security.DowngradeJustification
{
	JustificationMessage = "The information has been declassified.",
	IsDowngradeJustified = true
};

await graphClient.Users["{user-id}"].Security.InformationProtection.SensitivityLabels
	.EvaluateRemoval(contentInfo,downgradeJustification)
	.Request()
	.Header("User-Agent","ContosoLOBApp/1.0")
	.PostAsync();

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

The following is an example of the response.

>**Note:** The response object shown here might be shortened for readability.
<!-- {
  "blockType": "response",
  "name": "sensitivitylabelthis.evaluateremoval",
  "truncated": true,
  "@odata.type": "microsoft.graph.security.informationProtectionAction",
  "isCollection": true
}
-->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#Collection(microsoft.graph.security.informationProtectionAction)",
    "value": [
        {
            "@odata.type": "#microsoft.graph.security.metadataAction",
            "metadataToRemove": [
                "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Enabled",
                "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Method",
                "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SetDate",
                "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_SiteId",
                "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_Name",
                "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ContentBits",
                "MSIP_Label_836ff34f-b604-4a62-a68c-d6be4205d569_ActionId"
            ],
            "metadataToAdd": []
        }
    ]
}
```
