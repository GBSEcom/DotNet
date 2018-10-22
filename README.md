# FirstApiClient C# library

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.7.0.1
- RestSharp.Net2.1.1.11

<a name="installation"></a>
## Installation
### Install Via NuGet
-OR-
### Local
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh compile-mono.sh`
- [Windows] TODO

Include the DLL (under the `bin` folder) in the C# project

Use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using IO.Simple;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
using IO.Simple;

namespace Example
{
    public class Example
    {
        public void main()
        {
            string apiKey = "Your API Key Here";
            string apiSecret = "Your API Secret Here";

            MerchantCredentials credentials = new MerchantCredentials(apiKey, apiSecret);
            Gateway gateway = Gateway.create(credentials);

            PaymentMethod pMethod = new PaymentMethod();
            Expiration expiryDate = new Expiration();
            PaymentCard card = new PaymentCard();
            expiryDate.Month = "12";
            expiryDate.Year = "25";
            card.ExpiryDate = expiryDate;
            card.Number = "4111111111111111";
            pMethod.PaymentCard = card;
            pMethod.Type = transaction_params.payload.paymentMethod.type;
            PrimaryTransaction trans = new PrimaryTransaction
            {
                Amount = GetAmount(),
                StoreId = StoreId(),
                PaymentMethod = pMethod,
                TransactionType = transaction_params.payload.transactionType
            };

            ApiResponse response = gateway.PrimaryPaymentTransaction(
                payload
            );

            Console.WriteLine(response.JsonData);
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://cert.api.firstdata.com/gateway*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**V1AuthenticationAccessTokensPost**](docs/AuthenticationApi.md#v1authenticationaccesstokenspost) | **POST** /v1/authentication/access-tokens | Generate an access token for user authentication
*OrderApi* | [**PerformPaymentPostAuthorisation**](docs/OrderApi.md#performpaymentpostauthorisation) | **POST** /v1/orders/{order-id}/postauth | Use this to capture/complete a transaction. Partial postauths are allowed.
*OrderApi* | [**ReturnTransaction**](docs/OrderApi.md#returntransaction) | **POST** /v1/orders/{order-id}/return | Use this to return/refund on the order. Partial returns are allowed.
*PaymentApi* | [**PerformPaymentPostAuthorisation**](docs/PaymentApi.md#performpaymentpostauthorisation) | **POST** /v1/payments/{transaction-id}/postauth | Use this to capture/complete a transaction. Partial postauths are allowed.
*PaymentApi* | [**PrimaryPaymentTransaction**](docs/PaymentApi.md#primarypaymenttransaction) | **POST** /v1/payments | Generate a primary transaction
*PaymentApi* | [**ReturnTransaction**](docs/PaymentApi.md#returntransaction) | **POST** /v1/payments/{transaction-id}/return | Return/refund a transaction.
*PaymentApi* | [**TransactionInquiry**](docs/PaymentApi.md#transactioninquiry) | **GET** /v1/payments/{transaction-id} | Retrieve the state of a transaction
*PaymentApi* | [**VoidTransaction**](docs/PaymentApi.md#voidtransaction) | **POST** /v1/payments/{transaction-id}/void | Reverse a previous action on an existing transaction


<a name="documentation-for-models"></a>
## Documentation for Models

 - [IO.Swagger.Model.AccessTokenResponse](docs/AccessTokenResponse.md)
 - [IO.Swagger.Model.Address](docs/Address.md)
 - [IO.Swagger.Model.Airline](docs/Airline.md)
 - [IO.Swagger.Model.AirlineAncillaryServiceCategory](docs/AirlineAncillaryServiceCategory.md)
 - [IO.Swagger.Model.AirlineTravelRoute](docs/AirlineTravelRoute.md)
 - [IO.Swagger.Model.Amount](docs/Amount.md)
 - [IO.Swagger.Model.AmountComponents](docs/AmountComponents.md)
 - [IO.Swagger.Model.AuthenticationResponseVerification](docs/AuthenticationResponseVerification.md)
 - [IO.Swagger.Model.BasketItem](docs/BasketItem.md)
 - [IO.Swagger.Model.Billing](docs/Billing.md)
 - [IO.Swagger.Model.CarRental](docs/CarRental.md)
 - [IO.Swagger.Model.CarRentalExtraCharges](docs/CarRentalExtraCharges.md)
 - [IO.Swagger.Model.CardVerificationsTransaction](docs/CardVerificationsTransaction.md)
 - [IO.Swagger.Model.ClientLocale](docs/ClientLocale.md)
 - [IO.Swagger.Model.Contact](docs/Contact.md)
 - [IO.Swagger.Model.Error](docs/Error.md)
 - [IO.Swagger.Model.ErrorDetails](docs/ErrorDetails.md)
 - [IO.Swagger.Model.ErrorResponse](docs/ErrorResponse.md)
 - [IO.Swagger.Model.Expiration](docs/Expiration.md)
 - [IO.Swagger.Model.Frequency](docs/Frequency.md)
 - [IO.Swagger.Model.IndustrySpecificExtensions](docs/IndustrySpecificExtensions.md)
 - [IO.Swagger.Model.InstallmentOptions](docs/InstallmentOptions.md)
 - [IO.Swagger.Model.Lodging](docs/Lodging.md)
 - [IO.Swagger.Model.LodgingExtraCharges](docs/LodgingExtraCharges.md)
 - [IO.Swagger.Model.Order](docs/Order.md)
 - [IO.Swagger.Model.PayPal](docs/PayPal.md)
 - [IO.Swagger.Model.PaymentCard](docs/PaymentCard.md)
 - [IO.Swagger.Model.PaymentCardAuthenticationRequest](docs/PaymentCardAuthenticationRequest.md)
 - [IO.Swagger.Model.PaymentCardAuthenticationResult](docs/PaymentCardAuthenticationResult.md)
 - [IO.Swagger.Model.PaymentMethod](docs/PaymentMethod.md)
 - [IO.Swagger.Model.PaymentSchedulesRequest](docs/PaymentSchedulesRequest.md)
 - [IO.Swagger.Model.PaymentSchedulesResponse](docs/PaymentSchedulesResponse.md)
 - [IO.Swagger.Model.PaymentUrlRequest](docs/PaymentUrlRequest.md)
 - [IO.Swagger.Model.PaymentUrlResponse](docs/PaymentUrlResponse.md)
 - [IO.Swagger.Model.PrimaryTransaction](docs/PrimaryTransaction.md)
 - [IO.Swagger.Model.PrimaryTransactionAdditionalDetails](docs/PrimaryTransactionAdditionalDetails.md)
 - [IO.Swagger.Model.ProcessorData](docs/ProcessorData.md)
 - [IO.Swagger.Model.ResponseType](docs/ResponseType.md)
 - [IO.Swagger.Model.SecondaryTransaction](docs/SecondaryTransaction.md)
 - [IO.Swagger.Model.Sepa](docs/Sepa.md)
 - [IO.Swagger.Model.SepaMandate](docs/SepaMandate.md)
 - [IO.Swagger.Model.Shipping](docs/Shipping.md)
 - [IO.Swagger.Model.SplitShipment](docs/SplitShipment.md)
 - [IO.Swagger.Model.StoredCredential](docs/StoredCredential.md)
 - [IO.Swagger.Model.TransactionResponse](docs/TransactionResponse.md)
 - [IO.Swagger.Model.TransactionResponseAuthenticationRedirect](docs/TransactionResponseAuthenticationRedirect.md)
 - [IO.Swagger.Model.TransactionResponseAuthenticationRedirectParams](docs/TransactionResponseAuthenticationRedirectParams.md)
 - [IO.Swagger.Model.TransactionType](docs/TransactionType.md)
 - [IO.Swagger.Model.TransactionErrorResponse](docs/TransactionErrorResponse.md)
