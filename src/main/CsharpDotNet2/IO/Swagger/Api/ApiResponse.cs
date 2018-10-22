using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    public class ApiResponse
    {
        public int StatusCode { get; }
        public IList<Parameter>  Headers { get; }
        public String JsonData { get => GetJsonData(); }
        public object Data;
        public TransactionResponse TransResp = null;
        public TransactionErrorResponse TransErrResp = null;
        public AccessTokenResponse TokenResp = null; 

        public ApiResponse(int _statusCode, TransactionResponse _data, IList<Parameter> _headers = null)
        {
            StatusCode = _statusCode;
            Headers = _headers;
            Data = _data;
        }

        public ApiResponse(int _statusCode, TransactionErrorResponse _data, IList<Parameter> _headers = null)
        {
            StatusCode = _statusCode;
            Headers = _headers;
            Data = _data;
        }

        public ApiResponse(int _statusCode, AccessTokenResponse _data, IList<Parameter> _headers = null)
        {
            StatusCode = _statusCode;
            Headers = _headers;
            Data = _data;
        }

        public Type ResponseType()
        {
            return Data.GetType();
        }

        public String GetJsonData()
        {
            if (Data.GetType() == typeof(TransactionResponse))
            {
                TransactionResponse resp = (TransactionResponse)Data;
                return resp.ToJson();
            }
            if (Data.GetType() == typeof(TransactionErrorResponse))
            {
                TransactionErrorResponse resp = (TransactionErrorResponse)Data;
                return resp.ToJson();
            }
            else
            {
                AccessTokenResponse resp = (AccessTokenResponse)Data;
                return resp.ToJson();
            }
        }

    }
}
