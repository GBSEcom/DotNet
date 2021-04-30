/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.2.0.20210406.001
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
    ///  Class for testing InformationLookupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InformationLookupApiTests : IDisposable
    {
        private InformationLookupApi instance;

        public InformationLookupApiTests()
        {
            instance = new InformationLookupApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InformationLookupApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' InformationLookupApi
            //Assert.IsType(typeof(InformationLookupApi), instance, "instance is a InformationLookupApi");
        }

        
        /// <summary>
        /// Test CardInfoLookup
        /// </summary>
        [Fact]
        public void CardInfoLookupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string clientRequestId = null;
            //string apiKey = null;
            //long timestamp = null;
            //CardInfoLookupRequest cardInfoLookupRequest = null;
            //string messageSignature = null;
            //string region = null;
            //var response = instance.CardInfoLookup(contentType, clientRequestId, apiKey, timestamp, cardInfoLookupRequest, messageSignature, region);
            //Assert.IsType<CardInfoLookupResponse> (response, "response is CardInfoLookupResponse");
        }
        
        /// <summary>
        /// Test LookupAccount
        /// </summary>
        [Fact]
        public void LookupAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //string clientRequestId = null;
            //string apiKey = null;
            //long timestamp = null;
            //AccountInfoLookupRequest accountInfoLookupRequest = null;
            //string messageSignature = null;
            //string region = null;
            //var response = instance.LookupAccount(contentType, clientRequestId, apiKey, timestamp, accountInfoLookupRequest, messageSignature, region);
            //Assert.IsType<CardInfoLookupResponse> (response, "response is CardInfoLookupResponse");
        }
        
    }

}