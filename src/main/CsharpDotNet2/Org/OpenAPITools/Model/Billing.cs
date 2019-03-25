using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Customer billing information
  /// </summary>
  [DataContract]
  public class Billing {
    /// <summary>
    /// Billing name
    /// </summary>
    /// <value>Billing name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Customer ID for billing purpose
    /// </summary>
    /// <value>Customer ID for billing purpose</value>
    [DataMember(Name="customerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customerId")]
    public string CustomerId { get; set; }

    /// <summary>
    /// Personal number for the customer
    /// </summary>
    /// <value>Personal number for the customer</value>
    [DataMember(Name="personalNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "personalNumber")]
    public string PersonalNumber { get; set; }

    /// <summary>
    /// Customer birth date
    /// </summary>
    /// <value>Customer birth date</value>
    [DataMember(Name="birthDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "birthDate")]
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Customer gender
    /// </summary>
    /// <value>Customer gender</value>
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
      sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
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
