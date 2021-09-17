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
    /// Card function. This field is required when performing transactions for Brazil merchants.
    /// </summary>
    /// <value>Card function. This field is required when performing transactions for Brazil merchants.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CardFunction
    {
        /// <summary>
        /// Enum CREDIT for value: CREDIT
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        CREDIT = 1,

        /// <summary>
        /// Enum DEBIT for value: DEBIT
        /// </summary>
        [EnumMember(Value = "DEBIT")]
        DEBIT = 2,

        /// <summary>
        /// Enum PREPAID for value: PREPAID
        /// </summary>
        [EnumMember(Value = "PREPAID")]
        PREPAID = 3,

        /// <summary>
        /// Enum VOUCHER for value: VOUCHER
        /// </summary>
        [EnumMember(Value = "VOUCHER")]
        VOUCHER = 4,

        /// <summary>
        /// Enum UNDEFINED for value: UNDEFINED
        /// </summary>
        [EnumMember(Value = "UNDEFINED")]
        UNDEFINED = 5

    }

}
