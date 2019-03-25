using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model
{

    /// <summary>
    /// Various payment methods the Gateway supports
    /// </summary>
    [DataContract]
    public class PaymentMethod
    {
        /// <summary>
        /// The type of payment method. Note that PayPal can only process a 'CREDIT' transaction. Note that for requests we are now supporting only PAYMENT_CARD, SEPA, PAYPAL, ALIPAY. All this types are supported for response.
        /// </summary>
        /// <value>The type of payment method. Note that PayPal can only process a 'CREDIT' transaction. Note that for requests we are now supporting only PAYMENT_CARD, SEPA, PAYPAL, ALIPAY. All this types are supported for response.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets PaymentCard
        /// </summary>
        [DataMember(Name = "paymentCard", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentCard")]
        public PaymentCard PaymentCard { get; set; }

        /// <summary>
        /// Gets or Sets PaymentToken
        /// </summary>
        [DataMember(Name = "paymentToken", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "paymentToken")]
        public PaymentTokenization PaymentToken { get; set; }

        /// <summary>
        /// Gets or Sets Sepa
        /// </summary>
        [DataMember(Name = "sepa", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sepa")]
        public Sepa Sepa { get; set; }

        /// <summary>
        /// Gets or Sets PayPal
        /// </summary>
        [DataMember(Name = "payPal", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "payPal")]
        public PayPal PayPal { get; set; }

        /// <summary>
        /// Gets or Sets AliPay
        /// </summary>
        [DataMember(Name = "aliPay", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "aliPay")]
        public AliPay AliPay { get; set; }

        /// <summary>
        /// Gets or Sets ChinaDomestic
        /// </summary>
        [DataMember(Name = "chinaDomestic", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "chinaDomestic")]
        public ChinaDomestic ChinaDomestic { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethod {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PaymentCard: ").Append(PaymentCard).Append("\n");
            sb.Append("  PaymentToken: ").Append(PaymentToken).Append("\n");
            sb.Append("  Sepa: ").Append(Sepa).Append("\n");
            sb.Append("  PayPal: ").Append(PayPal).Append("\n");
            sb.Append("  AliPay: ").Append(AliPay).Append("\n");
            sb.Append("  ChinaDomestic: ").Append(ChinaDomestic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
