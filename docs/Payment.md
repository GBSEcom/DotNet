# Org.OpenAPITools.Model.Payment
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentType** | **string** | Defines the type of the payment. | 
**PayMethod** | [**PaymentPayMethod**](PaymentPayMethod.md) |  | 
**PinPresent** | **bool?** | Indicates if the cards Personal Identification Number was supplied. | 
**EntryMethod** | **string** | The method in which the card information entered the system. | 
**IssuerResponse** | [**PaymentIssuerResponse**](PaymentIssuerResponse.md) |  | [optional] 
**IssuerApprovedAmount** | **string** | The actual approved amount. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization). For transaction/authorization this amount refers to the amount that was locked on the card-holders account. | [optional] 
**IssuerCardBalance** | **string** | The payment methods account balance if available. This field should be filled in when the message has already passed through the issuer (e.g. post-authorization). | [optional] 
**VerificationAvs** | [**PaymentVerificationAvs**](PaymentVerificationAvs.md) |  | [optional] 
**Verification3ds** | [**PaymentVerification3ds**](PaymentVerification3ds.md) |  | [optional] 
**VerificationCvv** | [**PaymentVerificationCvv**](PaymentVerificationCvv.md) |  | [optional] 
**UserDefined** | [**Object**](.md) | A JSON object that carries any additional information that might be helpful for fraud detection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

