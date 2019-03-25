# Org.OpenAPITools.Model.PrimaryTransaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionType** | **TransactionType** |  | 
**StoreId** | **string** | An optional outlet ID for clients that support multiple stores in the same app. | [optional] 
**MerchantTransactionId** | **string** | The unique merchant transaction ID from the Request header, if supplied. | [optional] 
**TransactionOrigin** | **TransactionOrigin** |  | [optional] 
**Amount** | [**Amount**](Amount.md) |  | 
**PaymentMethod** | [**PaymentMethod**](PaymentMethod.md) |  | 
**Order** | [**Order**](Order.md) |  | [optional] 
**BasketItems** | [**List<BasketItem>**](BasketItem.md) | Required for some payment methods (for example, Klarna) | [optional] 
**SplitShipment** | [**SplitShipment**](SplitShipment.md) |  | [optional] 
**AdditionalDetails** | [**PrimaryTransactionAdditionalDetails**](PrimaryTransactionAdditionalDetails.md) |  | [optional] 
**IndustrySpecificExtensions** | [**IndustrySpecificExtensions**](IndustrySpecificExtensions.md) |  | [optional] 
**StoredCredentials** | [**StoredCredential**](StoredCredential.md) |  | [optional] 
**PurchaseCard** | [**PurchaseCards**](PurchaseCards.md) |  | [optional] 
**PaymentFacilitator** | [**PaymentFacilitator**](PaymentFacilitator.md) |  | [optional] 
**SoftDescriptor** | [**SoftDescriptor**](SoftDescriptor.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

