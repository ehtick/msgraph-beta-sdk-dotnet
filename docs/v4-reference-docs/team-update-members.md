---
title: "Update member in team"
description: "Update the role of member in a team."
author: "akjo"
doc_type: "apiPageType"
ms.localizationpriority: medium
ms.prod: "microsoft-teams"
---

# Update member in team

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Update the role of a [conversationMember](../resources/conversationmember.md) in a [team](../resources/team.md).

> [!NOTE]
> Team members with the role of `guest` cannot be given the role of `owner`.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission Type|Permissions (from least to most privileged)|
|---------|-------------|
|Delegated (work or school account)|TeamMember.ReadWrite.All. |
|Delegated (personal Microsoft account)|Not supported|
|Application|TeamMember.ReadWrite.All. |

## HTTP request
<!-- { "blockType": "ignored"} -->
```http
PATCH /teams/{team-id}/members/{membership-id}
```

## Request headers

| Header       | Value |
|:---------------|:--------|
| Authorization  | Bearer {token}. Required.  |
| Content-type | application/json. Required. |

## Request body

In the request body, supply the values for the relevant fields to update. Existing properties that are not included in the request body will maintain their previous values or be recalculated based on changes to other property values. For best performance, don't include existing values that haven't changed.

| Property   | Type |Description|
|:---------------|:--------|:----------|
|roles|string collection|The role for the user. Must be `owner` or empty. Guest users are automatically stamped with `guest` role and this value cannot be updated. |

## Response

If successful, this method returns a `200 OK` response code and an updated [conversationMember](../resources/conversationmember.md) object in the response body.

## Example

### Request

The following is a request to apply the `owner` role to an existing member of a team.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "update_member_2",
  "sampleKeys": ["ece6f0a1-7ca4-498b-be79-edf6c8fc4d82", "ZWUwZjVhZTItOGJjNi00YWU1LTg0NjYtN2RhZWViYmZhMDYyIyM3Mzc2MWYwNi0yYWM5LTQ2OWMtOWYxMC0yNzlhOGNjMjY3Zjk="]
} -->
```http
PATCH https://graph.microsoft.com/beta/teams/ece6f0a1-7ca4-498b-be79-edf6c8fc4d82/members/ZWUwZjVhZTItOGJjNi00YWU1LTg0NjYtN2RhZWViYmZhMDYyIyM3Mzc2MWYwNi0yYWM5LTQ2OWMtOWYxMC0yNzlhOGNjMjY3Zjk=
content-type: application/json
content-length: 26

{
  "@odata.type":"#microsoft.graph.aadUserConversationMember",
  "roles": ["owner"]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var conversationMember = new AadUserConversationMember
{
	Roles = new List<String>()
	{
		"owner"
	}
};

await graphClient.Teams["{team-id}"].Members["{conversationMember-id}"]
	.Request()
	.UpdateAsync(conversationMember);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

### Response

>**Note:** The response object shown here might be shortened for readability. 
<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.conversationMember"
} -->
```http
HTTP/1.1 200 OK
Content-type: application/json

{
  "@odata.context": "https://graph.microsoft.com/beta/$metadata#teams('ece6f0a1-7ca4-498b-be79-edf6c8fc4d82')/members/microsoft.graph.aadUserConversationMember/$entity",
  "@odata.type": "#microsoft.graph.aadUserConversationMember",
  "id": "ZWUwZjVhZTItOGJjNi00YWU1LTg0NjYtN2RhZWViYmZhMDYyIyM3Mzc2MWYwNi0yYWM5LTQ2OWMtOWYxMC0yNzlhOGNjMjY3Zjk=",
  "roles": ["owner"],
  "displayName": "John Doe",
  "userId": "8b081ef6-4792-4def-b2c9-c363a1bf41d5",
  "email": null
}
```

## See also

- [Update member in channel](channel-update-members.md)

<!-- uuid: 8fcb5dbc-d5aa-4681-8e31-b001d5168d79
2015-10-25 14:57:30 UTC -->
<!--
{
  "type": "#page.annotation",
  "description": "update role of team member",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
  ]
}
-->
