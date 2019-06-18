using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Org.OpenAPITools.Model {

    [JsonConverter(typeof(StringEnumConverter))]

    public enum TransactionOrigin
    {
        /// <summary>
        /// Enum ECOM for "ECOM"
        /// </summary>
        [EnumMember(Value = "ECOM")]
        ECOM,

        /// <summary>
        /// Enum MAIL for "MAIL"
        /// </summary>
        [EnumMember(Value = "MAIL")]
        MAIL,

        /// <summary>
        /// Enum PHONE for "PHONE"
        /// </summary>
        [EnumMember(Value = "PHONE")]
        PHONE,

        /// <summary>
        /// Enum RETAIL for "RETAIL"
        /// </summary>
        [EnumMember(Value = "RETAIL")]
        RETAIL

    }
}
