/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.3.0.20210608.001
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Net;

namespace Org.OpenAPITools.Client
{
    /// <summary>
    /// Provides a non-generic contract for the ApiResponse wrapper.
    /// </summary>
    public interface IApiResponse
    {
        /// <summary>
        /// The data type of <see cref="Content"/>
        /// </summary>
        Type ResponseType { get; }

        /// <summary>
        /// The content of this response
        /// </summary>
        Object Content { get; }

        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Gets or sets the HTTP headers
        /// </summary>
        /// <value>HTTP headers</value>
        Multimap<string, string> Headers { get; }

        /// <summary>
        /// Gets or sets any error text defined by the calling client.
        /// </summary>
        String ErrorText { get; set; }

        /// <summary>
        /// Gets or sets any cookies passed along on the response.
        /// </summary>
        List<Cookie> Cookies { get; set; }
    }

    /// <summary>
    /// API Response
    /// </summary>
    public class ApiResponse<T> : IApiResponse
    {
        #region Properties
        
        /// <summary>
        /// Gets or sets the status code (HTTP status code)
        /// </summary>
        /// <value>The status code.</value>
        public HttpStatusCode StatusCode { get; }

        /// <summary>
        /// Gets or sets the HTTP headers
        /// </summary>
        /// <value>HTTP headers</value>
        public Multimap<string, string> Headers { get; }

        /// <summary>
        /// Gets or sets the data (parsed HTTP body)
        /// </summary>
        /// <value>The data.</value>
        public T Data { get; }

        /// <summary>
        /// Gets or sets any error text defined by the calling client.
        /// </summary>
        public String ErrorText { get; set; }

        /// <summary>
        /// Gets or sets any cookies passed along on the response.
        /// </summary>
        public List<Cookie> Cookies { get; set; }

        /// <summary>
        /// The content of this response
        /// </summary>
        public Type ResponseType
        {
            get { return typeof(T); }
        }

        /// <summary>
        /// The data type of <see cref="Content"/>
        /// </summary>
        public object Content
        {
            get { return Data; }
        }
        
        #endregion Properties
        
        #region Constructors
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="headers">HTTP headers.</param>
        /// <param name="data">Data (parsed HTTP body)</param>
        public ApiResponse(HttpStatusCode statusCode, Multimap<string, string> headers, T data)
        {
            StatusCode = statusCode;
            Headers = headers;
            Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiResponse{T}" /> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="data">Data (parsed HTTP body)</param>
        public ApiResponse(HttpStatusCode statusCode, T data)
        {
            StatusCode = statusCode;
            Data = data;
        }

        #endregion Constructors
    }
}
