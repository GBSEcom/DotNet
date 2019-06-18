# Org.OpenAPITools.Model.ScoreOnlyResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiTraceId** | **string** | Unique trace ID for issue triage. | [optional] 
**TransactionStatus** | **string** | Please refer to \&quot;Errors Section\&quot; for more info. | [optional] 
**ValidationStatus** | **string** | If status returned is \&quot;failure\&quot;, input validation errors occurred. Please refer to the \&quot;Errors Section\&quot; for more info. Valid values are &#39;success&#39; and &#39;failure&#39;. | [optional] 
**TransactionType** | **string** | The transactionType provided in request. | [optional] 
**FraudScore** | [**ScoreOnlyResponseFraudScore**](ScoreOnlyResponseFraudScore.md) |  | [optional] 
**RecommendedDecision** | **string** | The action that should be taken for the request that was sent. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

