# Org.OpenAPITools.Model.PaymentTokenization
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Value** | **string** | Client supplied Payment Token value | [optional] 
**Reusable** | **bool?** | One time or reusable token | [optional] [default to true]
**DeclineDuplicates** | **bool?** | Decline duplicate payment info if client token is supplied | [optional] [default to false]
**Last4** | **string** | The last 4 payment card numbers | [optional] 
**Brand** | **string** | Only for tokenization with payment | [optional] 
**Country** | **string** | Only for tokenization with payment | [optional] 
**AccountVerification** | **bool?** |  | [optional] [default to false]
**SecurityCode** | **string** | Card Verification Value/Number | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

