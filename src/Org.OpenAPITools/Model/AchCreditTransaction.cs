/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 21.3.0.20210608.001
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
    /// Request to create Credit primary transaction using ACH telecheck details.
    /// </summary>
    [DataContract]
    public partial class AchCreditTransaction : PrimaryTransaction, IEquatable<AchCreditTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AchCreditTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AchCreditTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AchCreditTransaction" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="requestType">Object name of the primary transaction request. (required).</param>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="storeId">An optional outlet ID for clients that support multiple stores in the same app..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request header, if supplied..</param>
        /// <param name="transactionOrigin">transactionOrigin.</param>
        /// <param name="order">order.</param>
        /// <param name="allowPartialApproval">Indicates if the particular transaction is a partial approval transaction, if supplied..</param>
        public AchCreditTransaction(TeleCheckAchPaymentMethod paymentMethod = default(TeleCheckAchPaymentMethod), string requestType = default(string), Amount transactionAmount = default(Amount), string storeId = default(string), string merchantTransactionId = default(string), TransactionOrigin transactionOrigin = default(TransactionOrigin), Order order = default(Order), bool allowPartialApproval = default(bool)) : base(requestType, transactionAmount, storeId, merchantTransactionId, transactionOrigin, order, allowPartialApproval)
        {
            // to ensure "paymentMethod" is required (not null)
            this.PaymentMethod = paymentMethod ?? throw new ArgumentNullException("paymentMethod is a required property for AchCreditTransaction and cannot be null");
        }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public TeleCheckAchPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AchCreditTransaction {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as AchCreditTransaction);
        }

        /// <summary>
        /// Returns true if AchCreditTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of AchCreditTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AchCreditTransaction input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
