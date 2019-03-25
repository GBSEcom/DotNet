# Org.OpenAPITools.Model.ScoreOnlyResponseFraudScore
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Score** | **string** | The score attributed to this request by our machine learning system, ranging from 0 (less likely to be fraud) to 1000 (more likely to be fraud). | [optional] 
**Warnings** | **List<string>** | A list of non-critical warnings raised while processing the request. Warnings included in this list will have integration and data-quality related messages. | [optional] 
**Explanations** | [**List<ScoreOnlyResponseFraudScoreExplanations>**](ScoreOnlyResponseFraudScoreExplanations.md) | Type of the explanation to the warning raised | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

