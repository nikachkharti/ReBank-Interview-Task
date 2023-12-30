using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetworkManagementAPI.Models;
using NetworkManagementAPI.Repository.Interfaces;
using System.Net;

namespace NetworkMarketingManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BonusController : ControllerBase
    {
        private readonly IRepositoryFactory _repository;
        private APIResponse _response;
        public BonusController(IRepositoryFactory repository)
        {
            _repository = repository;
            _response = new();
        }

        [HttpPost("calculate/{distributorId:int}")]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<APIResponse>> CountDistributorBonus([FromRoute] int distributorId)
        {
            try
            {
                await _repository.BonusHistory.CalculateBonuses(distributorId);

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.ErrorMessages = null;

                return _response;
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.IsSuccess = false;
                _response.Result = null;
                _response.ErrorMessages = new List<string>() { ex.Message };

                return _response;
            }
        }
    }
}
