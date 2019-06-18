using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Model {

  /// <summary>
  /// Additional data specific to the airline industry.
  /// </summary>
  [DataContract]
  public class Airline {
    /// <summary>
    /// The passenger name associated with the transaction.
    /// </summary>
    /// <value>The passenger name associated with the transaction.</value>
    [DataMember(Name="passengerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passengerName")]
    public string PassengerName { get; set; }

    /// <summary>
    /// The airline ticket number associated with the transaction.
    /// </summary>
    /// <value>The airline ticket number associated with the transaction.</value>
    [DataMember(Name="ticketNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticketNumber")]
    public string TicketNumber { get; set; }

    /// <summary>
    /// The carrier that issued the ticket.
    /// </summary>
    /// <value>The carrier that issued the ticket.</value>
    [DataMember(Name="issuingCarrier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issuingCarrier")]
    public string IssuingCarrier { get; set; }

    /// <summary>
    /// The carrier associated with the transaction.
    /// </summary>
    /// <value>The carrier associated with the transaction.</value>
    [DataMember(Name="carrierName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "carrierName")]
    public string CarrierName { get; set; }

    /// <summary>
    /// The IATA code associated with the travel agency.
    /// </summary>
    /// <value>The IATA code associated with the travel agency.</value>
    [DataMember(Name="travelAgencyIataCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "travelAgencyIataCode")]
    public string TravelAgencyIataCode { get; set; }

    /// <summary>
    /// The business name of the travel agency.
    /// </summary>
    /// <value>The business name of the travel agency.</value>
    [DataMember(Name="travelAgencyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "travelAgencyName")]
    public string TravelAgencyName { get; set; }

    /// <summary>
    /// The airline plan number associated with the transaction.
    /// </summary>
    /// <value>The airline plan number associated with the transaction.</value>
    [DataMember(Name="airlinePlanNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airlinePlanNumber")]
    public string AirlinePlanNumber { get; set; }

    /// <summary>
    /// The invoice number used by the airline.
    /// </summary>
    /// <value>The invoice number used by the airline.</value>
    [DataMember(Name="airlineInvoiceNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "airlineInvoiceNumber")]
    public string AirlineInvoiceNumber { get; set; }

    /// <summary>
    /// The reservation system used to create the ticket.
    /// </summary>
    /// <value>The reservation system used to create the ticket.</value>
    [DataMember(Name="reservationSystem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reservationSystem")]
    public string ReservationSystem { get; set; }

    /// <summary>
    /// If the transaction is associated with a restricted class fare.
    /// </summary>
    /// <value>If the transaction is associated with a restricted class fare.</value>
    [DataMember(Name="restricted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "restricted")]
    public bool? Restricted { get; set; }

    /// <summary>
    /// Array containing up to 4 items that describe the route associated with the transaction.
    /// </summary>
    /// <value>Array containing up to 4 items that describe the route associated with the transaction.</value>
    [DataMember(Name="travelRoute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "travelRoute")]
    public List<AirlineTravelRoute> TravelRoute { get; set; }

    /// <summary>
    /// The number of any other tickets associated with the transaction ticket.
    /// </summary>
    /// <value>The number of any other tickets associated with the transaction ticket.</value>
    [DataMember(Name="relatedTicketNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relatedTicketNumber")]
    public string RelatedTicketNumber { get; set; }

    /// <summary>
    /// Identify the purchase of ancillary goods or services with a false value. If this element is not provided, the transaction is assumed to be a purchase of an airline ticket.
    /// </summary>
    /// <value>Identify the purchase of ancillary goods or services with a false value. If this element is not provided, the transaction is assumed to be a purchase of an airline ticket.</value>
    [DataMember(Name="ancillaryServiceCategory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ancillaryServiceCategory")]
    public List<AirlineAncillaryServiceCategory> AncillaryServiceCategory { get; set; }

    /// <summary>
    /// Identifies if the transaction is a ticket purchase.
    /// </summary>
    /// <value>Identifies if the transaction is a ticket purchase.</value>
    [DataMember(Name="ticketPurchase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticketPurchase")]
    public bool? TicketPurchase { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Airline {\n");
      sb.Append("  PassengerName: ").Append(PassengerName).Append("\n");
      sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
      sb.Append("  IssuingCarrier: ").Append(IssuingCarrier).Append("\n");
      sb.Append("  CarrierName: ").Append(CarrierName).Append("\n");
      sb.Append("  TravelAgencyIataCode: ").Append(TravelAgencyIataCode).Append("\n");
      sb.Append("  TravelAgencyName: ").Append(TravelAgencyName).Append("\n");
      sb.Append("  AirlinePlanNumber: ").Append(AirlinePlanNumber).Append("\n");
      sb.Append("  AirlineInvoiceNumber: ").Append(AirlineInvoiceNumber).Append("\n");
      sb.Append("  ReservationSystem: ").Append(ReservationSystem).Append("\n");
      sb.Append("  Restricted: ").Append(Restricted).Append("\n");
      sb.Append("  TravelRoute: ").Append(TravelRoute).Append("\n");
      sb.Append("  RelatedTicketNumber: ").Append(RelatedTicketNumber).Append("\n");
      sb.Append("  AncillaryServiceCategory: ").Append(AncillaryServiceCategory).Append("\n");
      sb.Append("  TicketPurchase: ").Append(TicketPurchase).Append("\n");
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
