# FirstApiClient C# library

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 2.0

<a name="dependencies"></a>
## Dependencies
- Mono compiler
- Newtonsoft.Json.11.0.2
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
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://cert.api.firstdata.com/gateway/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**AuthenticationAccessTokensPost**](docs/AuthenticationApi.md#authenticationaccesstokenspost) | **POST** /authentication/access-tokens | Generate an access token for user authentication.
*CardInfoLookupApi* | [**CardInfoLookup**](docs/CardInfoLookupApi.md#cardinfolookup) | **POST** /card-information | Card information lookup.
*CardVerificationApi* | [**VerifyCard**](docs/CardVerificationApi.md#verifycard) | **POST** /card-verification | Verify a payment card.
*CurrencyConversionApi* | [**GetExchangeRate**](docs/CurrencyConversionApi.md#getexchangerate) | **POST** /exchange-rates | Generate dynamic currency conversion transactions.
*FraudDetectApi* | [**ScoreOnly**](docs/FraudDetectApi.md#scoreonly) | **POST** /fraud/score-only | Score a transaction for fraud.
*OrderApi* | [**OrderInquiry**](docs/OrderApi.md#orderinquiry) | **GET** /orders/{order-id} | Retrieve the state of an order.
*OrderApi* | [**SubmitSecondaryTransactionFromOrder**](docs/OrderApi.md#submitsecondarytransactionfromorder) | **POST** /orders/{order-id} | Perform return or postAuth secondary transactions.
*PaymentApi* | [**FinalizeSecureTransaction**](docs/PaymentApi.md#finalizesecuretransaction) | **PATCH** /payments/{transaction-id} | Update a 3DSecure or UnionPay payment and continue processing.
*PaymentApi* | [**SubmitPrimaryTransaction**](docs/PaymentApi.md#submitprimarytransaction) | **POST** /payments | Generate a primary transaction.
*PaymentApi* | [**SubmitSecondaryTransaction**](docs/PaymentApi.md#submitsecondarytransaction) | **POST** /payments/{transaction-id} | Perform a secondary transaction.
*PaymentApi* | [**TransactionInquiry**](docs/PaymentApi.md#transactioninquiry) | **GET** /payments/{transaction-id} | Retrieve the state of a transaction.
*PaymentSchedulesApi* | [**CancelPaymentSchedule**](docs/PaymentSchedulesApi.md#cancelpaymentschedule) | **DELETE** /payment-schedules/{order-id} | Cancel a gateway payment schedule.
*PaymentSchedulesApi* | [**CreatePaymentSchedule**](docs/PaymentSchedulesApi.md#createpaymentschedule) | **POST** /payment-schedules | Create gateway payment schedule.
*PaymentSchedulesApi* | [**InquiryPaymentSchedule**](docs/PaymentSchedulesApi.md#inquirypaymentschedule) | **GET** /payment-schedules/{order-id} | View a gateway payment schedule.
*PaymentSchedulesApi* | [**UpdatePaymentSchedule**](docs/PaymentSchedulesApi.md#updatepaymentschedule) | **PATCH** /payment-schedules/{order-id} | Update a gateway payment schedule.
*PaymentTokenApi* | [**CreatePaymentToken**](docs/PaymentTokenApi.md#createpaymenttoken) | **POST** /payment-tokens | Create a payment token from a payment card.
*PaymentTokenApi* | [**DeletePaymentToken**](docs/PaymentTokenApi.md#deletepaymenttoken) | **DELETE** /payment-tokens/{token-id} | Delete a payment token.
*PaymentURLApi* | [**CreatePaymentUrl**](docs/PaymentURLApi.md#createpaymenturl) | **POST** /payment-url | Create a payment URL.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Org.OpenAPITools.Model.AVSResponse](docs/AVSResponse.md)
 - [Org.OpenAPITools.Model.AccessTokenResponse](docs/AccessTokenResponse.md)
 - [Org.OpenAPITools.Model.AccountUpdaterResponse](docs/AccountUpdaterResponse.md)
 - [Org.OpenAPITools.Model.AdditionalAmountRate](docs/AdditionalAmountRate.md)
 - [Org.OpenAPITools.Model.AdditionalDetails](docs/AdditionalDetails.md)
 - [Org.OpenAPITools.Model.AdditionalTransactionDetails](docs/AdditionalTransactionDetails.md)
 - [Org.OpenAPITools.Model.Address](docs/Address.md)
 - [Org.OpenAPITools.Model.Airline](docs/Airline.md)
 - [Org.OpenAPITools.Model.AirlineAncillaryServiceCategory](docs/AirlineAncillaryServiceCategory.md)
 - [Org.OpenAPITools.Model.AirlineTravelRoute](docs/AirlineTravelRoute.md)
 - [Org.OpenAPITools.Model.AliPay](docs/AliPay.md)
 - [Org.OpenAPITools.Model.AliPayPaymentMethod](docs/AliPayPaymentMethod.md)
 - [Org.OpenAPITools.Model.AliPayPaymentMethodAllOf](docs/AliPayPaymentMethodAllOf.md)
 - [Org.OpenAPITools.Model.AliPaySaleTransaction](docs/AliPaySaleTransaction.md)
 - [Org.OpenAPITools.Model.AliPaySaleTransactionAllOf](docs/AliPaySaleTransactionAllOf.md)
 - [Org.OpenAPITools.Model.Amount](docs/Amount.md)
 - [Org.OpenAPITools.Model.AmountComponents](docs/AmountComponents.md)
 - [Org.OpenAPITools.Model.Authentication](docs/Authentication.md)
 - [Org.OpenAPITools.Model.AuthenticationRedirect](docs/AuthenticationRedirect.md)
 - [Org.OpenAPITools.Model.AuthenticationRedirectParams](docs/AuthenticationRedirectParams.md)
 - [Org.OpenAPITools.Model.AuthenticationVerificationRequest](docs/AuthenticationVerificationRequest.md)
 - [Org.OpenAPITools.Model.BasicResponse](docs/BasicResponse.md)
 - [Org.OpenAPITools.Model.Billing](docs/Billing.md)
 - [Org.OpenAPITools.Model.BillingAddress](docs/BillingAddress.md)
 - [Org.OpenAPITools.Model.BillingAddressPhone](docs/BillingAddressPhone.md)
 - [Org.OpenAPITools.Model.CarRental](docs/CarRental.md)
 - [Org.OpenAPITools.Model.CarRentalExtraCharges](docs/CarRentalExtraCharges.md)
 - [Org.OpenAPITools.Model.Card](docs/Card.md)
 - [Org.OpenAPITools.Model.CardFunction](docs/CardFunction.md)
 - [Org.OpenAPITools.Model.CardInfo](docs/CardInfo.md)
 - [Org.OpenAPITools.Model.CardInfoLookupRequest](docs/CardInfoLookupRequest.md)
 - [Org.OpenAPITools.Model.CardInfoLookupResponse](docs/CardInfoLookupResponse.md)
 - [Org.OpenAPITools.Model.CardVerificationRequest](docs/CardVerificationRequest.md)
 - [Org.OpenAPITools.Model.ChinaDomestic](docs/ChinaDomestic.md)
 - [Org.OpenAPITools.Model.ChinaDomesticPaymentMethod](docs/ChinaDomesticPaymentMethod.md)
 - [Org.OpenAPITools.Model.ChinaDomesticPaymentMethodAllOf](docs/ChinaDomesticPaymentMethodAllOf.md)
 - [Org.OpenAPITools.Model.ChinaPnRSaleTransaction](docs/ChinaPnRSaleTransaction.md)
 - [Org.OpenAPITools.Model.ChinaPnRSaleTransactionAllOf](docs/ChinaPnRSaleTransactionAllOf.md)
 - [Org.OpenAPITools.Model.ClientLocale](docs/ClientLocale.md)
 - [Org.OpenAPITools.Model.Contact](docs/Contact.md)
 - [Org.OpenAPITools.Model.CreatePaymentToken](docs/CreatePaymentToken.md)
 - [Org.OpenAPITools.Model.CurrencyConversion](docs/CurrencyConversion.md)
 - [Org.OpenAPITools.Model.Customer](docs/Customer.md)
 - [Org.OpenAPITools.Model.CustomerAddress](docs/CustomerAddress.md)
 - [Org.OpenAPITools.Model.CustomerAddressPhone](docs/CustomerAddressPhone.md)
 - [Org.OpenAPITools.Model.DCCExchangeRateRequest](docs/DCCExchangeRateRequest.md)
 - [Org.OpenAPITools.Model.DCCExchangeRateRequestAllOf](docs/DCCExchangeRateRequestAllOf.md)
 - [Org.OpenAPITools.Model.Dcc](docs/Dcc.md)
 - [Org.OpenAPITools.Model.DccAllOf](docs/DccAllOf.md)
 - [Org.OpenAPITools.Model.Device](docs/Device.md)
 - [Org.OpenAPITools.Model.DeviceNetworks](docs/DeviceNetworks.md)
 - [Org.OpenAPITools.Model.Document](docs/Document.md)
 - [Org.OpenAPITools.Model.DynamicPricing](docs/DynamicPricing.md)
 - [Org.OpenAPITools.Model.DynamicPricingAllOf](docs/DynamicPricingAllOf.md)
 - [Org.OpenAPITools.Model.DynamicPricingExchangeRateRequest](docs/DynamicPricingExchangeRateRequest.md)
 - [Org.OpenAPITools.Model.DynamicPricingExchangeRateRequestAllOf](docs/DynamicPricingExchangeRateRequestAllOf.md)
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
 - [Org.OpenAPITools.Model.PayPalPaymentMethod](docs/PayPalPaymentMethod.md)
 - [Org.OpenAPITools.Model.PayPalPaymentMethodAllOf](docs/PayPalPaymentMethodAllOf.md)
 - [Org.OpenAPITools.Model.Payment](docs/Payment.md)
 - [Org.OpenAPITools.Model.PaymentCard](docs/PaymentCard.md)
 - [Org.OpenAPITools.Model.PaymentCardCreditTransaction](docs/PaymentCardCreditTransaction.md)
 - [Org.OpenAPITools.Model.PaymentCardForcedTicketTransaction](docs/PaymentCardForcedTicketTransaction.md)
 - [Org.OpenAPITools.Model.PaymentCardForcedTicketTransactionAllOf](docs/PaymentCardForcedTicketTransactionAllOf.md)
 - [Org.OpenAPITools.Model.PaymentCardPayerAuthTransaction](docs/PaymentCardPayerAuthTransaction.md)
 - [Org.OpenAPITools.Model.PaymentCardPayerAuthTransactionAllOf](docs/PaymentCardPayerAuthTransactionAllOf.md)
 - [Org.OpenAPITools.Model.PaymentCardPaymentMethod](docs/PaymentCardPaymentMethod.md)
 - [Org.OpenAPITools.Model.PaymentCardPaymentMethodAllOf](docs/PaymentCardPaymentMethodAllOf.md)
 - [Org.OpenAPITools.Model.PaymentCardPaymentTokenizationRequest](docs/PaymentCardPaymentTokenizationRequest.md)
 - [Org.OpenAPITools.Model.PaymentCardPaymentTokenizationRequestAllOf](docs/PaymentCardPaymentTokenizationRequestAllOf.md)
 - [Org.OpenAPITools.Model.PaymentCardPreAuthTransaction](docs/PaymentCardPreAuthTransaction.md)
 - [Org.OpenAPITools.Model.PaymentCardPreAuthTransactionAllOf](docs/PaymentCardPreAuthTransactionAllOf.md)
 - [Org.OpenAPITools.Model.PaymentCardSaleTransaction](docs/PaymentCardSaleTransaction.md)
 - [Org.OpenAPITools.Model.PaymentCardSaleTransactionAllOf](docs/PaymentCardSaleTransactionAllOf.md)
 - [Org.OpenAPITools.Model.PaymentFacilitator](docs/PaymentFacilitator.md)
 - [Org.OpenAPITools.Model.PaymentIssuerResponse](docs/PaymentIssuerResponse.md)
 - [Org.OpenAPITools.Model.PaymentMethodDetails](docs/PaymentMethodDetails.md)
 - [Org.OpenAPITools.Model.PaymentMethodPaymentSchedulesRequest](docs/PaymentMethodPaymentSchedulesRequest.md)
 - [Org.OpenAPITools.Model.PaymentMethodPaymentSchedulesRequestAllOf](docs/PaymentMethodPaymentSchedulesRequestAllOf.md)
 - [Org.OpenAPITools.Model.PaymentMethodType](docs/PaymentMethodType.md)
 - [Org.OpenAPITools.Model.PaymentPayMethod](docs/PaymentPayMethod.md)
 - [Org.OpenAPITools.Model.PaymentSchedulesErrorResponse](docs/PaymentSchedulesErrorResponse.md)
 - [Org.OpenAPITools.Model.PaymentSchedulesRequest](docs/PaymentSchedulesRequest.md)
 - [Org.OpenAPITools.Model.PaymentSchedulesResponse](docs/PaymentSchedulesResponse.md)
 - [Org.OpenAPITools.Model.PaymentTokenCreditTransaction](docs/PaymentTokenCreditTransaction.md)
 - [Org.OpenAPITools.Model.PaymentTokenCreditTransactionAllOf](docs/PaymentTokenCreditTransactionAllOf.md)
 - [Org.OpenAPITools.Model.PaymentTokenDetails](docs/PaymentTokenDetails.md)
 - [Org.OpenAPITools.Model.PaymentTokenDetailsAllOf](docs/PaymentTokenDetailsAllOf.md)
 - [Org.OpenAPITools.Model.PaymentTokenPaymentMethod](docs/PaymentTokenPaymentMethod.md)
 - [Org.OpenAPITools.Model.PaymentTokenPaymentMethodAllOf](docs/PaymentTokenPaymentMethodAllOf.md)
 - [Org.OpenAPITools.Model.PaymentTokenPreAuthTransaction](docs/PaymentTokenPreAuthTransaction.md)
 - [Org.OpenAPITools.Model.PaymentTokenPreAuthTransactionAllOf](docs/PaymentTokenPreAuthTransactionAllOf.md)
 - [Org.OpenAPITools.Model.PaymentTokenSaleTransaction](docs/PaymentTokenSaleTransaction.md)
 - [Org.OpenAPITools.Model.PaymentTokenSaleTransactionAllOf](docs/PaymentTokenSaleTransactionAllOf.md)
 - [Org.OpenAPITools.Model.PaymentTokenizationErrorResponse](docs/PaymentTokenizationErrorResponse.md)
 - [Org.OpenAPITools.Model.PaymentTokenizationRequest](docs/PaymentTokenizationRequest.md)
 - [Org.OpenAPITools.Model.PaymentTokenizationResponse](docs/PaymentTokenizationResponse.md)
 - [Org.OpenAPITools.Model.PaymentUrlErrorResponse](docs/PaymentUrlErrorResponse.md)
 - [Org.OpenAPITools.Model.PaymentUrlRequest](docs/PaymentUrlRequest.md)
 - [Org.OpenAPITools.Model.PaymentUrlResponse](docs/PaymentUrlResponse.md)
 - [Org.OpenAPITools.Model.PaymentVerification3ds](docs/PaymentVerification3ds.md)
 - [Org.OpenAPITools.Model.PaymentVerificationAvs](docs/PaymentVerificationAvs.md)
 - [Org.OpenAPITools.Model.PaymentVerificationCvv](docs/PaymentVerificationCvv.md)
 - [Org.OpenAPITools.Model.PaypalCreditTransaction](docs/PaypalCreditTransaction.md)
 - [Org.OpenAPITools.Model.PaypalCreditTransactionAllOf](docs/PaypalCreditTransactionAllOf.md)
 - [Org.OpenAPITools.Model.PostAuthTransaction](docs/PostAuthTransaction.md)
 - [Org.OpenAPITools.Model.PostAuthTransactionAllOf](docs/PostAuthTransactionAllOf.md)
 - [Org.OpenAPITools.Model.PrimaryTransaction](docs/PrimaryTransaction.md)
 - [Org.OpenAPITools.Model.ProcessorData](docs/ProcessorData.md)
 - [Org.OpenAPITools.Model.PurchaseCards](docs/PurchaseCards.md)
 - [Org.OpenAPITools.Model.PurchaseCardsLevel2](docs/PurchaseCardsLevel2.md)
 - [Org.OpenAPITools.Model.PurchaseCardsLevel3](docs/PurchaseCardsLevel3.md)
 - [Org.OpenAPITools.Model.PurchaseCardsLevel3LineItems](docs/PurchaseCardsLevel3LineItems.md)
 - [Org.OpenAPITools.Model.RecurringPaymentDetails](docs/RecurringPaymentDetails.md)
 - [Org.OpenAPITools.Model.RecurringPaymentDetailsResponse](docs/RecurringPaymentDetailsResponse.md)
 - [Org.OpenAPITools.Model.ReferencedOrderPaymentSchedulesRequest](docs/ReferencedOrderPaymentSchedulesRequest.md)
 - [Org.OpenAPITools.Model.ReferencedOrderPaymentSchedulesRequestAllOf](docs/ReferencedOrderPaymentSchedulesRequestAllOf.md)
 - [Org.OpenAPITools.Model.ReferencedOrderPaymentTokenizationRequest](docs/ReferencedOrderPaymentTokenizationRequest.md)
 - [Org.OpenAPITools.Model.ReferencedOrderPaymentTokenizationRequestAllOf](docs/ReferencedOrderPaymentTokenizationRequestAllOf.md)
 - [Org.OpenAPITools.Model.ResponseAmountComponents](docs/ResponseAmountComponents.md)
 - [Org.OpenAPITools.Model.ResponseAmountComponentsAllOf](docs/ResponseAmountComponentsAllOf.md)
 - [Org.OpenAPITools.Model.ResponseType](docs/ResponseType.md)
 - [Org.OpenAPITools.Model.ReturnTransaction](docs/ReturnTransaction.md)
 - [Org.OpenAPITools.Model.ReturnTransactionAllOf](docs/ReturnTransactionAllOf.md)
 - [Org.OpenAPITools.Model.ScoreOnlyRequest](docs/ScoreOnlyRequest.md)
 - [Org.OpenAPITools.Model.ScoreOnlyResponse](docs/ScoreOnlyResponse.md)
 - [Org.OpenAPITools.Model.ScoreOnlyResponseFraudScore](docs/ScoreOnlyResponseFraudScore.md)
 - [Org.OpenAPITools.Model.ScoreOnlyResponseFraudScoreExplanations](docs/ScoreOnlyResponseFraudScoreExplanations.md)
 - [Org.OpenAPITools.Model.SecondaryTransaction](docs/SecondaryTransaction.md)
 - [Org.OpenAPITools.Model.Secure3dAuthenticationRequest](docs/Secure3dAuthenticationRequest.md)
 - [Org.OpenAPITools.Model.Secure3dAuthenticationResult](docs/Secure3dAuthenticationResult.md)
 - [Org.OpenAPITools.Model.Secure3dAuthenticationResultAllOf](docs/Secure3dAuthenticationResultAllOf.md)
 - [Org.OpenAPITools.Model.Secure3dAuthenticationVerificationRequest](docs/Secure3dAuthenticationVerificationRequest.md)
 - [Org.OpenAPITools.Model.Secure3dAuthenticationVerificationRequestAllOf](docs/Secure3dAuthenticationVerificationRequestAllOf.md)
 - [Org.OpenAPITools.Model.Secure3dResponse](docs/Secure3dResponse.md)
 - [Org.OpenAPITools.Model.Sepa](docs/Sepa.md)
 - [Org.OpenAPITools.Model.SepaMandate](docs/SepaMandate.md)
 - [Org.OpenAPITools.Model.SepaPaymentMethod](docs/SepaPaymentMethod.md)
 - [Org.OpenAPITools.Model.SepaPaymentMethodAllOf](docs/SepaPaymentMethodAllOf.md)
 - [Org.OpenAPITools.Model.SepaSaleTransaction](docs/SepaSaleTransaction.md)
 - [Org.OpenAPITools.Model.SepaSaleTransactionAllOf](docs/SepaSaleTransactionAllOf.md)
 - [Org.OpenAPITools.Model.Shipping](docs/Shipping.md)
 - [Org.OpenAPITools.Model.SoftDescriptor](docs/SoftDescriptor.md)
 - [Org.OpenAPITools.Model.SplitShipment](docs/SplitShipment.md)
 - [Org.OpenAPITools.Model.StoredCredential](docs/StoredCredential.md)
 - [Org.OpenAPITools.Model.SubMerchantData](docs/SubMerchantData.md)
 - [Org.OpenAPITools.Model.SubMerchantSplit](docs/SubMerchantSplit.md)
 - [Org.OpenAPITools.Model.Transaction](docs/Transaction.md)
 - [Org.OpenAPITools.Model.TransactionErrorResponse](docs/TransactionErrorResponse.md)
 - [Org.OpenAPITools.Model.TransactionOrigin](docs/TransactionOrigin.md)
 - [Org.OpenAPITools.Model.TransactionResponse](docs/TransactionResponse.md)
 - [Org.OpenAPITools.Model.TransactionType](docs/TransactionType.md)
 - [Org.OpenAPITools.Model.UnionPayAuthenticationRequest](docs/UnionPayAuthenticationRequest.md)
 - [Org.OpenAPITools.Model.UnionPayAuthenticationRequestAllOf](docs/UnionPayAuthenticationRequestAllOf.md)
 - [Org.OpenAPITools.Model.UnionPayAuthenticationVerificationRequest](docs/UnionPayAuthenticationVerificationRequest.md)
 - [Org.OpenAPITools.Model.UnionPayAuthenticationVerificationRequestAllOf](docs/UnionPayAuthenticationVerificationRequestAllOf.md)
 - [Org.OpenAPITools.Model.UsePaymentToken](docs/UsePaymentToken.md)
 - [Org.OpenAPITools.Model.VoidTransaction](docs/VoidTransaction.md)
