# Org.OpenAPITools.Model.CardInfoLookupResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientRequestId** | **string** | Echoes back the value in the request header for tracking. | [optional] 
**ApiTraceId** | **string** | Request identifier in API, can be used to request logs from the support team. | [optional] 
**ResponseType** | [**ResponseType**](ResponseType.md) |  | [optional] 
**CardDetails** | [**List<CardInfo>**](CardInfo.md) | One or more card information retrieved based on BIN. | [optional] 
**RequestStatus** | **string** | Request status. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

