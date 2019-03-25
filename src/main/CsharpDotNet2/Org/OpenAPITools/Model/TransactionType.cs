using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Org.OpenAPITools.Model {

    [JsonConverter(typeof(StringEnumConverter))]

    public enum TransactionType
    {

        ///   <summary>
        /// Enum Default for "Default"
        /// </summary>
        [EnumMember(Value = "Default")]
        Default,

        /// <summary>
        /// Enum SALE for "SALE"
        /// </summary>
        [EnumMember(Value = "SALE")]
        SALE,

        /// <summary>
        /// Enum PREAUTH for "PREAUTH"
        /// </summary>
        [EnumMember(Value = "PREAUTH")]
        PREAUTH,

        /// <summary>
        /// Enum CREDIT for "CREDIT"
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        CREDIT,

        /// <summary>
        /// Enum FORCED_TICKET for "FORCED_TICKET"
        /// </summary>
        [EnumMember(Value = "FORCED_TICKET")]
        FORCED_TICKET,

        /// <summary>
        /// Enum VOID for "VOID"
        /// </summary>
        [EnumMember(Value = "VOID")]
        VOID,

        /// <summary>
        /// Enum RETURN for "RETURN"
        /// </summary>
        [EnumMember(Value = "RETURN")]
        RETURN,

        /// <summary>
        /// Enum POSTAUTH for "POSTAUTH"
        /// </summary>
        [EnumMember(Value = "POSTAUTH")]
        POSTAUTH,

        /// <summary>
        /// Enum PAYER_AUTH for "PAYER_AUTH"
        /// </summary>
        [EnumMember(Value = "PAYER_AUTH")]
        PAYER_AUTH

    }

}
