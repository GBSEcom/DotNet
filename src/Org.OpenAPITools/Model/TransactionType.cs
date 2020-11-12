/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.14.0.20201015.001
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Type of transaction to perform. Primary transaction types in requests include &#39;SALE&#39;, &#39;PREAUTH&#39;, &#39;CREDIT&#39; and &#39;FORCED_TICKET&#39;.
    /// </summary>
    /// <value>Type of transaction to perform. Primary transaction types in requests include &#39;SALE&#39;, &#39;PREAUTH&#39;, &#39;CREDIT&#39; and &#39;FORCED_TICKET&#39;.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TransactionType
    {
        /// <summary>
        /// Enum SALE for value: SALE
        /// </summary>
        [EnumMember(Value = "SALE")]
        SALE = 1,

        /// <summary>
        /// Enum PREAUTH for value: PREAUTH
        /// </summary>
        [EnumMember(Value = "PREAUTH")]
        PREAUTH = 2,

        /// <summary>
        /// Enum CREDIT for value: CREDIT
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        CREDIT = 3,

        /// <summary>
        /// Enum FORCEDTICKET for value: FORCED_TICKET
        /// </summary>
        [EnumMember(Value = "FORCED_TICKET")]
        FORCEDTICKET = 4,

        /// <summary>
        /// Enum VOID for value: VOID
        /// </summary>
        [EnumMember(Value = "VOID")]
        VOID = 5,

        /// <summary>
        /// Enum RETURN for value: RETURN
        /// </summary>
        [EnumMember(Value = "RETURN")]
        RETURN = 6,

        /// <summary>
        /// Enum POSTAUTH for value: POSTAUTH
        /// </summary>
        [EnumMember(Value = "POSTAUTH")]
        POSTAUTH = 7,

        /// <summary>
        /// Enum PAYERAUTH for value: PAYER_AUTH
        /// </summary>
        [EnumMember(Value = "PAYER_AUTH")]
        PAYERAUTH = 8,

        /// <summary>
        /// Enum DISBURSEMENT for value: DISBURSEMENT
        /// </summary>
        [EnumMember(Value = "DISBURSEMENT")]
        DISBURSEMENT = 9

    }

}
