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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Request to create Managed Redirect sale transaction using payment card.
    /// </summary>
    [DataContract(Name = "PaymentCardManagedRedirectRequest")]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    public partial class PaymentCardManagedRedirectRequest : ManagedRedirectPrimaryRequest, IEquatable<PaymentCardManagedRedirectRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardManagedRedirectRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentCardManagedRedirectRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCardManagedRedirectRequest" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="requestType">Object name of the primary transaction request. (required) (default to &quot;PaymentCardManagedRedirectRequest&quot;).</param>
        /// <param name="transactionAmount">transactionAmount (required).</param>
        /// <param name="storeId">An optional Outlet ID for clients that support multiple stores in the same developer app..</param>
        /// <param name="merchantTransactionId">The unique merchant transaction ID from the request, if supplied..</param>
        /// <param name="transactionType">transactionType.</param>
        /// <param name="order">order.</param>
        /// <param name="redirectAttributes">redirectAttributes.</param>
        public PaymentCardManagedRedirectRequest(PaymentCardPaymentMethod paymentMethod = default(PaymentCardPaymentMethod), string requestType = "PaymentCardManagedRedirectRequest", Amount transactionAmount = default(Amount), string storeId = default(string), string merchantTransactionId = default(string), ManagedRedirectTransactionType? transactionType = default(ManagedRedirectTransactionType?), Order order = default(Order), RedirectAttributes redirectAttributes = default(RedirectAttributes)) : base(requestType, transactionAmount, storeId, merchantTransactionId, transactionType, order, redirectAttributes)
        {
            this.PaymentMethod = paymentMethod;
        }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
        public PaymentCardPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCardManagedRedirectRequest {\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentCardManagedRedirectRequest);
        }

        /// <summary>
        /// Returns true if PaymentCardManagedRedirectRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCardManagedRedirectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCardManagedRedirectRequest input)
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }
}
