# VRChat.API.Api.InviteApi

All URIs are relative to *https://api.vrchat.cloud/api/1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetInviteMessage**](InviteApi.md#getinvitemessage) | **GET** /message/{userId}/{messageType}/{slot} | Get Invite Message
[**GetInviteMessages**](InviteApi.md#getinvitemessages) | **GET** /message/{userId}/{messageType} | List Invite Messages
[**InviteUser**](InviteApi.md#inviteuser) | **POST** /invite/{userId} | Invite User
[**RequestInvite**](InviteApi.md#requestinvite) | **POST** /requestInvite/{userId} | Request Invite
[**ResetInviteMessage**](InviteApi.md#resetinvitemessage) | **DELETE** /message/{userId}/{messageType}/{slot} | Reset Invite Message
[**RespondInvite**](InviteApi.md#respondinvite) | **POST** /invite/{notificationId}/response | Respond Invite
[**UpdateInviteMessage**](InviteApi.md#updateinvitemessage) | **PUT** /message/{userId}/{messageType}/{slot} | Update Invite Message


<a name="getinvitemessage"></a>
# **GetInviteMessage**
> InviteMessage GetInviteMessage (string userId, string messageType, int slot)

Get Invite Message

Returns a single Invite Message. This returns the exact same information but less than `getInviteMessages`. Admin Credentials are required to view messages of other users!  Message type refers to a different collection of messages, used during different types of responses.  * `message` = Message during a normal invite * `response` = Message when replying to a message * `request` = Message when requesting an invite * `requestResponse` = Message when replying to a request for invite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetInviteMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            config.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = userId_example;  // string | 
            var messageType = messageType_example;  // string | 
            var slot = 56;  // int | 

            try
            {
                // Get Invite Message
                InviteMessage result = apiInstance.GetInviteMessage(userId, messageType, slot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.GetInviteMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **messageType** | **string**|  | 
 **slot** | **int**|  | 

### Return type

[**InviteMessage**](InviteMessage.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single InviteMessage object. |  -  |
| **400** | Error response when trying to get an Invite Message with a negative slot number. |  -  |
| **401** | Error response due to missing authorization to perform that action. |  -  |
| **404** | Error response when trying to get an Invite Message with a too high slot number. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getinvitemessages"></a>
# **GetInviteMessages**
> List&lt;InviteMessage&gt; GetInviteMessages (string userId, string messageType)

List Invite Messages

Returns a list of all the users Invite Messages. Admin Credentials are required to view messages of other users!  Message type refers to a different collection of messages, used during different types of responses.  * `message` = Message during a normal invite * `response` = Message when replying to a message * `request` = Message when requesting an invite * `requestResponse` = Message when replying to a request for invite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class GetInviteMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            config.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = userId_example;  // string | 
            var messageType = messageType_example;  // string | 

            try
            {
                // List Invite Messages
                List<InviteMessage> result = apiInstance.GetInviteMessages(userId, messageType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.GetInviteMessages: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **messageType** | **string**|  | 

### Return type

[**List&lt;InviteMessage&gt;**](InviteMessage.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of InviteMessage objects. |  -  |
| **400** | Error response when trying to update an Invite Message with an invalid slot number. |  -  |
| **401** | Error response due to missing authorization to perform that action. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="inviteuser"></a>
# **InviteUser**
> Notification InviteUser (string userId, InviteRequest inviteRequest = null)

Invite User

Sends an invite to a user. Returns the Notification of type `invite` that was sent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class InviteUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            config.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = userId_example;  // string | 
            var inviteRequest = new InviteRequest(); // InviteRequest | Slot number of the Invite Message to use when inviting a user. (optional) 

            try
            {
                // Invite User
                Notification result = apiInstance.InviteUser(userId, inviteRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.InviteUser: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **inviteRequest** | [**InviteRequest**](InviteRequest.md)| Slot number of the Invite Message to use when inviting a user. | [optional] 

### Return type

[**Notification**](Notification.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Notifcation object. |  -  |
| **403** | Error response when trying to invite someome whom you are not friends with. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="requestinvite"></a>
# **RequestInvite**
> Notification RequestInvite (string userId)

Request Invite

Requests an invite from a user. Returns the Notification of type `requestInvite` that was sent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class RequestInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            config.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = userId_example;  // string | 

            try
            {
                // Request Invite
                Notification result = apiInstance.RequestInvite(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.RequestInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 

### Return type

[**Notification**](Notification.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Notifcation object. |  -  |
| **403** | Error response when trying to invite someome whom you are not friends with. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetinvitemessage"></a>
# **ResetInviteMessage**
> List&lt;InviteMessage&gt; ResetInviteMessage (string userId, string messageType, int slot)

Reset Invite Message

Resets a single Invite Message back to its original message, and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Resetting a message respects the rate-limit, so it is not possible to reset within the 60 minutes countdown. Resetting it does however not set the rate-limit to 60 like when editing it. It is possible to edit it right after resetting it. Trying to edit a message before the cooldown timer expires results in a 429 \"Too Fast Error\".  Message type refers to a different collection of messages, used during different types of responses.  * `message` = Message during a normal invite * `response` = Message when replying to a message * `request` = Message when requesting an invite * `requestResponse` = Message when replying to a request for invite  The DELETE endpoint does not have/require any request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class ResetInviteMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            config.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = userId_example;  // string | 
            var messageType = messageType_example;  // string | 
            var slot = 56;  // int | 

            try
            {
                // Reset Invite Message
                List<InviteMessage> result = apiInstance.ResetInviteMessage(userId, messageType, slot);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.ResetInviteMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **messageType** | **string**|  | 
 **slot** | **int**|  | 

### Return type

[**List&lt;InviteMessage&gt;**](InviteMessage.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of InviteMessage objects. |  -  |
| **400** | Error response when trying to update an Invite Message with an invalid slot number. |  -  |
| **401** | Error response due to missing authorization to perform that action. |  -  |
| **404** | Error response when trying to reset an Invite Message whos slot doesn&#39;t exist. |  -  |
| **429** | Error response when trying to update an Invite Message before the cooldown has expired. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="respondinvite"></a>
# **RespondInvite**
> Notification RespondInvite (string notificationId, InviteResponse inviteResponse = null)

Respond Invite

Respond to an invite request by sending a world invite to the requesting user. `:notificationId` is the ID of the requesting notification.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class RespondInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            config.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var notificationId = notificationId_example;  // string | 
            var inviteResponse = new InviteResponse(); // InviteResponse | Instance ID when inviting a user. (optional) 

            try
            {
                // Respond Invite
                Notification result = apiInstance.RespondInvite(notificationId, inviteResponse);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.RespondInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notificationId** | **string**|  | 
 **inviteResponse** | [**InviteResponse**](InviteResponse.md)| Instance ID when inviting a user. | [optional] 

### Return type

[**Notification**](Notification.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a single Notifcation object. |  -  |
| **400** | Error response when trying to respond to an invite and something went wrong. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateinvitemessage"></a>
# **UpdateInviteMessage**
> List&lt;InviteMessage&gt; UpdateInviteMessage (string userId, string messageType, int slot, UpdateInviteMessageRequest updateInviteMessageRequest = null)

Update Invite Message

Updates a single Invite Message and then returns a list of all of them. Admin Credentials are required to update messages of other users!  Updating a message automatically sets the cooldown timer to 60 minutes. Trying to edit a message before the cooldown timer expires results in a 429 \"Too Fast Error\".  Message type refers to a different collection of messages, used during different types of responses.  * `message` = Message during a normal invite * `response` = Message when replying to a message * `request` = Message when requesting an invite * `requestResponse` = Message when replying to a request for invite

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VRChat.API.Api;
using VRChat.API.Client;
using VRChat.API.Model;

namespace Example
{
    public class UpdateInviteMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vrchat.cloud/api/1";
            // Configure API key authorization: apiKeyCookie
            config.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("apiKey", "Bearer");
            // Configure API key authorization: authCookie
            config.AddApiKey("auth", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("auth", "Bearer");

            var apiInstance = new InviteApi(config);
            var userId = userId_example;  // string | 
            var messageType = messageType_example;  // string | 
            var slot = 56;  // int | 
            var updateInviteMessageRequest = new UpdateInviteMessageRequest(); // UpdateInviteMessageRequest | Message of what to set the invite message to. (optional) 

            try
            {
                // Update Invite Message
                List<InviteMessage> result = apiInstance.UpdateInviteMessage(userId, messageType, slot, updateInviteMessageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InviteApi.UpdateInviteMessage: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userId** | **string**|  | 
 **messageType** | **string**|  | 
 **slot** | **int**|  | 
 **updateInviteMessageRequest** | [**UpdateInviteMessageRequest**](UpdateInviteMessageRequest.md)| Message of what to set the invite message to. | [optional] 

### Return type

[**List&lt;InviteMessage&gt;**](InviteMessage.md)

### Authorization

[apiKeyCookie](../README.md#apiKeyCookie), [authCookie](../README.md#authCookie)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a list of InviteMessage objects. |  -  |
| **400** | Error response when trying to update an Invite Message with an invalid slot number. |  -  |
| **401** | Error response due to missing authorization to perform that action. |  -  |
| **429** | Error response when trying to update an Invite Message before the cooldown has expired. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

