# Org.OpenAPITools.Model.PaymentIssuerResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The verification response code, as sent by the verification system. | 
**Status** | **string** | The interpretation of the response code. Valid values are \&quot;approved\&quot; - The verification was conducted and is approved. \&quot;declined\&quot; - The verification was conducted and is not approved. \&quot;disabled\&quot; - The verification was not conducted because it was not requested or disabled in the verification. \&quot;unknown\&quot; - The verification was attempted but it failed due to some system error (e.g. timeout). | [optional] 
**Scheme** | **string** | An identifier of the system/specification from which the code was received, and how the status was derived. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

