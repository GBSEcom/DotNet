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
    /// Represents a line in the receipt response.
    /// </summary>
    [DataContract]
    public partial class ReceiptLine : IEquatable<ReceiptLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptLine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReceiptLine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptLine" /> class.
        /// </summary>
        /// <param name="endOfLine">Flag to indicate if the text ends at the end of this receipt line. (default to true).</param>
        /// <param name="text">Text that represents a line of the actual receipt data, that can be printed out. (required).</param>
        public ReceiptLine(bool endOfLine = true, string text = default(string))
        {
            // to ensure "text" is required (not null)
            this.Text = text ?? throw new ArgumentNullException("text is a required property for ReceiptLine and cannot be null");
            // use default value if no "endOfLine" provided
            this.EndOfLine = endOfLine;
        }

        /// <summary>
        /// Flag to indicate if the text ends at the end of this receipt line.
        /// </summary>
        /// <value>Flag to indicate if the text ends at the end of this receipt line.</value>
        [DataMember(Name = "endOfLine", EmitDefaultValue = false)]
        public bool EndOfLine { get; set; }

        /// <summary>
        /// Text that represents a line of the actual receipt data, that can be printed out.
        /// </summary>
        /// <value>Text that represents a line of the actual receipt data, that can be printed out.</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReceiptLine {\n");
            sb.Append("  EndOfLine: ").Append(EndOfLine).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as ReceiptLine);
        }

        /// <summary>
        /// Returns true if ReceiptLine instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceiptLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceiptLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EndOfLine == input.EndOfLine ||
                    (this.EndOfLine != null &&
                    this.EndOfLine.Equals(input.EndOfLine))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.EndOfLine != null)
                    hashCode = hashCode * 59 + this.EndOfLine.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
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
