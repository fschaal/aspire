namespace Aspire.Net.Web.Data;

public interface ITeslaDealsService
{
    Task<TeslaDeal[]?> GetTeslaDeals();
}