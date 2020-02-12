/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.9.1.20191223.002
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
    ///  Class for testing FraudDetectApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FraudDetectApiTests : IDisposable
    {
        private FraudDetectApi instance;

        public FraudDetectApiTests()
        {
            instance = new FraudDetectApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FraudDetectApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FraudDetectApi
            //Assert.IsType(typeof(FraudDetectApi), instance, "instance is a FraudDetectApi");
        }

        
        /// <summary>
        /// Test FraudClientRegistrationPost
        /// </summary>
        [Fact]
        public void FraudClientRegistrationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string clientRequestId = null;
            //string apiKey = null;
            //long timestamp = null;
            //ClientRegistration clientRegistration = null;
            //string messageSignature = null;
            //string region = null;
            //var response = instance.FraudClientRegistrationPost(contentType, clientRequestId, apiKey, timestamp, clientRegistration, messageSignature, region);
            //Assert.IsType<FraudRegistrationResponse> (response, "response is FraudRegistrationResponse");
        }
        
        /// <summary>
        /// Test FraudPaymentRegistrationPost
        /// </summary>
        [Fact]
        public void FraudPaymentRegistrationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string clientRequestId = null;
            //string apiKey = null;
            //long timestamp = null;
            //PaymentRegistration paymentRegistration = null;
            //string messageSignature = null;
            //string region = null;
            //var response = instance.FraudPaymentRegistrationPost(contentType, clientRequestId, apiKey, timestamp, paymentRegistration, messageSignature, region);
            //Assert.IsType<FraudRegistrationResponse> (response, "response is FraudRegistrationResponse");
        }
        
        /// <summary>
        /// Test ScoreOnly
        /// </summary>
        [Fact]
        public void ScoreOnlyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string clientRequestId = null;
            //string apiKey = null;
            //long timestamp = null;
            //ScoreOnlyRequest scoreOnlyRequest = null;
            //string messageSignature = null;
            //string region = null;
            //var response = instance.ScoreOnly(contentType, clientRequestId, apiKey, timestamp, scoreOnlyRequest, messageSignature, region);
            //Assert.IsType<ScoreOnlyResponse> (response, "response is ScoreOnlyResponse");
        }
        
    }

}
