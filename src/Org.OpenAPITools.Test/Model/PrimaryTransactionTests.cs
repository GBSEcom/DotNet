/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.3.0.20210608.001
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing PrimaryTransaction
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PrimaryTransactionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PrimaryTransaction
        //private PrimaryTransaction instance;

        public PrimaryTransactionTests()
        {
            // TODO uncomment below to create an instance of PrimaryTransaction
            //instance = new PrimaryTransaction();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PrimaryTransaction
        /// </summary>
        [Fact]
        public void PrimaryTransactionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" PrimaryTransaction
            //Assert.IsInstanceOfType<PrimaryTransaction> (instance, "variable 'instance' is a PrimaryTransaction");
        }

        /// <summary>
        /// Test deserialize a AliPaySaleTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void AliPaySaleTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a AliPaySaleTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new AliPaySaleTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaypalCreditTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaypalCreditTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaypalCreditTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaypalCreditTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentDeviceSaleTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentDeviceSaleTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentDeviceSaleTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentDeviceSaleTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentDevicePreAuthTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentDevicePreAuthTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentDevicePreAuthTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentDevicePreAuthTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a AchSaleTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void AchSaleTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a AchSaleTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new AchSaleTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentCardPayerAuthTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentCardPayerAuthTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentCardPayerAuthTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentCardPayerAuthTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentTokenSaleTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentTokenSaleTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentTokenSaleTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentTokenSaleTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentCardForcedTicketTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentCardForcedTicketTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentCardForcedTicketTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentCardForcedTicketTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentCardSaleTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentCardSaleTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentCardSaleTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentCardSaleTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a AchPreAuthTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void AchPreAuthTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a AchPreAuthTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new AchPreAuthTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a WalletPreAuthTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void WalletPreAuthTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a WalletPreAuthTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new WalletPreAuthTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentDeviceDisbursementTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentDeviceDisbursementTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentDeviceDisbursementTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentDeviceDisbursementTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a ApmSaleTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void ApmSaleTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a ApmSaleTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new ApmSaleTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentTokenDisbursementTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentTokenDisbursementTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentTokenDisbursementTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentTokenDisbursementTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a SepaSaleTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void SepaSaleTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a SepaSaleTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new SepaSaleTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentDeviceCreditTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentDeviceCreditTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentDeviceCreditTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentDeviceCreditTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentCardCreditTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentCardCreditTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentCardCreditTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentCardCreditTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentTokenPreAuthTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentTokenPreAuthTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentTokenPreAuthTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentTokenPreAuthTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentTokenCreditTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentTokenCreditTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentTokenCreditTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentTokenCreditTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a AchCreditTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void AchCreditTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a AchCreditTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new AchCreditTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentCardDisbursementTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentCardDisbursementTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentCardDisbursementTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentCardDisbursementTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a PaymentCardPreAuthTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void PaymentCardPreAuthTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a PaymentCardPreAuthTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new PaymentCardPreAuthTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a SepaCreditTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void SepaCreditTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a SepaCreditTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new SepaCreditTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a WalletSaleTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void WalletSaleTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a WalletSaleTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new WalletSaleTransaction().ToJson()));
        }
        /// <summary>
        /// Test deserialize a ChinaPnRSaleTransaction from type PrimaryTransaction
        /// </summary>
        [Fact]
        public void ChinaPnRSaleTransactionDeserializeFromPrimaryTransactionTest()
        {
            // TODO uncomment below to test deserialize a ChinaPnRSaleTransaction from type PrimaryTransaction
            //Assert.IsInstanceOf<PrimaryTransaction>(JsonConvert.DeserializeObject<PrimaryTransaction>(new ChinaPnRSaleTransaction().ToJson()));
        }

        /// <summary>
        /// Test the property 'RequestType'
        /// </summary>
        [Fact]
        public void RequestTypeTest()
        {
            // TODO unit test for the property 'RequestType'
        }
        /// <summary>
        /// Test the property 'TransactionAmount'
        /// </summary>
        [Fact]
        public void TransactionAmountTest()
        {
            // TODO unit test for the property 'TransactionAmount'
        }
        /// <summary>
        /// Test the property 'StoreId'
        /// </summary>
        [Fact]
        public void StoreIdTest()
        {
            // TODO unit test for the property 'StoreId'
        }
        /// <summary>
        /// Test the property 'MerchantTransactionId'
        /// </summary>
        [Fact]
        public void MerchantTransactionIdTest()
        {
            // TODO unit test for the property 'MerchantTransactionId'
        }
        /// <summary>
        /// Test the property 'TransactionOrigin'
        /// </summary>
        [Fact]
        public void TransactionOriginTest()
        {
            // TODO unit test for the property 'TransactionOrigin'
        }
        /// <summary>
        /// Test the property 'Order'
        /// </summary>
        [Fact]
        public void OrderTest()
        {
            // TODO unit test for the property 'Order'
        }
        /// <summary>
        /// Test the property 'AllowPartialApproval'
        /// </summary>
        [Fact]
        public void AllowPartialApprovalTest()
        {
            // TODO unit test for the property 'AllowPartialApproval'
        }

    }

}
