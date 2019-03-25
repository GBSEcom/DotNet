# Org.OpenAPITools.Model.Airline
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassengerName** | **string** | The passenger name associated with the transaction | [optional] 
**TicketNumber** | **string** | The airline ticket number associated with the transaction | [optional] 
**IssuingCarrier** | **string** | The carrier that issued the ticket | [optional] 
**CarrierName** | **string** | The carrier associated with the transaction | [optional] 
**TravelAgencyIataCode** | **string** | The IATA code associated with the travel agency | [optional] 
**TravelAgencyName** | **string** | The business name of the travel agency | [optional] 
**AirlinePlanNumber** | **string** | The airline plan number associated with the transaction | [optional] 
**AirlineInvoiceNumber** | **string** | The invoice number used by the airline | [optional] 
**ReservationSystem** | **string** | The reservation system used to create the ticket | [optional] 
**Restricted** | **bool?** | Whether or not the transaction is associated with a restricted class fare | [optional] 
**TravelRoute** | [**List<AirlineTravelRoute>**](AirlineTravelRoute.md) | Array containing up to 4 items that describe the route associated with the transaction | [optional] 
**RelatedTicketNumber** | **string** | The number of any other tickets associated with the transaction ticket. | [optional] 
**AncillaryServiceCategory** | [**List<AirlineAncillaryServiceCategory>**](AirlineAncillaryServiceCategory.md) | Identify the purchase of ancillary goods or services with a false value. If this element is not provided, the transaction is assumed to be a purchase of an airline ticket. | [optional] 
**TicketPurchase** | **bool?** | Identifies if the transaction is a ticket purchase | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

