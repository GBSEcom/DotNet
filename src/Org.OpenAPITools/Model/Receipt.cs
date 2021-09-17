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
    /// Provides POS receipt data.
    /// </summary>
    [DataContract(Name = "Receipt")]
    public partial class Receipt : IEquatable<Receipt>, IValidatableObject
    {
        /// <summary>
        /// Defines the consumer of the receipt (e.g. cardholder, merchant).
        /// </summary>
        /// <value>Defines the consumer of the receipt (e.g. cardholder, merchant).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Cardholder for value: cardholder
            /// </summary>
            [EnumMember(Value = "cardholder")]
            Cardholder = 1,

            /// <summary>
            /// Enum Merchant for value: merchant
            /// </summary>
            [EnumMember(Value = "merchant")]
            Merchant = 2

        }


        /// <summary>
        /// Defines the consumer of the receipt (e.g. cardholder, merchant).
        /// </summary>
        /// <value>Defines the consumer of the receipt (e.g. cardholder, merchant).</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Receipt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Receipt() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Receipt" /> class.
        /// </summary>
        /// <param name="type">Defines the consumer of the receipt (e.g. cardholder, merchant). (required).</param>
        /// <param name="data">Array of formatted lines that represents the actual receipt data, that can be printed out. (required).</param>
        public Receipt(TypeEnum type = default(TypeEnum), List<ReceiptLine> data = default(List<ReceiptLine>))
        {
            this.Type = type;
            // to ensure "data" is required (not null)
            this.Data = data ?? throw new ArgumentNullException("data is a required property for Receipt and cannot be null");
        }

        /// <summary>
        /// Array of formatted lines that represents the actual receipt data, that can be printed out.
        /// </summary>
        /// <value>Array of formatted lines that represents the actual receipt data, that can be printed out.</value>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public List<ReceiptLine> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Receipt {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as Receipt);
        }

        /// <summary>
        /// Returns true if Receipt instances are equal
        /// </summary>
        /// <param name="input">Instance of Receipt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Receipt input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
