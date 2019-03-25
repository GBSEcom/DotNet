# Org.OpenAPITools.Model.Customer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID for the customer, if registered. This field is required if the parent object is present. | 
**StartDate** | **string** | The timestamp of the customers registration in the merchants platform. Format is CCYY-MM-DD. | [optional] 
**FirstName** | **string** | Customers first name. | [optional] 
**LastName** | **string** | Customers last name. | [optional] 
**MiddleName** | **string** | Customers middle name. | [optional] 
**Email** | **string** | Customers email address. | [optional] 
**SessionId** | **string** | The unique ID of the current login session. Must be unique for the customer. | [optional] 
**Username** | **string** | The username of this customer in the merchants system. This field should contain customer-supplied data if available instead of a generated ID. This field can contain the clients email address if it is also used for authentication purposes. | [optional] 
**Gender** | **string** | The customers gender. Do not set this property if the customer does not specify a gender. | [optional] 
**DateOfBirth** | **string** | The customers year of birth. Format is CCYY. | [optional] 
**Address** | [**CustomerAddress**](CustomerAddress.md) |  | [optional] 
**UserDefined** | [**Object**](.md) | A JSON object that can carry any additional information about the customer that might be helpful for fraud detection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

