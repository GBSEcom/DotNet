# IO.Swagger.Model.PaymentMethod
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of payment method. Note that PayPal can only process a &#39;Credit&#39;  primary transaction with Order.Billing.Contact.email being mandatory. PayPal secondary transactions (void/return/postauth) are processed the same as any other secondary transactions. | 
**PaymentCard** | [**PaymentCard**](PaymentCard.md) |  | [optional] 
**Sepa** | [**Sepa**](Sepa.md) |  | [optional] 
**PayPal** | [**PayPal**](PayPal.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

