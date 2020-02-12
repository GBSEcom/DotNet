using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public IList<Parameter> Headers { get; set; }
        public String JsonData { get => GetJsonData(); }
        public object Data;

        public ApiResponse(int _statusCode, TransactionResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }

        public ApiResponse(int _statusCode, ErrorResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }

        public ApiResponse(int _statusCode, TransactionErrorResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }

        public ApiResponse(int _statusCode, AccessTokenResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }

        public ApiResponse(int _statusCode, OrderResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }

        public ApiResponse(int _statusCode, PaymentSchedulesResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }

        public ApiResponse(int _statusCode, PaymentSchedulesErrorResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }

        public ApiResponse(int _statusCode, RecurringPaymentDetailsResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }

        public ApiResponse(int _statusCode, ScoreOnlyResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }

        public ApiResponse(int _statusCode, PaymentUrlResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }

        public ApiResponse(int _statusCode, PaymentTokenizationResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }

        public ApiResponse(int _statusCode, ExchangeRateResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }
        public ApiResponse(int _statusCode, CardInfoLookupResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }
        public ApiResponse(int _statusCode, FraudRegistrationResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }
        public ApiResponse(int _statusCode, PaymentUrlDetailResponse _data, IList<Parameter> _headers = null)
        {
            SetData(_statusCode, _data, _headers);
        }
        private void SetData(int _statusCode, object _data, IList<Parameter> _headers = null)
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
            if (Data.GetType() == typeof(ErrorResponse))
            {
                ErrorResponse resp = (ErrorResponse)Data;
                return resp.ToJson();
            }
            if (Data.GetType() == typeof(TransactionErrorResponse))
            {
                TransactionErrorResponse resp = (TransactionErrorResponse)Data;
                return resp.ToJson();
            }
            if (Data.GetType() == typeof(OrderResponse))
            {
                OrderResponse resp = (OrderResponse)Data;
                return resp.ToJson();
            }
            if (Data.GetType() == typeof(PaymentSchedulesResponse))
            {
                PaymentSchedulesResponse resp = (PaymentSchedulesResponse)Data;
                return resp.ToJson();
            }
            if (Data.GetType() == typeof(PaymentSchedulesErrorResponse))
            {
                PaymentSchedulesErrorResponse resp = (PaymentSchedulesErrorResponse)Data;
                return resp.ToJson();
            }
            if (Data.GetType() == typeof(RecurringPaymentDetailsResponse))
            {
                RecurringPaymentDetailsResponse resp = (RecurringPaymentDetailsResponse)Data;
                return resp.ToJson();
            }
            if (Data.GetType() == typeof(ScoreOnlyResponse))
            {
                ScoreOnlyResponse resp = (ScoreOnlyResponse)Data;
                return resp.ToJson();
            }
            if (Data.GetType() == typeof(PaymentUrlResponse))
            {
                PaymentUrlResponse resp = (PaymentUrlResponse)Data;
                return resp.ToJson();
            }
            if (Data.GetType() == typeof(PaymentTokenizationResponse))
            {
                PaymentTokenizationResponse resp = (PaymentTokenizationResponse)Data;
                return resp.ToJson();
            }
            if (Data.GetType() == typeof(ExchangeRateResponse))
            {
                ExchangeRateResponse resp = (ExchangeRateResponse)Data;
                return resp.ToJson();
            }
            if (Data.GetType() == typeof(CardInfoLookupResponse))
            {
                CardInfoLookupResponse response = (CardInfoLookupResponse)Data;
                return response.ToJson();
            }
            if (Data.GetType() == typeof(FraudRegistrationResponse))
            {
                FraudRegistrationResponse response = (FraudRegistrationResponse)Data;
                return response.ToJson();
            }
            if (Data.GetType() == typeof(PaymentUrlDetailResponse))
            {
                PaymentUrlDetailResponse response = (PaymentUrlDetailResponse)Data;
                return response.ToJson();
            }
            else
            {
                AccessTokenResponse resp = (AccessTokenResponse)Data;
                return resp.ToJson();
            }
        }

    }
}
