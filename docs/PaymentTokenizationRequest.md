# Org.OpenAPITools.Model.PaymentTokenizationRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestType** | **string** | Object name of tokenization request. | 
**StoreId** | **string** | An optional outlet ID for clients that support multiple stores in the same app. | [optional] 
**BillingAddress** | [**Address**](Address.md) |  | [optional] 
**CreateToken** | [**CreatePaymentToken**](CreatePaymentToken.md) |  | 
**AccountVerification** | **bool?** | If the account should be verified prior to token creation. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

