# Org.OpenAPITools.Model.PaymentMethod
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of payment method. Note that PayPal can only process a &#39;CREDIT&#39; transaction. Note that for requests we are now supporting only PAYMENT_CARD, SEPA, PAYPAL, ALIPAY. All this types are supported for response. | 
**PaymentCard** | [**PaymentCard**](PaymentCard.md) |  | [optional] 
**PaymentToken** | [**PaymentTokenization**](PaymentTokenization.md) |  | [optional] 
**Sepa** | [**Sepa**](Sepa.md) |  | [optional] 
**PayPal** | [**PayPal**](PayPal.md) |  | [optional] 
**AliPay** | [**AliPay**](AliPay.md) |  | [optional] 
**ChinaDomestic** | [**ChinaDomestic**](ChinaDomestic.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

