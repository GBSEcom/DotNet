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
    /// AliPaySaleTransactionAllOf
    /// </summary>
    [DataContract(Name = "AliPaySaleTransaction_allOf")]
    public partial class AliPaySaleTransactionAllOf : IEquatable<AliPaySaleTransactionAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AliPaySaleTransactionAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AliPaySaleTransactionAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AliPaySaleTransactionAllOf" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        public AliPaySaleTransactionAllOf(AliPayPaymentMethod paymentMethod = default(AliPayPaymentMethod))
        {
            // to ensure "paymentMethod" is required (not null)
            this.PaymentMethod = paymentMethod ?? throw new ArgumentNullException("paymentMethod is a required property for AliPaySaleTransactionAllOf and cannot be null");
        }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", IsRequired = true, EmitDefaultValue = false)]
        public AliPayPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AliPaySaleTransactionAllOf {\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AliPaySaleTransactionAllOf);
        }

        /// <summary>
        /// Returns true if AliPaySaleTransactionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of AliPaySaleTransactionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AliPaySaleTransactionAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
