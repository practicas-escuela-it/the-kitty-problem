using Microsoft.AspNetCore.Mvc;

namespace TaxiFinder.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FinderController : ControllerBase
    {
        private readonly Domain.TaxiFinder _taxiFinder;

        public FinderController(Domain.TaxiFinder taxiFinder)
        {
            this._taxiFinder = taxiFinder;
        }

        [HttpPost]
        public void ProposeCandidateTaxis(int userId)
        {
            this._taxiFinder.Find(userId);
        }
    }
}