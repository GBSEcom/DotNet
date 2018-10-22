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
  public class CarRental {
    /// <summary>
    /// Gets or Sets AgreementNumber
    /// </summary>
    [DataMember(Name="agreementNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "agreementNumber")]
    public string AgreementNumber { get; set; }

    /// <summary>
    /// Gets or Sets RenterName
    /// </summary>
    [DataMember(Name="renterName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renterName")]
    public string RenterName { get; set; }

    /// <summary>
    /// Gets or Sets ReturnCity
    /// </summary>
    [DataMember(Name="returnCity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnCity")]
    public string ReturnCity { get; set; }

    /// <summary>
    /// Gets or Sets ReturnDate
    /// </summary>
    [DataMember(Name="returnDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnDate")]
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// Gets or Sets PickupDate
    /// </summary>
    [DataMember(Name="pickupDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickupDate")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// Gets or Sets RentalClassId
    /// </summary>
    [DataMember(Name="rentalClassId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rentalClassId")]
    public string RentalClassId { get; set; }

    /// <summary>
    /// Gets or Sets ExtraCharges
    /// </summary>
    [DataMember(Name="extraCharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extraCharges")]
    public List<CarRentalExtraCharges> ExtraCharges { get; set; }

    /// <summary>
    /// Gets or Sets NoShowIndicator
    /// </summary>
    [DataMember(Name="noShowIndicator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "noShowIndicator")]
    public bool? NoShowIndicator { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CarRental {\n");
      sb.Append("  AgreementNumber: ").Append(AgreementNumber).Append("\n");
      sb.Append("  RenterName: ").Append(RenterName).Append("\n");
      sb.Append("  ReturnCity: ").Append(ReturnCity).Append("\n");
      sb.Append("  ReturnDate: ").Append(ReturnDate).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  RentalClassId: ").Append(RentalClassId).Append("\n");
      sb.Append("  ExtraCharges: ").Append(ExtraCharges).Append("\n");
      sb.Append("  NoShowIndicator: ").Append(NoShowIndicator).Append("\n");
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
