using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NetworkManagementAPI.Entities;
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
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<APIResponse>> GetAllSells()
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
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
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
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
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
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
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

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<APIResponse>> AddSell([FromBody] AddDistributorSellDTO distributorSellDTO)
        {
            try
            {
                if (distributorSellDTO == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Invalid distributor sell passed" };

                    return _response;
                }

                if (!await ProductExists(distributorSellDTO.ProductId))
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Product with passed id don't exists" };

                    return _response;
                }

                if (!await DistributorExists(distributorSellDTO.ProductId))
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Distributor with passed id don't exists" };

                    return _response;
                }

                var result = _mapper.Map<DistributorSell>(distributorSellDTO);

                result.TotalPrice = await GetProductPrice(distributorSellDTO.ProductId) * distributorSellDTO.SellsCount;
                await _repository.DistributorSells.AddAsync(result);
                await _repository.Save();


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

        private async Task<decimal> GetProductPrice(int productId)
        {
            var result = await _repository.Product.GetAsync(x => x.Id == productId);
            return result.Price;
        }

        private async Task<bool> ProductExists(int productId)
        {
            var result = await _repository.Product.GetAsync(x => x.Id == productId);
            return result != null;
        }

        private async Task<bool> DistributorExists(int distributorId)
        {
            var result = await _repository.Distributor.GetAsync(x => x.Id == distributorId);
            return result != null;
        }
    }
}
