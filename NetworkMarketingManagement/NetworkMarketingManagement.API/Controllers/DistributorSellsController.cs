using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NetworkManagementAPI.Models;
using NetworkManagementAPI.Repository.Interfaces;
using System.Net;

namespace NetworkMarketingManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistributorSellsController : ControllerBase
    {
        private readonly IRepositoryFactory _repository;
        private readonly IMapper _mapper;
        private APIResponse _response;
        public DistributorSellsController(IMapper mapper, IRepositoryFactory repository)
        {
            _repository = repository;
            _mapper = mapper;
            _response = new();
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetAllDistributorSells()
        {
            try
            {
                var distributorSells = await _repository.DistributorSells.GetAllAsync(includeProperties: "Distributor,Product");

                if (distributorSells.Count() == 0)
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Distributor sells not found" };

                    return _response;
                }

                var result = _mapper.Map<List<GetDistributorSellDTO>>(distributorSells);

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = result;
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

        [HttpGet("date")]
        public async Task<ActionResult<APIResponse>> GetAllSellsWithSpecificDate([FromHeader] DateTime sellingDate)
        {
            try
            {
                var distributorSells = await _repository.DistributorSells.GetAllAsync(x => x.SellDate.Date == sellingDate.Date, includeProperties: "Distributor,Product");

                if (distributorSells.Count() == 0)
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Distributor sells not found" };

                    return _response;
                }

                var result = _mapper.Map<List<GetDistributorSellDTO>>(distributorSells);

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = result;
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

        [HttpGet("product/{productId:int}")]
        public async Task<ActionResult<APIResponse>> GetAllSellsWithSpecificProduct([FromRoute] int productId)
        {
            try
            {
                var distributorSells = await _repository.DistributorSells.GetAllAsync(x => x.ProductId == productId, includeProperties: "Distributor,Product");

                if (distributorSells.Count() == 0)
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Distributor sells not found" };

                    return _response;
                }

                var result = _mapper.Map<List<GetDistributorSellDTO>>(distributorSells);

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = result;
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

        [HttpGet("distributor/{distributorId:int}")]
        public async Task<ActionResult<APIResponse>> GetAllSellsWithSpecificDistributor([FromRoute] int distributorId)
        {
            try
            {
                var distributorSells = await _repository.DistributorSells.GetAllAsync(x => x.DistributorId == distributorId, includeProperties: "Distributor,Product");

                if (distributorSells.Count() == 0)
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Distributor sells not found" };

                    return _response;
                }

                var result = _mapper.Map<List<GetDistributorSellDTO>>(distributorSells);

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = result;
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
