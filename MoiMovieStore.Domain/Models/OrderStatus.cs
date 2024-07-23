namespace MoiMovieStore.Domain.Models
{
    public enum OrderStatus
    {
        /// <summary>
        /// The order has been placed but not yet processed.
        /// </summary>
        Pending,

        /// <summary>
        /// The order has been confirmed and is being prepared for shipment.
        /// </summary>
        Confirmed,

        /// <summary>
        /// The order is currently being processed.
        /// </summary>
        Processed,

        /// <summary>
        /// The order has been shipped to the customer.
        /// </summary>
        Shipped,

        /// <summary>
        /// The order has been delivered to the customer.
        /// </summary>
        Delivered,

        /// <summary>
        /// The order has been cancelled.
        /// </summary>
        Cancelled,

        /// <summary>
        /// The order has been returned by the customer.
        /// </summary>
        Returned,

        /// <summary>
        /// The money for the order has been refunded to the customer.
        /// </summary>
        Refunded,

        /// <summary>
        /// The order failed, e.g., due to payment issues.
        /// </summary>
        Failed
    }

}