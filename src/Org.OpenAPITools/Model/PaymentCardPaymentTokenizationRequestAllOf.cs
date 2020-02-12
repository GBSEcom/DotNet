/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.9.1.20191223.002
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
    /// PaymentCardPaymentTokenizationRequestAllOf
    /// </summary>
    [DataContract]
    public partial class PaymentCardPaymentTokenizationRequestAllOf :  IEquatable<PaymentCardPaymentTokenizationRequestAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardPaymentTokenizationRequestAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentCardPaymentTokenizationRequestAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardPaymentTokenizationRequestAllOf" /> class.
        /// </summary>
        /// <param name="paymentCard">paymentCard (required).</param>
        public PaymentCardPaymentTokenizationRequestAllOf(PaymentCard paymentCard = default(PaymentCard))
        {
            // to ensure "paymentCard" is required (not null)
            if (paymentCard == null)
            {
                throw new InvalidDataException("paymentCard is a required property for PaymentCardPaymentTokenizationRequestAllOf and cannot be null");
            }
            else
            {
                this.PaymentCard = paymentCard;
            }

        }
        
        /// <summary>
        /// Gets or Sets PaymentCard
        /// </summary>
        [DataMember(Name="paymentCard", EmitDefaultValue=false)]
        public PaymentCard PaymentCard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCardPaymentTokenizationRequestAllOf {\n");
            sb.Append("  PaymentCard: ").Append(PaymentCard).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentCardPaymentTokenizationRequestAllOf);
        }

        /// <summary>
        /// Returns true if PaymentCardPaymentTokenizationRequestAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCardPaymentTokenizationRequestAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCardPaymentTokenizationRequestAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentCard == input.PaymentCard ||
                    (this.PaymentCard != null &&
                    this.PaymentCard.Equals(input.PaymentCard))
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
                if (this.PaymentCard != null)
                    hashCode = hashCode * 59 + this.PaymentCard.GetHashCode();
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
