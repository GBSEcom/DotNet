# Org.OpenAPITools.Model.DeviceNetworks
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkType** | **string** | Defines the type of network associated with the device. | 
**Ip** | **string** | The IPv4 or IPv6 address of the device if the network assigned one. | [optional] 
**PhoneNumber** | **string** | The devices primary phone number. This value should be supplied directly without any transformation (e.g. removal of spaces, hyphens or parentheses). If this data is available in segregated fields, it should be concatenated using a blank space (\&quot; \&quot;) as a separator. | [optional] 
**CarrierName** | **string** | The network carrier name. | [optional] 
**MobileCountryCode** | **string** | The Mobile Country Code (MCC) as described in the ITUs E.212 specification. | [optional] 
**MobileNetworkCode** | **string** | The Mobile Network Code (MNC) as described in the ITUs E.212 specification. | [optional] 
**SubscriptionIdentificationNumber** | **string** | The Mobile Subscription Identification Number code (MSIN) as described in the ITUs E.212 specification. | [optional] 
**LocationAreaCode** | **string** | The Location Area Code (LAC) is a16-bit identifier for a region that is covered by a set of network antennas. | [optional] 
**CellId** | **string** | The Cell ID (CID) is identifier for a specific Base Transceiver Station (BTS) within a specific Location Area Code (LAC). | [optional] 
**Standard** | **string** | An identifier of the network standard used. | [optional] 
**Mac** | **string** | The MAC address of the device that is connected to the Wi-Fi network. | [optional] 
**Ssid** | **string** | The Wi-Fi networks Service Set Identifier (SSID). | [optional] 
**Bssid** | **string** | The Wi-Fi networks Basic Service Set Identifier (BSSID). | [optional] 
**UserDefined** | [**Object**](.md) | A JSON object that can carry any additional information about the network that might be helpful for fraud detection. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

