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

Include the DLL (under the `bin` folder) in the C# project

Use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
using Org.Simple;
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
*AuthenticationApi* | [**V1AuthenticationAccessTokensPost**](docs/AuthenticationApi.md#v1authenticationaccesstokenspost) | **POST** /v1/authentication/access-tokens | Generate an access token for user authentication.
*CardInfoLookupApi* | [**CardInfoLookup**](docs/CardInfoLookupApi.md#cardinfolookup) | **POST** /v1/card-information | Card information lookUp
*CardVerificationApi* | [**VerifyCard**](docs/CardVerificationApi.md#verifycard) | **POST** /v1/card-verification | Verify a payment card.
*CurrencyConversionApi* | [**GetExchangeRate**](docs/CurrencyConversionApi.md#getexchangerate) | **POST** /v1/exchange-rates | Generate dynamic currency conversion transactions
*FraudDetectApi* | [**ScoreOnly**](docs/FraudDetectApi.md#scoreonly) | **POST** /v1/fraud/score-only | Score a transaction for fraud.
*OrderApi* | [**OrderInquiry**](docs/OrderApi.md#orderinquiry) | **GET** /v1/orders/{order-id} | Retrieve the state of an order
*OrderApi* | [**OrderPostAuth**](docs/OrderApi.md#orderpostauth) | **POST** /v1/orders/{order-id}/postauth | Capture/complete an already existing order.
*OrderApi* | [**OrderReturnTransaction**](docs/OrderApi.md#orderreturntransaction) | **POST** /v1/orders/{order-id}/return | Return/refund an order.
*PaymentApi* | [**FinalizeSecureTransaction**](docs/PaymentApi.md#finalizesecuretransaction) | **PATCH** /v1/payments/{transaction-id} | Update a 3DSecure or UnionPay payment and continue processing.
*PaymentApi* | [**PerformPaymentPostAuthorisation**](docs/PaymentApi.md#performpaymentpostauthorisation) | **POST** /v1/payments/{transaction-id}/postauth | Capture/complete a transaction.
*PaymentApi* | [**PrimaryPaymentTransaction**](docs/PaymentApi.md#primarypaymenttransaction) | **POST** /v1/payments | Generate a primary transaction.
*PaymentApi* | [**ReturnTransaction**](docs/PaymentApi.md#returntransaction) | **POST** /v1/payments/{transaction-id}/return | Return/refund a transaction.
*PaymentApi* | [**TransactionInquiry**](docs/PaymentApi.md#transactioninquiry) | **GET** /v1/payments/{transaction-id} | Retrieve the state of a transaction.
*PaymentApi* | [**VoidTransaction**](docs/PaymentApi.md#voidtransaction) | **POST** /v1/payments/{transaction-id}/void | Reverse a previous action on an existing transaction.
*PaymentSchedulesApi* | [**CancelPaymentSchedule**](docs/PaymentSchedulesApi.md#cancelpaymentschedule) | **DELETE** /v1/payment-schedules/{order-id} | Cancel a gateway payment schedule.
*PaymentSchedulesApi* | [**CreatePaymentSchedule**](docs/PaymentSchedulesApi.md#createpaymentschedule) | **POST** /v1/payment-schedules | Use this to create a gateway payment schedule.
*PaymentSchedulesApi* | [**InquiryPaymentSchedule**](docs/PaymentSchedulesApi.md#inquirypaymentschedule) | **GET** /v1/payment-schedules/{order-id} | View a gateway payment schedule.
*PaymentSchedulesApi* | [**UpdatePaymentSchedule**](docs/PaymentSchedulesApi.md#updatepaymentschedule) | **PATCH** /v1/payment-schedules/{order-id} | Update a gateway payment schedule.
*PaymentTokenApi* | [**CreatePaymentToken**](docs/PaymentTokenApi.md#createpaymenttoken) | **POST** /v1/payment-tokens | Create a payment token from a payment card.
*PaymentTokenApi* | [**DeletePaymentToken**](docs/PaymentTokenApi.md#deletepaymenttoken) | **DELETE** /v1/payment-tokens/{token-id} | Delete a payment token.
*PaymentURLApi* | [**CreatePaymentUrl**](docs/PaymentURLApi.md#createpaymenturl) | **POST** /v1/payment-url | Create a payment URL.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Org.OpenAPITools.Model.AVSResponse](docs/AVSResponse.md)
 - [Org.OpenAPITools.Model.AccessTokenResponse](docs/AccessTokenResponse.md)
 - [Org.OpenAPITools.Model.AdditionalAmountRate](docs/AdditionalAmountRate.md)
 - [Org.OpenAPITools.Model.AdditionalTransactionDetails](docs/AdditionalTransactionDetails.md)
 - [Org.OpenAPITools.Model.Address](docs/Address.md)
 - [Org.OpenAPITools.Model.Airline](docs/Airline.md)
 - [Org.OpenAPITools.Model.AirlineAncillaryServiceCategory](docs/AirlineAncillaryServiceCategory.md)
 - [Org.OpenAPITools.Model.AirlineTravelRoute](docs/AirlineTravelRoute.md)
 - [Org.OpenAPITools.Model.AliPay](docs/AliPay.md)
 - [Org.OpenAPITools.Model.Amount](docs/Amount.md)
 - [Org.OpenAPITools.Model.AmountComponents](docs/AmountComponents.md)
 - [Org.OpenAPITools.Model.AuthenticationRequest](docs/AuthenticationRequest.md)
 - [Org.OpenAPITools.Model.AuthenticationResponseVerification](docs/AuthenticationResponseVerification.md)
 - [Org.OpenAPITools.Model.AuthenticationResponseVerificationRequest](docs/AuthenticationResponseVerificationRequest.md)
 - [Org.OpenAPITools.Model.BasicResponse](docs/BasicResponse.md)
 - [Org.OpenAPITools.Model.BasketItem](docs/BasketItem.md)
 - [Org.OpenAPITools.Model.Billing](docs/Billing.md)
 - [Org.OpenAPITools.Model.BillingAddress](docs/BillingAddress.md)
 - [Org.OpenAPITools.Model.BillingAddressPhone](docs/BillingAddressPhone.md)
 - [Org.OpenAPITools.Model.CarRental](docs/CarRental.md)
 - [Org.OpenAPITools.Model.CarRentalExtraCharges](docs/CarRentalExtraCharges.md)
 - [Org.OpenAPITools.Model.Card](docs/Card.md)
 - [Org.OpenAPITools.Model.CardInfo](docs/CardInfo.md)
 - [Org.OpenAPITools.Model.CardInfoLookupRequest](docs/CardInfoLookupRequest.md)
 - [Org.OpenAPITools.Model.CardInfoLookupResponse](docs/CardInfoLookupResponse.md)
 - [Org.OpenAPITools.Model.CardVerificationRequest](docs/CardVerificationRequest.md)
 - [Org.OpenAPITools.Model.CardVerificationsTransaction](docs/CardVerificationsTransaction.md)
 - [Org.OpenAPITools.Model.ChinaDomestic](docs/ChinaDomestic.md)
 - [Org.OpenAPITools.Model.ClientLocale](docs/ClientLocale.md)
 - [Org.OpenAPITools.Model.Contact](docs/Contact.md)
 - [Org.OpenAPITools.Model.Customer](docs/Customer.md)
 - [Org.OpenAPITools.Model.CustomerAddress](docs/CustomerAddress.md)
 - [Org.OpenAPITools.Model.CustomerAddressPhone](docs/CustomerAddressPhone.md)
 - [Org.OpenAPITools.Model.Dcc](docs/Dcc.md)
 - [Org.OpenAPITools.Model.Device](docs/Device.md)
 - [Org.OpenAPITools.Model.DeviceNetworks](docs/DeviceNetworks.md)
 - [Org.OpenAPITools.Model.Document](docs/Document.md)
 - [Org.OpenAPITools.Model.Error](docs/Error.md)
 - [Org.OpenAPITools.Model.ErrorDetails](docs/ErrorDetails.md)
 - [Org.OpenAPITools.Model.ErrorResponse](docs/ErrorResponse.md)
 - [Org.OpenAPITools.Model.ExchangeRateRequest](docs/ExchangeRateRequest.md)
 - [Org.OpenAPITools.Model.ExchangeRateResponse](docs/ExchangeRateResponse.md)
 - [Org.OpenAPITools.Model.Expiration](docs/Expiration.md)
 - [Org.OpenAPITools.Model.FraudOrder](docs/FraudOrder.md)
 - [Org.OpenAPITools.Model.FraudOrderItems](docs/FraudOrderItems.md)
 - [Org.OpenAPITools.Model.FraudOrderShipToAddress](docs/FraudOrderShipToAddress.md)
 - [Org.OpenAPITools.Model.Frequency](docs/Frequency.md)
 - [Org.OpenAPITools.Model.IndustrySpecificExtensions](docs/IndustrySpecificExtensions.md)
 - [Org.OpenAPITools.Model.InstallmentOptions](docs/InstallmentOptions.md)
 - [Org.OpenAPITools.Model.Lodging](docs/Lodging.md)
 - [Org.OpenAPITools.Model.LodgingExtraCharges](docs/LodgingExtraCharges.md)
 - [Org.OpenAPITools.Model.Loyalty](docs/Loyalty.md)
 - [Org.OpenAPITools.Model.Merchant](docs/Merchant.md)
 - [Org.OpenAPITools.Model.MerchantLocation](docs/MerchantLocation.md)
 - [Org.OpenAPITools.Model.MerchantLocationMerchantAddress](docs/MerchantLocationMerchantAddress.md)
 - [Org.OpenAPITools.Model.Order](docs/Order.md)
 - [Org.OpenAPITools.Model.OrderErrorResponse](docs/OrderErrorResponse.md)
 - [Org.OpenAPITools.Model.OrderResponse](docs/OrderResponse.md)
 - [Org.OpenAPITools.Model.PayPal](docs/PayPal.md)
 - [Org.OpenAPITools.Model.Payment](docs/Payment.md)
 - [Org.OpenAPITools.Model.PaymentCard](docs/PaymentCard.md)
 - [Org.OpenAPITools.Model.PaymentCardAuthenticationResult](docs/PaymentCardAuthenticationResult.md)
 - [Org.OpenAPITools.Model.PaymentFacilitator](docs/PaymentFacilitator.md)
 - [Org.OpenAPITools.Model.PaymentIssuerResponse](docs/PaymentIssuerResponse.md)
 - [Org.OpenAPITools.Model.PaymentMethod](docs/PaymentMethod.md)
 - [Org.OpenAPITools.Model.PaymentPayMethod](docs/PaymentPayMethod.md)
 - [Org.OpenAPITools.Model.PaymentSchedulesErrorResponse](docs/PaymentSchedulesErrorResponse.md)
 - [Org.OpenAPITools.Model.PaymentSchedulesRequest](docs/PaymentSchedulesRequest.md)
 - [Org.OpenAPITools.Model.PaymentSchedulesResponse](docs/PaymentSchedulesResponse.md)
 - [Org.OpenAPITools.Model.PaymentTokenization](docs/PaymentTokenization.md)
 - [Org.OpenAPITools.Model.PaymentTokenizationErrorResponse](docs/PaymentTokenizationErrorResponse.md)
 - [Org.OpenAPITools.Model.PaymentTokenizationRequest](docs/PaymentTokenizationRequest.md)
 - [Org.OpenAPITools.Model.PaymentTokenizationResponse](docs/PaymentTokenizationResponse.md)
 - [Org.OpenAPITools.Model.PaymentUrlErrorResponse](docs/PaymentUrlErrorResponse.md)
 - [Org.OpenAPITools.Model.PaymentUrlRequest](docs/PaymentUrlRequest.md)
 - [Org.OpenAPITools.Model.PaymentUrlResponse](docs/PaymentUrlResponse.md)
 - [Org.OpenAPITools.Model.PaymentVerification3ds](docs/PaymentVerification3ds.md)
 - [Org.OpenAPITools.Model.PaymentVerificationAvs](docs/PaymentVerificationAvs.md)
 - [Org.OpenAPITools.Model.PaymentVerificationCvv](docs/PaymentVerificationCvv.md)
 - [Org.OpenAPITools.Model.PrimaryTransaction](docs/PrimaryTransaction.md)
 - [Org.OpenAPITools.Model.PrimaryTransactionAdditionalDetails](docs/PrimaryTransactionAdditionalDetails.md)
 - [Org.OpenAPITools.Model.ProcessorData](docs/ProcessorData.md)
 - [Org.OpenAPITools.Model.PurchaseCards](docs/PurchaseCards.md)
 - [Org.OpenAPITools.Model.PurchaseCardsLevel2](docs/PurchaseCardsLevel2.md)
 - [Org.OpenAPITools.Model.PurchaseCardsLevel3](docs/PurchaseCardsLevel3.md)
 - [Org.OpenAPITools.Model.PurchaseCardsLevel3LineItems](docs/PurchaseCardsLevel3LineItems.md)
 - [Org.OpenAPITools.Model.RecurringPaymentDetails](docs/RecurringPaymentDetails.md)
 - [Org.OpenAPITools.Model.RecurringPaymentDetailsResponse](docs/RecurringPaymentDetailsResponse.md)
 - [Org.OpenAPITools.Model.ReferencedOrder](docs/ReferencedOrder.md)
 - [Org.OpenAPITools.Model.ResponseType](docs/ResponseType.md)
 - [Org.OpenAPITools.Model.ScoreOnlyRequest](docs/ScoreOnlyRequest.md)
 - [Org.OpenAPITools.Model.ScoreOnlyResponse](docs/ScoreOnlyResponse.md)
 - [Org.OpenAPITools.Model.ScoreOnlyResponseFraudScore](docs/ScoreOnlyResponseFraudScore.md)
 - [Org.OpenAPITools.Model.ScoreOnlyResponseFraudScoreExplanations](docs/ScoreOnlyResponseFraudScoreExplanations.md)
 - [Org.OpenAPITools.Model.SecondaryTransaction](docs/SecondaryTransaction.md)
 - [Org.OpenAPITools.Model.SecondaryTransactionAdditionalDetails](docs/SecondaryTransactionAdditionalDetails.md)
 - [Org.OpenAPITools.Model.Secure3dResponse](docs/Secure3dResponse.md)
 - [Org.OpenAPITools.Model.Sepa](docs/Sepa.md)
 - [Org.OpenAPITools.Model.SepaMandate](docs/SepaMandate.md)
 - [Org.OpenAPITools.Model.Shipping](docs/Shipping.md)
 - [Org.OpenAPITools.Model.SoftDescriptor](docs/SoftDescriptor.md)
 - [Org.OpenAPITools.Model.SplitShipment](docs/SplitShipment.md)
 - [Org.OpenAPITools.Model.StoredCredential](docs/StoredCredential.md)
 - [Org.OpenAPITools.Model.SubMerchantData](docs/SubMerchantData.md)
 - [Org.OpenAPITools.Model.Transaction](docs/Transaction.md)
 - [Org.OpenAPITools.Model.TransactionErrorResponse](docs/TransactionErrorResponse.md)
 - [Org.OpenAPITools.Model.TransactionOrigin](docs/TransactionOrigin.md)
 - [Org.OpenAPITools.Model.TransactionResponse](docs/TransactionResponse.md)
 - [Org.OpenAPITools.Model.TransactionType](docs/TransactionType.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

All endpoints do not require authorization.
