using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Org.OpenAPITools.Model {

    [JsonConverter(typeof(StringEnumConverter))]

    public enum PaymentMethodType
    {
        /// <summary>
        /// Enum ALIPAY for "ALIPAY"
        /// </summary>
        [EnumMember(Value = "ALIPAY")]
        ALIPAY,

        /// <summary>
        /// Enum ALIPAY_PAYSECURE_US for "ALIPAY_PAYSECURE_US"
        /// </summary>
        [EnumMember(Value = "ALIPAY_PAYSECURE_US")]
        ALIPAY_PAYSECURE_US,

        /// <summary>
        /// Enum ALIPAY_DOMESTIC for "ALIPAY_DOMESTIC"
        /// </summary>
        [EnumMember(Value = "ALIPAY_DOMESTIC")]
        ALIPAY_DOMESTIC,

        /// <summary>
        /// Enum APM for "APM"
        /// </summary>
        [EnumMember(Value = "APM")]
        APM,

        /// <summary>
        /// Enum CUP_DOMESTIC for "CUP_DOMESTIC"
        /// </summary>
        [EnumMember(Value = "CUP_DOMESTIC")]
        CUP_DOMESTIC,

        /// <summary>
        /// Enum DEBITDE for "DEBITDE"
        /// </summary>
        [EnumMember(Value = "DEBITDE")]
        DEBITDE,

        /// <summary>
        /// Enum EMI for "EMI"
        /// </summary>
        [EnumMember(Value = "EMI")]
        EMI,

        /// <summary>
        /// Enum GIROPAY for "GIROPAY"
        /// </summary>
        [EnumMember(Value = "GIROPAY")]
        GIROPAY,

        ///   <summary>
        /// Enum IDEAL for "IDEAL"
        /// </summary>
        [EnumMember(Value = "IDEAL")]
        IDEAL,

        /// <summary>
        /// Enum INDIAWALLET for "INDIAWALLET"
        /// </summary>
        [EnumMember(Value = "INDIAWALLET")]
        INDIAWALLET,

        /// <summary>
        /// Enum KLARNA for "KLARNA"
        /// </summary>
        [EnumMember(Value = "KLARNA")]
        KLARNA,

        /// <summary>
        /// Enum NETBANKING for "NETBANKING"
        /// </summary>
        [EnumMember(Value = "NETBANKING")]
        NETBANKING,

        /// <summary>
        /// Enum PAYMENT_CARD for "PAYMENT_CARD"
        /// </summary>
        [EnumMember(Value = "PAYMENT_CARD")]
        PAYMENT_CARD,

        /// <summary>
        /// Enum PAYMENT_TOKEN for "PAYMENT_TOKEN"
        /// </summary>
        [EnumMember(Value = "PAYMENT_TOKEN")]
        PAYMENT_TOKEN,

        /// <summary>
        /// Enum PAYPAL for "PAYPAL"
        /// </summary>
        [EnumMember(Value = "PAYPAL")]
        PAYPAL,

        /// <summary>
        /// Enum SEPA for "SEPA"
        /// </summary>
        [EnumMember(Value = "SEPA")]
        SEPA,

        /// <summary>
        /// Enum SOFORT for "SOFORT"
        /// </summary>
        [EnumMember(Value = "SOFORT")]
        SOFORT,

        /// <summary>
        /// Enum WALLET for "WALLET"
        /// </summary>
        [EnumMember(Value = "WALLET")]
        WALLET,

        /// <summary>
        /// Enum WECHAT_DOMESTIC for "WECHAT_DOMESTIC"
        /// </summary>
        [EnumMember(Value = "WECHAT_DOMESTIC")]
        WECHAT_DOMESTIC

    }
}
