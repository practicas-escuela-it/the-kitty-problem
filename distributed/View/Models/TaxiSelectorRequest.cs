namespace View.Models
{
    internal class TaxiSelectorRequest
    {
        internal IEnumerable<TaxiFound> TaxiFounds { get; set; }
        internal TaxiSelectionCriteria TaxiSelectionCriteria { get; set; }
    }
}