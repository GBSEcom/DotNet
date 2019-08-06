/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.6.0.20190507.002
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing PaymentTokenApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PaymentTokenApiTests : IDisposable
    {
        private PaymentTokenApi instance;

        public PaymentTokenApiTests()
        {
            instance = new PaymentTokenApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PaymentTokenApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PaymentTokenApi
            //Assert.IsType(typeof(PaymentTokenApi), instance, "instance is a PaymentTokenApi");
        }

        
        /// <summary>
        /// Test CreatePaymentToken
        /// </summary>
        [Fact]
        public void CreatePaymentTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string clientRequestId = null;
            //string apiKey = null;
            //long timestamp = null;
            //PaymentTokenizationRequest paymentTokenizationRequest = null;
            //string messageSignature = null;
            //string authorization = null;
            //string region = null;
            //var response = instance.CreatePaymentToken(contentType, clientRequestId, apiKey, timestamp, paymentTokenizationRequest, messageSignature, authorization, region);
            //Assert.IsType<PaymentTokenizationResponse> (response, "response is PaymentTokenizationResponse");
        }
        
        /// <summary>
        /// Test DeletePaymentToken
        /// </summary>
        [Fact]
        public void DeletePaymentTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string clientRequestId = null;
            //string apiKey = null;
            //long timestamp = null;
            //string tokenId = null;
            //string messageSignature = null;
            //string authorization = null;
            //string region = null;
            //string storeId = null;
            //var response = instance.DeletePaymentToken(contentType, clientRequestId, apiKey, timestamp, tokenId, messageSignature, authorization, region, storeId);
            //Assert.IsType<PaymentTokenizationResponse> (response, "response is PaymentTokenizationResponse");
        }
        
    }

}