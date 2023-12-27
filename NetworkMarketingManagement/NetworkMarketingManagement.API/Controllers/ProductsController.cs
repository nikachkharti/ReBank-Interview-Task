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
    public class ProductsController : ControllerBase
    {
        private readonly IRepositoryFactory _repository;
        private readonly IMapper _mapper;
        private APIResponse _response;
        public ProductsController(IMapper mapper, IRepositoryFactory repository)
        {
            _repository = repository;
            _mapper = mapper;
            _response = new();
        }


        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<APIResponse>> GetAllProducts()
        {
            try
            {
                var products = await _repository.Product.GetAllAsync();

                if (products.Count() == 0)
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Products not found" };

                    return _response;
                }

                var result = _mapper.Map<List<GetProductDTO>>(products);

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
        public async Task<ActionResult<APIResponse>> AddProduct([FromBody] AddProductDTO model)
        {
            try
            {
                if (model == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Invalid product passed" };

                    return _response;
                }

                if (await ProductIsNotUnique(model.Code))
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Product with passed code already exists" };

                    return _response;
                }

                var result = _mapper.Map<Product>(model);
                await _repository.Product.AddAsync(result);
                await _repository.Save();

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = model;
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


        [HttpDelete("{id:int}")]
        public async Task<ActionResult<APIResponse>> DeleteProduct(int id)
        {
            try
            {
                if (id <= 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Invalid id parameter passed" };

                    return _response;
                }

                var productToRemove = await _repository.Product.GetAsync(x => x.Id == id);

                if (productToRemove == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    _response.ErrorMessages = new List<string>() { "Product with passed id not found" };

                    return _response;
                }

                _repository.Product.Remove(productToRemove);
                await _repository.Save();

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = productToRemove;
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

        private async Task<bool> ProductIsNotUnique(string productCode)
        {
            var products = await _repository.Product.GetAllAsync();
            return products.Any(x => x.Code.ToLower() == productCode.ToLower());
        }

    }
}
