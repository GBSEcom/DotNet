/*
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.4.0.20210824.002
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// The source of the transaction. The possible values are ECOM (if the order was received via email or Internet), MOTO (mail order, telephone order), MAIL, PHONE and RETAIL (face to face).
    /// </summary>
    /// <value>The source of the transaction. The possible values are ECOM (if the order was received via email or Internet), MOTO (mail order, telephone order), MAIL, PHONE and RETAIL (face to face).</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TransactionOrigin
    {
        /// <summary>
        /// Enum ECOM for value: ECOM
        /// </summary>
        [EnumMember(Value = "ECOM")]
        ECOM = 1,

        /// <summary>
        /// Enum MOTO for value: MOTO
        /// </summary>
        [EnumMember(Value = "MOTO")]
        MOTO = 2,

        /// <summary>
        /// Enum MAIL for value: MAIL
        /// </summary>
        [EnumMember(Value = "MAIL")]
        MAIL = 3,

        /// <summary>
        /// Enum PHONE for value: PHONE
        /// </summary>
        [EnumMember(Value = "PHONE")]
        PHONE = 4,

        /// <summary>
        /// Enum RETAIL for value: RETAIL
        /// </summary>
        [EnumMember(Value = "RETAIL")]
        RETAIL = 5

    }

}
