using System;
using System.Collections.Generic;

namespace firstdata.Models
{
    public class Transaction : TransactionRequest
    {
        public String TransactionType { get; set; }
        public String StoreId { get; set; }
        public String ClientTransactionId { get; set; }
        public Amount Amount { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public Order Order { get; set; }
        public List<BasketItem> BasketItems { get; set; }
        public SplitShipment SplitShipment { get; set; }
        public PtAdditionalDetails AdditionalDetails { get; set; }
        public IndustrySpecificExtensions IndustrySpecificExtensions { get; set; }

        public PaymentCard PaymentCard { set { SetPaymentCard(value); } }
        public SepaDirectDebit SepaDirectDebit { set { SetSepaDirectDebit(value); } }
        public ApplePay ApplePay { set { SetApplePay(value); } }

        private void SetPaymentCard(PaymentCard card)
        {
            PaymentMethod = new PaymentMethod
            {
                Type = "PAYMENT_CARD",
                PaymentCard = card
            };
        }

        private void SetSepaDirectDebit(SepaDirectDebit sepa)
        {
            PaymentMethod = new PaymentMethod
            {
                Type = "SEPA_DIRECT_DEBIT",
                SepaDirectDebit = sepa
            };
        }

        private void SetApplePay(ApplePay applePay)
        {
            PaymentMethod = new PaymentMethod
            {
                Type = "APPLE_PAY",
                ApplePay = applePay
            };
        }
    }
}