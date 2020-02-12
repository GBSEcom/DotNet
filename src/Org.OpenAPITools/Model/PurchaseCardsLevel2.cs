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
    /// Level 2 data for monitoring and controlling corporate expenditures.
    /// </summary>
    [DataContract]
    public partial class PurchaseCardsLevel2 :  IEquatable<PurchaseCardsLevel2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseCardsLevel2" /> class.
        /// </summary>
        /// <param name="customerReferenceID">Customer code/customer reference ID..</param>
        /// <param name="supplierInvoiceNumber">Purchase identifier/merchant-related data..</param>
        /// <param name="supplierVATRegistrationNumber">Merchant VAT registration/single business reference number/merchant tax ID or corporation VAT number..</param>
        /// <param name="totalDiscountAmountAndRate">totalDiscountAmountAndRate.</param>
        /// <param name="vatShippingAmountAndRate">vatShippingAmountAndRate.</param>
        public PurchaseCardsLevel2(string customerReferenceID = default(string), string supplierInvoiceNumber = default(string), string supplierVATRegistrationNumber = default(string), AdditionalAmountRate totalDiscountAmountAndRate = default(AdditionalAmountRate), AdditionalAmountRate vatShippingAmountAndRate = default(AdditionalAmountRate))
        {
            this.CustomerReferenceID = customerReferenceID;
            this.SupplierInvoiceNumber = supplierInvoiceNumber;
            this.SupplierVATRegistrationNumber = supplierVATRegistrationNumber;
            this.TotalDiscountAmountAndRate = totalDiscountAmountAndRate;
            this.VatShippingAmountAndRate = vatShippingAmountAndRate;
        }
        
        /// <summary>
        /// Customer code/customer reference ID.
        /// </summary>
        /// <value>Customer code/customer reference ID.</value>
        [DataMember(Name="customerReferenceID", EmitDefaultValue=false)]
        public string CustomerReferenceID { get; set; }

        /// <summary>
        /// Purchase identifier/merchant-related data.
        /// </summary>
        /// <value>Purchase identifier/merchant-related data.</value>
        [DataMember(Name="supplierInvoiceNumber", EmitDefaultValue=false)]
        public string SupplierInvoiceNumber { get; set; }

        /// <summary>
        /// Merchant VAT registration/single business reference number/merchant tax ID or corporation VAT number.
        /// </summary>
        /// <value>Merchant VAT registration/single business reference number/merchant tax ID or corporation VAT number.</value>
        [DataMember(Name="supplierVATRegistrationNumber", EmitDefaultValue=false)]
        public string SupplierVATRegistrationNumber { get; set; }

        /// <summary>
        /// Gets or Sets TotalDiscountAmountAndRate
        /// </summary>
        [DataMember(Name="totalDiscountAmountAndRate", EmitDefaultValue=false)]
        public AdditionalAmountRate TotalDiscountAmountAndRate { get; set; }

        /// <summary>
        /// Gets or Sets VatShippingAmountAndRate
        /// </summary>
        [DataMember(Name="vatShippingAmountAndRate", EmitDefaultValue=false)]
        public AdditionalAmountRate VatShippingAmountAndRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseCardsLevel2 {\n");
            sb.Append("  CustomerReferenceID: ").Append(CustomerReferenceID).Append("\n");
            sb.Append("  SupplierInvoiceNumber: ").Append(SupplierInvoiceNumber).Append("\n");
            sb.Append("  SupplierVATRegistrationNumber: ").Append(SupplierVATRegistrationNumber).Append("\n");
            sb.Append("  TotalDiscountAmountAndRate: ").Append(TotalDiscountAmountAndRate).Append("\n");
            sb.Append("  VatShippingAmountAndRate: ").Append(VatShippingAmountAndRate).Append("\n");
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
            return this.Equals(input as PurchaseCardsLevel2);
        }

        /// <summary>
        /// Returns true if PurchaseCardsLevel2 instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseCardsLevel2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseCardsLevel2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomerReferenceID == input.CustomerReferenceID ||
                    (this.CustomerReferenceID != null &&
                    this.CustomerReferenceID.Equals(input.CustomerReferenceID))
                ) && 
                (
                    this.SupplierInvoiceNumber == input.SupplierInvoiceNumber ||
                    (this.SupplierInvoiceNumber != null &&
                    this.SupplierInvoiceNumber.Equals(input.SupplierInvoiceNumber))
                ) && 
                (
                    this.SupplierVATRegistrationNumber == input.SupplierVATRegistrationNumber ||
                    (this.SupplierVATRegistrationNumber != null &&
                    this.SupplierVATRegistrationNumber.Equals(input.SupplierVATRegistrationNumber))
                ) && 
                (
                    this.TotalDiscountAmountAndRate == input.TotalDiscountAmountAndRate ||
                    (this.TotalDiscountAmountAndRate != null &&
                    this.TotalDiscountAmountAndRate.Equals(input.TotalDiscountAmountAndRate))
                ) && 
                (
                    this.VatShippingAmountAndRate == input.VatShippingAmountAndRate ||
                    (this.VatShippingAmountAndRate != null &&
                    this.VatShippingAmountAndRate.Equals(input.VatShippingAmountAndRate))
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
                if (this.CustomerReferenceID != null)
                    hashCode = hashCode * 59 + this.CustomerReferenceID.GetHashCode();
                if (this.SupplierInvoiceNumber != null)
                    hashCode = hashCode * 59 + this.SupplierInvoiceNumber.GetHashCode();
                if (this.SupplierVATRegistrationNumber != null)
                    hashCode = hashCode * 59 + this.SupplierVATRegistrationNumber.GetHashCode();
                if (this.TotalDiscountAmountAndRate != null)
                    hashCode = hashCode * 59 + this.TotalDiscountAmountAndRate.GetHashCode();
                if (this.VatShippingAmountAndRate != null)
                    hashCode = hashCode * 59 + this.VatShippingAmountAndRate.GetHashCode();
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
            // CustomerReferenceID (string) maxLength
            if(this.CustomerReferenceID != null && this.CustomerReferenceID.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CustomerReferenceID, length must be less than 20.", new [] { "CustomerReferenceID" });
            }

            // SupplierInvoiceNumber (string) maxLength
            if(this.SupplierInvoiceNumber != null && this.SupplierInvoiceNumber.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SupplierInvoiceNumber, length must be less than 30.", new [] { "SupplierInvoiceNumber" });
            }

            // SupplierVATRegistrationNumber (string) maxLength
            if(this.SupplierVATRegistrationNumber != null && this.SupplierVATRegistrationNumber.Length > 30)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SupplierVATRegistrationNumber, length must be less than 30.", new [] { "SupplierVATRegistrationNumber" });
            }

            yield break;
        }
    }

}
