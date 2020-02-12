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
    /// PaymentCardDisbursementTransactionAllOf
    /// </summary>
    [DataContract]
    public partial class PaymentCardDisbursementTransactionAllOf :  IEquatable<PaymentCardDisbursementTransactionAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardDisbursementTransactionAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentCardDisbursementTransactionAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardDisbursementTransactionAllOf" /> class.
        /// </summary>
        /// <param name="disbursement">disbursement (required).</param>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="storedCredentials">storedCredentials.</param>
        /// <param name="createToken">createToken.</param>
        public PaymentCardDisbursementTransactionAllOf(Disbursement disbursement = default(Disbursement), PaymentCardPaymentMethod paymentMethod = default(PaymentCardPaymentMethod), StoredCredential storedCredentials = default(StoredCredential), CreatePaymentToken createToken = default(CreatePaymentToken))
        {
            // to ensure "disbursement" is required (not null)
            if (disbursement == null)
            {
                throw new InvalidDataException("disbursement is a required property for PaymentCardDisbursementTransactionAllOf and cannot be null");
            }
            else
            {
                this.Disbursement = disbursement;
            }

            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new InvalidDataException("paymentMethod is a required property for PaymentCardDisbursementTransactionAllOf and cannot be null");
            }
            else
            {
                this.PaymentMethod = paymentMethod;
            }

            this.StoredCredentials = storedCredentials;
            this.CreateToken = createToken;
        }
        
        /// <summary>
        /// Gets or Sets Disbursement
        /// </summary>
        [DataMember(Name="disbursement", EmitDefaultValue=false)]
        public Disbursement Disbursement { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public PaymentCardPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets StoredCredentials
        /// </summary>
        [DataMember(Name="storedCredentials", EmitDefaultValue=false)]
        public StoredCredential StoredCredentials { get; set; }

        /// <summary>
        /// Gets or Sets CreateToken
        /// </summary>
        [DataMember(Name="createToken", EmitDefaultValue=false)]
        public CreatePaymentToken CreateToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCardDisbursementTransactionAllOf {\n");
            sb.Append("  Disbursement: ").Append(Disbursement).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  StoredCredentials: ").Append(StoredCredentials).Append("\n");
            sb.Append("  CreateToken: ").Append(CreateToken).Append("\n");
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
            return this.Equals(input as PaymentCardDisbursementTransactionAllOf);
        }

        /// <summary>
        /// Returns true if PaymentCardDisbursementTransactionAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCardDisbursementTransactionAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCardDisbursementTransactionAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Disbursement == input.Disbursement ||
                    (this.Disbursement != null &&
                    this.Disbursement.Equals(input.Disbursement))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.StoredCredentials == input.StoredCredentials ||
                    (this.StoredCredentials != null &&
                    this.StoredCredentials.Equals(input.StoredCredentials))
                ) && 
                (
                    this.CreateToken == input.CreateToken ||
                    (this.CreateToken != null &&
                    this.CreateToken.Equals(input.CreateToken))
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
                if (this.Disbursement != null)
                    hashCode = hashCode * 59 + this.Disbursement.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.StoredCredentials != null)
                    hashCode = hashCode * 59 + this.StoredCredentials.GetHashCode();
                if (this.CreateToken != null)
                    hashCode = hashCode * 59 + this.CreateToken.GetHashCode();
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
