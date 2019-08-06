/* 
 * Payment Gateway API Specification.
 *
 * The documentation here is designed to provide all of the technical guidance required to consume and integrate with our APIs for payment processing. To learn more about our APIs please visit https://docs.firstdata.com/org/gateway.
 *
 * The version of the OpenAPI document: 6.6.0.20190507.002
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
    /// ChinaDomesticPaymentMethodAllOf
    /// </summary>
    [DataContract]
    public partial class ChinaDomesticPaymentMethodAllOf :  IEquatable<ChinaDomesticPaymentMethodAllOf>, IValidatableObject
    {
        /// <summary>
        /// Defines Brand
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BrandEnum
        {
            /// <summary>
            /// Enum ALIPAYDOMESTIC for value: ALIPAY_DOMESTIC
            /// </summary>
            [EnumMember(Value = "ALIPAY_DOMESTIC")]
            ALIPAYDOMESTIC = 1,

            /// <summary>
            /// Enum CUPDOMESTIC for value: CUP_DOMESTIC
            /// </summary>
            [EnumMember(Value = "CUP_DOMESTIC")]
            CUPDOMESTIC = 2,

            /// <summary>
            /// Enum WECHATDOMESTIC for value: WECHAT_DOMESTIC
            /// </summary>
            [EnumMember(Value = "WECHAT_DOMESTIC")]
            WECHATDOMESTIC = 3

        }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public BrandEnum Brand { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChinaDomesticPaymentMethodAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChinaDomesticPaymentMethodAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChinaDomesticPaymentMethodAllOf" /> class.
        /// </summary>
        /// <param name="chinaDomestic">chinaDomestic (required).</param>
        /// <param name="brand">brand (required).</param>
        public ChinaDomesticPaymentMethodAllOf(ChinaDomestic chinaDomestic = default(ChinaDomestic), BrandEnum brand = default(BrandEnum))
        {
            // to ensure "chinaDomestic" is required (not null)
            if (chinaDomestic == null)
            {
                throw new InvalidDataException("chinaDomestic is a required property for ChinaDomesticPaymentMethodAllOf and cannot be null");
            }
            else
            {
                this.ChinaDomestic = chinaDomestic;
            }

            this.Brand = brand;
        }
        
        /// <summary>
        /// Gets or Sets ChinaDomestic
        /// </summary>
        [DataMember(Name="chinaDomestic", EmitDefaultValue=false)]
        public ChinaDomestic ChinaDomestic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChinaDomesticPaymentMethodAllOf {\n");
            sb.Append("  ChinaDomestic: ").Append(ChinaDomestic).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
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
            return this.Equals(input as ChinaDomesticPaymentMethodAllOf);
        }

        /// <summary>
        /// Returns true if ChinaDomesticPaymentMethodAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ChinaDomesticPaymentMethodAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChinaDomesticPaymentMethodAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChinaDomestic == input.ChinaDomestic ||
                    (this.ChinaDomestic != null &&
                    this.ChinaDomestic.Equals(input.ChinaDomestic))
                ) && 
                (
                    this.Brand == input.Brand ||
                    this.Brand.Equals(input.Brand)
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
                if (this.ChinaDomestic != null)
                    hashCode = hashCode * 59 + this.ChinaDomestic.GetHashCode();
                hashCode = hashCode * 59 + this.Brand.GetHashCode();
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