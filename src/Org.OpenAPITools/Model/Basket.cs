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
    /// Indicates basket of items.
    /// </summary>
    [DataContract(Name = "Basket")]
    public partial class Basket : IEquatable<Basket>, IValidatableObject
    {
        /// <summary>
        /// Product stock.
        /// </summary>
        /// <value>Product stock.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProductStockEnum
        {
            /// <summary>
            /// Enum Check for value: check
            /// </summary>
            [EnumMember(Value = "check")]
            Check = 1

        }


        /// <summary>
        /// Product stock.
        /// </summary>
        /// <value>Product stock.</value>
        [DataMember(Name = "productStock", EmitDefaultValue = false)]
        public ProductStockEnum? ProductStock { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Basket" /> class.
        /// </summary>
        /// <param name="productStock">Product stock..</param>
        /// <param name="items">The list of items included in the order..</param>
        public Basket(ProductStockEnum? productStock = default(ProductStockEnum?), List<BasketItem> items = default(List<BasketItem>))
        {
            this.ProductStock = productStock;
            this.Items = items;
        }

        /// <summary>
        /// The list of items included in the order.
        /// </summary>
        /// <value>The list of items included in the order.</value>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<BasketItem> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Basket {\n");
            sb.Append("  ProductStock: ").Append(ProductStock).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as Basket);
        }

        /// <summary>
        /// Returns true if Basket instances are equal
        /// </summary>
        /// <param name="input">Instance of Basket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Basket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductStock == input.ProductStock ||
                    this.ProductStock.Equals(input.ProductStock)
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                hashCode = hashCode * 59 + this.ProductStock.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
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
