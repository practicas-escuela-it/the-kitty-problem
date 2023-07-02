namespace View.Models
{
    internal class ConfirmTaxiRequest
    {
        internal TaxiFound TaxiFound { get; init; }
        internal string destinationAddress { get; init; }
    }
}