using TaxiSelector.API.Domain;

namespace TaxiSelector.API.Models
{
    public class TaxiSelectorRequest
    {
        internal IEnumerable<TaxiFound> TaxiFounds { get; set; }
        internal TaxiSelectionCriteria TaxiSelectionCriteria { get; set; }
    }
}