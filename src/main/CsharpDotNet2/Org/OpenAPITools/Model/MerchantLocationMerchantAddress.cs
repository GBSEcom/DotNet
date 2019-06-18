using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Info for the merchant address.
  /// </summary>
  [DataContract]
  public class MerchantLocationMerchantAddress {
    /// <summary>
    /// First line of street address.
    /// </summary>
    /// <value>First line of street address.</value>
    [DataMember(Name="street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street")]
    public string Street { get; set; }

    /// <summary>
    /// Second line of street address.
    /// </summary>
    /// <value>Second line of street address.</value>
    [DataMember(Name="street2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street2")]
    public string Street2 { get; set; }

    /// <summary>
    /// Merchant state or provinceu.
    /// </summary>
    /// <value>Merchant state or provinceu.</value>
    [DataMember(Name="stateProvince", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stateProvince")]
    public string StateProvince { get; set; }

    /// <summary>
    /// Merchant city.
    /// </summary>
    /// <value>Merchant city.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Merchant country.
    /// </summary>
    /// <value>Merchant country.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Merchant ZIP code.
    /// </summary>
    /// <value>Merchant ZIP code.</value>
    [DataMember(Name="zipPostalCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zipPostalCode")]
    public string ZipPostalCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MerchantLocationMerchantAddress {\n");
      sb.Append("  Street: ").Append(Street).Append("\n");
      sb.Append("  Street2: ").Append(Street2).Append("\n");
      sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  ZipPostalCode: ").Append(ZipPostalCode).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
