using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Org.OpenAPITools.Model {

    [JsonConverter(typeof(StringEnumConverter))]

    public enum CardFunction
    {
        /// <summary>
        /// Enum CREDIT for "CREDIT"
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        CREDIT,

        /// <summary>
        /// Enum DEBIT for "DEBIT"
        /// </summary>
        [EnumMember(Value = "DEBIT")]
        DEBIT,

        /// <summary>
        /// Enum PREPAID for "PREPAID"
        /// </summary>
        [EnumMember(Value = "PREPAID")]
        PREPAID,

        /// <summary>
        /// Enum VOUCHER for "VOUCHER"
        /// </summary>
        [EnumMember(Value = "VOUCHER")]
        VOUCHER,

        /// <summary>
        /// Enum UNDEFINED for "UNDEFINED"
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        UNDEFINED
    }
}

