---
title: "Create b2cIdentityUserFlow"
description: "Create a new b2cIdentityUserFlow object."
ms.localizationpriority: medium
doc_type: apiPageType
author: "jkdouglas"
ms.prod: "identity-and-sign-in"
---

# Create b2cIdentityUserFlow

Namespace: microsoft.graph

> [!IMPORTANT]
> APIs under the `/beta` version in Microsoft Graph are subject to change. Use of these APIs in production applications is not supported. To determine whether an API is available in v1.0, use the **Version** selector.

Create a new [b2cIdentityUserFlow](../resources/b2cidentityuserflow.md) object.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

|Permission type      | Permissions (from least to most privileged)              |
|:--------------------|:---------------------------------------------------------|
|Delegated (work or school account)|IdentityUserFlow.ReadWrite.All|
|Delegated (personal Microsoft account)| Not supported.|
|Application|IdentityUserFlow.ReadWrite.All|

The work or school account needs to belong to one of the following roles:

* Global administrator
* External Identity User Flow administrator

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /identity/b2cUserFlows
```

## Request headers

|Name|Description|
|:---------------|:----------|
|Authorization|Bearer {token}. Required.|
|Content-Type|application/json. Required.|

## Request body

In the request body, provide a JSON representation of a [b2cIdentityUserFlow](../resources/b2cidentityuserflow.md).

|Property|Type|Description|
|:---------------|:--------|:----------|
|id|String|Required. The name of the user flow. The name will be pre-pended with `B2C_1_` after creation if the prefix was not added to the name during your request. |
|userFlowType|String|Required. The type of user flow you are creating. The supported values for **userFlowType** are:<br/><ul><li>`signUp`</li><li>`signIn`</li><li>`signUpOrSignIn`</li><li>`passwordReset`</li><li>`profileUpdate`</li><li>`resourceOwner`</li>|
|userFlowTypeVersion|Float|Required. The version of the user flow.|
|isLanguageCustomizationEnabled|Boolean|Optional. Determines whether language customization is enabled within the Azure AD B2C user flow. Language customization is not enabled by default for Azure AD B2C user flows.|
|defaultLanguageTag|String|Optional.  Specifies the default language of the b2cIdentityUserFlow that is used when no `ui_locale` tag is specified in the request. This field is [RFC 5646](https://tools.ietf.org/html/rfc5646) compliant.|
|identityProviders|[identityProvider](../resources/identityprovider.md) collection|Optional. The identity providers you want to include in the user flow.|

## Response

If successful, this method returns a `201 Created` response code and a Location header with a URI to the [b2cIdentityUserFlow](../resources/b2cidentityuserflow.md) object created for this request, with the `B2C_1_` prefix added to the name. If unsuccessful, a `4xx` error will be returned with specific details.

## Examples

### Example 1: Create a user flow with the default values

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_b2cuserflow_from_b2cuserflows"
}
-->

``` http
POST https://graph.microsoft.com/beta/identity/b2cUserFlows
Content-type: application/json

{
    "id": "Customer",
    "userFlowType": "signUpOrSignIn",
    "userFlowTypeVersion": 3
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var b2cIdentityUserFlow = new B2cIdentityUserFlow
{
	Id = "Customer",
	UserFlowType = UserFlowType.SignUpOrSignIn,
	UserFlowTypeVersion = 3f
};

await graphClient.Identity.B2cUserFlows
	.Request()
	.AddAsync(b2cIdentityUserFlow);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.b2cIdentityUserFlow"
} -->

```http
HTTP/1.1 201 Created
Location: https://graph.microsoft.com/beta/identity/b2cUserFlows('B2C_1_Customer')
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identity/b2cUserFlows/$entity",
    "id": "B2C_1_Customer",
    "userFlowType": "signUpOrSignIn",
    "userFlowTypeVersion": 3,
    "isLanguageCustomizationEnabled": false,
    "defaultLanguageTag": "en",
    "authenticationMethods": "emailWithPassword",
    "tokenClaimsConfiguration": {
        "isIssuerEntityUserFlow": false
    },
    "apiConnectorConfiguration": {}
}
```

### Example 2: Create a user flow with the default values and an identity provider

#### Request

The following is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_b2cuserflow_from_b2cuserflows_identityProvider"
}
-->

``` http
POST https://graph.microsoft.com/beta/identity/b2cUserFlows
Location: https://graph.microsoft.com/beta/identity/b2cUserFlows('B2C_1_Customer')
Content-type: application/json

{
    "id": "Customer",
    "userFlowType": "signUpOrSignIn",
    "userFlowTypeVersion": 3,
    "identityProviders": [
        {
            "id": "Facebook-OAuth"
        }
    ]
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var b2cIdentityUserFlow = new B2cIdentityUserFlow
{
	Id = "Customer",
	UserFlowType = UserFlowType.SignUpOrSignIn,
	UserFlowTypeVersion = 3f,
	IdentityProviders = new B2cIdentityUserFlowIdentityProvidersCollectionWithReferencesPage()
	{
		new IdentityProvider
		{
			Id = "Facebook-OAuth"
		}
	}
};

await graphClient.Identity.B2cUserFlows
	.Request()
	.Header("Location","https://graph.microsoft.com/beta/identity/b2cUserFlows('B2C_1_Customer')")
	.AddAsync(b2cIdentityUserFlow);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

**Note:** The response object shown here might be shortened for readability.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.b2cIdentityUserFlow"
} -->

```http
HTTP/1.1 201 Created
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identity/b2cUserFlows/$entity",
    "id": "B2C_1_Customer",
    "userFlowType": "signUpOrSignIn",
    "userFlowTypeVersion": 3,
    "isLanguageCustomizationEnabled": false,
    "defaultLanguageTag": "en",
    "authenticationMethods": "0",
    "tokenClaimsConfiguration": {
        "isIssuerEntityUserFlow": false
    },
    "apiConnectorConfiguration": {}
}
```

<!-- {
  "type": "#page.annotation",
  "description": "Create b2CUserFlow",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
    "Error: create_b2cUserFlow_from_b2cUserFlows/userFlowTypeVersion:\r\n      Expected type Single but actual was Int64. Property: userFlowTypeVersion, actual value: '3'",
    "Error: create_b2cUserFlow_from_b2cUserFlows_identityProvider/userFlowTypeVersion:\r\n    Expected type Single but actual was Int64. Property: userFlowTypeVersion, actual value: '3'"
  ]
}-->

### Example 3: Create a user flow with the default values and configuration for API connectors

#### Request

The following is an example of the request.


# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "create_b2cuserflow_from_b2cuserflows_apiconnectors"
}
-->

``` http
POST https://graph.microsoft.com/beta/identity/b2cUserFlows
Content-type: application/json

{
    "id": "UserFlowWithAPIConnector",
    "userFlowType": "signUpOrSignIn",
    "userFlowTypeVersion": 1,
    "apiConnectorConfiguration":{
        "postFederationSignup":{
            "@odata.id": "{apiConnectorId}"
        },
        "postAttributeCollection":{
            "@odata.id": "{apiConnectorId}"
        }
    }
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var b2cIdentityUserFlow = new B2cIdentityUserFlow
{
	Id = "UserFlowWithAPIConnector",
	UserFlowType = UserFlowType.SignUpOrSignIn,
	UserFlowTypeVersion = 1f,
	ApiConnectorConfiguration = new UserFlowApiConnectorConfiguration
	{
		PostFederationSignup = new IdentityApiConnector
		{
			AdditionalData = new Dictionary<string, object>()
			{
				{"@odata.id", "{apiConnectorId}"}
			}
		},
		PostAttributeCollection = new IdentityApiConnector
		{
			AdditionalData = new Dictionary<string, object>()
			{
				{"@odata.id", "{apiConnectorId}"}
			}
		}
	}
};

await graphClient.Identity.B2cUserFlows
	.Request()
	.AddAsync(b2cIdentityUserFlow);

```


 [!IMPORTANT]
 Microsoft Graph SDKs use the v1.0 version of the API by default, and do not support all the types, properties, and APIs available in the beta version. For details about accessing the beta API with the SDK, see [Use the Microsoft Graph SDKs with the beta API](/graph/sdks/use-beta).

 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

#### Response

The following is an example of the response.

**Note:** The response object shown here might be shortened for readability.

**Note:** The `apiConnectorConfiguration` property always returns a '{}' value. To see full value with the navigation properties, use [this](../api/b2cidentityuserflow-get-apiConnectorConfiguration.md) API.

<!-- {
  "blockType": "response",
  "truncated": true,
  "@odata.type": "microsoft.graph.b2cIdentityUserFlow"
} -->

```http
HTTP/1.1 201 Created
Location: https://graph.microsoft.com/beta/identity/b2cUserFlows/B2C_1_Partner
Content-type: application/json

{
    "@odata.context": "https://graph.microsoft.com/beta/$metadata#identity/b2cUserFlows/$entity",
    "id": "B2C_1_UserFlowWithAPIConnector",
    "userFlowType": "signUpOrSignIn",
    "userFlowTypeVersion": 1,
    "apiConnectorConfiguration": {}
}
```

<!-- {
  "type": "#page.annotation",
  "description": "Create b2cUserFlow",
  "keywords": "",
  "section": "documentation",
  "tocPath": "",
  "suppressions": [
    "Error: create_b2cUserFlow_from_b2cuserflows_apiconnectors/userFlowTypeVersion:\r\n      Expected type Single but actual was Int64. Property: userFlowTypeVersion, actual value: '1'"
  ]
}-->
