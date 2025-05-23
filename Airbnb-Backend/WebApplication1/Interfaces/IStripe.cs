﻿using Stripe;
using WebApplication1.DTOS.Payment;

namespace WebApplication1.Interfaces
{
    public interface IStripe
    {
        Task<PaymentIntentResponseDTO> CreatePaymentIntentAsync(Guid bookingId,PaymentIntentRequestDTO request);
        Task CancelPaymentIntentAsync(string paymentIntentId);
        Task<(PaymentIntent intent, Charge charge)> ConfirmPaymentStripeAsync(Guid bookingId,ConfirmPaymentDTO dto);
        Task RefundAsync(string transactionId, long amountInCents);
    }
}