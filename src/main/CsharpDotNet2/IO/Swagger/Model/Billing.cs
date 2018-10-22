using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Billing {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets PersonalNumber
    /// </summary>
    [DataMember(Name="personalNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "personalNumber")]
    public string PersonalNumber { get; set; }

    /// <summary>
    /// Gets or Sets BirthDate
    /// </summary>
    [DataMember(Name="birthDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "birthDate")]
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Gets or Sets Gender
    /// </summary>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// Gets or Sets Contact
    /// </summary>
    [DataMember(Name="contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact")]
    public Contact Contact { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Billing {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PersonalNumber: ").Append(PersonalNumber).Append("\n");
      sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  Contact: ").Append(Contact).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
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
