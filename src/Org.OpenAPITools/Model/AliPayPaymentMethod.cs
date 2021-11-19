/*
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.5.0.20211029.001
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
    /// Payment method containing AliPay information.
    /// </summary>
    [DataContract(Name = "AliPayPaymentMethod")]
    public partial class AliPayPaymentMethod : IEquatable<AliPayPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AliPayPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AliPayPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AliPayPaymentMethod" /> class.
        /// </summary>
        /// <param name="aliPay">aliPay (required).</param>
        public AliPayPaymentMethod(AliPay aliPay = default(AliPay))
        {
            // to ensure "aliPay" is required (not null)
            this.AliPay = aliPay ?? throw new ArgumentNullException("aliPay is a required property for AliPayPaymentMethod and cannot be null");
        }

        /// <summary>
        /// Gets or Sets AliPay
        /// </summary>
        [DataMember(Name = "aliPay", IsRequired = true, EmitDefaultValue = false)]
        public AliPay AliPay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AliPayPaymentMethod {\n");
            sb.Append("  AliPay: ").Append(AliPay).Append("\n");
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
            return this.Equals(input as AliPayPaymentMethod);
        }

        /// <summary>
        /// Returns true if AliPayPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of AliPayPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AliPayPaymentMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AliPay == input.AliPay ||
                    (this.AliPay != null &&
                    this.AliPay.Equals(input.AliPay))
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
                if (this.AliPay != null)
                    hashCode = hashCode * 59 + this.AliPay.GetHashCode();
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
